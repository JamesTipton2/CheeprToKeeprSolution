using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CheeprToKeepr.Models
{
    public class Fillup
    {
        [Key]
        public int FillupID { get; set; }
        public double Gallons { get; set; }
        public double MilesDriven { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayName("Vehicle")]
        public int VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }
        //[NotMapped]
        //public double MPG
        //{
        //    get
        //    {
        //        return MilesDriven / Gallons;
        //    }
        //}
    }
}
