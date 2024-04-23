using AcunMedyaFestavaLive.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Controllers
{
    public class FestavaArtistController : Controller
    {  
        public ActionResult ArtistList()
        {
            var result = _festavaContext.Artists.ToList();
            return View(result);
        }
    }
}