using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookViewingViewModel
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public int PropertyId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Viewing Date")]
        public DateTime DateV { get; set; }
        public string VisitorId { get; set; }

    }
}