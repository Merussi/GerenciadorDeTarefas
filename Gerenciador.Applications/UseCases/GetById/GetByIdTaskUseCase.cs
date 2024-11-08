using Gerenciador.Communications.Responses;

namespace Gerenciador.Applications.UseCases.GetById
{
    public class GetByIdTaskUseCase
    {
        public ResponseGetByIdTaskJson Execute(int id)
        {
            return new ResponseGetByIdTaskJson
            {
                Id = id,
                Nome = "teste",
                Descricao = "testeste",
                DataDeEntrega = new DateTime(year: 2024, month: 1, day: 1),
                Prioridade = Communications.Enums.Priority.alta,

            };
        }
    }
}
