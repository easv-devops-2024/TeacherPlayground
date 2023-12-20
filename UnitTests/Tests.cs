using Xunit;

public class ProgramTests
{
    [Fact]
    public void GetGreetingMessage_ShouldReturnDroneCI_GivenDroneCIBranch()
    {
        // Arrange
        Environment.SetEnvironmentVariable("DRONE", "true");

        // Act
        var result = Program.GetGreetingMessage();

        // Assert
        Assert.Equal("Hello, Drone CI!", result);
    }

    [Fact]
    public void GetGreetingMessage_ShouldReturnHelloWorld_GivenNonDroneCIBranch()
    {
        // Arrange
        Environment.SetEnvironmentVariable("DRONE", "false");

        // Act
        var result = Program.GetGreetingMessage();

        // Assert
        Assert.Equal("Hello, World!", result);
    }

    [Fact]
    public void Hit()
    {
        Program.Main();
    }
}