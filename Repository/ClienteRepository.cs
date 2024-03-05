using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;
using PegasusPetshop.Database;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly PetshopContext petshop_Context;
        public ClienteRepository(PetshopContext petshopContext) // CONSTRUTOR GERADO
        {
            petshop_Context = petshopContext;
        }

        // CREATE
        public ClienteModel adicionar(ClienteModel cliente) // INTERFACE IMPLEMENTADA
        {
            petshop_Context.clientes.Add(cliente);
            petshop_Context.SaveChanges();
            return cliente;           
        }

        //UPDATE
        public ClienteModel atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = buscarId(cliente.id);

            if(clienteDB == null) throw new Exception("Cliente não encontrado");

            clienteDB.CPF = cliente.CPF;
            clienteDB.Nome = cliente.Nome;
            clienteDB.Genero = cliente.Genero;  
            clienteDB.QuantidadePets = cliente.QuantidadePets;
            clienteDB.Contato = cliente.Contato;
            clienteDB.Email = cliente.Email;
            clienteDB.Endereco = cliente.Endereco;     

            petshop_Context.clientes.Update(clienteDB);
            petshop_Context.SaveChanges();
            return clienteDB;
        }

        //READ
        public ClienteModel buscarId(int id)
        {
            return petshop_Context.clientes.FirstOrDefault(x => x.id == id);
        }

        // DELETE
        public bool deletar(int id)
        {
            ClienteModel clienteDB = buscarId(id);
            if(clienteDB == null) throw new Exception("Cliente não encontrado");

            petshop_Context.clientes.Remove(clienteDB);
            petshop_Context.SaveChanges();
            return true;
        }


        public List<ClienteModel> listarClientes()
        {
            return petshop_Context.clientes.ToList();
        }         
    }
}