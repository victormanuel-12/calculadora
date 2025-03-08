using Microsoft.AspNetCore.Mvc;

namespace Miproyecto.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double operador1, double operador2, string operando)
        {
            double resultado = 0;

            switch (operando)
            {
                case "Suma":
                    resultado = operador1 + operador2;
                    break;
                case "Resta":
                    resultado = operador1 - operador2;
                    break;
                case "Multiplicación":
                    resultado = operador1 * operador2;
                    break;
                case "División":
                    resultado = operador2 != 0 ? operador1 / operador2 : double.NaN;
                    break;
            }

            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
