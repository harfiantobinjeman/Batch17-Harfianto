namespace Latihan
{
    class latihan
    {
        public static void LatihanNoEnam()
        {
            int max = 0;
            for (int i = 0; i<5; i++)
            {
                Console.Write("masukan Nilai interger : ");
                var input = Console.ReadLine();
                int.TryParse(input, out int input2);
                max = input2;
                if (max > input2)
                {
                max = input2;
                }
            }
            Console.WriteLine(max);
        }
        public static void NoTujuh()
        {
            Console.WriteLine("enter your number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<input; i++)
            {
                if (input % i == 0 )
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public static void NoDelapan()
        {
            bool prima = true;
            Console.WriteLine("Masukan batas bilangan : ");
            int bilangan = Convert.ToInt32(Console.ReadLine());
            for (int x = 2; x <= bilangan; x++)
            {
                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        prima = false;
                        break;
                    }
                }
                if (prima)
                    Console.Write(x + " ");
                prima = true;
            }
        }
        public static void NoSembilan()
        {
            Console.WriteLine("Masukan batas bilangan : ");
            string input = Console.ReadLine();
            string input2 = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input2[i] == input2[(input.Length - 1) - i])
                {
                    Console.WriteLine("String is Polindrom");
                    break;
                }
                else
                {
                    Console.WriteLine("String not Polindrom");
                    break;
                }
            }
        }
    }
}