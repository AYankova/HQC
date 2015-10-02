namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using Cars.Tests.JustMock.Mocks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())    // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = string.Empty,
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = string.Empty,
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void DetailsShouldReturnFirstCarView()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual(model.Model, "A5");
        }

        [TestMethod]
        public void SearchShouldReturnAllBMWs()
        {
            var model = (List<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(model[0].Model, "325i");
            Assert.AreEqual(model[1].Model, "330d");
        }

        [TestMethod]
        public void SortByMakeShouldReturnCarsSorted()
        {
            var model = (List<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(model[0].Model, "A5");
            Assert.AreEqual(model[1].Model, "325i");
            Assert.AreEqual(model[2].Model, "330d");
            Assert.AreEqual(model[3].Model, "Astra");
        }

        [TestMethod]
        public void SortByYearShouldReturnCarsSorted()
        {
            var model = (List<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(model[0].Model, "Astra");
            Assert.AreEqual(model[1].Model, "325i");
            Assert.AreEqual(model[2].Model, "330d");
            Assert.AreEqual(model[3].Model, "A5");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortByNonexistentOptionShouldThrowArgumentException()
        {
            var model = (List<Car>)this.GetModel(() => this.controller.Sort("price"));
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
