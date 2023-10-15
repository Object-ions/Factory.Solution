using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class EngineerController : Controller
  {
    private readonly FactoryContext _db;

    public EngineerController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      if (!ModelState.IsValid)
      {
        return View(engineer);
      }
      else
      {
        _db.Engineers.Add(engineer);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
    Engineer thisEngineer = _db.Engineers
                  .Include(en => en.JoinEntities)
                  .ThenInclude(j => j.Machine)
                  .FirstOrDefault(en => en.EngineerId == id);
    return View(thisEngineer);
    }

    public ActionResult Edit(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(en => en.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      _db.Engineers.Edit(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(en => en.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirm(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(en => en.EngineerId == id);
      _db.Engineers.Delete(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index")
    }
  }
}