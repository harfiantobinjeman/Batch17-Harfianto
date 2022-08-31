using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] ints = new int[] {89,12,545,23,32,76,867,233,5,68};
            //khusus sum
            var sum = ints.Sum(x=> x++);
            //khusus min
            var min = ints.Min();
            var max = ints.Max();

            var duplicat = ints.Distinct();
            Console.WriteLine("SUM : " + sum);
            Console.WriteLine("SUM : " + min);
            Console.WriteLine("SUM : " + max);
            foreach (var i in duplicat)
            {
                Console.WriteLine("duplikat "+ i);
            }
        }
    }
}
