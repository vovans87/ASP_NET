using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppASP_MVC.Models
{
    public class User
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string password { get; set; }

        public int age { get; set; }

        public List<string> country { get; set; }
    }
}