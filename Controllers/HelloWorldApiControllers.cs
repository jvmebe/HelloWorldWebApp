using Microsoft.AspNetCore.Mvc;
namespace HelloWorldWebApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldApiController : ControllerBase
{
 // GET: api/helloworldapi
 [HttpGet]
 public ActionResult<string> Get()
 {
 return "Hello, World!";
 }
}