using AutoMapper;
using CleanTblHrEmp.Application.Dtos;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;

namespace CleanTblHrEmp.Application.Commands.HrEmp.CreateHrEmp
{
    public class CreateHrEmpCommand : IRequest<int>
    {
        public TblHrEmpDto tblHrEmpDto { get; set; }
    }
    public class CreateHrEmpCommandHandler : IRequestHandler<CreateHrEmpCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITblHrEmpServices _repository;

        public CreateHrEmpCommandHandler(IMapper mapper, ITblHrEmpServices Repository)
        {
            _mapper = mapper;
            _repository = Repository;
        }
        public async Task<int> Handle(CreateHrEmpCommand request, CancellationToken cancellationToken)
        {
            var NewDto = request.tblHrEmpDto;
            var NewModel = new TblHrEmp();
            var EstablishMapper = _mapper.Map(NewDto, NewModel);
            var SendToRepository = await _repository.CreateTblHrEmp(EstablishMapper);
            return SendToRepository;
        }
    }
}
