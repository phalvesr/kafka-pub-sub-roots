using Microsoft.AspNetCore.Mvc;
using ProducerCadastro.Models;
using ProducerCadastro.Services.Interfaces;
using Serilog;
using System.Threading.Tasks;

namespace ProducerCadastro.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ILogger logger;
    private readonly IClientService clientService;

    public ClienteController(
        ILogger logger, 
        IClientService clientService)
    {
        this.logger = logger;
        this.clientService = clientService;
    }

    [HttpPost("cadastro", Name = "CreatCliente")]
    public async Task<IActionResult> Post(
        [FromBody] CreateClientRequest createClientRequest)
    {
        logger.Information("Processando cadastro de cliente...");

        if (await clientService.ExecuteAsync(createClientRequest))
        {
            return Accepted();
        }

        return BadRequest();
    }
}
