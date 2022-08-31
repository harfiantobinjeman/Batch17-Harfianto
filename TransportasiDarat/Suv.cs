using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal class Suv : Kendaraan
    {
        private decimal sewa;
        private decimal supir;

        public override string? ToString()
        {
            return $"{base.ToString()} Type : {this.Type} | Sewa : {this.sewa} Supir : {this.supir} | Total Revenue : {TotalRevenue}";
        }

        public Suv(string noPolisi, int tahunKendaraan,  decimal sewa, decimal supir) : base(noPolisi, tahunKendaraan)
        {
            this.sewa = sewa;
            this.supir = supir;
            this.Type = "SUV";
            this.TotalRevenue = this.sewa + this.supir;
        }
        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }
    }
}
