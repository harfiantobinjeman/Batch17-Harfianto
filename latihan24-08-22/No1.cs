namespace Latihan
{
    class DayOne
    {
        public static void NoSatu()
        {
            Console.WriteLine("enter your number : ");
            string input = Console.ReadLine();
            int input2 = Convert.ToInt32(input);
            int hasil = 0;
            for (int i = input2; i >=0; i--)
            {
                hasil += input2 % 10;
                input2 /= 10;
            }
            Console.WriteLine(hasil);
        }
    }
}