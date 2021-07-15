using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers.NewFolder
{
    public class AuthorController : AbpController
    {
        private readonly IAuthorAppService _authorAppService;
        public AuthorController(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }

        [HttpPost("/CreateAuthor")]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto input)
        {
            await _authorAppService.CreateAsync(input);
            return NoContent();
        }

        [HttpGet("/GetAllAuthor")]
        public async Task<IActionResult> GetAuthor()
        {
            var author = await _authorAppService.GetAllAuthor();
            return Ok(author);
        }
    }
}
