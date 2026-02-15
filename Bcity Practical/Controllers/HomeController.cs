using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bcity_Practical.Data;

namespace Bcity_Practical.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Get the last 5 clients with count of linked contacts
            var recentClients = await _context.Clients
                .Include(c => c.ClientContacts)
                .OrderByDescending(c => c.Id) // latest first
                .Take(10)
                .Select(c => new
                {
                    c.Id,
                    c.ClientCode,
                    c.Name,
                    ContactsCount = c.ClientContacts.Count
                })
                .ToListAsync();

            // Get the last 5 contacts with count of linked clients
            var recentContacts = await _context.Contacts
                .Include(c => c.ClientContacts)
                .OrderByDescending(c => c.Id)
                .Take(10)
                .Select(c => new
                {
                    c.Id,
                    FullName = c.Surname + " " + c.Name,
                    c.Email,
                    ClientsCount = c.ClientContacts.Count
                })
                .ToListAsync();

            // Pass to View via ViewBag
            ViewBag.RecentClients = recentClients;
            ViewBag.RecentContacts = recentContacts;

            return View();
        }
    }
}
