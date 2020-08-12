using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MC_Application
{
    public class Employee
    {
        public string Employeename { get; set; }
        public string Password { get; set; }
        public SqlDateTime DateOfCreation { get; set;}
        public int EmployeeID { get; set; }

        public string FullInfo
        {
            get
            {
                //     "Jon (1, June 28 2020 2:43:12PM)"
                return $"{ Employeename } ({ EmployeeID }, { DateOfCreation })"; 
            }
        }
    }
}
