using Business;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IUserDataB iuserDataB;
        public DataController(IUserDataB iuserDataB)
        {
            this.iuserDataB = iuserDataB;
        }
        [HttpPost]
        [Route("EnterData")]
        public IActionResult UserData(DataModel dataModel)
        {
            try
            {
                var result = iuserDataB.DataDetails(dataModel);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Data Registered Is Successful", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Registration Is Not Successful", data = result });
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
