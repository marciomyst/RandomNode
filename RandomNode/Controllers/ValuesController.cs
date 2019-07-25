using Microsoft.AspNetCore.Mvc;

namespace RandomNode.Controllers
{
    [Route("")]
    [ApiController]
    public class NodeNameController : ControllerBase
    {      
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Startup.NodeName;
        }
    }
}
