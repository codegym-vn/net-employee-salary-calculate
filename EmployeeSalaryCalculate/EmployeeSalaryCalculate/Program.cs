using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo các biến sử dụng trong chương trình
            int coefSalary, numberOfYears, salary;

            // Nhập vào hệ số lương
            Console.Write("Enter coefficients salary:");
            coefSalary = Int32.Parse(Console.ReadLine());

            // Nhập vào số năm làm việc
            Console.Write("Enter number of years:");
            numberOfYears = Int32.Parse(Console.ReadLine());

            // Tính toán số lương dựa trên hệ số và số năm làm việc
            salary = coefSalary * 4000000 + numberOfYears * 500000;

            // In ra số lương tháng
            if (coefSalary >= 1 && coefSalary <= 5)
            {
                Console.Write("Monthly salary is: {0:N}", salary);
            }
            else
            {
                Console.Write("Salary coefficient is not valid!");
            }

            Console.ReadLine();
        }
    }
}
