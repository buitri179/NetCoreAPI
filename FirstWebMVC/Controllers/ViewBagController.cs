using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;
[Route("viewbag")]
public class ViewBagController : Controller
{
    private readonly ILogger<ViewBagController> _logger;

    public ViewBagController(ILogger<ViewBagController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Hello from ViewBag!";
        ViewBag.Date = DateTime.Now;
        return View();
    }
}