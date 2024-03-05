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

public class PetsController : Controller
{
    private readonly IPetsRepository  _petshopRepository;
    public PetsController(IPetsRepository petshopRepository)
    {
        _petshopRepository = petshopRepository;
    }


    public IActionResult IndexPets() //pets
    {
        List<PetsModel> pet = _petshopRepository.listarPets();
        return View(pet);
    }

     public IActionResult Criar()
    {
        return View();
    }

     public IActionResult Editar(int id)
    {
        var pet = _petshopRepository.buscarId(id);
        return View(pet);
    }

    public IActionResult Deletar(int id){
        _petshopRepository.deletar(id);
        return RedirectToAction("IndexPets");
    }

    public IActionResult VerificarDeletar(int id)
    {
        var pet = _petshopRepository.buscarId(id);
        return View(pet);
    }
    
    [HttpPost] // annotation para realizar os posts
    public IActionResult Criar(PetsModel pet){
        _petshopRepository.adicionar(pet);
        return RedirectToAction("IndexPets");
    }

    [HttpPost] // annotation para realizar os posts
    public IActionResult Atualizar(PetsModel pet){
        _petshopRepository.atualizar(pet);
        return RedirectToAction("IndexPets");
    }
}