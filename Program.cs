// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using JuraganTransportasi.TransportasiDarat;
using static System.Console;

/*Suv kenSuv = new Suv("D 1001 UM", 2015, 100_000, 600_000);
Suv kenSuv2 = new Suv("D 1002 UM", 2019, 100_000, 600_000);

Taxi kenTax = new Taxi("D 88 Uk", 2018, 5, 4500,40,10_000);
Taxi kenTax2 = new Taxi("D 87 Uk", 2018, 10, 4500, 100, 10_000);

Suv kenAng = new Suv("D 55 UJ", 2016, 4500, 35);
Suv kenAng2 = new Suv("D 55 Ui", 2015, 4500, 10);

Console.WriteLine(kenSuv.ToString());
Console.WriteLine(kenTax2.ToString());
Console.WriteLine(kenAng.ToString());
*/

IKendaraan kenImpls = new KendaraanImpl();
var listOfKendaraan = kenImpls.InitDataKendaraan();
kenImpls.Showlist(listOfKendaraan);

var sum = kenImpls.GetSum(listOfKendaraan);
kenImpls.ShowDirectory(ref sum);

var sumTotal = kenImpls.GetSumTotal(listOfKendaraan);
kenImpls.ShowSumTotal(ref sumTotal);

var empsRange = kenImpls.FindRevenueRange(listOfKendaraan, 500_000, 600_000);
kenImpls.Showlist(empsRange);
