using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdReview.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProdReview.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)

        {
            _context = context;

        }

        /// <summary>
        /// Retrieve all the users
        /// </summary>
        /// <returns>ClientApplicationUser Objects in a List</returns>

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var usersList = await _context.ApplicationUsers.ToListAsync();
            return Ok(usersList);
        }
    }
}
