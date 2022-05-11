using ConsumerCadastro.Data;
using ConsumerCadastro.Models;
using ConsumerCadastro.Services.Interfaces;

namespace ConsumerCadastro.Services;
class SaveClient : ISaveClient
{
    private readonly IClientRepository clientRepository;

    public SaveClient(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public Task Save(CreateCadastroEvent createClientEvent)
    {
        throw new NotImplementedException();
    }
}

