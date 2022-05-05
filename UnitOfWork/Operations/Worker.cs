using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Repository.Contracts;
using Domain.Entities;
using Repository;
using Repository.Operations;
using UnitOWork.Contracts;

namespace UnitOWork.Operations
{
    public class Worker : IWorker
    {
        private ClientRepository _CLIENT_REPO;
        private readonly MwDbContext _CONTEXT;
        public Worker(MwDbContext CONTEXT)
        {
            _CONTEXT = CONTEXT;
        }

        public IClientRepository _CLIENTS_REPO
        {
            get
            {
                return _CLIENT_REPO = _CLIENT_REPO ?? new ClientRepository(_CONTEXT);
            }
        }

        public async Task<bool> SaveAsync()
        {
            if (await _CONTEXT.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
