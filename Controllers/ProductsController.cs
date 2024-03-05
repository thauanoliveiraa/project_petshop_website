using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PegasusPetshop.Models;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Controllers; // CASO DE ALGUM ERRO DEPOIS, COLOQUE DE VOLTA NO LUGAR DE _produtoRepository

public class ProductsController : Controller
{
    private readonly IProdutosRepository  _produtoRepository;
    public ProductsController(IProdutosRepository produtosRepository)
    {
        _produtoRepository = produtosRepository;
    }


    public IActionResult IndexProdutos() // produtos
    {
        List<ProdutoModel> produto = _produtoRepository.listarProdutos();
        return View(produto);
    }

     public IActionResult Criar()
    {
        return View();
    }

     public IActionResult Editar(int id)
    {
        var produto = _produtoRepository.buscarId(id);
        return View(produto);
    }

    public IActionResult Deletar(int id){
        _produtoRepository.deletar(id);
        return RedirectToAction("IndexProdutos");
    }

    public IActionResult VerificarDeletar(int id)
    {
        var produto = _produtoRepository.buscarId(id);
        return View(produto);
    }
    
    [HttpPost] // annotation para realizar os posts
    public IActionResult Criar(ProdutoModel produto){
        _produtoRepository.adicionar(produto);
        return RedirectToAction("IndexProdutos");
    }

    [HttpPost] // annotation para realizar os posts
    public IActionResult Atualizar(ProdutoModel produto){
        _produtoRepository.atualizar(produto);
        return RedirectToAction("IndexProdutos");
    }
}