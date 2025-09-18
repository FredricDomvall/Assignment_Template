using Infrastructure.Helpers;

namespace Infrastructure.Tests.Helpers;

public class UniqueIdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnGuidId_InStringFormat_WhenSuccessful()
    {
        //arrange

        //act
        var result = UniqueIdGenerator.Generate();
        //assert
        Assert.NotEmpty(result);
        Assert.True(Guid.TryParse(result, out Guid id));
        Assert.IsType<Guid>(id);
    }
}
