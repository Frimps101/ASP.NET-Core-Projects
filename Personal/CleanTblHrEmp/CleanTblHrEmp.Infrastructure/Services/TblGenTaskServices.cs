using CleanTblHrEmp.Application.Interfaces;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using CleanTblHrEmp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Infrastructure.Services
{
    public class TblGenTaskServices : ITblGenTaskServices
    {
        private readonly IBaseServices _repository;

        public TblGenTaskServices(IBaseServices repository)
        {
            _repository = repository;
        }
        public async Task<int> CreateGenTask(TblGenTask tblGenTask)
        {
            var createData = await _repository.CreateData<TblGenTask>(tblGenTask);
            return 0;
        }

        public async Task<int> DeleteGenTask(int id)
        {
            //var getDataId = _repository.GetData<TblGenTask>(id);
            return await _repository.DeleteData<TblGenTask>(id);
        }

        public async Task<IEnumerable<TblGenTask>> GetGenTasks()
        {
            return await _repository.GetAllData<TblGenTask>();
        }

        public async Task<TblGenTask> GetGenTask(int id)
        {
            return await _repository.GetData<TblGenTask>(id);
        }

        public async Task<int> UpdateGenTask(TblGenTask tblGenTask)
        {
            return await _repository.Update<TblGenTask>(tblGenTask);
        }
    }
}
