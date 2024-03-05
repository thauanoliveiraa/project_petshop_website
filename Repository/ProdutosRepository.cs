using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;
using PegasusPetshop.Database;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Repository
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly PetshopContext petshop_Context;
        public ProdutosRepository(PetshopContext petshopContext) // CONSTRUTOR GERADO
        {
            petshop_Context = petshopContext;
        }

        // CREATE
        public ProdutoModel adicionar(ProdutoModel produto) // INTERFACE IMPLEMENTADA
        {
            petshop_Context.produtos.Add(produto);
            petshop_Context.SaveChanges();
            return produto;           
        }

        //UPDATE
        public ProdutoModel atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDB = buscarId(produto.CodigoDeBarra);

            if(produto == null) throw new Exception("Produto não encontrado");

            produtoDB.CNPJ = produto.CNPJ;
            produtoDB.Nome = produto.Nome;  
            produtoDB.ClasseDoProduto = produto.ClasseDoProduto;
            produtoDB.Valor = produto.Valor;
            produtoDB.DataDeValidade = produto.DataDeValidade;
            produtoDB.QuantidadeEmEstoque = produto.QuantidadeEmEstoque;


            petshop_Context.produtos.Update(produtoDB);
            petshop_Context.SaveChanges();
            return produtoDB;
        }

        //READ
        public ProdutoModel buscarId(int CodigoDeBarra)
        {
            return petshop_Context.produtos.FirstOrDefault(x => x.CodigoDeBarra == CodigoDeBarra);
        }

        // DELETE
        public bool deletar(int CodigoDeBarra)
        {
            ProdutoModel produtoDB = buscarId(CodigoDeBarra);
            if(produtoDB == null) throw new Exception("Produto não encontrado");

            petshop_Context.produtos.Remove(produtoDB);
            petshop_Context.SaveChanges();
            return true;
        }


        public List<ProdutoModel> listarProdutos()
        {
            return petshop_Context.produtos.ToList();
        }         
    }
}