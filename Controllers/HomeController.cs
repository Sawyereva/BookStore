using BookStore.Models;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository;

        public HomeController(IBookRepository temp)
        {
            _bookRepository = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var bleh = new BooksListViewModel
            {
                Books = _bookRepository.Books
                        .OrderBy(x => x.Author)
                        .Skip((pageNum - 1) * pageSize)
                        .Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRepository.Books.Count()
                }
            };

            
            return View(bleh);
        }
    }
}
