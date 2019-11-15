using System;
using System.Collections.Generic;
using System.Linq;

namespace FAQpage.Models
{
    public class SporsmalOgSvarRepository : ISporsmalOgSvarRepository
    {
        private List<SporsmalOgSvar> _SporsmalListe;

        public SporsmalOgSvarRepository()
        {
            _SporsmalListe = new List<SporsmalOgSvar>()
            {
                new SporsmalOgSvar {Id = 1, Sporsmal = "Her er spørsmål 1", Svar = "Her er svar 1"},
                new SporsmalOgSvar {Id = 2, Sporsmal = "Her er spørsmål 2", Svar = "Her er svar 2"},
                new SporsmalOgSvar {Id = 3, Sporsmal = "Her er spørsmål 3", Svar = "Her er svar 3"}
            };
        }

        public IEnumerable<SporsmalOgSvar> GetAlleSporsmal()
        {
            return _SporsmalListe;
        }

        public SporsmalOgSvar GetSporsmalOgSvar(int Id)
        {
            return _SporsmalListe.FirstOrDefault(s => s.Id == Id);
        }

        
    }
}
