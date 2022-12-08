using CleanTblHrEmp.Application.Commands.HrEmp.CreateHrEmp;
using CleanTblHrEmp.Application.Commands.HrEmp.DeleteHrEmp;
using CleanTblHrEmp.Application.Commands.HrEmp.GetAllHrEmp;
using CleanTblHrEmp.Application.Commands.HrEmp.GetHrEmp;
using CleanTblHrEmp.Application.Commands.HrEmp.UpdateHrEmp;
using CleanTblHrEmp.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanTblHrEmp.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class HrEmpController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<HrEmpController> _logger;

        public HrEmpController(IMediator mediator, ILogger<HrEmpController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("{ID:int}", Name = ("GetHrEmpByID"))]
        public async Task<IActionResult> GetHrEmpByID([FromRoute] int ID)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
           
                var getData = await _mediator.Send(new GetHrEmpCommand { Id = ID });
                if (getData == null)
                {

                    return NotFound($"no data found with ID: {ID}. enter a valid ID");
                }
                return Ok(getData);

        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateHrEmp([FromBody] TblHrEmpDto tblHrEmpDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var CreateDataMediatR = await _mediator.Send(new CreateHrEmpCommand { tblHrEmpDto = tblHrEmpDto });
                return Ok(CreateDataMediatR);
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Create Hr Employee");
                return null;
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAllHrEmp()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                var GetDataMediatR = await _mediator.Send(new GetAllHrEmpCommand());
                return Ok(GetDataMediatR);
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to get all Data");
                return null;
            }
        }

        [HttpDelete("{EmpkId:int}")]
        public async Task<int> DeleteHrEmp([FromRoute] int EmpkId)
        {

            try
            {
                var DeleteData = await _mediator.Send(new DeleteHrEmpCommand { EmpkId = EmpkId });
                _logger.LogError(message: "Data Deleted");
                return DeleteData;
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Delete!.");
                return 0;
            }

        }

        [HttpPut("{EmpkId:int}")]
        public async Task<int> UpdateHrEmp([FromRoute, FromBody] int EmpkId, TblHrEmpDto updateHrEmpDto)
        {
            try
            {
                var UpdateData = await _mediator.Send(new UpdateHrEmpCommand { EmpkId = EmpkId, tblHrEmpDto = updateHrEmpDto });
                return UpdateData;
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Update Data");
                return 0;
            }

        }

    }

}
