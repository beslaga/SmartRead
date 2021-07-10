using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.ML;
using Microsoft.OpenApi.Models;
using SmartRead.API.Database.Context;
using SmartRead.API.Recommender;
using SmartRead.API.Recommender.Models;
using SmartRead.API.Security;
using SmartRead.API.Services;
using SmartRead.API.Stripe;
using SmartRead.Model;
using SmartRead.Model.Requests;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using IDocumentFilter = Swashbuckle.AspNetCore.SwaggerGen.IDocumentFilter;

namespace SmartRead.API
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };
        }
    }
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
            services.AddControllers();

            var connection = Configuration.GetConnectionString("SmartRead");
            services.AddDbContext<SmartReadContext>(options => options.UseSqlServer(connection));
            services.AddAutoMapper(typeof(Startup));

            services.AddControllers().AddNewtonsoftJson(options => 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<
                ICrudService<Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>,
                CrudService<Kategorija, KategorijaSearchRequest, Database.Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>>();
            
            services.AddTransient<IClanakService, ClanakService>();

            services.AddTransient<IBaseService<Drzava, object>, BaseService<Drzava, object, Database.Drzava>>();

            services.AddTransient<IKorisniciService, KorisniciService>();
            services.AddTransient<IBaseService<Uloga, object>, UlogaService>();

            services.AddPredictionEnginePool<ClanakRating, ClanakRatingPrediction>()
                .FromFile(modelName: "ClanakRatingAnalysisModel", filePath: "Recommender/Data/ClanakRecommenderModel.zip", watchForChanges: true);

            services.AddTransient<IRecommender, Recommender.Recommender>();

            var stripeOptions = Configuration
                .GetSection("Stripe")
                .Get<StripeOptions>();
            services.AddSingleton(stripeOptions);

            services.AddTransient<IStripeService, StripeService>();

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartRead API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartRead API");
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
