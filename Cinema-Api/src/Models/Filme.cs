namespace Cinema_Api.src.Models;

public class Filme(string titulo, int anoLancamento, string sinopse, string posterURLs, float nota)
{

	public string Titulo { get; set; } = titulo;

	public int AnoLancamento { get; set; } = anoLancamento;

	public string Sinopse { get; set; } = sinopse;

	public string PosterURLs { get; set; } = posterURLs;

	public float NotaIMDB { get; set; } = nota;
	
}