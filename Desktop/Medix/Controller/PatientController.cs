using BaseLib;
using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PatientController : IPatientController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;

        public PatientController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
        }

        public void ViewSelectPatient(ISelectPatientView inForm)
        {
            inForm.ShowModaless(this);
        }

        public IList<Patient> SearchPatients(string inLastName)
        {
            var patienService = _serviceFactory.createPatientService();

            return patienService.GetAllByLastName(inLastName);
        }

        public void UpdateAddMedicalExaminationPatient(Patient inPatient)
        {
            throw new NotImplementedException();
        }
    }
}
