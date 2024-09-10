using AlphaStandardDemo.Abstracts;
using AlphaStandardDemo.Models;
using Moq;

namespace AlphaTestes
{
    public class Tests
    {
        private GenericViewModel<Safra> _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = Mock.Of<GenericViewModel<Safra>>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}