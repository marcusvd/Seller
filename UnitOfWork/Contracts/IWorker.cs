using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Repository.Contracts;
using Domain.Entities;

namespace UnitOWork.Contracts
{
    public interface IWorker
    {
        IClientRepository _CLIENTS_REPO { get; }
        Task<bool> SaveAsync();



    }
}
