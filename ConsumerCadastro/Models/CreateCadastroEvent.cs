namespace ConsumerCadastro.Models;
record CreateCadastroEvent
(
    Guid GlobalId,
    string FirstName,
    string LastName,
    DateTime DateOfBirth
);

