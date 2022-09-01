using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Jawaban
    {
        public static int NumberSatu(int nilai)
        {
            int jarakTempuh = 10;
            int count = 0;
            for (int i = 30; i < nilai; i++)
            {
                jarakTempuh =jarakTempuh + i;
                count++;
                if (jarakTempuh >= nilai)
                {
                    break;
                }
            }
            return count;
        }

        public static int NumberDua(int nilai)
        {
            int result = 1;
            for (int i = 1; i <= nilai; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int NumberTiga(int nilai)
        {
            int result = 0;
            for (int i = 0; i <= nilai; i++)
            {
                result += i;
            }
            return result;
        }
        public static int NumberEmpat(int nilai)
        {
            int result = 0;
            int simpan = 0;
            int hasil = 1;
            int a = 0;
            for (int i = 1; i < nilai; i++)
            {
                a += i;
                result = simpan + hasil;     //0 = 0 + 1  // 1 = 1 + 2
                simpan = result;     // 1 = 0       // 3 = 2
                Console.WriteLine(simpan);
            }
            return result;
        }
        public static int NumberLima()
        {
            int result = 0;

            return result;
        }

        public static string NumberEnam(string nilai)
        {
            string result = "FALSE";
            for (int i = 1; i <= nilai.Length; i++)
            {
                if (i%2==0)
                {
                    result = "TRUE";
                }
                else
                {
                    result = "FALSE";
                }
            }
            return result;
        }
        public static string NumberTujuh(string nilai1, string nilai2)
        {
            string result = "FALSE";
            string simpanNilai1 = nilai1.ToLower();
            string simpanNilai2 = nilai2.ToLower();
            string a = "";
            if (nilai1.Length != nilai2.Length)
            {
                result = "FALSE";
            }
            else
            {
                for (int i = 0; i < simpanNilai1.Length; i++)
                {
                    for (int j = 0; j < simpanNilai2.Length; j++)
                    {
                        if (simpanNilai1[i] == simpanNilai2[j])
                        {
                            a += simpanNilai1[i];
                            break;
                        }
                    }
                }
            }            
            if (a == simpanNilai1)
            {
                result = "True";
            }
            else
            {
                result = "False";
            }
            return result;
        }
        public static int[,] NumberDelapan(int b,int k)
        {
            int[,] matrix = new int[b, k];
            int counter = b;
            int count = 10;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        matrix[i, 0] = count;
                    }
                }
            }
                return matrix;
        }
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
    }
}
