using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "blahblah ipsum";
        return View("Index", message);
    }

    [HttpGet("Numbers")]
    public IActionResult Numbers()
    {
        int [] numbers = new int []
        {
            1,
            4,
            6,
            657,
            25,
            234,
            2
        };
        return View(numbers);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>();
        users.Add(new User("Stemen", "Gregorith"));
        users.Add(new User("Bumlo", "Mendersoi"));
        users.Add(new User("Toigail", "Poinamjo"));
        users.Add(new User("Shem", "Grem"));
        users.Add(new User("Albertsons", "McDangerous"));
        users.Add(new User("Safeway", "DangerBuey"));
        users.Add(new User("Bjorn", "Yiemarbo"));

        return View(users);
    }
    [HttpGet("user")]
    public IActionResult OneUser()
    {
        User firstUser = new User("Stemen", "Gregorith");
        return View(firstUser);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
