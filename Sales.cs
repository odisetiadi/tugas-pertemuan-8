using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas_Pertemuan8
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; internal set; }
        public double Komisi { get; internal set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}