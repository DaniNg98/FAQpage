using System;
using System.Collections.Generic;
using FAQpage.Data;

namespace FAQpage.Models
{
    public class SQLSporsmalOgSvarRepository : ISporsmalOgSvarRepository
    {
        private readonly ApplicationDbContext context;

        public SQLSporsmalOgSvarRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SporsmalOgSvar> GetAlleSporsmal()
        {
            return context.SporsmalerOgSvar;
        }

        public SporsmalOgSvar GetSporsmalOgSvar(int id)
        {
            return context.SporsmalerOgSvar.Find(id);
        }
    }
}
