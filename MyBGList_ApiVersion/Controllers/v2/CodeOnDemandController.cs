using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MyBGList_ApiVersion.Controllers.v2
{
    [Route("v{version:ApiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class CodeOnDemandController : Controller
    {
        [ResponseCache(NoStore = true)]
        [EnableCors("AnyOrigin")]
        [HttpGet(Name = "Test")]
        public ContentResult Test()
        {
            return Content("<script>" +
                "window.alert('Your client supports JavaScript!" +
                "\\r\\n\\r\\n" +
                $"Server time (UTC): {DateTime.UtcNow.ToString("o")}" +
                "\\r\\n" +
                "Client time (UTC): ' + new Date().toISOString());" +
                "</script>" +
                "<noscript>Your client does not support JavaScript</noscript>",
                "text/html");
        }
        [ResponseCache(NoStore = true)]
        [EnableCors("AnyOrigin")]
        [HttpGet(Name = "Test2")]
        public ContentResult Test2(int? addMinutes = null)
        {
            var datetime = DateTime.UtcNow;
            if (addMinutes.HasValue)
                datetime.AddMinutes(addMinutes.Value);

            return Content("<script>" +
                "window.alert('Your client supports JavaScript!" +
                "\\r\\n\\r\\n" +
                $"Server time (UTC): {DateTime.UtcNow.ToString("o")}" +
                "\\r\\n" +
                "Client time (UTC): ' + new Date().toISOString());" +
                "</script>" +
                "<noscript>Your client does not support JavaScript</noscript>",
                "text/html");
        }
    }
}
