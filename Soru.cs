using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class Soru
    {
        public SozlukKelime Dogru { get; }
        public List<SozlukKelime> Secenekler { get; }

        public Soru(SozlukKelime dogru, List<SozlukKelime> tumSozluk)
        {
            Dogru = dogru;
            var yanlis = tumSozluk
                .Where(k => k.Kelime != dogru.Kelime)
                .OrderBy(_ => Guid.NewGuid())
                .Take(3)
                .ToList();

            Secenekler = yanlis.Append(dogru)
                                .OrderBy(_ => Guid.NewGuid())
                                .ToList();
        }
    }
}
