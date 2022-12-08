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

namespace CleanTblHrEmp.Application.Commands.GenTask.CreateGenTask
{
    public class CreateGenTaskCommand : IRequest<int>
    {
        public TblGenTaskDto tblGenTaskDto { get; set; }
    }
    public class CreateGenTaskCommandHandler : IRequestHandler<CreateGenTaskCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITblGenTaskServices _repository;

        public CreateGenTaskCommandHandler(IMapper mapper, ITblGenTaskServices Repository)
        {
            _mapper = mapper;
            _repository = Repository;
        }
        public async Task<int> Handle(CreateGenTaskCommand request, CancellationToken cancellationToken)
        {
            var NewDto = request.tblGenTaskDto;
            var NewModel = new TblGenTask();
            var EstablishMapper = _mapper.Map(NewDto, NewModel);
            var SendToRepository = await _repository.CreateGenTask(EstablishMapper);
            return SendToRepository;
        }
    }
}
