using SCC.Api;
namespace SCC.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Calcular calcular = new Calcular();
        int total = calcular.Somar(2,2);
        Assert.Equal(4, total);
    }
}