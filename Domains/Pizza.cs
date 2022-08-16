public abstract class Pizza
{
    public string description = "Unknown pizza";

    public string GetDescription()
    {
        return description;
    }

    public abstract int GetCost();
}