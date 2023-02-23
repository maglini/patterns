namespace Prototype;

public abstract class Animal
{ 
    public string Name { get; set; }
    
    public Toy Toy { get; set; }
    
    public abstract Animal ShallowCopy();

    public abstract Animal DeepCopy();
}