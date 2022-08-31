using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal abstract class Person
    {
        private int sosialNumber;
        private string firsName;
        private string lastName;
        private string email;
        private DateTime birthday;
        private decimal totalRevenue;

        public int SosialNumber { get => sosialNumber; set => sosialNumber = value; }
        public string FirsName { get => firsName; set => firsName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        protected Person(string firsName, string lastName, string email, DateTime birthday)
        {
            this.firsName = firsName;
            this.lastName = lastName;
            this.email = email;
            this.birthday = birthday;
        }

        public abstract decimal TotalIncam(Dictionary<string, decimal> data);

        public override string? ToString()
        {
            return $"Sosial Number : |{this.sosialNumber} FullName : {this.firsName} {this.lastName} Email : {this.email} Ulang Tahun : {this.birthday} Total Reveneue : {this.totalRevenue}";
        }
    }
}
