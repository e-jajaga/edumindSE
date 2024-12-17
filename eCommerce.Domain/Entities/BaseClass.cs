using eCommerce.Domain.Interfaces.IModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class BaseClass : IBaseClass
    {
        [Key]
        public int Numri { get; set; }
        public DateTime KrijuarMe { get; set; } = DateTime.Now;
        public String KrijuarNga { get; set; } = String.Empty;
        public DateTime PerditesuarMe { get; set; } = DateTime.Now;
        public String PerditesuarNga { get; set; } = String.Empty;
    }
}
