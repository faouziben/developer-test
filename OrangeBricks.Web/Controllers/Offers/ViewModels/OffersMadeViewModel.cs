using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OrangeBricks.Web.Models;


namespace OrangeBricks.Web.Controllers.Offers.ViewModels
{
    public class OffersMadeViewModel
    {

        public int Id { get; set; }
        public string PropertyType { get; set; }
        public int NumberOfBedrooms{ get; set; }
        public string StreetName { get; set; }

        public int Amount { get; set; }

        public OfferStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

   
}