using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Stu
    {

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }

        public string GetFullName()
        {

            this.firstName = "Bill ";
            this.lastName = "Gates";
            return firstName + lastName;
           

        }

    }
}