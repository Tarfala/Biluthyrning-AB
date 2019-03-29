﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BiluthyrningApp.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Typ av bil*")]
        [Required(ErrorMessage = "Du måste ange vilken biltyp du vill boka")]
        public Carsize CarSize { get; set; }
        [Display(Name = "Registreringsnummer*")]
        [RegularExpression(@"^[A-Z]{3}[0-9]{3}$", ErrorMessage = "Du måste ange registeringsnummret i formatet ABC123")]
        public string LicensePlate { get; set; }
        [Display(Name = "Antal km körda*")]
        [Required(ErrorMessage = "Du måste ange hur många kilometer bilen har gått")]
        public decimal DistanceInKm { get; set; }
        public List<Booking> Bookings { get; set; }

    }        
    public enum Carsize
    {
        Small,
        Van,
        Minibus
    }
}
