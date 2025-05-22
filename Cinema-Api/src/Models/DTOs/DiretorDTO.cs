namespace Cinema_Api.src.Models.DTOs;

public class DiretorDTO(string nome, DateOnly dataNascimento, string? biografia)
{
	public string Nome { get; set; } = nome;

	public DateOnly DataNascimento { get; set; } = dataNascimento;

	public string? Biografia { get; } = biografia;
}
