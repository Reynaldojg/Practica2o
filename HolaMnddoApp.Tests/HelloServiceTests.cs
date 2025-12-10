using Xunit;

namespace HolaMnddoApp.Tests;

public class HelloServiceTests
{
    [Fact]
    public void HolaMundo_Should_Return_Correct_Message()
    {
        var mensaje = "Hola Mundo desde C# y Docker!";
        
        Assert.Equal("Hola Mundo desde C# y Docker!", mensaje);
    }
}
