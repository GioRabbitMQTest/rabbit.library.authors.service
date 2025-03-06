using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rabbit.framework.messaging.MassTransit;
using System.Reflection;

namespace rabbit.library.authors.application;
public static class DependencyInjection
{
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddMediatR(config =>
    {
      config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    });

    services.AddAutoMapper(Assembly.GetExecutingAssembly());

    //ADD RABBITMQ CONFIG
    services.AddMessageBroker(configuration, Assembly.GetExecutingAssembly());

    return services;
  }
}