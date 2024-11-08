using Gerenciador.Communications.Enums;

namespace Gerenciador.Communications.Request
{
    public class RequestTaskJson
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Priority Prioridade { get; set; }
        public DateTime DataDeEntrega {  get; set; }
        public Status Status { get; set; }
    }
}
