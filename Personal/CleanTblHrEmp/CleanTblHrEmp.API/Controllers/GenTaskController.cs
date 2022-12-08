using CleanTblHrEmp.Application.Commands.GenTask.CreateGenTask;
using CleanTblHrEmp.Application.Commands.GenTask.DeleteGenTask;
using CleanTblHrEmp.Application.Commands.GenTask.GetAllGenTask;
using CleanTblHrEmp.Application.Commands.GenTask.GetGenTask;
using CleanTblHrEmp.Application.Commands.GenTask.UpdateGenTask;
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
    public class GenTaskController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<GenTaskController> _logger;

        public GenTaskController(IMediator mediator, ILogger<GenTaskController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("{ID:int}", Name = ("GetTaskByID"))]
        public async Task<IActionResult> GetTaskByID([FromRoute] int ID)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            var getData = await _mediator.Send(new GetGenTaskCommand { Id = ID });
            if (getData == null)
            {

                return NotFound($"no data found with ID: {ID}. enter a valid ID");
            }
            return Ok(getData);

        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateGenTask([FromBody] TblGenTaskDto tblGenTaskDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var CreateDataMediatR = await _mediator.Send(new CreateGenTaskCommand { tblGenTaskDto = tblGenTaskDto });
                return Ok(CreateDataMediatR);
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Create General Task");
                return null;
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenTasks()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                var GetDataMediatR = await _mediator.Send(new GetAllGenTaskCommand());
                return Ok(GetDataMediatR);
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to get all Data");
                return null;
            }
        }

        [HttpDelete("{TsklDpk:int}")]
        public async Task<int> DeleteGenTask([FromRoute] int TsklDpk)
        {

            try
            {
                var DeleteData = await _mediator.Send(new DeleteGenTaskCommand { TsklDpk = TsklDpk });
                _logger.LogError(message: "Data Deleted");
                return DeleteData;
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Delete!.");
                return 0;
            }

        }

        [HttpPut("{TsklDpk:int}")]
        public async Task<int> UpdateGenTask([FromRoute, FromBody] int TsklDpk, TblGenTaskDto updateGenTaskDto)
        {
            try
            {
                var UpdateData = await _mediator.Send(new UpdateGenTaskCommand { TskIdpk = TsklDpk, tblGenTaskDto = updateGenTaskDto });
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
