﻿using Tarefas.Communication.Enums;
using TaskStatus = Tarefas.Communication.Enums.TaskStatus;

namespace Tarefas.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public TaskStatus Status { get; set; }
}
