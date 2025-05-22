namespace Cinema_Api.src.Models.DTOs;

public class GeneroDTO(
	string nome,
	List<FilmeDTO> Filmes
)
{
	public string nome { get; set; } = nome;

	public List<FilmeDTO> Filmes { get; set; } = Filmes;
}
