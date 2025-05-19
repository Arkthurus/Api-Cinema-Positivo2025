using System;

namespace Cinema_Api.src.Models;

public class Ator(int id, string nome, DateTime dataNascimento)
{

    public int Id { get; set; } = id;

    public string Nome { get; set; } = nome;

    public DateTime DataNascimento { get; set; } = dataNascimento;
    
}