using Infrastructure.Interfaces;
using Infrastructure.Models;
using Moq;

namespace Infrastructure.Tests.Services;

public class FileService_Tests
{
    [Fact]
    public void SaveContentToFile_ShouldSaveContentToJsonFile_ReturnTrue()
    {
        var fileResult = new FileResult { IsSuccess = true };

        var fileServiceMock = new Mock<IFileService>();
        var fileService = fileServiceMock.Object;

        fileServiceMock.Setup(fs => fs.SaveToFile(It.IsAny<string>(), It.IsAny<string>())).Returns(fileResult);

        var result = fileService.SaveToFile("", "");

        Assert.True(result.IsSuccess);

    }
    [Fact]
    public void SaveContentToFile_ShouldReturnFalseWithError_WhenCOntentNotSavedToFile()
    {
        var fileResult = new FileResult { IsSuccess = false, Response = "Unable to save content." };

        var fileServiceMock = new Mock<IFileService>();
        var fileService = fileServiceMock.Object;

        fileServiceMock.Setup(fs => fs.SaveToFile(It.IsAny<string>(), It.IsAny<string>())).Returns(fileResult);

        var result = fileService.SaveToFile("", "");

        Assert.False(result.IsSuccess);
        Assert.Equal("Unable to save content.", result.Response);

    }
    [Fact]
    public void GetContentFromFile_ShouldReturnContentAsJson_ReturnTrue()
    {
        var jsonContent = "[{}]";
        var fileResult = new FileResult { IsSuccess = true, Content = jsonContent };

        var fileServiceMock = new Mock<IFileService>();
        var fileService = fileServiceMock.Object;

        fileServiceMock.Setup(fs => fs.GetFromFile(It.IsAny<string>())).Returns(fileResult);

        var result = fileService.GetFromFile("");
        Assert.True(result.IsSuccess);
        Assert.Equal(jsonContent, result.Content);
    }
    [Fact]
    public void GetContentFromFile_ShouldReturnEmptyString_WHenNoFileFound()
    {
        var jsonContent = "";
        var fileResult = new FileResult { IsSuccess = true, Content = jsonContent };

        var fileServiceMock = new Mock<IFileService>();
        var fileService = fileServiceMock.Object;

        fileServiceMock.Setup(fs => fs.GetFromFile(It.IsAny<string>())).Returns(fileResult);

        var result = fileService.GetFromFile("");
        Assert.True(result.IsSuccess);
        Assert.Equal(jsonContent, result.Content);
    }
}
