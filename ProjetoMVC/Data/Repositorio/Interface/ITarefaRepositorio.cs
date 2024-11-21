using ProjetoMVC.Controllers;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data.Repositorio.Interface
{
    public interface ITarefaRepositorio
    {
        List<Tarefa> ListarTarefas();
        void InserirTarefa(Tarefa tarefa);
        Tarefa BuscarId(int id);
        void EditarTarefa(Tarefa tarefa);
        void Excluir(Tarefa tarefa);    }
}
