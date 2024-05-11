using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    /*
    [HttpGet]
    public IActionResult GetAll()
    {

    }


    [HttpGet]
    public IActionResult GetById(int id) 
    {
    
    }


    [HttpPut]
    public IActionResult Edit(int id)
    {

    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {

    }
    */
}
