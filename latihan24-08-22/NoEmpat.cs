namespace Latihan
{
    class NoEmpat
    {
        public static void LatihanNoEmpat()
        {
            Console.WriteLine("masukan Nilai interger");
            int input =Convert.ToInt32(Console.ReadLine());
            int kurangSatu = 0;
            for (int i = 0; i < input; i++)
            {
                kurangSatu = i;
                if (kurangSatu>=i)
                {
                    kurangSatu=i;
                }
            }
            Console.WriteLine(kurangSatu);
        }
    }
}