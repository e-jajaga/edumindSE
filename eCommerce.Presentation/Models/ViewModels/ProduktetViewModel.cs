using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdumindAkademia.Models
{
    public class ProduktetViewModel
    {
        public int Numri { get; set; }
        
        public String Emri { get; set; }
        
        public int? KategoriaNumri { get; set; }
        public virtual Kategorite Kategoria { get; set; }
        public List<Komentet> Komentet { get; set; }

    }
}
