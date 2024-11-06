using Microsoft.AspNetCore.Mvc;
using SingtelMovieBackEnd.Application.Interfaces.Content.Movie;
using SingtelMovieBackEnd.Domain.Model;

namespace SingtelMovieBackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovie _movieServcie;

        public MovieController(IMovie movieServcie)
        {
            _movieServcie = movieServcie;

        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Movie>>> GetProducts()
        {
            return Ok(await _movieServcie.GetAll());
        }
    }
}
