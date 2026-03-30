namespace NakamaShop.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly NakamaShopDbContext _context;

        public CustomerRepository(NakamaShopDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer); // 1. Lo prepara
            _context.SaveChanges();           // 2. ¡LO GUARDA DE VERDAD!
        }

        // Propiedad extra para leerlos después si quieres
        public IEnumerable<Customer> AllCustomers => _context.Customers;
    }
}