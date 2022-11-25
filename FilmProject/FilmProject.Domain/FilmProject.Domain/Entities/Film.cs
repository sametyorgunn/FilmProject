using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Domain.Entities
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public int FilmYapimYil { get; set; }
        public List<FilmSalonMapTable> FilmSalonMapTableFilmId { get; set; }









        //public int? SalonId { get; set; }
        //public Salon Salon { get; set; }
    }
}
