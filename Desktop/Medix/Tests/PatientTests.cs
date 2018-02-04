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
    public class PatientTests
    { 

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
        public void AddPatient()
        {
            Patient patient = new Patient("Ivo", "Ivić", "23456117890", DateTime.Now, "ii01234");

            var mockRepository = new Mock<IPatientRepository>();
            mockRepository.Setup(x => x.Add(It.IsAny<Patient>())).Returns(patient);
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "Ivić", "23456117890", DateTime.Now, "ii01234");

            mockRepository.Verify(x => x.Add(patient), Times.Once());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidOIB1()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "Ivić", "234567890", DateTime.Now, "ii01234");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidOIB2()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "Ivić", "23R456a7890", DateTime.Now, "ii01234");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidFirstName()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("I4vo", "Ivić", "23456789101", DateTime.Now, "ii01234");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidLastName()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "I32vić", "23456789101", DateTime.Now, "ii01234");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddPatient_WithInvalidDate()
        {
            var mockRepository = new Mock<IPatientRepository>();
            PatientService patientService = new PatientService(mockRepository.Object);
            patientService.Add("Ivo", "Ivić", "23456789101", DateTime.Now.AddDays(2), "ii01234");
        }
    }
}