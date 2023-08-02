    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            Console.WriteLine(GetAccessToVoucher(true));
        }
    }
