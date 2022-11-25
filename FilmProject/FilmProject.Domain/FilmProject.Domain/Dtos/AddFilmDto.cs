using FilmProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Domain.Dtos
{
    public class AddFilmDto
    {
        public string FilmAdi { get; set; }
        public int FilmYapimYil { get; set; }
        public int SalonId { get; set; }
        public List<int>Salons { get; set; }
    }
}
