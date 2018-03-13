using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    public enum EmployeeTitle
    {
        Other,
        ProjectManager,
        Developer,
        Tester
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public EmployeeTitle Title { get; set; }
        public string Name { get; set; }
        public int ManagerEmployeeId { get; set; }

        //Confidential Properties
        public decimal Salary { get; set; }
        public string Phone { get; set; }

        //Navigation Properties
        public Manager Manager { get; set; }
        public ICollection<EmployeeProject> Projects { get; set; }
    }

    public class EmployeeProject
    {
        public Project Project {get; set;}
        public int AllocationPercent { get; set; }
    }
}
