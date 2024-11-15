namespace DecoratorPattern.StarbuzzExample;

public class Soy:CondimentDecorator
{
    public override string Description => $"{_beverage.Description} + Soy";
    public Soy(Beverage beverage) : base(beverage)
    {
    }
   
    public override double Cost() => Size switch
    {
        Size.Tall =>_beverage.Cost() + .1, 
        Size.Grande => _beverage.Cost() + .2, 
        Size.Venti => _beverage.Cost() + .3, 
        _ => throw new ArgumentOutOfRangeException()
    };
}