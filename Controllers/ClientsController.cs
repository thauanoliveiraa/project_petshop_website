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

public class ClientsController : Controller
{
    private readonly IClienteRepository  _petshopRepository;
    public ClientsController(IClienteRepository petshopRepository) // mudar de acordo com a interface do dado
    {
        _petshopRepository = petshopRepository;
    }


    public IActionResult IndexClientes() // clientes
    {
        List<ClienteModel> cliente = _petshopRepository.listarClientes();
        return View(cliente);
    }

     public IActionResult Criar()
    {
        return View();
    }

     public IActionResult Editar(int id)
    {
        var cliente = _petshopRepository.buscarId(id);
        return View(cliente);
    }

    public IActionResult Deletar(int id){
        _petshopRepository.deletar(id);
        return RedirectToAction("IndexClientes");
    }

    public IActionResult VerificarDeletar(int id)
    {
        var cliente = _petshopRepository.buscarId(id);
        return View(cliente);
    }
    
    [HttpPost] // annotation para realizar os posts
    public IActionResult Criar(ClienteModel cliente){
        _petshopRepository.adicionar(cliente);
        return RedirectToAction("IndexClientes");
    }

    [HttpPost] // annotation para realizar os posts
    public IActionResult Atualizar(ClienteModel cliente){
        _petshopRepository.atualizar(cliente);
        return RedirectToAction("IndexClientes");
    }
}