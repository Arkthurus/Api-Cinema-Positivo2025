using Cinema_Api.src.Context;
using Cinema_Api.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Api.src.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class FilmesController(FilmeContext filmeContext) : ControllerBase
{
	private readonly FilmeContext _filmeContext = filmeContext;

	[HttpGet]
	public ActionResult AllFilmes()
	{
		List<Filme> filmes = [.. _filmeContext.Filme];
		return Ok(filmes);
	}
}
