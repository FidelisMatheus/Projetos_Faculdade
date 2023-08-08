using GerenciadorDeTarefas.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

using System.Text;
using GerenciadorDeTarefas.Repository;
using GerenciadorDeTarefas.Repository.Impl;

namespace GerenciadorDeTarefas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public string JwtBearerDefault { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GerenciadorDeTarefasContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers(); //adicionar controladores - configura os serviços mvc para as apis - escaneia os arquivos para encontra controllers
            services.AddSwaggerGen(c => //criar documentação do swagger
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GerenciadorDeTarefas", Version = "v1" });
            });
            //a partir daqui

            var chaveCriptografiaEmBytes = Encoding.ASCII.GetBytes(ChaveJWT.ChaveSecreta);
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; //desafio para quebrar a criptografia
            }).AddJwtBearer(auth =>
            {
                auth.RequireHttpsMetadata = false;
                auth.SaveToken = true;
                auth.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(chaveCriptografiaEmBytes),
                    ValidateIssuer = false, //se vai expirar
                    ValidateAudience = false //se alguem que logou é um admin
                };
            });

            //ferramenta para liberar e bloquear certas fontes de entrada - bloquear alguma requisicao http
            //podemos bloquear o acesso de fontes não confiaveis
            services.AddCors();

            services.AddScoped<IUsuarioRepository, UsuarioRepositoryImpl>(); //faz um singleton
            services.AddScoped<ITarefaRepository, TarefaRepositoryImpl>(); //faz um singleton
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //configura o servidor
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GerenciadorDeTarefas v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //useCors aqui
            app.UseCors(cors =>
                cors.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            
            //importante colocar que agora nós nos authenticamos
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); //mapear controller
            });
        }
    }
}
