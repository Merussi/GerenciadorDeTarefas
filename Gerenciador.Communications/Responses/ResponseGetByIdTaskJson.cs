using Gerenciador.Communications.Enums;

namespace Gerenciador.Communications.Responses
{
    public class ResponseGetByIdTaskJson
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Priority Prioridade { get; set; }
        public DateTime DataDeEntrega { get; set; }
        public Status Status { get; set; }

    }
}
