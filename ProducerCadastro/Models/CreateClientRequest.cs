using System;

namespace ProducerCadastro.Models;

public sealed class CreateClientRequest
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; set; }
}

