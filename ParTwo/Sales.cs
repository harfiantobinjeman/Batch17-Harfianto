using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.PartTwo
{
    internal class Sales : Employee
    {
        private decimal tjSales;

        public override string? ToString()
        {
            return $"{base.ToString()} Bonus Sales : {this.tjSales.ToString("C", new CultureInfo("id-ID"))}";
        }

        public Sales(int empId, string firsName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal tjSales) : base(empId, firsName, lastName, joinDate, basicSalary, city)
        {
            this.tjSales = tjSales;
            this.Role = "Sales";
            TotalSalery = basicSalary + TjSales;
        }

        public decimal TjSales { get => tjSales; set => tjSales = value; }
    }

}
