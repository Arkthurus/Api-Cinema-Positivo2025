using Cinema_Api.src.Context;
using Cinema_Api.src.Models;
using Cinema_Api.src.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Service;

public class FilmesService(MasterContext masterContext, GeneroService generoService)
{
	private readonly MasterContext _masterContext = masterContext;
	private readonly GeneroService _generoService = generoService;

	public List<FilmeDTO> AllFilmes()
	{
		var filmes = _masterContext
			.Filme.Include(f => f.FilmesGeneros)
			.ThenInclude(fg => fg.Genero)
			.Select(f => new FilmeDTO(
				f.Titulo,
				f.AnoLancamento,
				f.Sinopse,
				f.NotaIMDB,
				f.FilmesGeneros.Select(fg => fg.Genero.Nome).ToList(),
				new DiretorDTO { Nome = "", DataNascimento = "" }
			))
			.ToList();

		return filmes;
	}

	public FilmeDTO? SingleFilme(int id)
	{
		var filme = _masterContext
			.Filme.Include(f => f.FilmesGeneros)
			.ThenInclude(fg => fg.Genero)
			.Where(f => f.Id == id)
			.Select(f => new FilmeDTO(
				f.Titulo,
				f.AnoLancamento,
				f.Sinopse,
				f.NotaIMDB,
				f.FilmesGeneros.Select(fg => fg.Genero.Nome).ToList()
			))
			.FirstOrDefault();

		return filme;
	}

	public Filme? NovoFilme(FilmeDTO filmeDto)
	{
		foreach (string dtoGenero in filmeDto.Generos)
		{
			_generoService.NovoGenero(dtoGenero);
		}

		// Verifica se um filme com mesmo título e
		// ano de lançamento já existe no banco de dados
		var existe = masterContext
			.Filme.Where(filmeBd =>
				filmeBd.Titulo.ToLower().Equals(filmeDto.Titulo.ToLower())
				&& filmeBd.AnoLancamento == filmeDto.AnoLancamento
			)
			.Any();

		if (existe)
		{
			return null;
		}

		var filme = new Filme
		{
			Titulo = filmeDto.Titulo,
			Sinopse = filmeDto.Sinopse,
			NotaIMDB = filmeDto.NotaIMDB,
			AnoLancamento = filmeDto.AnoLancamento,
		};

		_masterContext.Filme.Add(filme);
		_masterContext.SaveChanges();

		return filme;
	}
}
