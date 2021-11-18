using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204053
{
     class Universitastest
    {
       
        static void Main(String[] args)
        {
            Mahasiswa object1 = new Mahasiswa("Resa Rianti", "20tahun","D4 Teknik Informatika 2B");
            Dosen object2 = new Dosen("Pak Bayu", "25tahun", "Pemrograman II");

            Console.WriteLine(" Mahasiswi dari bandung bernama {0} berusia \"{1}\" dan Prodi {2} ", object1.name, object1.age, object1.Prodi);
            Console.WriteLine(" Dosen Informatika di Poltekpos bernama  {0} berusia \"{1}\" dan mengajar {2} ", object2.name, object2.age, object2.lesson);

        }
    }
}
