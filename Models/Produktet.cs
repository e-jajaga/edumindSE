using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdumindAkademia.Models
{
    public class Produktet
    {
        [Key]
        public int Numri { get; set; }
        
        public String Emri { get; set; }
        //public List<Kategorite> Kategorite { get; set; }
        
        [ForeignKey("Kategoria"), DisplayName("Kategoria")]
        public int? KategoriaNumri { get; set; }
        public virtual Kategorite Kategoria { get; set; }

    }
}
