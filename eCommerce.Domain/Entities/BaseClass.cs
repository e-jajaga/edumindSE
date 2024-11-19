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
        public DateTime KrijuarMe { get; set; }
        public String KrijuarNga { get; set; }
        public DateTime PerditesuarMe { get; set; }
        public String PerditesuarNga { get; set; }
    }
}
