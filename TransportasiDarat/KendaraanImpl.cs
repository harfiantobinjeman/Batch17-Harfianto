using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal class KendaraanImpl : IKendaraan
    {
        public List<Kendaraan> FindRevenueRange(List<Kendaraan> list, decimal starFrom, decimal endTo)
        {
            //throw new NotImplementedException();
            var empRange = new List<Kendaraan>();

            foreach (var item in list)
            {
                if (item.TotalRevenue >= starFrom && item.TotalRevenue <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetSum(List<Kendaraan> list)
        {
            //throw new NotImplementedException();
            var result = new Dictionary<string, int>();
            var sv = 0;
            var taxi = 0;
            var angkot = 0;
            foreach (var item in list.OfType<Kendaraan>())
            {
                if (item.Type =="SUV")
                {
                    sv++;
                }else if (item.Type == "TAXI")
                {
                    taxi++;
                }else if(item.Type == "ANGKOT") {
                    angkot++;
                }
            }
            result.Add("SUV", sv);
            result.Add("TAXI", taxi);
            result.Add("ANGKOT", angkot);
            return result;
        }

        public Dictionary<string, decimal> GetSumTotal(List<Kendaraan> dict)
        {
            //throw new NotImplementedException();
            var result = new Dictionary<string, decimal>();
            var sv = 0M;
            var taxi = 0M;
            var angkot = 0M;
            foreach (var item in dict.OfType<Kendaraan>())
            {
                if (item.Type == "SUV")
                {
                    sv += item.TotalRevenue;
                }
                else if (item.Type == "TAXI")
                {
                    taxi += item.TotalRevenue;
                }
                else if (item.Type == "ANGKOT")
                {
                    angkot += item.TotalRevenue;
                }
            }
            result.Add("SUV", sv);
            result.Add("TAXI", taxi);
            result.Add("ANGKOT", angkot);
            return result;
        }

        public List<Kendaraan> InitDataKendaraan()
        {
            //throw new NotImplementedException();
            Suv kenSuv = new Suv("D 1001 UM", 2015, 500_000, 100_000);
            Suv kenSuv2 = new Suv("D 1002 UM", 2019, 500_000, 100_000);

            Taxi kenTax = new Taxi("D 88 Uk", 2018, 5, 4500, 40, 10_000);
            Taxi kenTax2 = new Taxi("D 87 Uk", 2018, 10, 4500, 100, 10_000);

            Angkot kenAng = new Angkot("D 55 UJ", 2016, 4500, 35);
            Angkot kenAng2 = new Angkot("D 55 Ui", 2015, 4500, 40);
            List<Kendaraan> kend =new List<Kendaraan> { kenSuv, kenSuv2, kenTax, kenTax2, kenAng, kenAng2 };
            return kend;
        }

        public void ShowDirectory(ref Dictionary<string, int> dict)
        {
            //throw new NotImplementedException();
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        public void Showlist<T>(List<T> list)
        {
            //throw new NotImplementedException();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void ShowSumTotal(ref Dictionary<string, decimal> dict)
        {
            //throw new NotImplementedException();
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
