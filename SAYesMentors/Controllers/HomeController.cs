using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAYesMentors.Models;

namespace SAYesMentors.Controllers
{
    public class HomeController : Controller
    {
        public List<Narative> narratives = new List<Narative>
        {
            new Narative{MyName = "Nkateko Maluleke", CaseName="Register", CaseID="1.1", Version="1.0.0",
                          Date="14-08-2022", Priority="High", Source="Case Study", PBA="User", PSA="None",
                           OPS="None", OPA="Employee", Description="A user, whether a mentor or mentee clicks the register tab" +
                           " on the web application's navigation bar to make a profile and create an application",
                            PreCon="User has opened the web application", Trigger="A potential mentee or volunteering mentor" +
                            " clicks the register tab to create an application"},

            new Narative{MyName = "Nkateko Maluleke", CaseName="Login", CaseID="1.2", Version="1.0.0",
                          Date="14-08-2022", Priority="High", Source="Case Study", PBA="User", PSA="None",
                           OPS="None", OPA="None", Description="A user, whether a mentor, mentee or employee clicks the login tab" +
                           " on the web application's navigation bar to log into their profile",
                            PreCon="User has to be registered in the system", Trigger="A user clicks the login tab and attempts" +
                            " to log into their user account"},

            new Narative{MyName = "Nkateko Maluleke", CaseName="Approve Application", CaseID="2.1", Version="1.0.0",
                          Date="14-08-2022", Priority="High", Source="Case Study", PBA="Employee", PSA="None",
                           OPS="None", OPA="Mentor, Mentee", Description="The employee chooses to approve an applicant's application",
                            PreCon="The employee has logged into the system", Trigger="The employee clicks an applicant's application " +
                            "and chooses to approve it"},

            new Narative{MyName = "Nkateko Maluleke", CaseName="Delete application", CaseID="1.4", Version="1.0.0",
                          Date="14-08-2022", Priority="Medium", Source="Case Study", PBA="User", PSA="None",
                           OPS="None", OPA="None", Description="A mentor or mentee wants to delete their pending application",
                            PreCon="The user is logged into their profile", Trigger="A mentor or mentee chooses to delete their pending " +
                            "application"},
        };


        public ActionResult Index()
        {
            return View(narratives);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your Welcome page.";

            return View();
        }
    }
}