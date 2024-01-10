
using GT.Domain.Enums;

namespace GT.Domain.Entities
{
    public class Tarefa
    {


        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public TipoPrioridade Prioridade { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataConclusao { get; set; }


        public virtual Usuario? Usuario { get; set; }

    }
}
