using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal interface IKendaraan

    {
        public List<Kendaraan> InitDataKendaraan();
        public void Showlist<T>(List<T> list);
        public Dictionary<string, int> GetSum(List<Kendaraan> list);
        public void ShowDirectory(ref Dictionary<string, int> dict);
        public Dictionary<string , decimal> GetSumTotal(List<Kendaraan> dict);
        public void ShowSumTotal(ref Dictionary<string , decimal> dict);
        public List<Kendaraan> FindRevenueRange (List<Kendaraan> list, decimal starFrom, decimal endTo);

    }
}
