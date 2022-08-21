using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21454249_HW04.Models;

namespace u21454249_HW04.Controllers
{
   
    public class HomeController : Controller
    {
        public static List<Booking> bookings = new List<Booking>();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Confirmation()
        {
            return View(bookings);
        }
        [HttpGet]
        public ActionResult Addbooking()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addbooking(string name, string surname, string location, string time, int? date, int type, string farlong,string condition, int? age, int ?grade)
        {
            if (type == 1)
            {
                // Create a teenager instance and add to list
                Teenagers teen = new Teenagers()
                {
                    Name = name,
                    Surname =surname,
                    Location=location,
                    Time=time,
                    Date = Convert.ToInt32(date),
                    Age = Convert.ToInt32(age),
                    Grade= Convert.ToInt32(grade),
                };
                bookings.Add(teen);
            }
            else if (type == 2)
            {
                // Create new Circle instance and add to list
                Maternal Mother = new Maternal()
                {
                    Name = name,
                    Surname = surname,
                    Location = location,
                    Time = time,
                    //Date = Convert.ToInt32(date),
                    Condition = condition,
                };
               bookings.Add(Mother);
            }
            else if (type == 3)
            {
                // Create plan instance and add to list
                PlanB plan = new PlanB()
                {
                    Name = name,
                    Surname = surname,
                    Location = location,
                    Time = time,
                    //Date = Convert.Toin(date),
                    Farlong =farlong,
                };
                bookings.Add(plan);
            }
            
            return RedirectToAction("Confirmation");
        }

         public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Donate()
        {

            return View("Donate");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact details.";

            return View();
        }
        public ActionResult DonorList()
        {

            return View();
        }

    }
}