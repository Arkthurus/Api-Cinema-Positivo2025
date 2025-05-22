using Cinema_Api.src.Models;
using Cinema_Api.src.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class FilmesController(FilmesService service) : ControllerBase
{
	private FilmesService FilmesService { get; } = service;

	[HttpGet]
	public ActionResult<List<Filme>> AllFilmes()
	{
		var filmes = FilmesService.AllFilmes();

		return Ok(filmes);
	}

	[HttpGet("{id}")]
	public ActionResult<Filme> SingleFilme(int id)
	{
		var filme = FilmesService.SingleFilme(id);

		return Ok(filme);
	}
}
