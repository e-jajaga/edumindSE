using AutoMapper;
using eCommerce.BLL.Models.RequestModels;
using eCommerce.BLL.Models.ResponseModels;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Models
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Produktet, ProduktetResponseModel>();
            CreateMap<ProduktetRequestModel, Produktet>();
        }
    }
}
