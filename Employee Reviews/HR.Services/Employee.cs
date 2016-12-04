using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Services
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        //public double Raise { get; set; }
        //public string Review { get; set; }
        public SalaryStat Money { get; set; } = new SalaryStat();

    }

    
}
