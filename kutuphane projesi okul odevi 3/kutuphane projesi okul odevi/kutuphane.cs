using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_projesi_okul_odevi
{ 
public class kitap
    {
        public string ISSN;
        public string Kitapadi;
        public string Yazar;
     
        public override string ToString()
        {
            return  "kitap adi = " + Kitapadi + "Yazar = " + Yazar;
        }
    }

}
