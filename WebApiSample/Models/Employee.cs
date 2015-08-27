using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee Get()
        {
            Employee e = new Employee();
            e.FirstName = "Sukesh";
            e.LastName = "Marla";
            e.Salary = 25000;
            return e;
        }
    }
}