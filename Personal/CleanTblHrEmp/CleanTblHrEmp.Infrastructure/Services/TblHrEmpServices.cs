using CleanTblHrEmp.Application.Interfaces;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Infrastructure.Services
{
    public class TblHrEmpServices : ITblHrEmpServices
    {
        private readonly IBaseServices _repository;

        public TblHrEmpServices(IBaseServices repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateTblHrEmp(TblHrEmp tblHrEmp)
        {
           var createData = await _repository.CreateData(tblHrEmp);
            return 0;
        }

        public async Task<int> DeleteHrEmp(int id)
        {
            //var searchData = await _repository.GetData<TblHrEmp>(id);
            return await _repository.DeleteData<TblHrEmp>(id);
        }

        public async Task<IEnumerable<TblHrEmp>> GetHrEmp()
        {
            return await _repository.GetAllData<TblHrEmp>();
        }

        public async Task<TblHrEmp> GetHrEmpByID(int id)
        {
            return await _repository.GetData<TblHrEmp>(id);
        }

        public async Task<int> UpdateHrEmp(TblHrEmp tblHrEmp)
        {
            return await _repository.Update<TblHrEmp>(tblHrEmp);
        }
    }
}
