using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Latihan
{
    internal class Soal
    {
        public static void ArrayDisplays(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }
        //No 1.
        public static void RandomArrayNo1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void RandomIndexNo1(int[] arr)
        {
            Console.WriteLine("Before Random Position");
            RandomArrayNo1(arr);
            Console.WriteLine("After Random Position change");
            arr = RandomPosition(arr);
            RandomArrayNo1(RandomPosition(arr));
            Console.WriteLine();
        }
        public static int[] RandomPosition(int[] arr15)
        {
            int[] array = arr15;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0, arr15.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }
        //batas no 1

        //No 2.
        public static int[] NumberDua(int[] arr)
        {
            int[] array = arr;
            int a = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = a;
            return arr;
        }

        //NO 3.
        public static int[] NoTiga(int[] nilai)
        {
            int[] arr = nilai;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotasi Ke - {i} : ");
                int awal = nilai[0];
                for (int j = 0; j < nilai.Length - 1; j++)
                {
                    arr[j] = nilai[j + 1];
                }
                arr[nilai.Length - 1] = awal;
                ArrayDisplays(arr);
            }
            return arr;
        }
        //Batas No 3.

        //No 4.
        public static int[] NoEmpat(int[] nilai)
        {
            int[] arr = nilai;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotasi Ke - {i} : ");
                int last = nilai[nilai.Length - 1];
                for (int j = nilai.Length - 1; j > 0; j--)
                {
                    arr[j] = nilai[(j - 1)];
                }
                arr[0] = last;
                ArrayDisplays(arr);
                nilai = arr;
            }
            return arr;
        }
        public static void NoLima(int[] arr)
        {
            Array.Sort(arr);
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                if (i < arr.Length - 1 && index == arr[i + 1])
                {
                    count++;
                }
                else if (i == arr.Length - 1 && index == arr[i - 1])
                {
                    Console.WriteLine($"{arr[i]} muncul {count} kali");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} muncul {count} kali");
                    count = 1;
                }
            }
        }

        public static void NoEnam(int[] arr)
        {
            int[] array = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];
                if (i < arr.Length - 1 && x == arr[i + 1])
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }
                    }
                }
            }
            ArrayDisplays(arr);
        }

        public static int NoTujuh(int[] arr)
        {
            int[] nilai = arr;
            Array.Sort(nilai);
            int j = 0;

            for (int i = 0; i < nilai.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    nilai[j++] = arr[i];
                }
            }
            nilai[j++] = arr[arr.Length - 1];

            for (int i = 0; i < j; i++)
            {
                arr[i] = nilai[i];
            }
            return j;
        }

        //No 9.
        public static int[,] NoSembilan(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = baris;
            int count = 0;
            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                        count += matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            Console.WriteLine(count);
            return matrix;
        }
        ///dari sini/
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] NoSepuluh(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();
            int count = 0;
            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        int counter = random.Next(0, 20);
                        matrix[i, j] = counter--;
                        count += matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            Console.WriteLine(count);
            return matrix;
        }
        public static int[,] NoSebelas(int baris,int kolom)
        {
            int[,] newArray = new int[baris,kolom];
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (i == 0 || i == newArray.GetLength(0) - 1)
                    {
                        newArray[i, j] = i + j;
                    }
                    else if (j == 0 || j == newArray.GetLength(1) - 1)
                    {
                        newArray[i, j] = i + j;
                    }
                }
                Console.WriteLine();
            }
            return newArray;
        }
        public static int[,] NoDuaBelas(int baris, int kolom)
        {
            int[,] arr = new int[baris+1, kolom+1];
            int b = baris - 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                     arr[i, j] = i + j;
                     arr[j, i] = j + i;
                    if (i == arr.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < i; x++)
                        {
                            sum += arr[x, j];
                        }
                        arr[i, j] = sum;
                        arr[j, i] = sum;
                    }
                    else if (j == arr.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < j; x++)
                        {
                            sum += arr[i, x];
                        }
                        arr[i, j] = sum;
                        arr[j, i] = sum;
                    }
                }
            }
            return arr;
        }
    }
}
