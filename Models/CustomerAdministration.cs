using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VitecVitecovitch.Models
{
    public class CustomerAdministration
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int TelephoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public int CPR { get; set; }
        public string Subscription { get; set; }
        public int Price { get; set; }
    }
}
ec