using System;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookViewingCommand
    {
        public int PropertyId { get; set; }

        public DateTime DateV { get; set; }

        public string VisitorId { get; set; }
    }
}