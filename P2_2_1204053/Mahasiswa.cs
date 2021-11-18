using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204053
{
    public class Mahasiswa: Universitas
    {
     
        protected string myProdi;
        
       public Mahasiswa(string nama, string umur, string prodi)
            : base(nama,umur)
        {
            this.name = nama;
            this.age  = umur;
            this.myProdi = prodi;
                     
        }


        public string  Prodi
        {
            get
            {
                return myProdi;
            }

            set
            {
                myProdi = value;
            }
        }     
    }
}
