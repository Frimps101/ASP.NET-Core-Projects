using CleanTblHrEmp.Application.Interfaces;
using CleanTblHrEmp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Infrastructure.Services
{
    public class BaseServices : IBaseServices
    {
        private readonly DbInnoxContext _dbInnoxContext;

        public BaseServices(DbInnoxContext dbInnoxContext)
        {
            _dbInnoxContext = dbInnoxContext;
        }
        public async Task<int> CreateData<T>(T entity) where T : class
        {
            var addData = await _dbInnoxContext.AddAsync<T>(entity);
            await _dbInnoxContext.SaveChangesAsync();
            return 0;
        }

        public async Task<int> DeleteData<T>(int Id) where T : class
        {
            var searchData = await _dbInnoxContext.FindAsync<T>(Id);
            if(searchData != null)
            {
                _dbInnoxContext.Remove(searchData);
                await _dbInnoxContext.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<T>> GetAllData<T>() where T : class
        {
            var dataList = await _dbInnoxContext.TblHrEmps.ToListAsync();
            return (IEnumerable<T>)dataList;
        }

        public async Task<T> GetData<T>(int id) where T : class
        {
            var findData = await _dbInnoxContext.FindAsync<T>(id);
            if(id == null)
            {
                return null;
            }
            return findData;
        }

        public async Task<int> Update<T>(T entity) where T : class
        {
            _dbInnoxContext.Update<T>(entity);
            return await _dbInnoxContext.SaveChangesAsync();
            
        }
    }
}
