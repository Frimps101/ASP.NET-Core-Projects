using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.HrEmp.GetAllHrEmp
{
    public class GetAllHrEmpCommand : IRequest<IEnumerable<TblHrEmp>>
    {
        //public TblHrEmpDto HrEmpDto { get;}
    }
    public class GetAllHrEmpCommandHandler : IRequestHandler<GetAllHrEmpCommand, IEnumerable<TblHrEmp>>
    {
        private readonly IMapper _mapper;
        private readonly ITblHrEmpServices _repository;

        public GetAllHrEmpCommandHandler(IMapper mapper, ITblHrEmpServices repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<TblHrEmp>> Handle(GetAllHrEmpCommand request, CancellationToken cancellationToken)
        {
            //var ModelDto = request.HrEmpDto;
            //var MainModel = new TblHrEmp();
            //var mapping = _mapper.Map(ModelDto, MainModel);

            return await _repository.GetHrEmp();
        }
    }
}
