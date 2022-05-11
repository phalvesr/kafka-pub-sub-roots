using ConsumerCadastro.Models;

namespace ConsumerCadastro.Services.Interfaces;
interface ISaveClient
{
    Task Save(CreateCadastroEvent createClientEvent);
}

