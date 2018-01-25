using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IPatientController : IBaseController
    {
        IList<Patient> SearchPatients(string inLastName);
        void ViewSelectPatient(ISelectPatientView inForm);
        void UpdateAddMedicalExaminationPatient(Patient inPatient);
    }
}
