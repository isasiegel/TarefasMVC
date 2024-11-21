using ProjetoMVC.Data.Repositorio.Interface;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public TarefaRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Tarefa> ListarTarefas()
        {
            return _bancoContexto.Tarefa.ToList();
        }

        public void InserirTarefa(Tarefa tarefa)
        {
            _bancoContexto.Tarefa.Add(tarefa);
            _bancoContexto.SaveChanges();
        }
        public Tarefa BuscarId(int Id)
        {
            return _bancoContexto.Tarefa.FirstOrDefault(x => x.Id == Id);
        }
        public void EditarTarefa(Tarefa tarefa)
        {
            _bancoContexto.Tarefa.Update(tarefa);
            _bancoContexto.SaveChanges();
        }

        public void Excluir(Tarefa tarefa)
        {
            _bancoContexto.Remove(tarefa);
            _bancoContexto.SaveChanges();
        }
    }

}
