using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers
{
    [RemoteService]
    [Route("/api/BookStore")]
    public class BookController : AbpController
    {
        private readonly IBookAppService _bookAppService;
        public BookController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        //Lay tat ca book 
        [HttpGet("/Books")]
        public async Task<IActionResult> GetAllBook()
        {
            var listBook = await _bookAppService.GetAllBook();
            return Ok(listBook);
        }
    }
}
