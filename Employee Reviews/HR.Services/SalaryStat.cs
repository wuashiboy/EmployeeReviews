using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Services
{
    public class SalaryStat
    {
        public int SalaryIncrease { get; set; } = 0;
        public double DepartInc { get; set; } = 0;
        public double DepartIncTotal { get; set; } = 0;
        public string Review { get; set; }
        public string Raise { get; set; }
    }


}
