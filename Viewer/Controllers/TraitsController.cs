using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Viewer.Models;

namespace Viewer.Controllers
{
    public class TraitsController : Controller
    {
        private readonly ViewerContext _db;

        public TraitsController(ViewerContext db)
        {
            _db = db;
        }

        public IActionResult Index(int page, int pageCount)
        {   
            IQueryable<Object> traitQuery = Trait.GetTraits().AsQueryable();
            if(page == 0 ){
               page = 1;
            }
            ViewBag.pageCount = pageCount;
            ViewBag.page = page;
            traitQuery = PaginationHelper.GetPaged(traitQuery, page, pageCount);
            List<Trait> results = traitQuery.Cast<Trait>().ToList();
            return View(results);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trait trait)
        {
            _db.Traits.Add(trait);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisTrait = _db.Traits
                .Include(trait => trait.Characters)
                .ThenInclude(join => join.Character)
                .FirstOrDefault(Trait => Trait.TraitId == id);
            return View(thisTrait);
        }

        public ActionResult Edit(int id)
        {
            var thisTrait = _db.Traits.FirstOrDefault(trait => trait.TraitId == id);
            return View(thisTrait);
        }

        [HttpPost]
        public ActionResult Edit(Trait trait)
        {
            _db.Entry(trait).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisTrait = _db.Traits.FirstOrDefault(trait => trait.TraitId == id);
            return View(thisTrait);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisTrait = _db.Traits.FirstOrDefault(trait => trait.TraitId == id);
            _db.Traits.Remove(thisTrait);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}