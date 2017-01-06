using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VocabExpander.Context;
using VocabExpander.Models;

namespace VocabExpander.Controllers
{
    public class VocabController : Controller
    {

        private VocabContext db = new VocabContext();

        //
        // GET: /Vocab/
        public ActionResult Index()
        {
            return View(db.Vocabs.ToList());
        }

        //
        // GET: /Vocab/Details/5
        public ActionResult Details(int id)
        {

            Vocab vocab = db.Vocabs.Find(id);

            if (vocab==null)
            {
                return HttpNotFound();
            }

            return View(vocab);
        }

        //
        // GET: /Vocab/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vocab/Create
        [HttpPost]
        public ActionResult Create(Vocab vocab)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Vocabs.Add(vocab);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(vocab);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vocab/Edit/5
        public ActionResult Edit(int id)
        {
            Vocab vocab = db.Vocabs.Find(id);

            if (vocab==null)
            {
                return HttpNotFound();
            }

            return View(vocab);
        }

        //
        // POST: /Vocab/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Vocab vocab)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(vocab).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(vocab);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vocab/Delete/5
        public ActionResult Delete(int id)
        {

            Vocab vocab = db.Vocabs.Find(id);
            if (vocab==null)
            {
                return HttpNotFound();
            }

            return View(vocab);
        }

        //
        // POST: /Vocab/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {

                Vocab vocab = null;
                if (ModelState.IsValid)
                {
                    if(id==null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    vocab = db.Vocabs.Find(id);
                    if(vocab == null)
                        return HttpNotFound();

                    db.Vocabs.Remove(vocab);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(vocab);
            }
            catch
            {
                return View();
            }
        }
    }
}
