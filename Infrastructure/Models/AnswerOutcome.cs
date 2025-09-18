namespace Infrastructure.Models;

public class AnswerOutcome<T> where T : class
{
    public bool IsSuccess { get; set; }
    public string Response { get; set; } = null!;
    public T? Content { get; set; }
}
