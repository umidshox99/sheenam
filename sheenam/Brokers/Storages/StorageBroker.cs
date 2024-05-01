using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace sheenam.Brokers.Storages;

public class StorageBroker : EFxceptionsContext
{
  private readonly IConfiguration configuration;

  protected StorageBroker(IConfiguration configuration)
  {
    this.configuration = configuration;
    // this.Database
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    string connectionString = configuration.GetConnectionString(name: "DefaultConnection");
    // optionsBuilder
  }
}
