using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Repositories;
using Moq;

namespace Tests
{
    [TestClass]
    public class WaitingRoomTests
    {
        [TestMethod]
        public void Add_WithValidDate_UpdatesExaminations()
        {
            // arrange
            WaitingRoom waitingRoom = new WaitingRoom();
            Doctor doctor = new Doctor();
            Patient patient = new Patient();
            DateTime today = DateTime.Today;
            ExaminationType type = new ExaminationType();
            //bool examined = true;
            //bool emergency = true;
            MedicalExamination medicalExamination = new MedicalExamination(doctor, patient, today, type);

            // act
            waitingRoom.AddExamination(medicalExamination);

            // assert
            Assert.AreEqual(1, waitingRoom.Examinations.Count);
        }
    }
}
