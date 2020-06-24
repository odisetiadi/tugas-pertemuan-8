using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas_Pertemuan8
{
    class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; internal set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}