using DayOop.PartTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.ParTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeId(List<Employee> list, int id)
        {
            /*throw new NotImplementedException();*/
            //var emps = new Employee();
            Employee? emps = null;
            foreach(var item in list)
            {
                if (item.EmpId == id)
                {
                    emps = item;
                }
            }
            return emps;
        }

        public List<Employee> FindSalararyRang(List<Employee> list, decimal starFrom, decimal endTo)
        //public List<Employee> FindSalararyRang||<T>||(List<Employee> list, decimal starFrom, decimal endTo) // tidak boleh BOSSS
        {
            //throw new NotImplementedException();
            var empRange =  new List<Employee>();

            foreach (var item in list)
            {
                if (item.TotalSalery >= starFrom && item.TotalSalery <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public decimal GetTotal<T>(ref List<T> list)
        {
            /*throw new NotImplementedException();*/
            var total = 0M; /// M di anggap Decimal kala hanya 0 itu int
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalery;
            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
            Employee emp4 = new Employee(1001, "yuli", "aja", new DateTime(), 3_500_000, "kalimantan", "progamer");
            Employee emp3 = new Employee(1002, "yuli1", "aja2", new DateTime(), 4_000_000, "kalimantan1", "sales");
            Employee emp1 = new Employee(1003, "yuli1", "aja2", new DateTime(), 2_000_000, "kalimantan1", "QA");
            Progremer prog1 = new Progremer(1010, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
            Sales sales1 = new Sales(1009, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
            Qa qa = new Qa(1009, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
            List<Employee> emp2 = new List<Employee> { emp1, emp3, emp4,prog1,sales1,qa };
            return emp2;
        }

        public void ShowList<T>(List<T> list)
        {
            //throw new NotImplementedException();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
