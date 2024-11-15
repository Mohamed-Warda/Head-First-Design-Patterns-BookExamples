namespace DecoratorPattern.StarbuzzExample;

public class Decaf:Beverage
{
    public override string Description => "Decaf Coffee";

    public override double Cost() => Size switch
    {
        Size.Tall => .8, 
        Size.Grande => 1.1, 
        Size.Venti => 1.4,
        _ => throw new ArgumentOutOfRangeException()
    };
}