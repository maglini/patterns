using System.Text;
using Builder.Entries;

namespace Builder.Builders;

public class CityHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public CityHouseBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        this._house = new House();
    }
    
    public void BuildWalls()
    {
        this._house.Walls = "brick";
    }

    public void BuildRoof()
    {
        this._house.Walls = "slate";
    }

    public void BuildWindows()
    {
        this._house.Windows = "metal-plastic";
    }

    public void BuildDoor()
    {
        this._house.Door = "iron";
    }

    public void BuildGarden()
    {
        this._house.Garden = "cypresses";
    }

    public void BuildSwimmingPool()
    {
        this._house.SwimmingPool = "underground";
    }

    public House Get()
    {
        var house = this._house;
        
        this.Reset();

        return house;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        foreach (var property in this._house.GetType().GetProperties())
        {
            var value =  (string) property.GetValue(this._house, null)!;
            
            if (!string.IsNullOrEmpty(value))
            {
                builder.Append($"{property.Name}: {value} | ");
            }
        }

        return builder.ToString();
    }
}