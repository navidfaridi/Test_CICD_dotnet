using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{
    public interface ICustomerService
    {
        int Add(string name);
        List<Customer> GetAll();
    }


}
