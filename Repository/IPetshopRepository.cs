using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;

namespace PegasusPetshop.Repository
{
    public interface IPetshopRepository
    {
      // funcionario
      PetshopModel adicionar(PetshopModel funcionario);

      PetshopModel atualizar(PetshopModel funcionario);
     
      PetshopModel buscarId(int id);

      //Listas
      List<PetshopModel> listarFuncionarios();      // colocar cada um em sua interface  
    

      // DELETAR
      bool deletar(int id);
    }
}