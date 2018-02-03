using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Tests
{
    [TestClass]
    public class StatisticsTest
    {
        [TestMethod]
        public void Calculate_Sum()
        {
            Doctor d = new Doctor();

            Patient p1 = new Patient("Ivo", "Ivić", "01234567890", DateTime.Now, "ii01234");
            Patient p2 = new Patient("Filip", "Filipović", "01234567891", DateTime.Now, "ff01234");

            ExaminationType t1 = new ExaminationType("EKG", 100);
            ExaminationType t2 = new ExaminationType("holter", 132);

            MedicalExamination e1 = new MedicalExamination(d, p1, DateTime.Now, t1);
            MedicalExamination e2 = new MedicalExamination(d, p2, DateTime.Now, t1);
            MedicalExamination e3 = new MedicalExamination(d, p1, DateTime.Now, t2);
            List<MedicalExamination> examinations = new List<MedicalExamination>();
            examinations.Add(e1);
            examinations.Add(e2);
            examinations.Add(e3);

            Statistics stat = new Statistics(examinations);

            stat.Calculate();

            Assert.AreEqual(332, stat.priceSum);
            Assert.AreEqual(2, stat.patientCount);
        }
    }
}
