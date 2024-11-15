namespace DecoratorPattern.StarbuzzExample;

public  abstract class Beverage
{
    public virtual string Description => "Unknown Beverage";
    public virtual Size Size { set; get; } = Size.Grande;
    public abstract double Cost();

    public override string ToString()
    {
        return $"{Description} Cost = {Math.Round(Cost(),2)}";
    }
}