using DayOop.PartTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOop.ParTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();
        public void ShowList<T>(List<T> list);

        //menemuan atau mencari
        public Employee FindEmployeeId(List<Employee> list, int id);

        //retrun data type <T>
        public decimal GetTotal<T>(ref List<T> list);

        public List<Employee> FindSalararyRang(List<Employee> list, decimal starFrom, decimal endTo);
    }
}
