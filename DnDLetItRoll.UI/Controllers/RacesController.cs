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
    public class RacesController : Controller
    {
        private readonly IRaceRepository _raceRepository;

        public RacesController(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }

        // GET: Races
        public ViewResult Index()
        {
            return View(_raceRepository.AllRaces);
        }

        // GET: Races/Details/5
        public ViewResult Details(int id)
        {
            Race race = _raceRepository.GetRaceById(id);
            return View(race);
        }

        // GET: Races/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Races/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description,StatIncreased,IncreaseAmount,Size,Speed,Languages,RacialTraits")] Race race)
        {
            if (ModelState.IsValid)
            {
                _raceRepository.InsertRace(race);
                _raceRepository.Save();
                return RedirectToAction("Index");
            }
            return View(race);
        }

        // GET: Races/Edit/5
        public ActionResult Edit(int id)
        {
            Race race = _raceRepository.GetRaceById(id);
            return View(race);
        }

        // POST: Races/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Description,StatIncreased,IncreaseAmount,Size,Speed,Languages,RacialTraits")] Race race)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _raceRepository.UpdateRace(race);
                    _raceRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceExists(race.Id))
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
            return View(race);
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {

            Race race = _raceRepository.GetRaceById(id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        // POST: Races/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var race = _raceRepository.GetRaceById(id);
            _raceRepository.DeleteRace(id);
            _raceRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool RaceExists(int id)
        {
            return _raceRepository.AllRaces.Any(e => e.Id == id);
        }
    }
}
