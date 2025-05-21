using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Api.src.Models;

public class Filme(int id, string titulo, int anoLancamento, string sinopse, float notaIMDB)
{
	public int Id { get; set; } = id;

	public string Titulo { get; set; } = titulo;

	public int AnoLancamento { get; set; } = anoLancamento;

	public string Sinopse { get; set; } = sinopse;

	public float NotaIMDB { get; set; } = notaIMDB;
}
