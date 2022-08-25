using System;

namespace Latihan
{
    class DayOneNoDua
    {
        public static void NoDua()
        {
            /*Console.WriteLine("enter your number : ");
            string input = Console.ReadLine();
            int input2 = Convert.ToInt32(input);
            Console.WriteLine(Math.Ceiling(Math.Log10(input2 + 1)));*/
            Console.WriteLine("enter your number : ");
            string input = Console.ReadLine();
            int input2 = Convert.ToInt32(input);
            int count = 0;
            int sisa = input2;
            while (sisa > 0)
            {
                sisa = sisa / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}