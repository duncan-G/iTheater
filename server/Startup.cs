using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Server.Helpers;
using Server.Models;
using Server.Services;

namespace Server {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddCors ();
            services.AddDbContext<DataContext> (opts =>
                opts.UseMySql (Configuration.GetConnectionString ("DefaultConnection")));
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2);

            // Configure AutoMapper to map DTOs to Entities
            services.AddAutoMapper ();

            // Configure JWT
            var appSettingsSection = Configuration.GetSection ("AppSettings");
            // Ensure AppSettings is correctly typed
            services.Configure<AppSettings> (appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings> ();

            var jwtSecret = Encoding.ASCII.GetBytes (appSettings.JwtSecret);
            services.AddAuthentication (opts => {
                    opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer (opts => {
                    opts.Events = new JwtBearerEvents {
                        OnTokenValidated = context => {
                            var dataContext = context.HttpContext.RequestServices.GetRequiredService<DataContext> ();
                            var userId = int.Parse (context.Principal.Identity.Name);
                            var user = dataContext.Users.Find (userId);
                            System.Console.WriteLine (userId);
                            if (user == null) {
                                context.Fail ("Unauthorized");
                            }

                            return Task.CompletedTask;
                        }
                    };
                    opts.RequireHttpsMetadata = false;
                    opts.SaveToken = true;
                    opts.TokenValidationParameters = new TokenValidationParameters {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey (jwtSecret),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
                
            // configure DI for application services
            services.AddScoped<IUserService, UserService> ();
            services.AddScoped<IMovieListService, MovieListService> ();
            services.AddScoped<IMovieService, MovieService> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseCors (opts => opts
                .AllowAnyOrigin ()
                .AllowAnyMethod ()
                .AllowAnyHeader ());

            app.UseAuthentication ();
            app.UseHttpsRedirection ();
            app.UseMvc ();
        }
    }
}