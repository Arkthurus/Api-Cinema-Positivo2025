using Cinema_Api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Context;

public class FilmeContext : DbContext
{
	public DbSet<Filme> Filmes { get; set; }

	public FilmeContext(DbContextOptions options)
		: base(options) { }

	protected FilmeContext() { }
}
