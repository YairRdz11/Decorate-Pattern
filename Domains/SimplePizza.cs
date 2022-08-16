public class SimplePizza : Pizza
{
    public SimplePizza()
    {
        description = "SimplePizza";
    }

    public override int GetCost()
    {
        return 50;
    }
}