using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnetmvcssrs.Models;

namespace aspnetmvcssrs.Controllers
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

        public ActionResult ViewReport()
        {
           
            return View();
        }

        public ActionResult GenerateReport()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GroupSessionList(FormCollection fc)
        {
            string stdID = fc["stdID"].ToString();
            string staffID = fc["cID"].ToString();
            string sMonth = fc["sMonth"].ToString();
            string sYear = fc["sYear"].ToString();

            var ssrs = new SSRS
            {
                ReportURL = String.Format("~/../../Reports/GroupSessionList.aspx?ReportName={0}&StaffID={1}&StdID={2}&sMonth={3}&sYear={4}", "GroupSessionList", staffID, stdID, sMonth, sYear)
            };

            return View(ssrs);
        }
    }
}