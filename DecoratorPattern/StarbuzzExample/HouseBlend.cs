namespace DecoratorPattern.StarbuzzExample;

public class HouseBlend:Beverage
{
    public override string Description => "House Blend Coffee";

    public override double Cost() => Size switch
    {
        Size.Tall => 1.2, 
        Size.Grande => 1.4, 
        Size.Venti => 1.9,
        _ => throw new ArgumentOutOfRangeException()
    };
}