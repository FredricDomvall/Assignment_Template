using Infrastructure.Models;

namespace Infrastructure.Interfaces;

public interface IFileService
{
    FileResult GetFromFile(string filePath);
    FileResult SaveToFile(string filePath, string content);
}
