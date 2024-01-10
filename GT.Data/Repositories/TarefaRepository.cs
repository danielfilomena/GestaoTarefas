
using GT.Data.Context;
using GT.Domain.Entities;
using GT.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GT.Data.Repositories
{
    public class TarefaRepository : ITarefa
    {

        public readonly TarefaContext _context;

        public TarefaRepository(TarefaContext context)
        {
            
            _context = context;

        }

        public async Task<Tarefa?> BuscarTarefaPorId(int id)
        {

            try
            {

                var tarefa = await _context.Tarefa.Where(p => p.Id == id)
                    .Include(u => u.Usuario)
                    .FirstOrDefaultAsync();

                return tarefa;

            }
            catch (Exception ex)
            {

                throw new Exception($@"Ocorreu o erro: { ex.Message }, ao tentar consultar a tarefa.");

            }

        }

        public async Task<IEnumerable<Tarefa>?> BuscarTodasTarefas()
        {

            try
            {

                var tarefas = await _context.Tarefa
                    .Include(u => u.Usuario)
                    .ToListAsync();

                return tarefas;

            }
            catch (Exception ex)
            {

                throw new Exception($@"Ocorreu o erro: { ex.Message }, ao tentar consultar a lista de tarefas.");
            }

        }

        public async Task<bool> IncluirTarefa(Tarefa tarefa)
        {

            var sucesso = false;

            try
            {


                _context.Tarefa.Add(tarefa);
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    sucesso = true;
                }


            }
            catch (Exception ex)
            {

                throw new Exception($@"Ocorreu o erro: { ex.Message }, ao tentar incluir uma nova tarefa.");

            }

            return sucesso;

        }

        public async Task<bool> AlterarTarefa(Tarefa tarefa)
        {
            var sucesso = false;

            try
            {

                _context.Tarefa.Update(tarefa);
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    sucesso = true;
                }


            }
            catch (Exception ex)
            {

                throw new Exception($@"Ocorreu o erro: { ex.Message }, ao tentar alterar a tarefa.");
            }

            return sucesso;

        }
        
        public async Task<bool> ExcluirTarefa(int id)
        {
            var sucesso = false;

            try
            {

                //Verifico se o registro existe antes da exclusão.
                var tarefa = BuscarTarefaPorId(id);

                if (tarefa != null)
                {

                    var result = await _context.Tarefa.Where(x => x.Id == id).ExecuteDeleteAsync();

                    if (result > 0)
                    {
                        sucesso = true;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception($@"Ocorreu o erro: { ex.Message }, ao tentar excluir uma tarfa.");
            }

            return sucesso;
        }

        
    }
}
