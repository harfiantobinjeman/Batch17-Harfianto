using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal class Angkot : Kendaraan
    {
        private decimal hargaTiket;
        private int totalPenumpang;
        

        public override string? ToString()
        {
            return $"{base.ToString()} Type : {this.Type} | Harga Tiket : {this.HargaTiket} | Total Penumpang : {this.totalPenumpang} Total Revenur : {this.TotalRevenue}";
        }

        public Angkot(string noPolisi, int tahunKendaraan, decimal hargaTiket, int totalPenumpang) : base(noPolisi, tahunKendaraan)
        {
            this.hargaTiket = hargaTiket;
            this.totalPenumpang = totalPenumpang;
            this.Type = "ANGKOT";
            TotalRevenue =  this.totalPenumpang * this.hargaTiket ;
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public int TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }
    }
}
