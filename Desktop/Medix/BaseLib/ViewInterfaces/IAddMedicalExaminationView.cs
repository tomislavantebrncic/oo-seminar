using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IAddMedicalExaminationView
    {
        bool ShowViewModal();

        string PatientId { get; }
        string PatientFirstName { get; }
        string PatientLastName { get; }
        string PatientOIB { get; }
        string PatientDateOfBirth { get; }
    }
}
