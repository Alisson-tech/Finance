using Finance.Data;
using Finance.Service.Interfaces;
using Finance.Service.Repositories;
using Finance.Service.Revenue;
using Microsoft.Extensions.DependencyInjection;

namespace Finance;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        //services.AddSwaggerGen(options =>
        //{
        //    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        //    {
        //        Scheme = "Bearer",
        //        BearerFormat = "JWT",
        //        In = ParameterLocation.Header,
        //        Name = "Authorization",
        //        Description = "Bearer Authentication",
        //        Type = SecuritySchemeType.Http
        //    });
        //    options.AddSecurityRequirement(new OpenApiSecurityRequirement
        //    {
        //        {
        //            new OpenApiSecurityScheme
        //            {
        //                Reference=new OpenApiReference
        //                {
        //                    Id="Bearer",
        //                    Type=ReferenceType.SecurityScheme
        //                }
        //            },
        //            new List<string>()
        //        }
        //    });
        //});

        //services.AddAuthentication(options =>
        //{
        //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //})
        //.AddJwtBearer(x =>
        //{
        //    x.RequireHttpsMetadata = false;
        //    x.SaveToken = true;
        //    x.TokenValidationParameters = new TokenValidationParameters
        //    {
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("0540b43c8a81982cfcbccef136eecc91")),
        //        ValidateIssuer = false,
        //        ValidateAudience = false
        //    };
        //});

        services.AddDbContext<Context>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IExpensiveTypeService, ExpensiveTypeService>();

        services.AddScoped(provider => new AutoMapper.MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new ExpensiveMappingProfile());
        }).CreateMapper());
    }
}