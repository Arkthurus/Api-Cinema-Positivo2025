namespace Cinema_Api.src.Models.DTOs;

public class AvaliacaoDTO(
	string autor,
	float estrelas,
	string resenha,
	List<FilmeDTO> Filmes
)
{
	public string autor { get; set; } = autor;

	public float estrelas { get; set; } = estrelas;

	public string resenha { get; set; } = resenha;

	public List<FilmeDTO> Filmes { get; set; } = Filmes;
}
