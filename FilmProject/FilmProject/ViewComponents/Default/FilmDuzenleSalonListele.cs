using FilmProject.Application.Repositories.Salons;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace FilmProject.ViewComponents.Default
{
    public class FilmDuzenleSalonListele:ViewComponent
    {
        private readonly ISalonRepository _salonRepository;

        public FilmDuzenleSalonListele(ISalonRepository salonRepository)
        {
            _salonRepository = salonRepository;
        }

        public IViewComponentResult Invoke()
        {
            var salonlar = _salonRepository.GetList();
            return View(salonlar);
        }
    }
}
