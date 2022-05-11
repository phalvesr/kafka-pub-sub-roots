using System;

namespace ProducerCadastro.Models;

public sealed class ClienteCadastroEvent
{
    public Guid GlobalId { get; init; } = Guid.NewGuid();
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }
}
