using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204053
{
    public class Dosen: Universitas
    {

        protected string Mengajar;

        public Dosen(string nama, string umur, string mengajar)
        {
            this.Mengajar = mengajar;
            this.name = nama;
            this.age = umur;

            Console.WriteLine("Selamat datang di politeknik Pos Indonesia");
        }

        public string lesson
        {
            get
            {
                return Mengajar;
            }
            set
            {
                Mengajar = value;
            }
        }
      }
   }
    


