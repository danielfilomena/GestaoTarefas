
using GT.Application.Dtos;

namespace GT.Application.Interfaces
{
    public interface ITarefaService
    {

        Task<TarefaDto> BuscarTarefaPorId(int id);
        Task<IEnumerable<TarefaDto>> BuscarTodasTarefas();
        Task<bool> AdicionarTarefa(TarefaDto tarefa);
        Task<bool> AtualizarTarefa(TarefaDto tarefa);
        Task<bool> ExcluirTarefa(int id);

    }

}
