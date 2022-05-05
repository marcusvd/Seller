using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Repository.Contracts;

namespace Repository.Operations
{

    public class ProductRepository: Repository<Product>, IProductRepository
    {

        private readonly MwDbContext _CONTEXT;
        public ProductRepository(MwDbContext CONTEXT):base(CONTEXT)
        {
            _CONTEXT = CONTEXT;
        }


    }
}
