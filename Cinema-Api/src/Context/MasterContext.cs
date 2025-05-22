using Cinema_Api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.src.Context;

public class MasterContext : DbContext
{
	public DbSet<Filme> Filme { get; set; }

	public DbSet<Genero> Genero { get; set; }

	public DbSet<FilmeGenero> FilmeGenero { get; set; }

	public MasterContext(DbContextOptions options)
		: base(options) { }

	protected MasterContext() { }
}
