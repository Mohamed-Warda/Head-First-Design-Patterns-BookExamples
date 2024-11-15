namespace DecoratorPattern.StarbuzzExample;

public class Espresso:Beverage
{
    public override string Description => "Espresso";

    public override double Cost() => Size switch
    {
        Size.Tall => 1, 
        Size.Grande => 1.5, 
        Size.Venti => 1.8,
        _ => throw new ArgumentOutOfRangeException()
    };
}