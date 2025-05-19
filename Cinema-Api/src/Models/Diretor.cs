namespace Cinema_Api.src.Models;

public class Diretor(int id, string nome, string dataNascimento, string biografia)
{

    public int Id { get; set; } = id;

    public string Nome { get; set; } = nome;

    public string DataNascimento { get; set; } = dataNascimento;

    public string Biografia { get; set; } = biografia;
    
}