using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Domain.Entities;
using Services.Dto;

namespace Services.Contracts
{
    public interface IClientServices
    {
        Task<ClientDto> InsertAsync(ClientDto record);
        // Task<List<ClientDto>> LoadAllAsync();


    }
}
