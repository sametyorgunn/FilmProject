using FilmProject.Application.Repositories.SalonFilmMap;
using FilmProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Presistence.Repositories
{
    public class SalonFilmMapRepository:GenericRepository<FilmSalonMapTable>,ISalonFilmMap
    {
    }
}
