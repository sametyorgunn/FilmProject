using FilmProject.Application.Repositories.Films;
using FilmProject.Application.Repositories.SalonFilmMap;
using FilmProject.Presistence.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.ViewComponents.Default
{
    public class FilmAdiArama:ViewComponent
    {
        private readonly IFilmRepository _filmRepository;
        private readonly ISalonFilmMap _map;


        public FilmAdiArama(IFilmRepository filmRepository, ISalonFilmMap map)
        {
            _filmRepository = filmRepository;
            _map = map;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var filmidler = c.FilmSalonMapTables.Select(y => y.FilmId).Distinct().ToList();
            var filmlers = c.Films.Where(x=>filmidler.Contains(x.Id)).ToList();
            //var filmler = _filmRepository.GetList();
            return View(filmlers);
        }
    }
}
