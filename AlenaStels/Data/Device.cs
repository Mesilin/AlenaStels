using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaStels.Data
{
    public class Device
    {
        public int DeviceId { get; set; }
        
        public int SortIndex { get; set; } = 9999;

        public required string Name { get; set; }

        public bool IsActive { get; set; } = true;


    }
}
