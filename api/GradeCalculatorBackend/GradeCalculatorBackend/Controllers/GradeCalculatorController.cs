using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradeCalculatorBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeCalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("CalculateGrade")]
        public JsonResult CalculateGrade()
        {
            return new JsonResult("Example:Test");
        }
    }
}
