using System;
using System.Collections.Generic;
using System.Linq;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class ViewingsBookedModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public ViewingsBookedModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public List<BookViewingViewModel> Build( string visitorId)
        {
            List<BookViewingViewModel> lst = new List<BookViewingViewModel>();
             var viewlst = _context.Viewings.Where(p => p.VisitorId == visitorId).ToList();
            if (viewlst.Count()>0)
            {
                lst = viewlst
                    .Select(p => new BookViewingViewModel
                    {
                        Id = p.Id,
                        PropertyId = p.PropertyId,
                        DateV = p.Date,
                        VisitorId = p.VisitorId,
                        StreetName = _context.Properties.Find(p.PropertyId).StreetName,
                        PropertyType = _context.Properties.Find(p.PropertyId).PropertyType
                    })
                    .ToList();
                
            }
            return lst;
        }
    }
}