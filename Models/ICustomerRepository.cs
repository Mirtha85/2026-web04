namespace NakamaShop.Models
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        // AÑADE ESTA LÍNEA:
        IEnumerable<Customer> AllCustomers { get; } 
    }
}