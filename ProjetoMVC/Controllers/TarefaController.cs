using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Data.Repositorio.Interface;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        public IActionResult Index()

        {

            var tarefa = _tarefaRepositorio.ListarTarefas();

            return View(tarefa);

        }

        public IActionResult AdicionarTarefa()
        {
            return View();
        }

        public IActionResult InserirTarefa(Tarefa tarefa)
        {
            try
            {

                _tarefaRepositorio.InserirTarefa(tarefa);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("Index");

        }

        public IActionResult Editar(int id)

        {

            var tarefa= _tarefaRepositorio.BuscarId(id);

            return View(tarefa);

        }

        public IActionResult EditarTarefa(Tarefa tarefa)
        {
            _tarefaRepositorio.EditarTarefa(tarefa);

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Tarefa tarefa)

        {

            _tarefaRepositorio.Excluir(tarefa);

            return RedirectToAction("Index");

        }

    }

}
