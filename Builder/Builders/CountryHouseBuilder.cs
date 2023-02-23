using System.Text;
using Builder.Entries;

namespace Builder.Builders;

public class CountryHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public CountryHouseBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        this._house = new House();
    }
    
    public void BuildWalls()
    {
        this._house.Roof = "hay";
    }

    public void BuildRoof()
    {
        this._house.Walls = "wood";
    }

    public void BuildWindows()
    {
        this._house.Windows = "wooden";
    }

    public void BuildDoor()
    {
        this._house.Windows = "simple";
    }

    public void BuildGarden()
    {
        this._house.Windows = "apple";
    }

    public void BuildSwimmingPool()
    {
        this._house.SwimmingPool = "small trough";
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