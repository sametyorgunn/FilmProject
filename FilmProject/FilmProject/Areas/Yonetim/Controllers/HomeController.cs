using FilmProject.Application.Repositories.Films;
using FilmProject.Application.Repositories.SalonFilmMap;
using FilmProject.Application.Repositories.Salons;
using FilmProject.Domain.Dtos;
using FilmProject.Domain.Entities;
using FilmProject.Presistence.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace FilmProject.Areas.Yonetim.Controllers
{
    [Area("Yonetim")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IFilmRepository _filmrepository;
        private readonly ISalonRepository _salonrepository;
        private readonly IWebHostEnvironment _webHost;
        private readonly ISalonFilmMap _salonfilmMap;



        public HomeController(IFilmRepository filmrepository, ISalonRepository salonrepository, IWebHostEnvironment webHost, ISalonFilmMap salonfilmMap)
        {
            _filmrepository = filmrepository;
            _salonrepository = salonrepository;
            _webHost = webHost;
            _salonfilmMap = salonfilmMap;
        }

        public IActionResult Index()
        {
            var filmler = _filmrepository.GetList().Count();
            var salonlar = _salonrepository.GetList().Count();
            return View();
        }

        public IActionResult Filmler()
        {
            
            return View();
        }

        public IActionResult FilmEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FilmEkle(AddFilmDto dto)
        {

            Film film = new Film
            {
                FilmAdi = dto.FilmAdi,
                FilmYapimYil = dto.FilmYapimYil,

            };
            _filmrepository.TAdd(film);

            for (int i = 0; i<dto.Salons.Count();i++)
            {
               
                FilmSalonMapTable map = new FilmSalonMapTable
                {
                    FilmId = film.Id,
                    SalonId = dto.Salons[i]
                };
                _salonfilmMap.TAdd(map);
            };
                
            return View();
        }

        public IActionResult FilmDuzenle(int id)
        {
            var film = _filmrepository.TGetById(id);
            return View(film);
        }


        [HttpPost]
        public IActionResult FilmDuzenle(Film film)
        {
            _filmrepository.TUpdate(film);


            return Redirect("/Yonetim/Home/Filmler");
        }

        public IActionResult FilmSil(int id)
        {
            var silincekfilm = _filmrepository.TGetById(id);
           _filmrepository.TDelete(silincekfilm);
            return Redirect("/Yonetim/Home/Filmler");
        }

        public IActionResult FilmArama()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult FilmFiltrele(DataDto datas)
        {
            int ilkyil = datas.ilkyil;
            int ikinciyil = datas.ikinciyil;
            List<int> tarihler = new List<int>();
            for(int i =ilkyil;i<=ikinciyil;i++)

            {
                tarihler.Add(i);
            }
            Context c = new Context();
            var film = c.FilmSalonMapTables.Where(x => tarihler.Contains(x.Film.FilmYapimYil)).Include(y => y.Film).Include(z => z.Salon).ToList();
            //var films = _filmrepository.GetListAll(x => tarihler.Contains(x.FilmYapimYil));
            return Ok(film);
        }

        [HttpPost]
        public IActionResult SalonaAitFilmler(int id)
        {

            Context c =new Context();
            var films = c.FilmSalonMapTables.Where(x=>x.SalonId==id).Include(y=>y.Salon).Include(z=>z.Film).ToList();
            return Ok(films);
            //var filmid = _salonfilmMap.GetListAll(x => x.SalonId == id).Select(y=>y.FilmId);
            //var filmler = _filmrepository.GetListAll(x=>filmid.Contains(x.Id));
            //return Ok(filmler);
        }

        [HttpPost]
        public IActionResult FilmeAitBilgiler(int id)
        {
            List<FilmSalonMapTable>films;
            using (Context c = new Context())
            {
                films = c.FilmSalonMapTables.Where(x => x.FilmId == id).Include(y => y.Film).Include(z => z.Salon).ToList();
             
            }
            return Ok(films);



         



        }


     
   
      

    }
}
