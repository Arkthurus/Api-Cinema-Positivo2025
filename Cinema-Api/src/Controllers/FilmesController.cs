using Cinema_Api.src.Context;
using Cinema_Api.src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class FilmesController(MasterContext masterContext) : ControllerBase
{
	private readonly MasterContext masterContext = masterContext;

	public MasterContext MasterContext => masterContext;

	[HttpGet]
	public ActionResult AllFilmes()
	{
		var filmes = MasterContext
			.Filme.Include(f => f.FilmesGeneros)
			.ThenInclude(fg => fg.Genero)
			.Select(f => new
			{
				f.Id,
				f.Titulo,
				f.AnoLancamento,
				f.Sinopse,
				f.NotaIMDB,
				Generos = f.FilmesGeneros.Select(fg => fg.Genero.Nome).ToList(),
			})
			.ToListAsync();

		return Ok(filmes);
	}
}
