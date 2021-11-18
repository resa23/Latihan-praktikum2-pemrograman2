using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204053
{
   public class Universitas
    {
        private string Nama;
        private string Umur;

        public Universitas()
        {

        }

        public Universitas (string nama, string umur)
        {
            this.Nama = nama;
            this.Umur = umur;   
        }

        public string name
        {
            get
            {
                return Nama;
            }

            set
            {
                Nama = value;
            }
        }

        public string age
        {
            get
            {
                return Umur;
            }

            set
            {
                Umur = value;
            }
        }
    }
}
