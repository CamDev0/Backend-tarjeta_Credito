using System.ComponentModel.DataAnnotations;

namespace FBCreditCard.Models
{
    public class CreditCard
    {
        public int id { get; set; }
        [Required]
        public string titular { get; set; }
        [Required]
        public string numberCard { get; set; }
        [Required]
        public string expiracion{ get; set; }
        [Required]
        public string cvv { get; set; }
    }

}

