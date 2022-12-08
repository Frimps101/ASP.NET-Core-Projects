using AutoMapper;
using CleanTblHrEmp.Application.Dtos;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.GenTask.UpdateGenTask
{
    public class UpdateGenTaskCommand : IRequest<int>
    {
        public TblGenTaskDto tblGenTaskDto { get; set; }
        public int TskIdpk;
    }

    public class UpdateGenTaskCommandHandler : IRequestHandler<UpdateGenTaskCommand, int>
    {
        private readonly ITblGenTaskServices _repository;
        private readonly IMapper _mapper;

        public UpdateGenTaskCommandHandler(ITblGenTaskServices repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateGenTaskCommand request, CancellationToken cancellationToken)
        {
            var MainModel = request.tblGenTaskDto;
            var NewModel = new TblGenTask();
            var Mapping = _mapper.Map(MainModel, NewModel);
            var SendDataToRepo = await _repository.UpdateGenTask(Mapping);
            return SendDataToRepo;
        }
    }
}
