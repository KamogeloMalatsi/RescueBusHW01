using KamogeloRescueBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace KamogeloRescueBus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpGet]
        //public ActionResult SelectService()
        //{
        //    List<Service> services = ServiceRepository.GetServices();
        //    return View(services);
        //}

        //[HttpPost]
        //public ActionResult SelectService(int serviceType)
        //{

        //    //if (serviceType == "ALS(Advanced Life Support)") { return RedirectToAction("Index"); } //ALS(Advanced Life Support)
        //    //else if (serviceType == "BLS(Basic Life Support)") { return RedirectToAction("Index"); } //BLS(Basic Life Support)
        //    //else if (serviceType == "Patient Transport") { return RedirectToAction("Index"); } //Patient Transport
        //    //else if (serviceType == "Medical Utility Vehicle") { return RedirectToAction("Index"); } //Medical Utility Vehicle
        //    //else if (serviceType == "Event Medical Ambulance") { return RedirectToAction("Index"); } //Event Medical Ambulance
        //    //else if (serviceType == "Air Ambulance") { return RedirectToAction("Index"); } //Air Ambulance
        //    //else { return RedirectToAction("Index"); }

        //    if (serviceType == 1) { return RedirectToAction("Index"); } //ALS(Advanced Life Support)
        //    else if (serviceType == 2) { return RedirectToAction("Index"); } //BLS(Basic Life Support)
        //    else if (serviceType == 3) { return RedirectToAction("Index"); } //Patient Transport
        //    else if (serviceType == 4) { return RedirectToAction("Index"); } //Medical Utility Vehicle
        //    else if (serviceType == 5) { return RedirectToAction("Index"); } //Event Medical Ambulance
        //    else if (serviceType == 6) { return RedirectToAction("Index"); } //Air Ambulance
        //    else { return RedirectToAction("Index"); }

        //    //return RedirectToAction("Index");
        //}

        //public ActionResult ServiceA()
        //{
        //    return View();
        //}
    }
}