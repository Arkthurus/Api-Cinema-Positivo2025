namespace Cinema_Api.src.Models.DTOs;

public class FilmeDTO(
	string titulo,
	int anoLancamento,
	string sinopse,
	float notaIMDB,
	List<string> generos,
	DiretorDTO diretor
)
{
	public string Titulo { get; set; } = titulo;

	public int AnoLancamento { get; set; } = anoLancamento;

	public string Sinopse { get; set; } = sinopse;

	public float NotaIMDB { get; set; } = notaIMDB;

	DiretorDTO Diretor { get; set; } = diretor;

	public List<string> Generos { get; set; } = generos;
}
