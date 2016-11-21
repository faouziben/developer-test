using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeBricks.Web.Models
{
    public class Viewing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int PropertyId { get; set; }
        [Required]
        public string VisitorId { get; set; }

        [ForeignKey("VisitorId")]
        public virtual ApplicationUser User { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }

    }
}