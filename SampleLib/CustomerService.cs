namespace SampleLib
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _list;
        public CustomerService()
        {
            _list= new List<Customer>();
        }
        public int Add(string name)
        {
            var customer = new Customer
            {
                FullName= name, Created= DateTime.Now
            };
            customer.Id = _list.Max(u => u.Id) + 1;
            _list.Add(customer);
            return customer.Id;
        }

        public List<Customer> GetAll()
        {
            return _list;
        }
    }
}
