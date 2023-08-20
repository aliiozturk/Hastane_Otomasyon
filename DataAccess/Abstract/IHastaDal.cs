using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHastaDal
    {
        List<Hasta> GetAllPatients();
        Hasta GetPatientById(int id);
        Dictionary<string, int> GetPatientCountByDoctor();
        Dictionary<string, int> GetPatientCountByBranch();
        List<Hasta> GetPatientsByDoctorId(int doctorId);

        void Add(Hasta hasta);
        void UpdatePatient(Hasta hasta);
        void Delete(int id);
        bool CheckIfIdExistsPatient(int idToCheck);


    }
}
