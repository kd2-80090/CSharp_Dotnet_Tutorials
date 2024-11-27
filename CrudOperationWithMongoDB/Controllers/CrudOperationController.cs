using CrudOperationWithMongoDB.Model;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationWithMongoDB.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CrudOperationController : ControllerBase
    {
        private readonly ICrudOperationDL _crudOperationDL;

        public CrudOperationController(ICrudOperationDL crudOperationDL)
        {
            _crudOperationDL = crudOperationDL;
        }

        [HttpPost]
        public async Task<IActionResult> InsertRecord(InsertRecordRequest insertRecordRequest)
        {
            InsertRecordResponse response = new InsertRecordResponse();
            try
            {
                response = await _crudOperationDL.InsertRecord(insertRecordRequest);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecords()
        {
            GetAllRecordResponse response = new GetAllRecordResponse();
            try
            {
                response = await _crudOperationDL.GetAllRecord();
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }

            return Ok(response);
        }
    }
}
