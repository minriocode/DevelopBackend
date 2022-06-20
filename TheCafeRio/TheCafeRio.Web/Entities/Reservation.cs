using System;
using System.ComponentModel.DataAnnotations;
using TheCafeRio.Web.Enums;

namespace TheCafeRio.Web.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TotalPerson { get; set; }
        public DateTime ExpectedDate{ get; set; }
        public string ContactNo{ get; set; }
        public ReservationEnum ReservationShift { get; set; }

        public Reservation()
        {

        }
    }
}
