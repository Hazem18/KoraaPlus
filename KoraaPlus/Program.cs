using KoraaPlus.Data;
using KoraaPlus.Repository;
using KoraaPlus.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace KoraaPlus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>
                (
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"))
                );

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped(typeof(ILeagueRepository) , typeof(LeagueRepository));
            builder.Services.AddScoped(typeof(ITeamRepository), typeof(TeamRepository));
            builder.Services.AddScoped(typeof(IMatchRepository), typeof(MatchRepository));
            builder.Services.AddScoped(typeof(ITicketRepository), typeof(TicketRepository));
            builder.Services.AddScoped(typeof(ITicketCategoryRepository), typeof(TicketCategoryRepository));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
