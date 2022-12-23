using Moq;
using SampleLib;

namespace SampleLibTests
{
    public class CustomerServiceTests
    {
        private Mock<ICustomerService> _customerServiceMok;
        public CustomerServiceTests()
        {
            _customerServiceMok = new Mock<ICustomerService>();
        }

        [Fact]
        public void AddingFirstCustomerShouldReturn1ForId()
        {
            _customerServiceMok.Setup(u => u.Add(It.IsAny<string>())).Returns(1);
            var service = _customerServiceMok.Object;
            var x = service.Add("test");
            Assert.NotNull(x);
            Assert.Equal(x, 1);
        }
    }
}