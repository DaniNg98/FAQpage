using System;
using System.Collections.Generic;
using System.Linq;
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

        public void EndreRating(int id, string rating)
        {
            var sporsmal = context.SporsmalerOgSvar.FirstOrDefault(s => s.Id == id);

            if (sporsmal != null)
            {
                if (rating == "true")
                {
                    sporsmal.PositivRating += 1;
                    context.SaveChanges();
                }
                else if (rating == "false")
                {
                    sporsmal.NegativRating -= 1;
                    context.SaveChanges();
                }
            }
        }

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
