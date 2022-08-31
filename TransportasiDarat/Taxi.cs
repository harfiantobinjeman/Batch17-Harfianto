using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal class Taxi : Kendaraan
    {
        private int order;
        private decimal orderPerKm;
        private decimal totalKm;
        private decimal bonus;

        public override string? ToString()
        {
            return $"{base.ToString()} Type : {this.Type} | Order : {this.order} | OrderPerKm : {this.orderPerKm} | Bonus : {this.Bonus} | Total Revenue : {TotalRevenue}";
        }

        public int Order { get => order; set => order = value; }
        public decimal OrderPerKm { get => orderPerKm; set => orderPerKm = value; }
        public decimal TotalKm { get => totalKm; set => totalKm = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public Taxi(string noPolisi, int tahunKendaraan, int order, decimal orderPerKm, decimal totalKm, decimal bonus) : base(noPolisi, tahunKendaraan)
        {
            this.order = order;
            this.orderPerKm = orderPerKm;
            this.totalKm = totalKm;
            this.bonus = bonus;
            this.Type = "TAXI";
            TotalRevenue = (this.order *this.Bonus) + (this.orderPerKm * this.TotalKm);
        }
    }
}
