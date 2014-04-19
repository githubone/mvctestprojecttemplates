using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustEatRAPPS;
using JustEatRAPPS.Controllers;
using Rhino;
using Rhino.Mocks;
using JustEatRAPPS.Service;
using System.Threading.Tasks;
using JustEatRAPPS.Models;
using JustEatRAPPS.Common;

namespace JustEatRAPPS.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public async Task CallControllerSearchWithValidPostCode_Expect_ServiceClientToCallGetRestaurants_And_ValidatorToCallIsValid_To_Return_True()
        {
            // Arrange
            MainRestaurantViewModel viewModel = new MainRestaurantViewModel() { PostCode = "se19" };
            TaskCompletionSource<List<RestaurantViewModel>> taskResults = new TaskCompletionSource<List<RestaurantViewModel>>();
            taskResults.SetResult(new List<RestaurantViewModel>());
            
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            var mockValidator = MockRepository.GenerateMock<ISearchValidator>();

            mockServiceClient.Expect(c => c.GetRestaurants(viewModel.PostCode)).Return(taskResults.Task).Repeat.Once();
            mockValidator.Expect(v => v.IsValid(viewModel.PostCode)).Return(true).Repeat.Once();
            HomeController controller = new HomeController(mockServiceClient);
            
            // Act
            var result = await controller.Search(viewModel);

            // Verify expectation
            mockServiceClient.VerifyAllExpectations();
        }

        [TestMethod]
        public async Task CallControllerSearchWithInValidPostCode_Expect_ServiceClientToCallGetRestaurants_And_ValidatorToCallIsValid_To_Return_false()
        {
            // Arrange
            MainRestaurantViewModel viewModel = new MainRestaurantViewModel() { PostCode = "se190" };
            TaskCompletionSource<List<RestaurantViewModel>> taskResults = new TaskCompletionSource<List<RestaurantViewModel>>();
            taskResults.SetResult(null);

            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            var mockValidator = MockRepository.GenerateMock<ISearchValidator>();

            mockServiceClient.Expect(c => c.GetRestaurants(viewModel.PostCode)).Return(taskResults.Task).Repeat.Once();
            mockValidator.Expect(v => v.IsValid(viewModel.PostCode)).Return(false).Repeat.Once();
            HomeController controller = new HomeController(mockServiceClient);

            // Act
            var result = await controller.Search(viewModel);

            // Verify expectation
            mockServiceClient.VerifyAllExpectations();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task CallControllerSearchWithNullViewModel_Expect_ExceptionThrown()
        {
            // Arrange
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            HomeController controller = new HomeController(mockServiceClient);
            
            // Act
            var result = await controller.Search(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task CallControllerSearchWithNullPostCode_Expect_ExceptionThrown()
        {
            // Arrange
            MainRestaurantViewModel viewModel = new MainRestaurantViewModel();
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            HomeController controller = new HomeController(mockServiceClient);

            // Act
            var result = await controller.Search(viewModel);
        }

        [TestMethod]
        public async Task CallControllerProducts_Expect_ServiceClientToCallGetProducts()
        {
            // Arrange
            MainProductViewModel viewModel = new MainProductViewModel() {RestaurantId= "100" };
            TaskCompletionSource<List<ProductViewModel>> taskResults = new TaskCompletionSource<List<ProductViewModel>>();
            taskResults.SetResult(new List<ProductViewModel>());
            
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            mockServiceClient.Expect(c => c.GetProducts(viewModel.RestaurantId)).Return(taskResults.Task).Repeat.Once();
            HomeController controller = new HomeController(mockServiceClient);

            // Act
            var result = await controller.Products(viewModel);

            mockServiceClient.VerifyAllExpectations();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task CallControllerProductsWithNullViewModel_Expect_ExceptionThrown()
        {
            // Arrange
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            HomeController controller = new HomeController(mockServiceClient);

            // Act
            var result = await controller.Products(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task CallControllerProductsWithNullRestaurantId_Expect_ExceptionThrown()
        {
            // Arrange
            MainProductViewModel viewModel = new MainProductViewModel();
            var mockServiceClient = MockRepository.GenerateMock<IRestaurantServiceClient>();
            HomeController controller = new HomeController(mockServiceClient);

            // Act
            var result = await controller.Products(viewModel);
        }

        
     
    }
}
