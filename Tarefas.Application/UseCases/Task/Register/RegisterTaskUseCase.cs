using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        Random random = new Random();

        return new ResponseRegisterTaskJson
        {
            Id = random.Next(1, 101),
            Name = request.Name,
        };
    }
}
