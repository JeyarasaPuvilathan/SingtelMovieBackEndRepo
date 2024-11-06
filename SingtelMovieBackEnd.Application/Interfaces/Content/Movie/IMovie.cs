using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingtelMovieBackEnd.Application.Dtos;
using SingtelMovieBackEnd.Domain.Model;


namespace SingtelMovieBackEnd.Application.Interfaces.Content.Movie
{
    public interface IMovie
    {
        Task<List<MovieDto>> GetAll();
    }
}
