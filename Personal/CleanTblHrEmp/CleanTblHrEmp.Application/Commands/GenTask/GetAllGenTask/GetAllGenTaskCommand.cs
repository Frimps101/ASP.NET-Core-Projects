using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.Commands.GenTask.GetAllGenTask
{
    public class GetAllGenTaskCommand : IRequest<IEnumerable<TblGenTask>>
    {
        //public TblHrEmpDto HrEmpDto { get;}
    }
    public class GetAllGenTaskCommandHandler : IRequestHandler<GetAllGenTaskCommand, IEnumerable<TblGenTask>>
    {
        private readonly IMapper _mapper;
        private readonly ITblGenTaskServices _repository;

        public GetAllGenTaskCommandHandler(IMapper mapper, ITblGenTaskServices repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<TblGenTask>> Handle(GetAllGenTaskCommand request, CancellationToken cancellationToken)
        {
            //var ModelDto = request.HrEmpDto;
            //var MainModel = new TblHrEmp();
            //var mapping = _mapper.Map(ModelDto, MainModel);

            return await _repository.GetGenTasks();
        }
    }
}
