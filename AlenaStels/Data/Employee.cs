using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaStels.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int SortIndex { get; set; } = 0;

        public required string FIO { get; set; }

        public bool IsActive{ get; set; }=true;

    }
}
