using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheCafeRio.Web.Enums;

namespace TheCafeRio.Web.Models
{
    public class ReservationUpdateModel
    {
        public int Id { get; set; }
        [Required]
        public int TotalPerson { get; set; }
        [Required]
        public DateTime ExpectedDate { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public ReservationEnum ReservationShift { get; set; }
        public List<SelectListItem> Shifts { get; set; }

    }
}
