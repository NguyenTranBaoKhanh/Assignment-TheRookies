using BKShop.Application.Interfaces;
using BKShop.ViewModels.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.UnitTest.API.TestControllers.Mocks
{
    public class MockCategoryService : Mock<ICategoryService>
    {
        public MockCategoryService MockGetAllAsync(List<CategoryViewModel> result)
        {
            Setup(x => x.GetAllAsync()).ReturnsAsync(result);

            return this;
        }
        public MockCategoryService MockGetAllAsync_ThrowException()
        {
            Setup(x => x.GetAllAsync()).Throws(new Exception());

            return this;
        }
    }
}
