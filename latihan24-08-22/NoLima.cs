namespace Latihan
{
    class NoLima
    {
        public static void LatihanNoLima()
        {
            Console.WriteLine("masukan Nilai interger 1 - 20");
            Random random = new Random();
            int number = random.Next(0, 20);
            int gues = -1;
            while (gues !=number)
            {
                var input = Console.ReadLine();
                int.TryParse(input, out gues);

                if (gues == number)
                {
                    Console.WriteLine($"Your right, Number : {gues}");
                    Console.WriteLine($"Ulangi y/n");
                    string ulangLagi = Console.ReadLine();
                    if (ulangLagi == "y")
                    {
                        Latihan.NoLima.LatihanNoLima();
                    }
                    else if(ulangLagi == "n")
                    {
                        break;
                    }
                    else
                    {
                        break;
                    }

                }
                else if(gues>number){
                    Console.WriteLine($"Your gues is too hight. try again!");
                }
                else
                {
                    Console.WriteLine($"Your gues is too low. try again!");
                }
            }
        }
    }
}