using Library.Models.Patron;
using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        private readonly ILibraryAsset _assets;
        private readonly ICheckout _checkouts;
        private readonly IPatron _patrons;

        public PatronController(ILibraryAsset assets, ICheckout checkouts, IPatron patrons)
        {
            _assets = assets;
            _checkouts = checkouts;
            _patrons = patrons;
        }

        public IActionResult Index()
        {
            var allPatrons = _patrons.GetAll();

            var patronModels = allPatrons.Select(p => new PatronDetailModel
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                LibraryCardId = p.LibraryCard.Id,
                OverdueFees = p.LibraryCard.Fees,
                HomeLibraryBranch = p.HomeLibraryBranch.Name
            }).ToList();

            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };

            return View(model);
        }

        public IActionResult Detail(int patronId)
        {
            var patron = _patrons.Get(patronId);

            var model = new PatronDetailModel
            {
                Id = patron.Id,
                LastName = patron.LastName,
                FirstName = patron.FirstName,
                Address = patron.Address,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name,
                MemberSince = patron.LibraryCard.Created,
                OverdueFees = patron.LibraryCard.Fees,
                LibraryCardId = patron.LibraryCard.Id,
                Telephone = patron.TelephoneNumber,
                AssetsCheckedOut = _patrons.GetCheckouts(patronId).ToList() ?? new List<Checkout>(),
                CheckoutHistory = _patrons.GetCheckoutHistory(patronId),
                Holds = _patrons.GetHolds(patronId) //TODO : remove format from the view and incorporate here
            };

            return View(model);
        }
    }
}
