using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PegasusPetshop.Models;
using PegasusPetshop.Repository;

namespace PegasusPetshop.Controllers;

public class PetshopController : Controller
{
    private readonly IPetshopRepository  _petshopRepository;
    public PetshopController(IPetshopRepository petshopRepository)
    {
        _petshopRepository = petshopRepository;
    }

    public IActionResult Index() // funcionarios
    {
        List<PetshopModel> funcionario = _petshopRepository.listarFuncionarios();
        return View(funcionario);
    }


     public IActionResult Criar()
    {
        return View();
    }

    public IActionResult Escolha()
    {
        return View();
    }

    public IActionResult EscolhaExibir()
    {
        return View();
    }

     public IActionResult Editar(int id)
    {
        var funcionario = _petshopRepository.buscarId(id);
        return View(funcionario);
    }

    public IActionResult Deletar(int id){
        _petshopRepository.deletar(id);
        return RedirectToAction("Index");
    }

    public IActionResult VerificarDeletar(int id)
    {
        var funcionario = _petshopRepository.buscarId(id);
        return View(funcionario); // COLOQUEI DE VOLTA O FUNCIONARIO E COMEÇOU A DELETAR
    }
    
    [HttpPost] // annotation para realizar os posts
    public IActionResult Criar(PetshopModel funcionario){
        if (ModelState.IsValid)
        {

            _petshopRepository.adicionar(funcionario);
            return RedirectToAction("Index");   
        }
        return View("Criar");
    }

    [HttpPost] // annotation para realizar os posts
    public IActionResult Atualizar(PetshopModel funcionario){
        if (ModelState.IsValid)
        {
            _petshopRepository.atualizar(funcionario);
            return RedirectToAction("Index");
        }
        return View("Editar");
    }
}
