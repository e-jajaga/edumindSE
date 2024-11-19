using eCommerce.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Domain.Models
{
    public class Kategorite : BaseClass
    {
        [DisplayName("Titulli i Kategorise"), Required]
        public String Titulli { get; set; }

        public virtual List<Produktet> Produktet { get; set; }
    }
}
