namespace Cinema_Api.src.Models.DTOs;

public class AtorDTO(
	string nome,
	DateOnly dataNasc,
	List<FilmeDTO> Filmes
)
{
	public string nome { get; set; } = nome;

	public DateOnly dataNasc { get; set; } = dataNasc;
	public List<FilmeDTO> Filmes { get; set; } = Filmes;
}
