using caso1_AdrianMonge.Models;
using Microsoft.EntityFrameworkCore;

namespace caso1_AdrianMonge
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
            services.AddControllersWithViews();

            services.AddDbContext<UniversidadABCContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UniversidadABC")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UniversidadABCContext context)
        {
            // Verificar la conexión a la base de datos
            if (context.Database.CanConnect())
            {
                Console.WriteLine("La conexión a la base de datos es exitosa!");
            }
            else
            {
                Console.WriteLine("Error al conectarse a la base de datos");
            }
        }
    }
}
