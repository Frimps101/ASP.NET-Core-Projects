using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.HrEmp.GetHrEmp
{
    public class GetHrEmpCommand : IRequest<TblHrEmp>
    {
        public int Id;
    }

    public class GetHrEmpCommandHandler : IRequestHandler<GetHrEmpCommand, TblHrEmp>
    {
        private readonly ITblHrEmpServices _repository;
        private readonly IMapper _mapper;

        public GetHrEmpCommandHandler(ITblHrEmpServices repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TblHrEmp> Handle(GetHrEmpCommand request, CancellationToken cancellationToken)
        {
            return await _repository.GetHrEmpByID(request.Id);
        }
    }
}
