using Cinema_Api.src.Context;
using Cinema_Api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Service;

public class FilmesService(MasterContext masterContext)
{
	private readonly MasterContext _masterContext = masterContext;

	public List<dynamic> AllFilmes()
	{
		var filmes = _masterContext
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
			.ToList<dynamic>();

		return filmes;
	}

	public dynamic SingleFilme(int id)
	{
		var filme = _masterContext
			.Filme.Include(f => f.FilmesGeneros)
			.ThenInclude(fg => fg.Genero)
			.Where(f => f.Id == id)
			.Select(f => new
			{
				f.Id,
				f.Titulo,
				f.AnoLancamento,
				f.Sinopse,
				f.NotaIMDB,
				Generos = f.FilmesGeneros.Select(fg => fg.Genero.Nome).ToList(),
			});

		return filme;
	}
}
