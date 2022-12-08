using CleanTblHrEmp.Application.Interfaces;
using CleanTblHrEmp.Application.Interfaces.TblGenTasks;
using CleanTblHrEmp.Application.Interfaces.TblHrEmp;
using CleanTblHrEmp.Application.OtherServices.Implementation;
using CleanTblHrEmp.Application.OtherServices.Inferface;
using CleanTblHrEmp.Domain.Models;
using CleanTblHrEmp.Infrastructure.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.API
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDateTimeService, DateTimeService>();
            return serviceCollection;
        }

        //MediatR
        public static IServiceCollection RegisterMediatR(this IServiceCollection serviceCollections)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return serviceCollections.AddMediatR(assembly);
        }


        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
            //     Log.Logger = new LoggerConfiguration()
            //    .WriteTo.Console(
            //        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            //    restrictedToMinimumLevel: LogEventLevel.Information
            //    )
            //.WriteTo.File(
            //    path: "../logs/webapi-.log",
            //    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            //     rollingInterval: RollingInterval.Day,
            //     restrictedToMinimumLevel: LogEventLevel.Information
            //).CreateLogger();

            serviceCollection.AddScoped<IBaseServices, BaseServices>();
            serviceCollection.AddScoped<ITblHrEmpServices, TblHrEmpServices>();
            serviceCollection.AddScoped<ITblGenTaskServices, TblGenTaskServices>();

            

            return serviceCollection;
        }

        public static IServiceCollection RegisterTasks(this IServiceCollection serviceCollection, WebApplicationBuilder builder)
        {

            serviceCollection.AddDbContext<DbInnoxContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return serviceCollection;
        }
    }
}
