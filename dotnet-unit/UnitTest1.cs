using Lab2;
namespace dotnet_unit;


public class UnitTestDatabase
{
    Cinema cinema;
    public UnitTestDatabase()
    {
        cinema = new Cinema();
    }

    [Fact]
    public void Test1()
    {
        cinema.RemoveMovie("mvi1");
        /// cinema.ticketsContext.Movies
        Assert.True(true);
    }
}