
using GT.Domain.Entities;

namespace GT.Domain.Interfaces
{
    public interface ITarefa
    {

        Task<Tarefa?> BuscarTarefaPorId(int id);
        Task<IEnumerable<Tarefa>?> BuscarTodasTarefas();
        Task<bool> IncluirTarefa(Tarefa tarefa);
        Task<bool> AlterarTarefa(Tarefa tarefa);
        Task<bool> ExcluirTarefa(int id);
        
    }


}
