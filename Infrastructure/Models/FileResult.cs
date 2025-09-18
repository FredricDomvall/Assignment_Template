namespace Infrastructure.Models;

public class FileResult
{
    public bool IsSuccess { get; set; }
    public string Response { get; set; } = null!;
    public string? Content { get; set; }
}
