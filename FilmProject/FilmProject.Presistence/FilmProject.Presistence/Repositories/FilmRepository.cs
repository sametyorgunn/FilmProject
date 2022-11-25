using FilmProject.Application.Repositories.Films;
using FilmProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Presistence.Repositories
{
    public class FilmRepository:GenericRepository<Film>,IFilmRepository
    {
    }
}
