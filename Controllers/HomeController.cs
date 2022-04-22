using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CtrlUpEmploye.DAL;
using CtrlUpEmploye.Models;
using CtrlUpEmploye.Models.EmployeeViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;


namespace CtrlUpEmploye.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CtrlUpContext _context;

    public HomeController(ILogger<HomeController> logger, CtrlUpContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
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
    public async Task<ActionResult> About()
    {
        IQueryable<EnrollmentDate> data =
            from employee in _context.Employees
            group employee by employee.EnrollmentDate into dateGroup
            select new EnrollmentDate()
            {
                EnrollmentDatation = dateGroup.Key,
                EmployeeCount = dateGroup.Count()
            };
        return View(await data.AsNoTracking().ToListAsync());
    }
}

