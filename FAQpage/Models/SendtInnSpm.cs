using System;
using System.ComponentModel.DataAnnotations;

namespace FAQpage.Models
{
    public class SendtInnSpm
    {
        [Key]
        public int SId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Navnet må ha minst 2 bokstaver")]
        public string Navn { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Ugyldig email")]
        public string Email { get; set; }
        public string Tema { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Spørsmålet må ha minst 10 bokstaver")]
        public string Sporsmal { get; set; }
    }
}
