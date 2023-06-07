using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class Employee
    {
        private int id=-1;
        private string nameEmployee;
        private int yearOfBirth;
        private double salaryLevel; // Bậc lương
        private double basicSalary; // Lương cơ bản

        // Hàm tạo
        public Employee() { }

        public Employee(int id, string nameEmployee, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.nameEmployee = nameEmployee;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }

        public void setId()
        {
            int id1;
            do
            {
                Console.Write("\nNhập id: ");
                id1 = Convert.ToInt32(Console.ReadLine());
            } while (id1 < 0);
            this.id = id1;
        }

        public void setName()
        {
            Console.Write("\nNhập name: ");
            this.nameEmployee = Console.ReadLine();
        }

        public void setYearOfBirth()
        {
            Console.Write("\nNhập năm sinh: ");
            this.yearOfBirth = Convert.ToInt32(Console.ReadLine());
        }

        public void setSalaryLevel()
        {
            Console.Write("\nNhập bậc lương: ");
            salaryLevel = Convert.ToDouble(Console.ReadLine());
        }

        public void setBasicSalary()
        {
            Console.Write("\nNhập lương cơ bản: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }

            //  GET
        
        public int getId() { return id; }
        public String getName() { return nameEmployee; }
        public int getYearOfBirth() { return yearOfBirth; }
        public double getSalaryLevel() { return salaryLevel; }
        public double getBasicSalary() { return basicSalary; }
        


        public double GetIncome()   // Tính lương
        {
            return salaryLevel*basicSalary;
        }

        public void display()
        {
            Console.Write("\nId: " + id);
            Console.Write("\nName: "+nameEmployee);
            Console.Write("\nYear of birth: " + yearOfBirth);
            Console.Write("\nIncome: " + this.GetIncome());
            Console.WriteLine();
        }
    }
}
