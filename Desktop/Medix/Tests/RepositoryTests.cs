using System;
using System.Collections.Generic;
using BaseLib;
using BusinessLayer;
using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Repositories;
using Moq;

namespace Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }
        [TestMethod]
        public void GetPatientByOIB()
        {
            string oib = "2345678901";
            Patient expected = new Patient("Ivo", "Ivić", oib, DateTime.Now, "ii01234");

            var mockRepository = new Mock<IPatientRepository>();
            mockRepository.Setup(x => x.GetByOIB(oib)).Returns(expected);
            PatientService patientService = new PatientService(mockRepository.Object);

            Patient patient = patientService.GetByOIB(oib);

            Assert.AreEqual(expected, patient);
        }

        [TestMethod]
        public void GetPatientsByLastName()
        {
            string lastname = "Iv";
            Patient p1 = new Patient("Ivo", "Ivić", "2345678901", DateTime.Now, "ii01234");
            Patient p2 = new Patient("Ante", "Ivić", "2345642901", DateTime.Now, "ai01234");
            Patient p3 = new Patient("Ivo", "Antić", "2348524101", DateTime.Now, "ia01234");
            List<Patient> expected = new List<Patient>();
            expected.Add(p1);
            expected.Add(p2);

            var mockRepository = new Mock<IPatientRepository>();
            mockRepository.Setup(x => x.GetAllByLastName(lastname)).Returns(expected);
            PatientService patientService = new PatientService(mockRepository.Object);

            List<Patient> patients = patientService.GetAllByLastName(lastname);

            Assert.AreEqual(expected, patients);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidOIB_Failed()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "Ivić", "234567890", DateTime.Now, "ii01234");
        }
    }
}
