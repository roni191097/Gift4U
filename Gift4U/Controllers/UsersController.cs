using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gift4U.Data;
using Gift4U.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Gift4U.Controllers
{
    public class UsersController : Controller
    {
        private readonly Gift4UContext _context;

        public UsersController(Gift4UContext context)
        {
            _context = context;
        }
        // GET: Users
        public async Task<IActionResult> Index()
        {
            string userName = HttpContext.Session.GetString("User");
            if(String.IsNullOrEmpty(userName))
            {
                return RedirectToAction(nameof(Login));
            }
            else
            {
               //ar orders = _context.Order.Where(x => x.User.UserName == userName);
                // return View("~/Views/Orders/Index.cshtml", orders);
                var orders = _context.Order.Where(x => x.User.UserName == userName);
                 return View("~/Views/Users/MyPage.cshtml");
            }
        }
        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName,Password")] User user)
        {
            var u = (from a in _context.User
                    where user.UserName == a.UserName && user.Password == a.Password
                    select a).FirstOrDefault();
            if(u!=null)
            {
                HttpContext.Session.SetString("User", u.UserName);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Error"] = "המשתמש לא קיים, בוא תירשם :)";
            }
            return View(user);
        }
        public async Task<IActionResult> Logout()
        {
                HttpContext.Session.Remove("User");
                return RedirectToAction(nameof(Index));
        }
        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,FirstName,LastName,Type,Telephone")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,Password,FirstName,LastName,Type,Telephone")] User user)
        {
            if (id != user.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserName))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.UserName == id);
        }
    }
}
