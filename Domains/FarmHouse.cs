public class FarmHouse : Pizza
{
    public FarmHouse()
    {
        description = "FarmHouse";
    }

    public override int GetCost()
    {
        return 200;
    }
}