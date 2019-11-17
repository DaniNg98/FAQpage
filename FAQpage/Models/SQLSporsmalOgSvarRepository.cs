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

        public SporsmalOgSvar OpdaterPositiv(SporsmalOgSvar sporsmalOgSvar)
        {
            throw new NotImplementedException();
        }

        public SporsmalOgSvar OpdaterNegativ(SporsmalOgSvar sporsmalOgSvar)
        {
            throw new NotImplementedException();
        }

        /*--------------------------*/

        public IEnumerable<SendtInnSpm> GetAlleNySporsmal()
        {
            return context.SendtInnSpms;
        }

        public SendtInnSpm LeggTilSporsmal(SendtInnSpm sporsmal)
        {
            context.SendtInnSpms.Add(sporsmal);
            context.SaveChanges();
            return sporsmal;
        }

        public SendtInnSpm SlettSporsmal(int id)
        {
            SendtInnSpm sporsmal = context.SendtInnSpms.Find(id);
            if (sporsmal != null)
            {
                context.SendtInnSpms.Remove(sporsmal);
                context.SaveChanges();
            }
            return sporsmal;
        }
    }
}
