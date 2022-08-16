public class Barbeque : ToppingDecorator
{
    //We need a reference to obj we are decorating
    Pizza _pizza;
    
    public Barbeque(Pizza pizza)
    {
        _pizza = pizza;
    }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", Barbeque ";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 90;
    }
}