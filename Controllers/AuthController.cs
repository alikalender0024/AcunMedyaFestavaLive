using AcunMedyaFestavaLive.DataAccess.Context;
using AcunMedyaFestavaLive.Entities;
using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Controllers
{
    public class AuthController : Controller
    {
        private readonly FestavaContext _festavaContext = new FestavaContext();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _festavaContext.Users.Add(user);
                _festavaContext.SaveChanges();


                var userOperationClaim = new UserOperationClaim
                {
                    UserId = user.UserID,
                    OperationClaimId = 1
                };
                _festavaContext.UserOperationClaims.Add(userOperationClaim);
                _festavaContext.SaveChanges();

                return RedirectToAction("Index", "Default");
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = _festavaContext.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                Session["UserID"] = user.UserID;
                Session["UserName"] = user.UserName;

                return RedirectToAction("TicketList", "Ticket", new { area = "Admin" });
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid login attempt.";
                return View();
            }
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}
