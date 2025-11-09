using TravelMarket.Web.Components;
using TravelMarket.Core;
using Mapster;
using TravelMarket.Core.IRepositories;
using TravelMarket.BLL;
using TravelMarket.DAL;

namespace TravelMarket.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //var mapsterConfig = new MapsterConfig();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            //builder.Services.AddSingleton<MapsterConfig>();
            builder.Services.AddDbContext<DataContext>();
            builder.Services.AddScoped<IServiceRepozitory, ServiceRepository>();
            builder.Services.AddScoped<ServServise>();
            builder.Services.AddScoped<IPartnerRepozitory, PartnerRepository>();
            builder.Services.AddScoped<PartnerServise>();



            TypeAdapterConfig.GlobalSettings.Apply(new MapsterConfig());
            builder.Services.AddMapster();


        var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
