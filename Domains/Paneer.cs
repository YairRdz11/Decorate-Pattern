public class Panner : ToppingDecorator
{
    //We need a reference to obj we are decorating
    Pizza _pizza;
    
    public Panner(Pizza pizza)
    {
        _pizza = pizza;
    }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", Panner ";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 70;
    }
}