using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Repository.Contracts
{

    public class Repository
    {

        private readonly MwDbContext _CONTEXT;
        public Repository(MwDbContext CONTEXT)
        {
            _CONTEXT = CONTEXT;
        }



    }
}
