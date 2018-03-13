using System.Collections.Generic;

namespace EFDemo.Model
{
    public class Manager : Employee
    {
        public string BusinessArea { get; set; }
        public decimal AnnualBudget { get; set; }

        //Navigation Properties
        public ICollection<Employee> TeamMember { get; set; }
    }
}