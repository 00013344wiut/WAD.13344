using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WAD._13344.Application
{
	public static class Configurations
	{
		public static IServiceCollection ApplicationServices(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
			});

			return services;
		}
	}
}
