namespace Latihan
{
    class NoTiga
    {
        public static void LatihanNoTiga()
        {
            Console.WriteLine("Masukan nilai Interger : ");
            string input = Console.ReadLine();
            string hasilInput = String.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                hasilInput += input[i];
            }
    
            Console.WriteLine( Convert.ToInt32(hasilInput));
        }
    }
}