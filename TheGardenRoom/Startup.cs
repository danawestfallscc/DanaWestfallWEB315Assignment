using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TheGardenRoomFlower.Models;


namespace TheGardenRoom
{
    public class Startup
{
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Environment = env;
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        if (Environment.IsDevelopment())
        {
            services.AddDbContext<RazorPagesFlowerContext>(options =>
            options.UseSqlite(
                Configuration.GetConnectionString("RazorPagesFlowerContext")));
        }
        else
        {
            services.AddDbContext<RazorPagesFlowerContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("MovieContext")));
        }

        services.AddRazorPages();
        services.AddDbContext<RazorPagesFlowerContext>(options =>
        options.UseSqlite(Configuration.GetConnectionString("RazorPagesFlowerContext")));

    }

    public void Configure(IApplicationBuilder app)
    {
        if (Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}
}