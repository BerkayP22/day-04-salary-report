using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gün4
{
    public class Employee 
    { 
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int WorkHours { get; set; }
    }
    internal class Program
    {
        static Employee GetEmployeeName()
        {
            Employee employee = new Employee();
            Console.Write("Employee Name:"); 
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Employee Salary:");
            employee.EmployeeSalary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Employee Work Hours: ");

            if (int.TryParse(Console.ReadLine(), out int workHours))
            {
                employee.WorkHours = workHours;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            return employee;
        }
        static decimal CalculateTotalSalary(Employee employee)
        {

            if (employee.WorkHours < 160)
            {
                employee.EmployeeSalary = employee.EmployeeSalary;
            }
            else if (employee.WorkHours >= 160 && employee.WorkHours <= 180)
            {
                employee.EmployeeSalary += 1500;
            }
            else if (employee.WorkHours > 180 && employee.WorkHours <= 200)
            {
                employee.EmployeeSalary += 3000;
            }
            else
            {
                employee.EmployeeSalary += 5000;
            }

            return employee.EmployeeSalary;
        }
        static decimal BonusSalary(Employee employee)
        {
            decimal bonus;

            if (employee.WorkHours < 160)
            {
                bonus = 0;
            }
            else if (employee.WorkHours <= 180)
            {
                bonus = 1500;
            }
            else if (employee.WorkHours <= 200)
            {
                bonus = 3000;
            }
            else
            {
                bonus = 5000;
            }

            return bonus;
        }
        static decimal Productivity(decimal hour,decimal day)
        {
            decimal productivity = hour /day ;
            return productivity;
        }
        static string Productivity(string Comments)
        {
            if (string.IsNullOrEmpty(Comments))
            {
                Console.WriteLine("Comments cannot be empty.");
            }
            return Comments;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------Salary Report---------");

            Employee employee = GetEmployeeName();

            decimal bonusSalary = BonusSalary(employee);
            decimal totalSalary = CalculateTotalSalary(employee);
            Console.Clear();
            Console.WriteLine("---------Salary Report---------");
            Console.WriteLine(
                $"Employee Name: {employee.EmployeeName}\n" +
                $"Employee Salary: {employee.EmployeeSalary}\n" +
                $"Employee Work Hours: {employee.WorkHours}\n" +
                $"Bonus Salary: {bonusSalary}\n" +
                $"Total Salary: {totalSalary}"
            );
            Console.ReadLine();
            Console.Clear(); Console.WriteLine("---------Productivity Report---------");
            Console.Write("ENTER THE NUMBER OF HOURS WORKED: ");
            decimal hour = int.Parse(Console.ReadLine());
            Console.Write("ENTER THE NUMBER OF DAYS WORKED: ");
            decimal day = int.Parse(Console.ReadLine());
            decimal pro= Productivity(hour, day);
            Console.WriteLine(pro);
            Console.Write("YourComments: ");
            string Comments = Console.ReadLine();
            Console.Write(Productivity(Comments));
            Console.ReadLine();
        }
    }
}
