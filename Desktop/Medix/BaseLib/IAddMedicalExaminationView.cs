using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BaseLib
{
    public interface IAddMedicalExaminationView
    {
        bool ShowViewModal(IList<ExaminationType> inTypes);

        string PatientId { get; }
        string PatientFirstName { get; }
        string PatientLastName { get; }
        string PatientOIB { get; }
        string PatientDateOfBirth { get; }
        string Address { get; }
        string City { get; }
        string ZipCode { get; }
        ExaminationType ExaminationType { get; }
        bool Emergency { get; }

        void UpdateInfo(Patient inPatient);
    }
}
