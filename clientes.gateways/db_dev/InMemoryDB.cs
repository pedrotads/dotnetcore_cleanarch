using NMemory;
using NMemory.Tables;
using clientes.gateways.model;
using NMemory.Indexes;
using System;
using System.Collections.Generic;

namespace clientes.gateways.db_dev
{
    public class InMemoryDb : Database
    { 
        public static InMemoryDb db;
        public ITable<ClienteModel> Clientes {get; private set;}
        public ITable<EnderecoModel> Enderecos {get; private set;}

        public InMemoryDb()
        {  
            var clientes = this.Tables.Create<ClienteModel, int>(x => x.Id);
            var enderecos = this.Tables.Create<EnderecoModel, int>(k => k.Id);

            this.Clientes = clientes;
            this.Enderecos = enderecos;
            db = this;

            RelationOptions relationOptions = new RelationOptions(cascadedDeletion: true);

            var enderecoIndex = enderecos.CreateIndex(
                new RedBlackTreeIndexFactory(),
                e => e.Id
            );

            this.Tables.CreateRelation(
                clientes.PrimaryKeyIndex,
                enderecoIndex,
                x => x,
                x => x
            );

            Populate();
        }

        private void Populate()
        {
            var endereco = new EnderecoModel()
                {
                  Logradouro = "Rua Queiroz",
                  Cidade = "Jaguariuna",
                  CEP = "13910-474",
                  Tipo = TipoEnderecoModel.Residencial  
                };
            
            var cliente = new ClienteModel() { 
                Id = 1,
                Nome = "Pedro Rodrigo",
                Nascimento = new DateTime(1980, 07, 12),
                Telefone = "19.99215.9276",
                Enderecos = new List<EnderecoModel>()
            };
            cliente.Enderecos.Add(endereco);
            this.Clientes.Insert(
                cliente            
            );
            
        }
    }

    
}