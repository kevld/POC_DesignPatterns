using POC_DesignPatterns.NS_Singleton;

namespace POC_DesignPatterns.Tests;

public class Singleton_UnitTest
{
    [Fact]
    public void Singleton_SingleInstance()
    {
        // Arrange
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        // Assert
        Assert.Equal(s1.GeneratedGuid, s2.GeneratedGuid);
    }
}