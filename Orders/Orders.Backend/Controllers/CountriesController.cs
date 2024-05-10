namespace Orders.Backend.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Orders.Backend.Data;
    using Orders.Shared.Entities;

    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();

            return Ok(country);
        }
    }
}
