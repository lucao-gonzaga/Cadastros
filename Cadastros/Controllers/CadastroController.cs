using Cadastros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastros.Controllers
{
    public class CadastroController : Controller
    {
        public static IList<Cadastro> cadastros = new List<Cadastro>()
        {
            new Cadastro()
            {
                CadastroID = 1,
                Nome = "Lucas",
                Livro = "nao sei qual nome",
                Endereco = "Rua P, 225 - Campinas",
                Email = "lucasbenda@outlook.com",
                Telefone = "1231-4124",
                Validade = "21/05/2021"
            }
        };

        public IActionResult Index()
        {
            return View(cadastros);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        #region POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cadastro cad)
        {
            cadastros.Add(cad);
            cad.CadastroID = cadastros.Select(c => c.CadastroID).Max() + 1;
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
