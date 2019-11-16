using System;
using System.ComponentModel.DataAnnotations;

namespace FAQpage.Models
{
    public class SporsmalOgSvar
    {
        [Key]
        public int Id { get; set; }

        public string Tema { get; set; }
        public string Sporsmal { get; set; }
        public string Svar { get; set; }

    }
}
