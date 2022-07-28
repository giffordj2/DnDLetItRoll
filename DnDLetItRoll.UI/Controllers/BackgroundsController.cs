using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnDLetItRoll.Data;
using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;

namespace DnDLetItRoll.UI.Controllers
{
    public class BackgroundsController : Controller
    {
        private readonly IGenericRepository<Background> _backgroundRepository;

        public BackgroundsController(IGenericRepository<Background> backgroundRepository)
        {
            _backgroundRepository = backgroundRepository;
        }

        // GET: Backgrounds
        public ActionResult Index()
        {
            return View(_backgroundRepository.Get());
        }

        // GET: Backgrounds/Details/5
        public ActionResult Details(int id)
        {
            Background background = _backgroundRepository.GetByID(id);
            return View(background);
        }

        // GET: Backgrounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Backgrounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description")] Background background)
        {
            if (ModelState.IsValid)
            {
                _backgroundRepository.Insert(background);
                _backgroundRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(background);
        }

        // GET: Backgrounds/Edit/5
        public ActionResult Edit(int id)
        {
            Background background = _backgroundRepository.GetByID(id);
            return View(background);
        }

        // POST: Backgrounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Description")] Background background)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _backgroundRepository.Update(background);
                    _backgroundRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackgroundExists(background.Id))
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
            return View(background);
        }

        // GET: Backgrounds/Delete/5
        public ActionResult Delete(int id)
        {
            Background background = _backgroundRepository.GetByID(id);
            if (background == null)
            {
                return NotFound();
            }

            return View(background);
        }

        // POST: Backgrounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Background background = _backgroundRepository.GetByID(id);
            _backgroundRepository.Delete(id);
            _backgroundRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool BackgroundExists(int id)
        {
            return _backgroundRepository.Get().Any(e => e.Id == id);
        }
    }
}
