using AbcCompany.DAL;
using AbcCompany.Models;
using Microsoft.AspNetCore.Mvc;

namespace AbcCompany.Controllers
{
    public class ResellerController1 : Controller
    {
        private readonly ResellerDbContext _context;
        public ResellerController1(ResellerDbContext context) {
            this._context = context;
                }
        public IActionResult Index()
        {
            var resellers = _context.Resellers.ToList();
            if(resellers != null)
            {
                List<ResellerViewModel> resellerList = new List<ResellerViewModel>();
                foreach(var reseller in resellers)
                {
                    var ResellerViewModel = new ResellerViewModel()
                    {
                        Id = reseller.Id,
                        ResellerName = reseller.ResellerName,
                        Email = reseller.Email,
                        Address = reseller.Address,
                        FaxNumber = reseller.FaxNumber,
                        ContactPersonName = reseller.ContactPersonName,
                        ContactPersonPhoneNumber = reseller.ContactPersonPhoneNumber
                    };
                    resellerList.Add(ResellerViewModel);
                }
                return View(resellerList);
            }
            
            return View();
        }
    }
}
