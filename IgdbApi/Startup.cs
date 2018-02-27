using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgdbApi.Interfaces;
using IgdbApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IgdbApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;

            var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
          .AddEnvironmentVariables();
            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IApiClient, ApiClient>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IGameCollectionService, GameCollectionService>();
            services.AddTransient<ICreditService, CreditService>();
            services.AddTransient<IFeedService, FeedService>();
            services.AddTransient<IFranchiseService, FranchiseService>();
            services.AddTransient<IGameEngineService, GameEngineService>();
            services.AddTransient<IGameModeService, GameModeService>();
            services.AddTransient<IGenreService, GenreService>();

            // Add functionality to inject IOptions<T>
            services.AddOptions();

            // Add our Config object so it can be injected
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            // *If* you need access to generic IConfiguration this is **required**
            services.AddSingleton<IConfiguration>(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

        }
    }
}
