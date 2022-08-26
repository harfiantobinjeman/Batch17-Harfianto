/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

//kalau malas mau buat consele

using Day02;
using System.Linq.Expressions;
using static System.Console;

//ArrayCase.TipyArray();

//var myArray = ArrayCase.InitArrayInt(new int[] {10,20,30,40,50});
//BIas Juga
int[] n = { 1, 2, 3, 4, 5, 6, };
var myArrays = ArrayCase.InitArrayInt(n);
//ArrayCase.InitArrayInt(n);
//ArrayCase.DisplayArrayInt(myArrays);
var myRandom = ArrayCase.InitArrayRandom(20);
ArrayCase.DisplayArrayInt(myRandom);
Console.WriteLine($" Total Keseleuruhan Array : {ArrayCase.SumElement(myRandom)}");
Console.WriteLine($"Angka Terbesar dari random Adalah : {ArrayCase.FindLargeElement(myRandom)}");

int[] newArray = new int[myRandom.Length];


var randomArray = new int[myRandom.Length];
Array.Copy(myRandom, 0, randomArray, 0, myRandom.Length);
Array.Reverse(randomArray);
ArrayCase.DisplayArrayInt(randomArray);