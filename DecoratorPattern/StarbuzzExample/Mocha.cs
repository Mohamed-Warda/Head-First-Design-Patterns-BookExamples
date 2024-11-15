namespace DecoratorPattern.StarbuzzExample;
public class Mocha:CondimentDecorator
{
    public override string Description => $"{_beverage.Description} + Mocha";
    public Mocha(Beverage beverage) : base(beverage)
    {
    }
    public override double Cost() => Size switch
    {
        Size.Tall =>_beverage.Cost() + .5, 
        Size.Grande => _beverage.Cost() + .7, 
        Size.Venti => _beverage.Cost() + .9, 
        _ => throw new ArgumentOutOfRangeException()
    };
}