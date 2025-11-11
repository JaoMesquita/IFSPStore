using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStoreRepository.Context;
using IFSPStoreRepository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;
        public static ServiceProvider ConfigureServices()
        {
            //Database config
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Category, Category>(); }, NullLoggerFactory.Instance).CreateMapper());


            return services.BuildServiceProvider();
        }
    }
}
