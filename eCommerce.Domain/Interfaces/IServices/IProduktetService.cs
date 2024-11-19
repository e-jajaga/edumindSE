﻿using eCommerce.Domain.Interfaces.IModels.IResponseModels;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.IServices
{
    public interface IProduktetService
    {
        public Task<IEnumerable<IResponseModels>> GetProduktet();
    }
}
