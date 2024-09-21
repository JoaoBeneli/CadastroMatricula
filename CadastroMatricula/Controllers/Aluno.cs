using CadastroMatricula.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroMatricula.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar o aluno (ex: banco de dados)
                ViewBag.Message = "Cadastro realizado com sucesso!";
                return View();
            }
            ViewBag.Message = "Erro ao cadastrar. Verifique os dados.";
            return View();
        }
    }
}
