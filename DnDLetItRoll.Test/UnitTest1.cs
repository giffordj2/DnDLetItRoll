using DnDLetItRoll.Data;
using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using DnDLetItRoll.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace DnDLetItRoll.Test
{
    [TestClass]
    public class ControllerTest
    {


        [TestMethod]
        public void TestClassControllerDetial()
        {
            var mockRepo = new Mock<IGenericRepository<Class>>();
            mockRepo.Setup(repo => repo.Get()).Returns(GetTestClasses());
            ClassesController controller = new ClassesController(mockRepo.Object);
            ViewResult result = controller.Details(2) as ViewResult;
            Class @class = (Class) result.ViewData.Model;

            Assert.AreEqual("TestClass2", @class.Name);
        }
        
             
        

        private IEnumerable<Class> GetTestClasses()
        {
            var classes = new List<Class>();
            classes.Add(new Class()
            {
                Id = 1,
                Name = "TestClass1",
                Description = "Class 1 for testing purposes",
                HitDie = "d20"
            });
            classes.Add(new Class()
            {
                Id = 2,
                Name = "TestClass2",
                Description = "Class 2 for testing purposes",
                HitDie = "d20"
            });

            return classes;
        }
        
    }
}
