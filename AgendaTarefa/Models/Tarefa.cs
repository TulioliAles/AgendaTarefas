using System.ComponentModel.DataAnnotations;

namespace AgendaTarefa.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "Use no máximo 50 caracteres")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }
    }
}
