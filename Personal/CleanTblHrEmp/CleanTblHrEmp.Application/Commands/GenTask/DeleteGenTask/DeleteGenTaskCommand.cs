using AutoMapper;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using MediatR;

namespace CleanTblHrEmp.Application.Commands.GenTask.DeleteGenTask
{
    public class DeleteGenTaskCommand : IRequest<int>
    {
        public int TsklDpk;
    }

    public class DeleteGenTaskCommandHandler : IRequestHandler<DeleteGenTaskCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITblGenTaskServices _repository;

        public DeleteGenTaskCommandHandler(IMapper mapper, ITblGenTaskServices repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public Task<int> Handle(DeleteGenTaskCommand request, CancellationToken cancellationToken)
        {
            return _repository.DeleteGenTask(request.TsklDpk);
        }
    }
}
