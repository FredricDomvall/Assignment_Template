namespace Infrastructure.Models;

public class ProductResult<T>
{
    public bool IsSuccess { get; set; }
    public string? Response { get; set; }
    public T? Content { get; set; }
}
