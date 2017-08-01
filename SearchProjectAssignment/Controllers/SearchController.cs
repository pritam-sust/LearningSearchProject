using SearchProjectAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchProjectAssignment.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search

        public ActionResult Index()
        {
            return View();            
        }

        
        public ActionResult LoadData()
        {           
            Reservation resObj = new Reservation();
            List<Reservation> listReservation = new List<Reservation>();
            listReservation = resObj.GetData();//Get data from static list
            return Json(new { data = listReservation }, JsonRequestBehavior.AllowGet);


        }
    }
}