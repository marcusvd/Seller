using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Domain.Entities;
using Services.Dto;

namespace Services.Contracts
{
    public interface IProductServices
    {
        Task<ProductDto> InsertAsync(ProductDto record);
        Task<List<ProductDto>> LoadAllAsync();


    }
}
