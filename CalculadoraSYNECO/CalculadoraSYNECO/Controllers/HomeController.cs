using CalculadoraSYNECO.Database;
using CalculadoraSYNECO.Models;
using CalculadoraSYNECO.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace CalculadoraSYNECO.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalculadoraSYNECOContext _context;

        public HomeController(CalculadoraSYNECOContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculo calculo)
        {
            if (calculo.Numero1 == 0)
            {
                return View();
            }
            switch (calculo.Operacao)
            {
                case TipoOperacao.Adicao:
                    calculo.Resultado = calculo.Numero1 + calculo.Numero2;
                    break;
                case TipoOperacao.Subtracao:
                    calculo.Resultado = calculo.Numero1 - calculo.Numero2;
                    break;
                case TipoOperacao.Multiplicacao:
                    calculo.Resultado = calculo.Numero1 * calculo.Numero2;
                    break;
                case TipoOperacao.Divisao:
                    calculo.Resultado = calculo.Numero1 / calculo.Numero2;
                    break;
            }
            _context.Calculo.Add(calculo);
            _context.SaveChanges();

            var viewModel = new CalculoViewModel { Calculo = calculo };

            return View(viewModel);
        }

        public IActionResult Limpar()
        {
            List<Calculo> calculos = _context.Calculo.ToList();
            _context.Calculo.RemoveRange(calculos);
            _context.SaveChanges();
            return View("Index");
        }
        [HttpGet]
        public IActionResult Historico()
        {
            var viewModel = new CalculoViewModel { Calculos = _context.Calculo.ToList() };
            return View(viewModel);
        }
    }
}
