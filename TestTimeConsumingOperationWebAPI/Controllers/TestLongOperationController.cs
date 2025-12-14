using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTimeConsumingOperationWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestLongOperationController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(5000); //Representing a long operation

            return Content("Web API Long Operation Completed");

        }

    }
}
