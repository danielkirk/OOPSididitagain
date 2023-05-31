// See https://aka.ms/new-console-template for more information
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void Promote()
    {
        var calculator = new RateCalculator();
        calculator.Calculate(this);
    }
}