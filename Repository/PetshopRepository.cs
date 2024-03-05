using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;
using PegasusPetshop.Database;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Repository
{
    public class PetshopRepository : IPetshopRepository
    {
        private readonly PetshopContext petshop_Context;
        
        public PetshopRepository(PetshopContext petshopContext) // CONSTRUTOR GERADO
        {
            petshop_Context = petshopContext;
        }

        // CREATE
        public PetshopModel adicionar(PetshopModel funcionario) // INTERFACE IMPLEMENTADA
        {
            petshop_Context.funcionarios.Add(funcionario);
            petshop_Context.SaveChanges();
            return funcionario;           
        }

        //UPDATE
        public PetshopModel atualizar(PetshopModel funcionario)
        {
            PetshopModel funcionarioDB = buscarId(funcionario.Id);

            if(funcionarioDB == null) throw new Exception("Funcionário não encontrado");

            funcionarioDB.Nome = funcionario.Nome;
            funcionarioDB.Genero = funcionario.Genero;
            funcionarioDB.Cargo = funcionario.Cargo;
            funcionarioDB.Salario = funcionario.Salario;  
            funcionarioDB.Contato = funcionario.Contato;
            funcionarioDB.Email = funcionario.Email;
            funcionarioDB.Endereco = funcionario.Endereco;     

            petshop_Context.funcionarios.Update(funcionarioDB);
            petshop_Context.SaveChanges();
            return funcionarioDB;
        }

        //READ
        public PetshopModel buscarId(int id)
        {
            return petshop_Context.funcionarios.FirstOrDefault(x => x.Id == id);
        }

        // DELETE
        public bool deletar(int id)
        {
            PetshopModel funcionarioDB = buscarId(id);
            if(funcionarioDB == null) throw new Exception("Funcionário não encontrado");

            petshop_Context.funcionarios.Remove(funcionarioDB);
            petshop_Context.SaveChanges();
            return true;
        }


        public List<PetshopModel> listarFuncionarios()
        {
            return petshop_Context.funcionarios.ToList();
        }    

/*
        public List<ClienteModel> listarClientes()
        {
            return petshop_Context.clientes.ToList();
        }      


        
        public List<PetsModel> listarPets()
        {
            return petshop_Context.pets.ToList();
        }      


        
        public List<ProdutoModel> listarProdutos()
        {
            return petshop_Context.produtos.ToList();
        }       */
    }
}