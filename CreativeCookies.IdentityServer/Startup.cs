// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore.Internal;
using IdentityServer4.EntityFramework.Mappers;
using Microsoft.AspNetCore.Identity;
using CreativeCookies.IdSrv;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CreativeCookies.IdSrv.Services;
using CreativeCookies.IdSrv.Quickstart.Account;

namespace CreativeCookies.IdentityServer
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        private readonly IConfiguration _configuration;
        private string connectionString;

        public Startup(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            connectionString = _configuration.GetConnectionString("SqlServer");
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().ToString();

            services.AddDbContext<CCIdentityDbContext>(
                options => options.UseSqlServer(
                    connectionString, sqlOptions => sqlOptions.MigrationsAssembly(migrationsAssembly)));

            services.AddIdentityCore<IdentityUser>();

            services.AddScoped<IUserStore<IdentityUser>, UserOnlyStore<IdentityUser, CCIdentityDbContext>>();

            services.AddSingleton<IMailService, MailService>();
            //services.AddSingleton<>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", corsBuilder =>
                {
                    corsBuilder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(origin => origin == "https://localhost:44370")
                    .AllowCredentials();
                });
            });

            services.AddControllersWithViews();

            // configures IIS out-of-proc settings (see https://github.com/aspnet/AspNetCore/issues/14882)
            services.Configure<IISOptions>(iis =>
            {
                iis.AuthenticationDisplayName = "Windows";
                iis.AutomaticAuthentication = false;
            });

            // configures IIS in-proc settings
            services.Configure<IISServerOptions>(iis =>
            {
                iis.AuthenticationDisplayName = "Windows";
                iis.AutomaticAuthentication = false;
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<CCIdentityDbContext>()
                .AddDefaultTokenProviders();

            var builder = services.AddIdentityServer(options =>
            {
                options.Authentication.CookieLifetime = new TimeSpan(0, 15, 0);
            })
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = builder => builder
                        .UseSqlServer(connectionString, options => options.MigrationsAssembly(migrationsAssembly));
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = builder => builder
                        .UseSqlServer(connectionString, options => options.MigrationsAssembly(migrationsAssembly));
                })
                .AddAspNetIdentity<IdentityUser>();

            if (Environment.IsDevelopment())
            {
                builder.AddDeveloperSigningCredential();
            }
            else
            {
                throw new Exception("need to configure key material");
            }
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            InitializeDatabase(app);
            SeedData.EnsureSeedData(_configuration.GetConnectionString("SqlServer"));

            app.UseStaticFiles();
            app.UseCors("CorsPolicy");
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseIdentityServer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }

        private void InitializeDatabase (IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices
                .GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<PersistedGrantDbContext>().Database.Migrate();


                var context = serviceScope.ServiceProvider
                    .GetRequiredService<ConfigurationDbContext>();

                context.Database.Migrate();
                if (!context.Clients.Any())
                {
                    foreach (var client in Config.Clients)
                    {
                        context.Clients.Add(client.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.IdentityResources.Any())
                {
                    foreach (var idResource in Config.Ids)
                    {
                        context.IdentityResources.Add(idResource.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.ApiResources.Any())
                {
                    foreach(var api in Config.Apis)
                    {
                        context.ApiResources.Add(api.ToEntity());
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
