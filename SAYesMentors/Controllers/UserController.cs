using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAYesMentors.Models;

namespace SAYesMentors.Controllers
{
    public class UserController : Controller
    {
        public List<User> users = new List<User>();
     
        public List<User> admin = new List<User>
        {
            new Admin {FirstName="Nkateko", LastName="Maluleke", Gender="Male", Address="123 Hatfield Pretoria", Age=21, CellphoneNumber="0672472417",
                EmailAddress="u19075716@tuks.co.za", UserType="Employee", Password="MMaluleke"},
            new Admin {FirstName="Olimpia", LastName="Hlanjwa", Gender="Female", Address="123 Prinshof Pretoria", Age=21, CellphoneNumber="0835921928",
                EmailAddress="olimpiajohane@gmail.com", UserType="Employee", Password="OHlanjwa"},
        };


        // GET: User
        public ActionResult Register()
        {
           return View();
        }
        
        [HttpPost]
        public ActionResult Register(string validationCustom01, string validationCustom02, string validationCellphone, string genderValidation, string applicantType, string validationAddress, string validationEmail, DateTime DOB )
        {

            if (applicantType == "Mentee")
            {
                Mentee mentee = new Mentee();
                mentee.FirstName = validationCustom01;
                mentee.LastName = validationCustom02;
                mentee.CellphoneNumber = validationCellphone;
                mentee.Gender = genderValidation;
                mentee.UserType = applicantType;
                mentee.Address = validationAddress;
                mentee.EmailAddress = validationEmail;
                mentee.Age = mentee.getAge(DOB);

                users.Add(mentee);
            }

            else if(applicantType == "Mentor")
            {
                Mentor mentor = new Mentor();
                mentor.FirstName = validationCustom01;
                mentor.LastName = validationCustom02;
                mentor.CellphoneNumber = validationCellphone;
                mentor.Gender = genderValidation;
                mentor.UserType = applicantType;
                mentor.Address = validationAddress;
                mentor.EmailAddress = validationEmail;
                mentor.Age = mentor.getAge(DOB);

                users.Add(mentor);
            }

            return RedirectToAction("AdminProfile");
        }
        

        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string primaryKey, string loginKey)
        {
            bool phoneFound = false;
            foreach(var finder in admin)
            {
                if(finder.CellphoneNumber==primaryKey && finder.Password==loginKey)
                {
                    phoneFound = true;
                }           
            }
            if (phoneFound == true)
            {
                return RedirectToAction("AdminProfile");
            }
            else
                return View();
            
            
        }

        public ActionResult AdminProfile()
        {
            return View(admin);
        }

    }
}