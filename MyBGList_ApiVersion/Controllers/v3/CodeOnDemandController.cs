using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MyBGList_ApiVersion.Controllers.v3
{
    //Add string holder for APi version in URI and specify to which API version this controller is available to (3.0 in this case)
    [Route("v{version:ApiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("3.0")]
    [EnableCors("AnyOrigin_GetOnly")]
    [ResponseCache(NoStore = true)]
    public class CodeOnDemandController : Controller
    {

        [HttpGet]
        public ContentResult Test2(int minutesToAdd)
        {
            return Content("<script>" +
                "window.alert('Your client supports JavaScript!" +
                "\\r\\n\\r\\n" +
                $"Server time (UTC): {DateTime.UtcNow.AddMinutes(minutesToAdd).ToString("o")}" +
                "\\r\\n" +
                "Client time (UTC): ' + new Date().toISOString());" +
                "</script>" +
                "<noscript>Your client does not support JavaScript</noscript>",
                "text/html");
        }
    }
}
