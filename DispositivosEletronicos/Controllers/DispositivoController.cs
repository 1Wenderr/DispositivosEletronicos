using DispositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace DispositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador {Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11"},
                new Smartphone {Marca = "Samsung", Modelo = "Galaxy S24", AnoDeFabricacao = 2024, Tem5G = true}
            }; 

            return View(dispositivos);
        }
    }
}
