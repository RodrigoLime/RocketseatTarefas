using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.UseCases.Task.Delete;
using Tarefas.Application.UseCases.Task.Edit;
using Tarefas.Application.UseCases.Task.GetAll;
using Tarefas.Application.UseCases.Task.GetById;
using Tarefas.Application.UseCases.Task.Register;
using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request) //Endpoint para criar uma tarefa
    {
        var useCase = new RegisterTaskUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
   
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll() // Endpoint para visualizar todas as tarefas
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        if (response.Tasks.Any()) 
        {
            return Ok(response); //Se a lista de tarefas nao for vazia
        }

        return NoContent(); //Se for vazia

    }


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)  //Endpoint para visualizar uma tarefa buscando pelo seu id
    {
        var useCase = new GetTaskByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }


    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Edit([FromRoute] int id, [FromBody] RequestTaskJson request) //Endpoint para editar uma tarefa
    {
        var useCase = new EditTaskUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id) //Endpoint para deletar uma tarefa
    {
        var useCase = new DeleteTaskUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
