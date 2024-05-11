using Tarefas.Communication.Requests;

namespace Tarefas.Application.UseCases.Task.Edit;

public class EditTaskUseCase
{
    public void Execute (int id, RequestTaskJson request)
    {
        //Regra de negocio para atualizar informacoes no banco de dados com as informacoes passadas no request, identificandoi a tarefa pelo id passado.
    }
}
