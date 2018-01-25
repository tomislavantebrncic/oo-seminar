using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    public class StatisticsService : IStatisticsService
    {
        IMedicalExaminationRepository repository;

        public StatisticsService(IMedicalExaminationRepository repository)
        {
            this.repository = repository;
        }

        public Statistics CalculateStatistics(DateTime date, Doctor doctor)
        {
            var statistics = new Statistics();
            statistics.examinations = repository.GetAllByDateAndExamined(doctor.Id, DateTime.Now);
            statistics.patientCount = statistics.examinations.Count();
            statistics.priceSum = statistics.examinations.Sum(p => p.ExaminationType.Price);
            statistics.doctor = doctor;
            return statistics;
        }
    }
}
