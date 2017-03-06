using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DM_Tool.Models;

namespace DM_Tool.Controllers
{
    public class MonstersController : Controller
    {
        private GMToolDB_Context db = new GMToolDB_Context();

        // GET: Monsters
        public ActionResult Index()
        {
            return View(db.Monsters.ToList());
        }

        // GET: Monsters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monsters monsters = db.Monsters.Find(id);
            if (monsters == null)
            {
                return HttpNotFound();
            }
            return View(monsters);
        }

        // GET: Monsters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "monsterID,monsterName,monsterHP,monsterDamage,experience")] Monsters monsters)
        {
            if (ModelState.IsValid)
            {
                db.Monsters.Add(monsters);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monsters);
        }

        // GET: Monsters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monsters monsters = db.Monsters.Find(id);
            if (monsters == null)
            {
                return HttpNotFound();
            }
            return View(monsters);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "monsterID,monsterName,monsterHP,monsterDamage,experience")] Monsters monsters)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monsters).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monsters);
        }

        // GET: Monsters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monsters monsters = db.Monsters.Find(id);
            if (monsters == null)
            {
                return HttpNotFound();
            }
            return View(monsters);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monsters monsters = db.Monsters.Find(id);
            db.Monsters.Remove(monsters);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
