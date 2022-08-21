using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAYesMentors.Models
{
    public abstract class User
    {
        public string UserType { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellphoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public abstract int getAge(DateTime date);
        
    }
}