namespace SampleLib
{
    public interface ICustomerService
    {
        int Add(string name);
        List<Customer> GetAll();
    }
}
