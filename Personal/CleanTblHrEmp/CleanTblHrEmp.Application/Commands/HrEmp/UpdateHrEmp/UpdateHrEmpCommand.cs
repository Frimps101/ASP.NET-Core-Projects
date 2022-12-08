using AutoMapper;
using CleanTblHrEmp.Application.Dtos;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.HrEmp.UpdateHrEmp
{
    public class UpdateHrEmpCommand : IRequest<int>
    {
        public TblHrEmpDto tblHrEmpDto { get; set; }
        public int EmpkId;
    }

    public class UpdateHrEmpCommandHandler : IRequestHandler<UpdateHrEmpCommand, int>
    {
        private readonly ITblHrEmpServices _repository;
        private readonly IMapper _mapper;

        public UpdateHrEmpCommandHandler(ITblHrEmpServices repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateHrEmpCommand request, CancellationToken cancellationToken)
        {
            var MainModel = request.tblHrEmpDto;
            var NewModel = new TblHrEmp();
            var Mapping = _mapper.Map(MainModel, NewModel);
            var SendDataToRepo = await _repository.UpdateHrEmp(Mapping);
            return SendDataToRepo;
        }
    }
}
