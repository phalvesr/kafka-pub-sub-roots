using AutoMapper;
using ProducerCadastro.Models;
using ProducerCadastro.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProducerCadastro.Services;

public class ClientService : IClientService
{
    private readonly IMapper mapper;

    public ClientService(IMapper mapper)
    {
        this.mapper = mapper;
    }

    public Task<bool> ExecuteAsync(CreateClientRequest createClientRequest)
    {
        throw new NotImplementedException();
    }
}

