using eCommerce.Domain.Interfaces.IModels.IRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Models.RequestModels
{
    public class ProduktetRequestModel : IRequestModels
    {
        public int Numri { get; set; }

        public String Emri { get; set; }

        public int? KategoriaNumri { get; set; }
    }
}
