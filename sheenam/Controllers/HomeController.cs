using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace sheenam.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : RESTFulController
{
  [HttpGet]
  public ActionResult<string> Get() => Ok("Hammasi nazoratim ostida");
}
