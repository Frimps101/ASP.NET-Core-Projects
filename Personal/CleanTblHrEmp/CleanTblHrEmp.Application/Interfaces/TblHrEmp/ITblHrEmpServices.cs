using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Interfaces.TblHrEmp
{
    public interface ITblHrEmpServices
    {

        Task<int> CreateTblHrEmp(Domain.Models.TblHrEmp tblHrEmp);

        Task<IEnumerable<Domain.Models.TblHrEmp>> GetHrEmp();

        Task<Domain.Models.TblHrEmp> GetHrEmpByID(int id);

        Task<int> DeleteHrEmp(int id);

        Task<int> UpdateHrEmp(Domain.Models.TblHrEmp tblHrEmp);
    }
}
