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

    public class ClientServices : IClientServices
    {

        private readonly IWorker _CONTEXT;
        private readonly IMapper _MAP;
        public ClientServices(
            IWorker CONTEXT,
            IMapper MAP
            )
        {
            _CONTEXT = CONTEXT;
            _MAP = MAP;
        }

        public async Task<ClientDto> InsertAsync(ClientDto record)
        {
            try
            {
                if (record == null) return null;

                //var fromView = record;

                Client toDb = _MAP.Map<Client>(record);

                _CONTEXT._CLIENTS_REPO.AddRepAsync(toDb);

                // var ReturnToView = _MAP.Map<ClientDto>(toDb);
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

       public async Task<List<ClientDto>> LoadAllAsync()
        {
            try
            {
                List<Client> FromDb = await _CONTEXT._CLIENTS_REPO.GetAllRepAsync();

                if (FromDb == null) return null;

                List<ClientDto> ToView = _MAP.Map<List<ClientDto>>(FromDb);

                return ToView;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
