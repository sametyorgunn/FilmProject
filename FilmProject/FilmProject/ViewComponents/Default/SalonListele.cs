using FilmProject.Application.Repositories.Salons;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.ViewComponents.Default
{
    public class SalonListele:ViewComponent
    {
        private readonly ISalonRepository _salonRepository;

        public SalonListele(ISalonRepository salonRepository)
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
