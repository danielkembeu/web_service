var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<Todo>();


app.MapPost("/todos", (Todo task) => {
    todos.Add(task);
    return TypedResults.Created("/todos/{id}", task);
});


app.Run();

public record Todo(
    int Id,
    string Title,
    DateTime DueDate,
    bool IsCompleted = false
);