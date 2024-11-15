namespace DecoratorPattern.StarbuzzExample;

public class DarkRoast:Beverage
{
    public override string Description  => "Dark Roast Coffee";

    public override double Cost() => Size switch
    {
        Size.Tall => .99, 
        Size.Grande => 1.3, 
        Size.Venti => 1.5, 
        _ => throw new ArgumentOutOfRangeException()

    };
}