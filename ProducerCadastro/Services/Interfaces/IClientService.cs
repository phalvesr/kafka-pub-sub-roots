using ProducerCadastro.Models;
using System.Threading.Tasks;

namespace ProducerCadastro.Services.Interfaces;

public interface IClientService
{
    Task<bool> ExecuteAsync(CreateClientRequest createClientRequest);
}

