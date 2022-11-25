using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.Domain.Entities
{
    public class FilmSalonMapTable
    {
        [Key]
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}
