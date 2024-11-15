namespace DecoratorPattern.StarbuzzExample;
public class Milk:CondimentDecorator
{
    public override string Description => $"{_beverage.Description} + Milk";
    public Milk(Beverage beverage) : base(beverage)
    {
    }
    public override double Cost() => Size switch
    {
        Size.Tall =>_beverage.Cost() + .2, 
        Size.Grande => _beverage.Cost() + .5, 
        Size.Venti => _beverage.Cost() + .6, 
        _ => throw new ArgumentOutOfRangeException()
    };
}