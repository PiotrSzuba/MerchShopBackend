using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController()
        {

        }

        [HttpPost]
        public async Task<ActionResult<JsonResult>> LoginTask()
        {
            return null;
        }
    }
}
