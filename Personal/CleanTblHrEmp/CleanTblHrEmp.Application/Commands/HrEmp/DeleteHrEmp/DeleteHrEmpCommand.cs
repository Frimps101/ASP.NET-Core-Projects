using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.HrEmp.DeleteHrEmp
{
    public class DeleteHrEmpCommand : IRequest<int>
    {
        public int EmpkId;
    }

    public class DeleteHrEmpCommandHandler : IRequestHandler<DeleteHrEmpCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITblHrEmpServices _repository;

        public DeleteHrEmpCommandHandler(IMapper mapper, ITblHrEmpServices repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public Task<int> Handle(DeleteHrEmpCommand request, CancellationToken cancellationToken)
        {
            return _repository.DeleteHrEmp(request.EmpkId);
        }
    }
}
