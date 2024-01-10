
namespace GT.Domain.Entities
{
    public class Usuario
    {

        public int Id { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Tarefa>? Tarefas { get; set; }

    }
}
