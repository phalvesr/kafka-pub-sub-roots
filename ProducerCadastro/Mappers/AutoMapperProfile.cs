using AutoMapper;
using ProducerCadastro.Models;
using System;

namespace ProducerCadastro.Mappers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateClientRequest, ClienteCadastroEvent>();
    }
}

