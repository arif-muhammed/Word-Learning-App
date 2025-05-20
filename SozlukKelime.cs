using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class SozlukKelime    {
        public string Kelime { get; set; }
    public string Anlam { get; set; }

    public SozlukKelime(string kelime, string anlam)
    {
        Kelime = kelime;
        Anlam = anlam;
    }
}
}
