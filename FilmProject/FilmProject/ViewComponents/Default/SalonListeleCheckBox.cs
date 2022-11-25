using FilmProject.Application.Repositories.Salons;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.ViewComponents.Default
{
    public class SalonListeleCheckBox:ViewComponent
    {
        private readonly ISalonRepository _salonrep;

        public SalonListeleCheckBox(ISalonRepository salonrep)
        {
            _salonrep = salonrep;
        }

        public IViewComponentResult Invoke()
        {
            var salons = _salonrep.GetList();
            return View(salons);
        }
    }
}
