using BKShop.API.Controllers;
using BKShop.UnitTest.API.TestControllers.Mocks;
using BKShop.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.UnitTest.API.TestControllers
{
    public class CategoryTestController
    {
        // test for category api
        [Fact]
        public async void Get_ReturnsOk()
        {
            var mockData = new List<CategoryViewModel>()
            {
                 new CategoryViewModel()
                 {
                      Id = 1,
                 },
            };

            var mockCategoryService = new MockCategoryService().MockGetAllAsync(mockData);

            var controller = new CategoryController(mockCategoryService.Object);

            OkObjectResult result = await controller.Get() as OkObjectResult;

            //var content = JsonConvert.DeserializeObject<List<CategoryViewModel>>(result.Value.ToString());
            Assert.NotNull(result);
            var content = result.Value as IEnumerable<CategoryViewModel>;
            Assert.NotNull(content);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockData, content);
            Assert.IsType<List<CategoryViewModel>>(content);
        }

        [Fact]
        public async void Get_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockGetAllAsync_ThrowException();

            var controller = new CategoryController(mockCategoryService.Object);

            var result = await controller.Get();

            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
