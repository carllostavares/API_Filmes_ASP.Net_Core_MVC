

using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FilmesAPI.Data;

public class FIlmeContext : DbContext
{
    public FIlmeContext(DbContextOptions<FIlmeContext> opts) : base(opts)
    {
       
    }

    public DbSet<Filme> Filmes { get; set; }
}
