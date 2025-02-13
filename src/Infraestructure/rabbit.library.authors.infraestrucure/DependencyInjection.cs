using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rabbit.library.authors.application.Data;
using rabbit.library.authors.infraestrucure.Persistence;

namespace rabbit.library.authors.infraestrucure;
public static class DependencyInjection
{
  public static IServiceCollection AddInfraestructureService
  (
    this IServiceCollection services,
    IConfiguration configuration
  )
  {
    services.AddDbContext<ApplicationDbContext>(optiosn =>
    {
      optiosn.UseSqlServer(configuration.GetConnectionString("Database"));
    });

    services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

    return services;
  }
}