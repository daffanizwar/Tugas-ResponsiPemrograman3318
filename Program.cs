﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3318
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO" + " NIK/NAMA" + "         " + "Gaji Bulanan");
            Karyawan karyawan1 = new Karyawan(20113318, "Daffa", 3000000);
            Karyawan karyawan2 = new Karyawan(20113388, "Nizwar", 2000000);
            Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
            Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);
            if (karyawan1.gaji <= 0 || karyawan2.gaji <= 0)
            {
                Console.WriteLine("Anda memasukkan gaji minus");
                karyawan1.gaji = 0;
                karyawan2.gaji = 0;
                Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
                Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);
            }
            else
            {
                Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!!");
                int tambah = karyawan1.gaji * 10 / 100;
                karyawan1.gaji += tambah;
                int tambah1 = karyawan2.gaji * 10 / 100;
                karyawan2.gaji += tambah1;
                Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
                Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);

                Console.ReadKey();
            }
        }
    }
}