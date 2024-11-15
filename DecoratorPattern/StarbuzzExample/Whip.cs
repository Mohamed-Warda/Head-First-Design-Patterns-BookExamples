namespace DecoratorPattern.StarbuzzExample;
public class Whip:CondimentDecorator
{
    public override string Description => $"{_beverage.Description} + Whip";
    public Whip(Beverage beverage) : base(beverage)
    {
    }
  
      public override double Cost() => Size switch
    {
        Size.Tall =>_beverage.Cost() + .6, 
        Size.Grande => _beverage.Cost() + .9, 
        Size.Venti => _beverage.Cost() + 1, 
        _ => throw new ArgumentOutOfRangeException()
    };
}