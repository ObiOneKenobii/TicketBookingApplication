using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Data;
using TicketBookingApplication.Models;
namespace TicketBookingApplication.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();

        }



        public IActionResult Movies()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
        //public class ApplicationDbController: ControllerBase
        //{
        //    private readonly ApplicationDbContext ApplicationDbContext;


        //    public ApplicationDbController(ApplicationDbContext ApplicationDbContext)
        //    {
        //        this.ApplicationDbContext = ApplicationDbContext;
        //    }

        //    [HttpGet("GetAll")]
        //    public ActionResult Index()
        //    {
        //        return Ok(this.ApplicationDbContext.Tickets.ToList());
        //    }
    

}