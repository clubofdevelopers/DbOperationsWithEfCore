using DbOperationWithEfCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEfCoreApp.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            var result = await _appDbContext.Currencies.ToListAsync();
            // Adding new comment
            //var result = (from currency in  _appDbContext.Currencies
            //             select currency).ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {
            var result = await _appDbContext.Currencies.FindAsync(id);
            //var result = (from currency in  _appDbContext.Currencies
            //             select currency).ToList();
            return Ok(result);
        }
    }
}
