using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.PartTwo
{
    internal class Employee
    {
        //instan variable
        private int empId;
        private string firsName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string city;
        private string role;
        private decimal totalSalery;
        //static variabel
        public static int totalEmployee = 0;
        public static Decimal totalBasicSalary = 0;
        public Employee(int empId, string firsName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role) : this(empId, firsName, lastName, joinDate, basicSalary, city)
        {
            this.Role = role;
        }

        //empety constraktor
        public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalery = this.BasicSalary;
        }

        //construktor prameter
        public Employee(int empId, string firsName, string lastName, DateTime joinDate, decimal basicSalary,string city)
        {
            //instan variabel//
            this.empId = empId;
            this.firsName = firsName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.city = city;
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalery = this.BasicSalary;
        }

        public override string? ToString()
        {
            return $"Employee : {this.empId} | Firs Name : {this.firsName} | Last Name : {this.lastName} | salary : {this.basicSalary.ToString("C", new CultureInfo("id-ID"))} | Rolenya : {role} | Dengan Total Salery : {this.totalSalery.ToString("C", new CultureInfo("id-ID"))} |";
        }

        //geter seter blok private klik kanan paling atas
        public int EmpId { get => empId; set => empId = value; }
        public string FirsName { get => firsName; set => firsName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary; set 
                {
                    basicSalary = value;
                //totalSalery = basicSalary; 
                } 
            }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalery { get => totalSalery; set => totalSalery = value; }
    }
}
