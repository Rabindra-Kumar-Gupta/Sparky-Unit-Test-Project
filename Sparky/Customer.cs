namespace Sparky
{
    public interface ICustomer
    {
        public int Discount {  get; set; }
        public int orderTotal { get; set; }
        public string? GreetMessage { get; set; }
        public bool IsPlatinum { get; set; }
        public string GreetAndCombineNames(string firstName, string lastName);
        public CustomerType GetCustomerDetails();
    }
    public class Customer:ICustomer
    {
        public int Discount { get; set; }
        public int orderTotal {  get; set; }
        public string? GreetMessage { get; set; }
        public bool IsPlatinum {  get; set; }
        public Customer()
        {
            Discount = 15;
            IsPlatinum = false;
        }

        public string GreetAndCombineNames(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public CustomerType GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
    public class CustomerType { }
        public class BasicCustomer :CustomerType { }
        public class PlatinumCustomer: CustomerType { }
}
