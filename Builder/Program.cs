using Builder.Builders;
using Builder.Directors;

namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        var director = new Director();
        
        var countryBuilder = new CountryHouseBuilder();
        director.HouseBuilder = countryBuilder;
        director.BuildMinimal();
        Console.WriteLine(countryBuilder.ToString());
        
        var cityBuilder = new CityHouseBuilder();
        director.HouseBuilder = cityBuilder;
        director.BuildVip();
        Console.WriteLine(cityBuilder.ToString());

    } 
}