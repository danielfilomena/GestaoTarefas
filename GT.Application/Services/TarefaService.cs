using AutoMapper;
using GT.Application.Dtos;
using GT.Application.Interfaces;
using GT.Domain.Entities;
using GT.Domain.Interfaces;

namespace GT.Application.Services
{
    public class TarefaService : ITarefaService
    {

        public readonly IMapper _mapper;
        public readonly ITarefa _tarefa;

        public TarefaService(IMapper mapper, ITarefa tarefa)
        {
            
            _mapper = mapper;
            _tarefa = tarefa;

        }


        public async Task<TarefaDto> BuscarTarefaPorId(int id)
        {

            try
            {

                var tarefa = await _tarefa.BuscarTarefaPorId(id);
                return _mapper.Map<TarefaDto>(tarefa);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<IEnumerable<TarefaDto>> BuscarTodasTarefas()
        {

            try
            {

                var tarefas = await _tarefa.BuscarTodasTarefas();
                return _mapper.Map<IEnumerable<TarefaDto>>(tarefas);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> AdicionarTarefa(TarefaDto tarefa)
        {
                        
            try
            {

                if (tarefa.UsuarioId <= 0 || tarefa.UsuarioId > 3 )
                {
                    throw new ApplicationException("O ID do usuário não deve ser menor e igual a Zero (0) e maior que 3.");
                }


                                
                var task = _mapper.Map<Tarefa>(tarefa);
                var result = await _tarefa.IncluirTarefa(task);

                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> AtualizarTarefa(TarefaDto tarefa)
        {

            try
            {

                var task = _mapper.Map<Tarefa>(tarefa);
                var result = await _tarefa.AlterarTarefa(task);

                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }

        public async Task<bool> ExcluirTarefa(int id)
        {

            try
            {

                var result = await _tarefa.ExcluirTarefa(id);
                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
