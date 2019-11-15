using System;
using System.Collections.Generic;
namespace FAQpage.Models
{
    public interface ISporsmalOgSvarRepository
    {
        SporsmalOgSvar GetSporsmalOgSvar(int id);
        IEnumerable<SporsmalOgSvar> GetAlleSporsmal();
    }
}
