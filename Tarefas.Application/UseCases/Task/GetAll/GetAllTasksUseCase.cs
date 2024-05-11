using Tarefas.Communication.Enums;
using Tarefas.Communication.Responses;
using TaskStatus = Tarefas.Communication.Enums.TaskStatus;

namespace Tarefas.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseTaskJson> //Exemplo de lista de tarefas
            {
                new() {
                    Id = 0,
                    Name = "Supermercado",
                    Description = "Fazer compras no supermercado",
                    Priority = TaskPriority.High,
                    LimitDate = DateTime.Today.AddDays(2),
                    Status =  TaskStatus.Waiting,
                },

                new() {
                    Id = 1,
                    Name = "Agendar exame",
                    Description = "Agendar exame de sangue no hospital",
                    Priority = TaskPriority.Medium,
                    LimitDate = DateTime.Today.AddDays(10),
                    Status = TaskStatus.Waiting,
                },

                new() {
                    Id = 2,
                    Name = "Criar API",
                    Description = "Fazer projeto de API do .NET Core",
                    Priority = TaskPriority.Medium,
                    LimitDate = DateTime.Today.AddDays(15),
                    Status =  TaskStatus.Ongoing,
                },
            }
        };
    }
}
