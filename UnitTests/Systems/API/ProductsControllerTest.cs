using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Systems.API
{
    public class ProductsControllerTest
    {
        private Mock<IProductService> service = new Mock<IProductService>().Create();
        private readonly ProductsController _controller = new ProductsController(productService);
        public ProductsControllerTest()
        {
        }

        [Fact]
        public void GetProducts_PositiveReq_AllProductsList()
        {
            Assert.True(true);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

    }
}
