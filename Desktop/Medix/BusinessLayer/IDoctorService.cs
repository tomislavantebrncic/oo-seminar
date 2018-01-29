using Model;

namespace BusinessLayer
{
    public interface IDoctorService : IService<Doctor, int>
    {
        Doctor GetDoctorWithIdAndPassword(string id, string password);
        Doctor GetByEmployeeId(string employeeId);
    }
}
