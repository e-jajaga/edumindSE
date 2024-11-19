using eCommerce.Domain.Interfaces.IModels.IResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Models.ResponseModels
{
    public class ProduktetResponseModel : IResponseModels
    {
        public int Numri { get; set; }
        public String Emri { get; set; }
        public int? KategoriaNumri { get; set; }
        public string KategoriaEmri { get; set; }
        //public List<KomentetResponseModel> Komentet { get; set; }
    }
}
