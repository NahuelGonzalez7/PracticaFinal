using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Models;
using WebElReyCan.Admin;

namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {
        private static TurnoDbContext context = new TurnoDbContext();
        // GET: Turno
        public ActionResult Index()
        {
            return View("Index",AdmTurn.List());
        }

        [HttpGet]
        public ActionResult GetActualDay(DateTime day)
        {
            return View("Index", AdmTurn.ListByDay(day));
            //ToDo retorna los turnos del dia
        }

        [HttpGet]
        public ActionResult GetByName(string name)
        {
            return View("Index", AdmTurn.ListByName(name));
        }

        [HttpGet]
        public ActionResult GetByCell(string cell)
        {
            return View("Index", AdmTurn.ListByCell(cell));
        }

        [HttpGet]
        public ActionResult Create()
        {
            Turno turn = new Turno();
            return View("Create", turn);
        }

        [HttpPost]
        public ActionResult Create(Turno turn)
        {
            if (ModelState.IsValid)
            {
                AdmTurn.Create(turn);
                return RedirectToAction("Index");
            }
            return View("Create", turn);
        }

        public ActionResult Detail(int id)
        {
            Turno turn = AdmTurn.SearchByID(id);
            if (turn != null)
            {
                return View("Detail", turn);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Turno turn = AdmTurn.SearchByID(id);
            if (turn != null)
            {
                return View("Edit", turn);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Turno turn)
        {
            if (ModelState.IsValid)
            {
                AdmTurn.Edit(turn);
                return RedirectToAction("Index");
            }
            return View("Edit", turn);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Turno turn = context.Turnos.Find(id);
            if (turn != null)
            {
                return View("Delete", turn);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult Delete(Turno turn)
        {
            context.Turnos.Remove(context.Turnos.Find(turn.ID));
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}