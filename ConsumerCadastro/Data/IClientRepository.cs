using ConsumerCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerCadastro.Data
{
    internal interface IClientRepository
    {
        Task InsertAsync(ClientDto client);
    }
}
