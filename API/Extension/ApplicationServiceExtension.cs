using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Options;

namespace API.Extension;

public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) => services.AddCors(Options =>
    {
        Options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()  //.WithOrigins("https://dominio.com")
            .AllowAnyMethod()         //.WithMethods("GET", "POST")
            .AllowAnyHeader());       //.WithHeaders("accept", "content-type")
    });

    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUniOnWork, UnitOfWork>();
    }
}
