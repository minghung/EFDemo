using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int Name { get; set; }
        public int ProjectStatusId { get; set; }

        //Navigation Properties
        public ProjectStatus ProjectStatus { get; set; }
        public ICollection<ProjectMember> Members { get; set; }
    }

    public class ProjectStatus
    {
        public int ProjectStatusId { get; set; }
        public string Description { get; set; }

        //Navigation Properties
        public ICollection<Project> Projects { get; set; }
    }

    public class ProjectMember
    {
        public Employee Employee { get; set; }
        public int AllocationPercent { get; set; }
    }
}
