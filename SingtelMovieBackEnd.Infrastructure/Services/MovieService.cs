using Microsoft.EntityFrameworkCore;
using SingtelMovieBackEnd.Application.Dtos;
using SingtelMovieBackEnd.Application.Interfaces.Content.Movie;
using SingtelMovieBackEnd.Infrastructure.Content.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingtelMovieBackEnd.Infrastructure.Services
{
    public class MovieService : IMovie
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<MovieDto>> GetAll()
        {
            var movies = await _context.Movie.Select(m => new MovieDto
            {
                Id = m.Id,
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                ImagePath = m.ImagePath,
            }).AsNoTracking().ToListAsync();
            return movies;
        }
    }
}
