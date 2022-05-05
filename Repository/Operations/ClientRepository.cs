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

    public class ClientRepository: Repository<Client>, IClientRepository
    {

        private readonly MwDbContext _CONTEXT;
        public ClientRepository(MwDbContext CONTEXT):base(CONTEXT)
        {
            _CONTEXT = CONTEXT;
        }


    }
}
