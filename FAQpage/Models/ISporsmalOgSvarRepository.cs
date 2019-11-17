using System;
using System.Collections.Generic;
namespace FAQpage.Models
{
    public interface ISporsmalOgSvarRepository
    {
        SporsmalOgSvar GetSporsmalOgSvar(int id);
        IEnumerable<SporsmalOgSvar> GetAlleSporsmal();
        SporsmalOgSvar OpdaterPositiv(int id);
        SporsmalOgSvar OpdaterNegativ(int id);

        SendtInnSpm LeggTilSporsmal(SendtInnSpm sporsmal);
        SendtInnSpm SlettSporsmal(int id);
        IEnumerable<SendtInnSpm> GetAlleNySporsmal();
    }
}
