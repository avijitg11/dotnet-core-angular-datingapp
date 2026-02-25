using Dating.Api.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Api.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
