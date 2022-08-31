using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Costumers : Person
    {
        private string acountNumber;
        public Costumers(string firsName, string lastName, string email, DateTime birthday, string acountNumber) : base(firsName, lastName, email, birthday)
        {
            SosialNumber = new Random().Next(1000, 1100);
            FirsName = firsName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            this.acountNumber = acountNumber;
        }
    
        public override string? ToString()
        {
            return $"{base.ToString()} Count Number {acountNumber}";
        }

        public string AcountNumber { get => acountNumber; set => acountNumber = value; }

        public override decimal TotalIncam(Dictionary<string, decimal> data)
        {
            var totalIncome = 0M;
            foreach (var item in data)
            {
                totalIncome += item.Value;
            }
            return totalIncome;
        }
    }
}
