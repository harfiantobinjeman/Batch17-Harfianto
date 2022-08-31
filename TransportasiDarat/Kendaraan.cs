using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganTransportasi.TransportasiDarat
{
    internal class Kendaraan
    {
        private string noPolisi;
        private int tahunKendaraan;
        private string type;
        private decimal totalRevenue;

        public Kendaraan(string noPolisi, int tahunKendaraan, string type, decimal totalRevenue) : this(noPolisi, tahunKendaraan)
        {
            this.type = type;
            this.totalRevenue = 0M;
        }

        public Kendaraan(string noPolisi, int tahunKendaraan)
        {
            this.noPolisi = noPolisi;
            this.tahunKendaraan = tahunKendaraan;
            this.totalRevenue = 0M;
        }

        public override string? ToString()
        {
            return $"No Polisi : {this.noPolisi} | Tahun Kendaraan : {this.tahunKendaraan} |";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int TahunKendaraan { get => tahunKendaraan; set => tahunKendaraan = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
    }
}
