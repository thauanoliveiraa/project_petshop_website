using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;

namespace PegasusPetshop.Repository
{
    public interface IClienteRepository
    {
      // clientes
      ClienteModel adicionar(ClienteModel cliente);

      ClienteModel atualizar(ClienteModel cliente);
     
      ClienteModel buscarId(int id);
        

      //Listas

      List<ClienteModel> listarClientes();

      // DELETAR
      bool deletar(int id);
    }
}