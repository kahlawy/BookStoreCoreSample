using BookStoreCoreSample.Models;
using BookStoreCoreSample.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCoreSample.Controllers
{
    public class BookController : Controller
    {
        public IBookStoreRepository<Book> BookRepository { get; }

        public BookController(IBookStoreRepository<Book> bookRepository)
        {
            BookRepository = bookRepository;
        }
        // GET: BookController
        public ActionResult Index()
        {
            var books = BookRepository.List();

            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = BookRepository.Find(id);
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                BookRepository.Add(book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {

            var book = BookRepository.Find(id);
            return View(book);
           
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Book book)
        {
            try
            {
                BookRepository.Update(id, book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = BookRepository.Find(id);
            return View(book);
            //return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            try
            {
                 BookRepository.Delete(id);
                 return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
