using FilmProject.Application.Repositories.Films;
using FilmProject.Application.Repositories.SalonFilmMap;
using FilmProject.Application.Repositories.Salons;
using FilmProject.Presistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Presistence
{
    public static class ServiceRegistiration
    {
        public static void AddServiceRegistiration(this IServiceCollection services)
        {
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<ISalonRepository,SalonRepository>();
            services.AddScoped<ISalonFilmMap, SalonFilmMapRepository>();


        }
    }
}
