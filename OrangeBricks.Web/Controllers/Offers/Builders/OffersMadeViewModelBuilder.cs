using System.Collections.Generic;
using System.Linq;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Offers.Builders
{
    public class OffersMadeViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public OffersMadeViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public List<OffersMadeViewModel>  Build(string buyerId)
        {
            var offers = _context.Offers.Where(s => s.BuyerUserId == buyerId).ToList();
            List<OffersMadeViewModel> lst = new List<OffersMadeViewModel>();
            foreach (var ofr in offers)
            {
                var prop = _context.Properties.Find(ofr.Property.Id);
                var ofrMad = new OffersMadeViewModel()
                {
                    Id = ofr.Id,
                    PropertyType = prop.PropertyType,
                    NumberOfBedrooms = prop.NumberOfBedrooms,
                    StreetName = prop.StreetName,
                    Amount = ofr.Amount,
                    Status = ofr.Status,
                    CreatedAt = ofr.CreatedAt,
                    UpdatedAt = ofr.UpdatedAt

                };

                lst.Add(ofrMad);
            }
            return lst;
        }
    }
}