using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Etudiant.Models;
using Etudiant.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Etudiant
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // CORS config
            services.AddCors(options => options.AddPolicy("AllowCors",
              builder =>
              {
                  builder
                  .AllowAnyMethod()
                  .AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowCredentials();
              }));

            // Custome DI's
            services.AddScoped<InitMigrations>();
            services.AddScoped<SessionManager>();
            services.AddScoped<FileManager>();

            var sessionManager = new SessionManager();

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(sessionManager.salt),
                    ValidIssuer = sessionManager.Issuer,
                    ValidAudience = sessionManager.Audiance,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true
                };
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<EtudiantContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Migrate database if available
            var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var initMigrations = serviceScope.ServiceProvider.GetRequiredService<InitMigrations>();
            initMigrations.MigrateDatabase();

            // Allow Cores
            app.UseCors("AllowCors");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
