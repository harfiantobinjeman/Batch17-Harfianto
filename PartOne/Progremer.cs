using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.PartOne
{
    internal class Progremer : Employee
    {
        private Decimal transportasi;

        public Progremer(int empId, string firsName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal transportasi) : base(empId, firsName, lastName, joinDate, basicSalary, city)
        {
            this.Transportasi = transportasi;
            this.Role = "Progremer";
            TotalSalery = basicSalary + transportasi;
        }
        public decimal Transportasi { get => transportasi; set => transportasi = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} Tj Transportasi = {this.transportasi.ToString("C",new CultureInfo("id-ID"))}";
        }
    }

}
