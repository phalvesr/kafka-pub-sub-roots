using ConsumerCadastro.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerCadastro.Data.Repositories
{
    internal class ClientRepository : IClientRepository
    {
        private readonly IDbConnection dbConnection;

        public ClientRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task InsertAsync(ClientDto client)
        {
            /*
                create table cadastro_cliente (
                    id_global varchar(36) NOT NULL,
                    first_name varchar(100) NOT NULL,
                    last_name varchar(100) NOT NULL,
                    date_of_birth datetime NOT NULL
                );
             */
            var QUERY = "INSERT INTO cadastro_cliente " + 
                        "(id_global, first_name, last_name, date_of_birth)" + 
                        "VALUES (@IdGlobal, @FirstName, @LastName, @DateOfBirth)";
            await dbConnection.ExecuteAsync(QUERY, new 
            {
                IdGlobal = client.GlobalId,
                FirstName = client.FirstName,
                LastName = client.LastName,
                DateOfBirth = client.DateOfBirth
            });
        }
    }
}
