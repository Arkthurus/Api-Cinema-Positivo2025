using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Api.src.Controllers;

[ApiController]
[Route("api/v1/teste")]
public class TestController : ControllerBase {

	[HttpGet]
	public ActionResult<string> Teste() {
		return Ok("Funciona!");
	}

}