using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Project : Base
    {
        public Project()
        {
        }

        public Project(string code, DateTime startDate, DateTime estimatedEndDate)
        {
            Code = code;
            StartDate = startDate;
            EstimatedEndDate = estimatedEndDate;
        }

        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime RealEndTime { get; set; }
        //public Person Responsible { get; set; }

        public static Project GetProject()
        {
            return null;
        }

        public bool MarkFinished(Project project)
        {
            RealEndTime = DateTime.Now;
            return true;
        }

    }
}
