using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPPMVC.Models
{
    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Roles { get; set; }
        public bool IsActive { get; set; }
    }
    public class UserLogin
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
