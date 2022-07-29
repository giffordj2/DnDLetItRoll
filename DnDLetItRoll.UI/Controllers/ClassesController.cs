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
    public class ClassesController : Controller
    {
        private readonly IGenericRepository<Class> _classRepository;

        public ClassesController(IGenericRepository<Class> classRepository)
        {
            _classRepository = classRepository;
        }

        // GET: Classes
        public ActionResult Index()
        {
            return View(_classRepository.Get());
        }

        // GET: Classes/Details/5
        public ActionResult Details(int id)
        {
            Class classObject = _classRepository.GetByID(id);
            return View(classObject);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description,HitDie")] Class @class)
        {
            if (ModelState.IsValid)
            {
                _classRepository.Insert(@class);
                _classRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }

        // GET: Classes/Edit/5
        public ActionResult Edit(int id)
        {

            var @class = _classRepository.GetByID(id);
            if (@class == null)
            {
                return NotFound();
            }
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Description,HitDie")] Class @class)
        {
            if (id != @class.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _classRepository.Update(@class);
                    _classRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassExists(@class.Id))
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
            return View(@class);
        }

        // GET: Classes/Delete/5
        public ActionResult Delete(int id)
        {
            var @class = _classRepository.GetByID(id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var @class = _classRepository.GetByID(id);
            _classRepository.Delete(@class);
            _classRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassExists(int id)
        {
            return _classRepository.Get().Any(e => e.Id == id);
        }
    }
}
