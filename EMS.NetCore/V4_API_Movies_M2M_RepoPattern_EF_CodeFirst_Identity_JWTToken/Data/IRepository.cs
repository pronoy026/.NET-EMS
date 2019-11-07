using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Dto;
using V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Models;

namespace V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Data
{
    public interface IRepository
    {
        
        bool AddActor(Actor actor);
        IEnumerable<Actor> GetActors();
        Actor GetActor(int id);
        bool UpdateActor(Actor actor);
        bool DeleteActor(Actor actor);

        IEnumerable<Actor> GetActorsByMovie(int movieId);



        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        bool AddMovie(MovieDto movie);
        bool UpdateMovie(MovieDto movie);
        bool DeleteMovie(Movie movie);

        IEnumerable<Movie> GetMovieByActors(int actorId);
        IEnumerable<Movie> GetMovieByGenre(Genre genre);
    }
}
