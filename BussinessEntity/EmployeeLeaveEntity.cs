using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessEntity
{
    public class EmployeeLeaveEntity
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Deptname { get; set; }
        public string Designation { get; set; }
        public string Reason { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Days { get; set; }
        public string Status { get; set; }

    }
}
