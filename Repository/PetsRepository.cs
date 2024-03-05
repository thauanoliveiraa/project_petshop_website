using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;
using PegasusPetshop.Database;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Repository
{
    public class PetsRepository : IPetsRepository
    {
        private readonly PetshopContext petshop_Context;
        public PetsRepository(PetshopContext petshopContext) // CONSTRUTOR GERADO
        {
            petshop_Context = petshopContext;
        }

        // CREATE
        public PetsModel adicionar(PetsModel pet) // INTERFACE IMPLEMENTADA
        {
            petshop_Context.pets.Add(pet);
            petshop_Context.SaveChanges();
            return pet;           
        }

        //UPDATE
        public PetsModel atualizar(PetsModel pet)
        {
            PetsModel petDB = buscarId(pet.id);

            if(petDB == null) throw new Exception("Pet não encontrado");

            petDB.idDono = pet.idDono;
            petDB.Nome = pet.Nome;  
            petDB.TipoPet = pet.TipoPet;
            petDB.Plano = pet.Plano;


            petshop_Context.pets.Update(petDB);
            petshop_Context.SaveChanges();
            return petDB;
        }

        //READ
        public PetsModel buscarId(int id)
        {
            return petshop_Context.pets.FirstOrDefault(x => x.id == id);
        }

        // DELETE
        public bool deletar(int id)
        {
            PetsModel petDB = buscarId(id);
            if(petDB == null) throw new Exception("Pet não encontrado");

            petshop_Context.pets.Remove(petDB);
            petshop_Context.SaveChanges();
            return true;
        }


        public List<PetsModel> listarPets()
        {
            return petshop_Context.pets.ToList();
        }         
    }
}