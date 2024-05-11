using Tarefas.Communication.Enums;
using Tarefas.Communication.Responses;
using TaskStatus = Tarefas.Communication.Enums.TaskStatus;

namespace Tarefas.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson 
        { 
            Id = id,
            Name = "Dentes",
            Description = "Escovar os dentes de noite",
            Priority = TaskPriority.Medium,
            LimitDate = DateTime.Today,
            Status = TaskStatus.Completed,
        };
    }
}
