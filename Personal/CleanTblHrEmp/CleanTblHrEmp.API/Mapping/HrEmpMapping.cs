using AutoMapper;
using CleanTblHrEmp.Application.Dtos;
using CleanTblHrEmp.Domain.Models;

namespace CleanTblHrEmp.API.Mapping
{
    public class HrEmpMapping:Profile
    {
        public HrEmpMapping()
        {
            CreateMap<TblHrEmpDto, TblHrEmp >();

        }
    }
}
