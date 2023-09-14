using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.MODELS
{
    [Serializable]
    public class Passangers
    {
        [Required]
        public string Number {  get; set; }
        [Required]
        public string Character { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public Brush BgColor { get; set; }

    }
}
