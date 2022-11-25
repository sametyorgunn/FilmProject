using FilmProject.Application.Repositories.Films;
using FilmProject.Presistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace FilmProject.ViewComponents.Default
{
    public class FilmListele:ViewComponent
    {
        private readonly IFilmRepository _filmRepository;

        public FilmListele(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public IViewComponentResult Invoke()
        {

            Context c = new Context();
            var film = c.FilmSalonMapTables.Where(x => x.FilmId == x.Film.Id).Include(x => x.Salon).Include(y => y.Film).ToList();
            return View(film);

            //Context c = new Context();
            //var films = c.FilmSalonMapTables.Include(x => x.Film).Include(y=>y.Salon).ToList();
            //return View(films);


            //Context c = new Context();
            //var filmler = c.Films.Select(y => y.Id).ToList();
            //var films = c.FilmSalonMapTables.Where(z => filmler.Contains(z.FilmId)).Include(x => x.Film).Include(y => y.Salon).ToList();
            //return View(films);


        }

    }
}
