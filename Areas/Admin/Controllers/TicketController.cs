using AcunMedyaFestavaLive.DataAccess.Context;
using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{

    public class TicketController : Controller
    {
        FestavaContext _festavaContext = new FestavaContext();

        // GET: Admin/Ticket
        public ActionResult TicketList()
        {
            var result = _festavaContext.Tickets.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult CreateTicket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTicket(Ticket ticket)
        {
            _festavaContext.Tickets.Add(ticket);
            _festavaContext.SaveChanges();
            return RedirectToAction("TicketList");
        }
        public ActionResult DeleteTicket(int id)
        {
            var result = _festavaContext.Tickets.Find(id);
            _festavaContext.Tickets.Remove(result);
            _festavaContext.SaveChanges();
            return RedirectToAction("TicketList");
        }
        [HttpGet]
        public ActionResult UpdateTicket(int id)
        {
            var result = _festavaContext.Tickets.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult UpdateTicket(Ticket ticket)
        {
            var result = _festavaContext.Tickets.Find(ticket.TicketID);
            result.Title = ticket.Title;
            result.Description = ticket.Description;
            result.Price = ticket.Price;
            result.TicketProperty1 = ticket.TicketProperty1;
            result.TicketProperty2 = ticket.TicketProperty2;
            result.TicketProperty3 = ticket.TicketProperty3;
            result.TicketProperty4 = ticket.TicketProperty4;
            result.TicketProperty5 = ticket.TicketProperty5;
            result.TicketProperty6 = ticket.TicketProperty6;
            _festavaContext.SaveChanges();
            return RedirectToAction("TicketList");
        }
    }
}