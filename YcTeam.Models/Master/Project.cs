using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YcTeam.Models.Master
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public string WBSCode{ get;set; }
        public string SmallaProject { get; set; }
        public string SmallWBSCode { get; set; }
        public string NitialApprovalFunds { get; set; }
        public string VoltageGrade { get; set; }
        public string ProjectDepartment { get; set; }
        public string PickingPeople { get; set; }
        public string ContactNumber { get; set; }
    }
}
