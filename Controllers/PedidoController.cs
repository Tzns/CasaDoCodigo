using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Carrossel()
        {
            return View();
        }

         public IActionResult Resumo()
        {
            return View();
        }


       
    }
}
