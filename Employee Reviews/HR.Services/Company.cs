using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Services
{
    public class Company
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee AddEmployee(string name, string email, string phone, double salary, /*double raise,*/ string department)
        {
            var employee = new Employee
            {
                Name = name,
                Email = email,
                Phone = phone,
                Salary = salary,
                Department = department,
            };
            Employees.Add(employee);
            return employee;
        }

        public void UpdateEmployeeStats(Guid selectedEmployee, int salaryincrease, double deptsalinc, string raise, string review, double salary)
        {
            var employee = Employees.FirstOrDefault(f => f.Id == selectedEmployee);
            employee.Money.SalaryIncrease = salaryincrease;
            employee.Money.DepartInc = deptsalinc;
            employee.Money.Review = review;
            employee.Money.Raise = raise;
            
            
            //employee.Money.DepartIncTotal = departsaltotal;
            Employees.Add(employee);
        }
    }
}


