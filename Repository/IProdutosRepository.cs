using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;

namespace PegasusPetshop.Repository
{
    public interface IProdutosRepository
    {
      // produtos
      ProdutoModel adicionar(ProdutoModel produto);

      ProdutoModel atualizar(ProdutoModel produto);
     
      ProdutoModel buscarId(int CodigoDeBarra);    

      //Listas
      List<ProdutoModel> listarProdutos();

      // DELETAR
      bool deletar(int id);
    }
}