using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;

namespace TercihBilgiPlatformu
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
      services.AddTransient<IKullaniciService, KullaniciManager>();
      services.AddTransient<IKullaniciDAL, EFKullaniciRepository>();
      services.AddTransient<IBolumService, BolumManager>();
      services.AddTransient<IBolumDAL, EFBolumRepository>();
      services.AddTransient<IUniversiteService, UniversiteManager>();
      services.AddTransient<IUniversiteDAL, EFUniversiteRepository>();
      services.AddTransient<IEtiketService, EtiketManager>();
      services.AddTransient<IEtiketDAL, EFEtiketRepository>();
      services.AddMemoryCache();

      //services.AddControllers();
      services.AddMvc();
      services.AddSession(option =>
      {
        //Süre 10 dk olarak belirlendi
        option.IdleTimeout = TimeSpan.FromMinutes(10);
      });

      services.AddCors(options => options.AddDefaultPolicy(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

      services.AddControllersWithViews();
      services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
      {
        x.LoginPath = "/Login/SignIn";
      });


      services.AddMvc(config =>
      {
        var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
        config.Filters.Add(new AuthorizeFilter(policy));
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
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
      app.UseAuthentication();
      app.UseRouting();

      app.UseSession();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Login}/{action=SignIn}/{id?}");
      });
    }
  }
}
