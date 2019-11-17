using System;
using System.Collections.Generic;
namespace FAQpage.Models
{
    public interface ISporsmalOgSvarRepository
    {
        SporsmalOgSvar GetSporsmalOgSvar(int id);
        IEnumerable<SporsmalOgSvar> GetAlleSporsmal();
        void EndreRating(int id, string rating);

        SendtInnSpm LeggTilSporsmal(SendtInnSpm sporsmal);
        SendtInnSpm SlettSporsmal(int id);
        IEnumerable<SendtInnSpm> GetAlleNySporsmal();
    }
}
