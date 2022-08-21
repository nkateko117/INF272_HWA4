using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAYesMentors.Models
{
    public class Mentee: User
    {
        public string status { get; set; }
        public override int getAge(DateTime date)
        {
            DateTime now = DateTime.Now;
            var age = now.Year - date.Year;
            return (int)age;
        }
    }
}