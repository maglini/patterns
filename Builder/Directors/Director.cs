using Builder.Builders;

namespace Builder.Directors;

public class Director
{
    private IHouseBuilder _houseBuilder;

    public IHouseBuilder HouseBuilder
    {
        set { _houseBuilder = value; }
    }

    public void BuildMinimal()
    {
        this._houseBuilder.BuildWalls();
        this._houseBuilder.BuildRoof();
        this._houseBuilder.BuildWindows();
        this._houseBuilder.BuildDoor();
    }

    public void BuildStandard()
    {
        this._houseBuilder.BuildWalls();
        this._houseBuilder.BuildRoof();
        this._houseBuilder.BuildWindows();
        this._houseBuilder.BuildDoor();
        this._houseBuilder.BuildGarden();
    }
    
    public void BuildVip()
    {
        this._houseBuilder.BuildWalls();
        this._houseBuilder.BuildRoof();
        this._houseBuilder.BuildWindows();
        this._houseBuilder.BuildDoor();
        this._houseBuilder.BuildGarden();
        this._houseBuilder.BuildSwimmingPool();
    }
}