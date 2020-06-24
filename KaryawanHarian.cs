using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas_Pertemuan8
{
    class KaryawanHarian : Karyawan
    {
        public int JumlahJamKerja { get; internal set; }
        public int UpahPerJam { get; internal set; }

        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}