using Cinema_Api.src.Context;
using Cinema_Api.src.Models;
using Cinema_Api.src.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;

namespace Cinema_Api.src.Service;

public class AtoresService(MasterContext masterContext, FilmesService filmesService)
{
	private readonly MasterContext _masterContext = masterContext;

	private readonly FilmesService _filmesService = filmesService;

	public List<AtorDTO> AllAtores()
	{
		var atores = _masterContext
					.Ator.Include(a => a.FilmeAtor)
					.ThenInclude(af => af.Filme)
					.Select(a => new AtorDTO(
						a.Nome,
						a.DataNascimento,
						a.FilmeAtor.Select(af => new FilmeDTO(af.Filme.Titulo,
															  af.Filme.AnoLancamento
															  af.Filme.Sinopse,
															  af.Filme.NotaIMDB,
															  af.Filme.FilmesGeneros)).ToList()
					))
					.ToList();
					return atores;
	}
}