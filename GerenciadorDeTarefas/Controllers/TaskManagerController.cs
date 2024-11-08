using Gerenciador.Applications.UseCases.Delete;
using Gerenciador.Applications.UseCases.GetAll;
using Gerenciador.Applications.UseCases.GetById;
using Gerenciador.Applications.UseCases.Register;
using Gerenciador.Applications.UseCases.Update;
using Gerenciador.Communications.Request;
using Gerenciador.Communications.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            var response = new RegisterTaskUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            var UseCase = new UpdateTaskUseCase();
            UseCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var UseCase = new GetAllTaskUseCase();

            var response = UseCase.Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseGetByIdTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]

        public IActionResult GetById([FromRoute]int id)
        {
            var UseCase = new GetByIdTaskUseCase();
            var response = UseCase.Execute(id);
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var UseCase = new DeleteTaskUseCase();
            UseCase.Execute(id);

            return NoContent();
        }
    }

}
