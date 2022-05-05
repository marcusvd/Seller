using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.Dto;
using Services.Operations;

namespace Api.Controllers
{
    [ApiController]
    [Route("cli/{controller}")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices _Client;
        public ClientsController(IClientServices ClientCli)
        {
            _Client = ClientCli;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ClientDto ClientView)
        {
            try
            {
                if (ClientView == null) return NoContent();

                var cli = await _Client.InsertAsync(ClientView);

                return Ok(cli);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            try
            {
                var cli = await _Client.LoadAllAsync();

                if (cli == null) return NoContent();

                return Ok(cli);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
            }

        }

    }
}