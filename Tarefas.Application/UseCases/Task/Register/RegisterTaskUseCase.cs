using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = request.Id,
            Name = request.Name,
        };
    }
}
