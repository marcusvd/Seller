using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnitOWork.Contracts;
using Services.Contracts;
using Services.Dto;
using AutoMapper;
using UnitOWork.Operations;

namespace Services.Operations
{

    public class ProductServices : IProductServices
    {

        private readonly IWorker _CONTEXT;
        private readonly IMapper _MAP;
        public ProductServices(
            IWorker CONTEXT,
            IMapper MAP
            )
        {
            _CONTEXT = CONTEXT;
            _MAP = MAP;
        }

        public async Task<ProductDto> InsertAsync(ProductDto record)
        {
            try
            {
                if (record == null) return null;

                //var fromView = record;

                Product toDb = _MAP.Map<Product>(record);

                _CONTEXT._PRODUCTS_REPO.AddRepAsync(toDb);

                // var ReturnToView = _MAP.Map<ProductDto>(toDb);
                if (await _CONTEXT.SaveAsync())
                {
                    return null;
                }


                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProductDto>> LoadAllAsync()
        {
            try
            {
                List<Product> FromDb = await _CONTEXT._PRODUCTS_REPO.GetAllRepAsync();

                if (FromDb == null) return null;

                List<ProductDto> ToView = _MAP.Map<List<ProductDto>>(FromDb);

                return ToView;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // public async Task<List<ProductDto>> LoadAllAsync()
        // {
        //     throw new await NotImplementedException();
        // }
    }
}
