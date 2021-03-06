using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Servicos;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace LocalizaLabzAcademy.Grupo6.WebApi
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

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IUsuarioServicos, UsuarioServicos>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<ILocacaoServicos, LocacaoServicos>();
            services.AddScoped<ILocacaoRepositorio, LocacaoRepositorio>();
            services.AddScoped<IAgenciaRepositorio, AgenciaRepositorio>();
            services.AddScoped<IChecklistRepositorio, ChecklistRepositorio>();
            services.AddScoped<IVeiculoAgenciaRepositorio, VeiculoAgenciaRepositorio>();
            services.AddScoped<IEnderecoUsuarioRepositorio, EnderecoUsuarioRepositorio>();
            services.AddScoped<IRegistroUsuarioRepositorio, RegistroUsuarioRepositorio>();
            services.AddScoped<IMarcaVeiculoRepositorio, MarcaVeiculoRepositorio>();
            services.AddScoped<IModeloVeiculoRepositorio, ModeloVeiculoRepositorio>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LocalizaLabzAcademy.Grupo6.WebApi", Version = "v1" });
            });

            services.AddDbContext<EntityContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefautConection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LocalizaLabzAcademy.Grupo6.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
