using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Repositories;
using Moq;

namespace Tests
{
    [TestClass]
    public class MedicalExaminationTests
    {
        [TestMethod]
        public void Add_MedicalExamination_Doctor()
        {
            var waitingRoom = new Mock<WaitingRoom>();
            Doctor doctor = new Doctor("Ante", "Antić", "54372816532", DateTime.Now, "ia54372", "1234", waitingRoom.Object);
            LoggedIn.Initialize(doctor);
            var mockPatient = new Mock<Patient>();
            var mockExaminationType = new Mock<ExaminationType>();
            var examination = new MedicalExamination();
            var medicalExaminationRepository = new Mock<IMedicalExaminationRepository>();
            medicalExaminationRepository.Setup(x => x.Add(examination)).Returns(examination);
            MedicalExaminationService medicalExaminationService = new MedicalExaminationService(medicalExaminationRepository.Object);

            var ex = medicalExaminationService.Add(mockPatient.Object, mockExaminationType.Object, false);

            medicalExaminationRepository.Verify(x => x.Add(ex), Times.Once());
            Assert.AreEqual(doctor, ex.Doctor);
        }

        [TestMethod]
        public void Add_MedicalExamination_Nurse()
        {
            var waitingRoom = new Mock<WaitingRoom>();
            Doctor doctor = new Doctor("Ante", "Antić", "54372816532", DateTime.Now, "ia54372", "1234", waitingRoom.Object);
            waitingRoom.Setup(x => x.Doctor).Returns(doctor);
            Nurse nurse = new Nurse("Iva", "Antić", "54343816532", DateTime.Now, "ia54348", "1234", waitingRoom.Object);
            LoggedIn.Initialize(nurse);
            var mockPatient = new Mock<Patient>();
            var mockExaminationType = new Mock<ExaminationType>();
            var examination = new MedicalExamination();
            var medicalExaminationRepository = new Mock<IMedicalExaminationRepository>();
            medicalExaminationRepository.Setup(x => x.Add(examination)).Returns(examination);
            MedicalExaminationService medicalExaminationService = new MedicalExaminationService(medicalExaminationRepository.Object);

            var ex = medicalExaminationService.Add(mockPatient.Object, mockExaminationType.Object, false);

            medicalExaminationRepository.Verify(x => x.Add(ex), Times.Once());
            Assert.AreNotEqual(nurse, ex.Doctor);
            Assert.AreEqual(doctor, ex.Doctor);
        }
    }
}
