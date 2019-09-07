using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookForBook.Models;
using BookForBook.Persistance;

namespace BookForBook.Controllers
{
    public class BooksController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Books
        public ActionResult Index(string bookGenre, string searchString)
        {

            var GenreLst = new List<string>();

            // User u = db.Users.Include(us => us.Books).First();

            //var u = db.Users.Where(user => user.Id == 1).Include(us => us.Books).FirstOrDefault();
            //var u1 = db.Users.Where(user => user.Id == 2).Include(us => us.Books).FirstOrDefault();
            //var b = u.Books.First();
            //var b1 = u1.Books.First();
            //u.Books.Clear();
            //u1.Books.Clear();
            //u.Books.Add(b1);
            //u1.Books.Add(b);
            //db.SaveChanges();

            // var genres = db.Books.Select(b => b.Genre).ToList();

            //var GenreQry = from d in db.Books
            //               orderby d.Genre
            //               select d.Genre;


            //GenreLst.AddRange(GenreQry.Distinct());
            List<Book> books = db.Books.ToList();

            books.ForEach(x =>
            {
                GenreLst.Add(x.Genre);
            });


            ViewBag.bookGenre = new SelectList(GenreLst);

            //var books = from m in db.Books
            //            select m;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    books = books.Where(s => s.Title.Contains(searchString));
            //}

            //if (!string.IsNullOrEmpty(bookGenre))
            //{
            //    books = books.Where(x => x.Genre == bookGenre);
            //}

            return View(books);
        }

        [HttpPost]
        public string Index(FormCollection fc, string searchString)
        {
            return "<h3> From [HttpPost]Index: " + searchString + "</h3>";
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Artist,ReleaseDate,Genre")] Book book)
        {
            if (ModelState.IsValid)
            {
                book.UserId = 1;
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public ActionResult List()
        {
            return View(db.Books.ToList());
        }

        public ActionResult Details(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.Id == id);

            ViewBag.loggedUsersBooks = db.Books.Where(x => x.UserId == 1);

            return View(book);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Artist,ReleaseDate,Genre")] Book book)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
