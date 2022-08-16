public class FreshTomato : ToppingDecorator
{
    //We need a reference to obj we are decorating
    Pizza _pizza;
    
    public FreshTomato(Pizza pizza)
    {
        _pizza = pizza;
    }

    public override string GetDescription()
    {
        return _pizza.GetDescription() + ", Fresh Tomato ";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 40;
    }
}