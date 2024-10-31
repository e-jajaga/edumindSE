using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EdumindAkademia.Models
{
    public class Kategorite
    {
        [Key]
        public int Numri { get; set; }

        [DisplayName("Titulli i Kategorise"), Required]
        public String Titulli { get; set; }

        public virtual List<Produktet> Produktet { get; set; }
    }
}
