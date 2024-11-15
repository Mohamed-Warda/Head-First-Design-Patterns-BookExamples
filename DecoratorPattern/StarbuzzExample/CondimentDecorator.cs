namespace DecoratorPattern.StarbuzzExample;

public abstract class CondimentDecorator : Beverage
{
    protected readonly Beverage _beverage;

    protected CondimentDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }
}