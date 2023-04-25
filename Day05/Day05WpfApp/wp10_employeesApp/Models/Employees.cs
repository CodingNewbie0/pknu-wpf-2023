using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wp10_employeesApp.Models
{
    public class Employees
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public int Salary { 
            get => Salary;
            set
            {
                //{
                //    throw new Exception("급여 오류");
                //}
                //else
                //{
                //    Salary = value;
                //}
            } 
        }
        public string DeptName { get; set; }
        public string Address { get; set; }
        public string FullName { get; internal set; }
    }
}
