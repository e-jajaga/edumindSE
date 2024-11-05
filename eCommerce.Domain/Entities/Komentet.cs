using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Domain.Models
{
    public class Komentet
    {
        [Key]
        public int Numri { get; set; }
        public string Komenti { get; set; }
        public bool Eaprovuar { get; set; }
        public DateTime DataKrijimit { get; set; } = DateTime.Now;

        [ForeignKey("Produktet")]
        public int NumriProduktit { get; set; }
        public virtual Produktet Produktet { get; set; }
    }
}
    