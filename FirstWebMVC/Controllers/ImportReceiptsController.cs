using FirstWebMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.ViewModels;

public class ImportReceiptsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ImportReceiptsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // LIST
    public async Task<IActionResult> Index()
    {
        var data = await _context.ImportReceipts
            .Include(x => x.Supplier)
            .OrderByDescending(x => x.Id)
            .ToListAsync();

        return View(data);
    }

    // CREATE GET
    public IActionResult Create()
    {
        ViewBag.Suppliers = _context.Suppliers.ToList();
        ViewBag.Devices = _context.Devices.ToList();
        return View();
    }

    // CREATE POST
    [HttpPost]
    public async Task<IActionResult> Create(ImportRcVM vm)
    {
        if (vm.Details == null || !vm.Details.Any())
        {
            ModelState.AddModelError("", "Phải chọn ít nhất 1 thiết bị");
        }

        if (!ModelState.IsValid)
        {
            ViewBag.Suppliers = _context.Suppliers.ToList();
            ViewBag.Devices = _context.Devices.ToList();
            return View(vm);
        }

        // Tạo mã phiếu
        var count = _context.ImportReceipts.Count() + 1;
        var code = "PN" + count.ToString("D4");

        var receipt = new ImportRc
        {
            Code = code,
            SupplierId = vm.SupplierId,
            ImportDate = vm.ImportDate,
            TotalAmount = 0,
            Details = new List<ImportRcDetail>()
        };

        decimal totalAmount = 0;

        foreach (var item in vm.Details)
        {
            var total = item.Quantity * item.UnitPrice;

            var detail = new ImportRcDetail
            {
                DeviceId = item.DeviceId,
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                TotalPrice = total
            };

            receipt.Details.Add(detail);

            // UPDATE TỒN KHO
            var device = await _context.Devices.FindAsync(item.DeviceId);
            if (device != null)
            {
                device.Quantity += item.Quantity;
            }

            totalAmount += total;
        }

        receipt.TotalAmount = totalAmount;

        _context.ImportReceipts.Add(receipt);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}