using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HR.Services;

namespace Employee_Reviews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Guid SelectedEmployee { get; set; } = Guid.Empty;
        public Company Company { get; set; } = new Company();
        public MainWindow()
        {
            InitializeComponent();
            this.Roster.ItemsSource = Company.Employees;
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedEmployee == Guid.Empty)
            {
                var name = this.EmployeeName.Text;
                var email = this.Email.Text;
                var phone = this.PhoneNo.Text;
                var salary = double.Parse(Salary.Text);
                var department = this.Department.Text;

                var newEmployee = Company.AddEmployee(name, email, phone, salary, department);

                SelectedEmployee = newEmployee.Id;
                this.Roster.Items.Refresh();
            }
        }
        //to clear input boxes...not working @ this time ???
        private void ClearSelectedEmployee(object sender, RoutedEventArgs e)
        {
            SelectedEmployee = Guid.Empty;
        }
        //create view button inside the List Viewer
        private void EmployeeSelected(object sender, RoutedEventArgs e)
        {
            
            var btn = sender as Button;
            if (btn != null)
            {
                var employee = btn.DataContext as Employee;
                this.EmployeeName.Text = employee.Name;
                this.Email.Text = employee.Email.ToString();
                this.PhoneNo.Text = employee.Phone.ToString();
                this.Salary.Text = employee.Salary.ToString();
                this.Department.Text = employee.Department.ToString();
                this.Raise.Text = employee.Money.SalaryIncrease.ToString();
                this.TotalSalary.Text = employee.Money.DepartInc.ToString();
                this.DeptRaise.Text = employee.Money.DepartIncTotal.ToString();
                //this.Review.Text = employee.Money.Review.ToString();

                
                SelectedEmployee = employee.Id;

                
                
            }
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {

            var salary = double.Parse(this.Salary.Text);
            var saladd = double.Parse(this.Raise.Text);
            var total = salary + saladd;
            var btn = Update as Button;
            if (btn != null)
            {
                Salary.Text = total.ToString();
            }
            var salaryincrease = int.Parse(this.Raise.Text);
            var departinc = double.Parse(this.DeptRaise.Text);
            var review = this.Review.Text;
            var raise = this.Salary.Text;

           
            Company.UpdateEmployeeStats(SelectedEmployee, salaryincrease, departinc, raise, review, salary);
           
        }

        private void TotalSalary_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }

        private void Raise_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            Salary.Text = Salary.Text + Raise.Text;
        }

        private void Raise_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}





          