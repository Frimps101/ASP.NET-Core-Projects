using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Interfaces.TblGenTasks
{
    public interface ITblGenTaskServices
    {

        Task<int> CreateGenTask(Domain.Models.TblGenTask tblGenTask);

        Task<IEnumerable<Domain.Models.TblGenTask>> GetGenTasks();

        Task<Domain.Models.TblGenTask> GetGenTask(int id);

        Task<int> DeleteGenTask(int id);

        Task<int> UpdateGenTask(Domain.Models.TblGenTask tblGenTask);
    }
}
