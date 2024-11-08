using Gerenciador.Communications.Enums;

namespace Gerenciador.Communications.Responses
{
    public class ResponseShortTaskJson
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Status Status { get; set; }
    }
}
