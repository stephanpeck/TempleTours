using TempleToursProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleToursProject.Models.ViewModels;
using TempleToursProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


//Home controller
namespace TempleToursProject.Controllers
{
    public class HomeController : Controller
    {
        //initialize the context object to reference the context db
        private TourDbContext context { get; set; }
        
        private readonly ILogger<HomeController> _logger;

        private ITourRepository _repository;

        //sets the number of items per page returned (5 books per page)
        public int PageSize = 5;


        //constructor that gets the repository and context db's
        public HomeController(ILogger<HomeController> logger, ITourRepository repository, TourDbContext ctx)
        {
            _logger = logger;
            _repository = repository;
            context = ctx;
        }
        // Loads the index view and sends the book repository along with it in the form of a model so that it can be used in the cshtml page

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tours()
        {
            return View(new GroupTimeSlotCombo
            {
                TimeSlots = _repository.TimeSlots
                    .OrderBy(p => p.TimeSlot)
                    .Where(p => p.Scheduled == false)
            });
        }


        //timeSlot is posted from Tour View
        [HttpPost]
        public IActionResult TourSummary(DateTime SelectedTimeSlot)
        {
            //reference the selected time slot variable in the context db
            var result = context.TimeSlots.SingleOrDefault(t => t.TimeSlot == SelectedTimeSlot);
            //validate that it's not empty
            if (result != null)
            {
                //change scheduled to be true so it doesn't show up on the available times list
                result.Scheduled = true;
                context.SaveChanges();
            }


            return View(new GroupInfo
            {
                SelectedAppointmentDay = SelectedTimeSlot.ToShortDateString(),
                SelectedAppointmentTime = SelectedTimeSlot.ToShortTimeString()
            });
        }


        [HttpGet]
        public IActionResult ScheduledTours()
        {
            return View(context.GroupInfo);
        }


        [HttpPost]
        public IActionResult ScheduledTours(GroupInfo thisgroup)
        {
            if (ModelState.IsValid)
            {
                context.GroupInfo.Add(thisgroup);
                context.SaveChanges();
                return View(
                    context.GroupInfo 
                );
            }
            else
            {
                return RedirectToAction();
            }

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
}
