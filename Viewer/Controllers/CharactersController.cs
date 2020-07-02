using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Viewer.Models;
using System;
namespace Viewer.Controllers
{
    public class CharactersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ViewerContext _db;

        public CharactersController(UserManager<ApplicationUser> userManager, ViewerContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public static PagedResult<U> GetPaged<T, U>(this IQueryable<T> query,
                                                    int page, int pageSize) where U : class
        {
            var result = new PagedResult<U>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip)
                                  .Take(pageSize)
                                  .ProjectTo<U>()
                                  .ToList();

            return result;
        }
        public IActionResult Index(int page = 1, int amountShown = 2, int skip = 2)
        {
            PagedResult<Character> characterPage = new PagedResult<Character>();
            Character character = Character.GetDetails(i);
            characterPage.Results.Add(character);
            return View(characterPage);
            // int i = page * amountShown
            // int i = 2 * 10
            // i = 20

            // i <= amountShown
            // i <= (page * amountShown) + amountShown
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.TraitId = new SelectList(_db.Traits, "TraitId", "Name");
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(Character character, int traitId)
        {
            _db.Characters.Add(character);
            if (traitId != 0)
            {
                _db.CharacterTraits.Add(new CharacterTrait() { TraitId = traitId, CharacterId = character.CharacterId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisCharacter = _db.Characters
                .Include(Character => Character.Traits)
                .ThenInclude(join => join.Trait)
                .FirstOrDefault(Character => Character.CharacterId == id);
            return View(thisCharacter);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var thisCharacter = _db.Characters.FirstOrDefault(Characters => Characters.CharacterId == id);
            ViewBag.TraitId = new SelectList(_db.Traits, "TraitId", "Name");
            return View(thisCharacter);
        }

        [HttpPost]
        public ActionResult Edit(Character Character, int TraitId)
        {
            if (TraitId != 0)
            {
                _db.CharacterTraits.Add(new CharacterTrait() { TraitId = TraitId, CharacterId = Character.CharacterId });
            }
            _db.Entry(Character).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult AddTrait(int id)
        {
            var thisCharacter = _db.Characters.FirstOrDefault(Character => Character.CharacterId == id);
            ViewBag.TraitId = new SelectList(_db.Traits, "TraitId", "Name");
            return View(thisCharacter);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddTrait(Character character, int TraitId)
        {

            if (TraitId != 0)
            {
                var comparecharactertrait = _db.CharacterTraits.FirstOrDefault(trait => trait.TraitId == TraitId);
                foreach (CharacterTrait compareTrait in character.Traits)
                {
                    if (character.CharacterId == comparecharactertrait.CharacterId)
                    {
                        if (comparecharactertrait.TraitId == TraitId)
                        {

                            return RedirectToAction("Index", "Characters");
                        }
                    }
                }
                _db.CharacterTraits.Add(new CharacterTrait() { TraitId = TraitId, CharacterId = character.CharacterId });
                _db.SaveChanges();

            }
            return RedirectToAction("Index", "Characters");
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            var thisCharacter = _db.Characters.FirstOrDefault(Characters => Characters.CharacterId == id);
            return View(thisCharacter);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisCharacter = _db.Characters.FirstOrDefault(Characters => Characters.CharacterId == id);
            _db.Characters.Remove(thisCharacter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteTrait(int joinId)
        {
            var joinEntry = _db.CharacterTraits.FirstOrDefault(entry => entry.CharacterTraitId == joinId);
            _db.CharacterTraits.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}