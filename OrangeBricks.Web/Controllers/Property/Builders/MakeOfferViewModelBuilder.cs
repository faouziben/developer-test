using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class MakeOfferViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MakeOfferViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MakeOfferViewModel Build(int id, string buyerId)
        {
            var property = _context.Properties.Find(id);

            return new MakeOfferViewModel
            {
                PropertyId = property.Id,
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                BuyerUserId = buyerId,
                Offer = 100000 // TODO: property.SuggestedAskingPrice
            };
        }
    }
}