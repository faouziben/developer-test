using System;
using System.Collections.Generic;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookViewingCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public BookViewingCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(BookViewingCommand command)
        {
            

            var viewvg = new Viewing
            {
                Date = command.DateV,
                PropertyId = command.PropertyId,
                VisitorId = command.VisitorId
            };

            _context.Viewings.Add(viewvg);

            _context.SaveChanges();
        }
    }
}