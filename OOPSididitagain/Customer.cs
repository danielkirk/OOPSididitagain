// See https://aka.ms/new-console-template for more information
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void Promote()
    {
        var rating = CalculateRating();
        if (rating > 0)
        {
            Console.WriteLine("Promotion time!");
        }
        else
        {
            Console.WriteLine("Sorry, maybe next time.");
        }
    }

    private int CalculateRating()
    {
        return 1;
    }

    protected string GetAccessToVoucher(bool allowVoucher)
    {
        return allowVoucher ? "You have a voucher" : "No voucher for you sir";
    }
}