using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.PartOne
{
    internal class Qa : Employee
    {
        private decimal makan;

        public override string? ToString()
        {
            return $"{base.ToString()} Tunjangan Makan : {this.makan.ToString("C", new CultureInfo("id-ID"))}";
        }

        public Qa(int empId, string firsName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) : base(empId, firsName, lastName, joinDate, basicSalary, city)
        {
            this.makan = makan;
            this.Role = "QA";
            TotalSalery = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }
    }
}
