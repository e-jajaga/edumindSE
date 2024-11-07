using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EdumindAkademia.Models
{
    public class KategoriteViewModel
    {
        public int Numri { get; set; }

        public String Titulli { get; set; }

        public virtual List<ProduktetViewModel> Produktet { get; set; }
    }
}
