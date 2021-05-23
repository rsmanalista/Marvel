using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Smarkets.Marvel.ApiExtensions;
using Smarkets.Marvel.Infra.IoC;

namespace Smarkets.Marvel.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Smarkets Marvel Api", Version = "v1" });
			});

			services.AddAutoMapperSetup();
			BootStrapper.RegisterServices(services, Configuration);

			services
				.AddCors(o => o.AddPolicy("MyPolicy", builder =>
				{
					builder
						   .WithOrigins("http://localhost:4200")
						   .AllowAnyMethod()
						   .AllowAnyHeader()
						   .AllowCredentials();
				}));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Smarkets.Marvel.Api v1"));
			}
			else
			{
				app.UseHttpsRedirection();
			}	

			app.UseRouting();
			app.UseCors("MyPolicy");
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
