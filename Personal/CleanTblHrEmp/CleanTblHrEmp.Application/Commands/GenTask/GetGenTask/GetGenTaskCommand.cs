using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.GenTask.GetGenTask
{
    public class GetGenTaskCommand : IRequest<TblGenTask>
    {
        public int Id;
    }

    public class GetGenTaskCommandHandler : IRequestHandler<GetGenTaskCommand, TblGenTask>
    {
        private readonly ITblGenTaskServices _repository;
        private readonly IMapper _mapper;

        public GetGenTaskCommandHandler(ITblGenTaskServices repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TblGenTask> Handle(GetGenTaskCommand request, CancellationToken cancellationToken)
        {
            return await _repository.GetGenTask(request.Id);
        }
    }
}
