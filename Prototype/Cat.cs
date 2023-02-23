namespace Prototype;

public class Cat : Animal
{
    public bool IsEatFish { get; set; }
    
    public override Animal ShallowCopy()
    => (Cat) MemberwiseClone();
 
    public override Animal DeepCopy()
        =>  new Cat() {Name = Name, IsEatFish = IsEatFish, Toy = new Toy()
        {
            Name = Toy.Name
        }};

    public override string ToString()
        => $"Cat name: {Name}, is eat fish: {IsEatFish} and favorite toy is {Toy.Name}";
}