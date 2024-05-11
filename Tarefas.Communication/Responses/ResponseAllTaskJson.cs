namespace Tarefas.Communication.Responses;

public class ResponseAllTaskJson
{
    //Achei melhor fazer a lista com todas as informacoes de cada tarefa pois faz sentido alguem querer fazer todas as infomacoes das tarefas.
    public List<ResponseTaskJson> Tasks { get; set; } = [];
}
