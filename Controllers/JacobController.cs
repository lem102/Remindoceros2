using Microsoft.AspNetCore.Mvc;
using Remindoceros2.Models;

namespace Remindoceros2.Controllers;

public class JacobController : Controller
{
    private readonly ILogger<JacobController> _logger;

    private JacobView _jacob = new JacobView
    {
        Name = "Jacob",
        Age = 26
    };

    public JacobController(ILogger<JacobController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(_jacob);
    }

    [HttpPost]
    public IActionResult Age()
    {
        _jacob.Age++;
        // this will have no effect, as constructor is created anew per request
        return RedirectToAction("Index");
    }
}
