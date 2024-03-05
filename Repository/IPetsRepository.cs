using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;

namespace PegasusPetshop.Repository
{
    public interface IPetsRepository
    {

      // pets
      PetsModel adicionar(PetsModel pet);

      PetsModel atualizar(PetsModel pet);
     
      PetsModel buscarId(int id);      


      //Listas
      List<PetsModel> listarPets();

      // DELETAR
      bool deletar(int id);
    }
}