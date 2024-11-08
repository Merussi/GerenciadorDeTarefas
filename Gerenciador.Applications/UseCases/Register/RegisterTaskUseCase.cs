using Gerenciador.Communications.Request;
using Gerenciador.Communications.Responses;

namespace Gerenciador.Applications.UseCases.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = 1,
                Nome = request.Nome,

            };
        }
    }
}
