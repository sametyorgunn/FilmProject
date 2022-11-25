using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Domain.Entities
{
    public class Salon
    {
        [Key]
        public int Id { get; set; }
        public string SalonAdi { get; set; }
        public List<FilmSalonMapTable> FilmSalonMapTableSalonId { get; set; }




        //public List<Film> Films { get; set; }


    }
}
