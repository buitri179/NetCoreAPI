using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;
[Route("demo")]
public class DemoController : Controller
{
    private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
}