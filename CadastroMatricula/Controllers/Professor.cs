using CadastroMatricula.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroMatricula.Controllers
{
    public class ProfessorController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Professor professor)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Message = "Cadastro realizado com sucesso!";
                return View();
            }
            ViewBag.Message = "Erro ao cadastrar. Verifique os dados.";
            return View();
        }
    }
}