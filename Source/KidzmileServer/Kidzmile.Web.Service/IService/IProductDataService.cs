﻿using Kidzmile.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidzmile.Web.Service
{
   public interface IProductDataService
    {
        Task<IList<Product>> GetAll();

        Task<Product> GetBySKUCode(string code);

        Task<int> Insert(Product product);

        Task<bool> Update(Product product);

        Task<bool> Delete(string code);
    }
}
