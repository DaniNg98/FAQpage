using System;
using System.Collections.Generic;
namespace FAQpage.Models
{
    public interface ISporsmalOgSvarRepository
    {
        SporsmalOgSvar GetSporsmalOgSvar(int id);
        IEnumerable<SporsmalOgSvar> GetAlleSporsmal();
        SporsmalOgSvar OpdaterPositiv(SporsmalOgSvar sporsmalOgSvar);
        SporsmalOgSvar OpdaterNegativ(SporsmalOgSvar sporsmalOgSvar);

        SendtInnSpm LeggTilSporsmal(SendtInnSpm sporsmal);
        SendtInnSpm SlettSporsmal(int id);
        IEnumerable<SendtInnSpm> GetAlleNySporsmal();
    }
}
