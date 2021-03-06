﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kidzmile.Web.Repository.DTO;
namespace Kidzmile.Web.Repository
{
     public interface IProductRepository
    {
         Task<IList<ProductDTO>> GetAll();

        Task<ProductDTO> GetBySKUCode(string code);

        Task<int> Insert(ProductDTO product);

        Task<bool> Update(ProductDTO product);

        Task<bool> Delete(string code);
    }
}
