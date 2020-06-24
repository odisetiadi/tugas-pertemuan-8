using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan8
{
    public abstract class Karyawan
    {
        public string Nik { get; internal set; }
        public string Nama { get; internal set; }
        public abstract double Gaji();
    }
}