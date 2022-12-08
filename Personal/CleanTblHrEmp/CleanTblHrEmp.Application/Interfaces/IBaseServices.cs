using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Interfaces
{
    public interface IBaseServices
    {
        Task<T> GetData<T>(int id) where T:class;
        Task <IEnumerable<T>> GetAllData<T>() where T : class;
        Task<int> CreateData<T>(T entity) where T : class;
        Task<int> DeleteData<T>(int Id) where T : class;
        Task<int> Update<T>(T entity) where T : class;
    }
}
