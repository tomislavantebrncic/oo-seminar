using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Repositories;
using Moq;

namespace Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Login_Doctor()
        {
            string username = "aa54372";
            string password = "1234";
            var waitingRoom = new Mock<WaitingRoom>();
            Doctor doctor = new Doctor("Ante", "Antić", "54372816532", DateTime.Now, username, password, waitingRoom.Object);

            var employeeRepository = new Mock<IEmployeeRepository>();
            employeeRepository.Setup(x => x.GetByUsernameAndPassword(username, password)).Returns(doctor);

            AuthenticationService authenticationService = new AuthenticationService(employeeRepository.Object);
            bool authorization = authenticationService.Authenticate(username, password);

            employeeRepository.Verify(x => x.GetByUsernameAndPassword(username, password), Times.Once());
            Assert.AreEqual(true, authorization);
            Assert.AreEqual(doctor, LoggedIn.GetEmployee());
        }

        [TestMethod]
        public void Logout_Doctor()
        {
            var employeeRepository = new Mock<IEmployeeRepository>();
            AuthenticationService authenticationService = new AuthenticationService(employeeRepository.Object);

            authenticationService.Logout();

            Assert.AreEqual(null, LoggedIn.GetEmployee());
        }
    }
}
