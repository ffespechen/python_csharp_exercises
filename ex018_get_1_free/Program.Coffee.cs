partial class Program
{
    public static double GetCostOfCoffee(int numberOfCoffees, double pricePerCoffee)
    {
        if (numberOfCoffees < 8) return numberOfCoffees * pricePerCoffee;

        int div = numberOfCoffees / 8;
        int resto = numberOfCoffees % 8;

        if (resto == 0)
        {
            return numberOfCoffees * pricePerCoffee;
        }
        else if (resto == div)
        {
            return div * 8 * pricePerCoffee;
        }
        else
        {
            return ((div * 8) + (resto - div)) * pricePerCoffee;
        }
    }
}