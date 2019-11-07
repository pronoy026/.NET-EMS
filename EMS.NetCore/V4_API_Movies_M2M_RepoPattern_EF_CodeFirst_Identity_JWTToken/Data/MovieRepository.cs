using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Dto;
using V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Models;

namespace V4_API_Movies_M2M_RepoPattern_EF_CodeFirst_Identity_JWTToken.Data
{
    public class MovieRepository : IRepository
    {
        MovieContext context;
        public MovieRepository(MovieContext context)
        {
            this.context = context;
        }

        public bool AddActor(Actor actor)
        {
            try
            {
                context.Actors.Add(actor);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            return this.context.Movies.Include(m => m.MovieActors);
        }
        public IEnumerable<Actor> GetActors()
        {
            return context.Actors.ToList();
        }

        public Actor GetActor(int id)
        {
            return context.Actors.Find(id);
        }

        public bool UpdateActor(Actor actor)
        {
            try
            {
                context.Actors.Update(actor);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool DeleteActor(Actor actor)
        {
            try
            {
                context.Actors.Remove(actor);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Movie GetMovie(int id)
        {
            return context.Movies.Find(id);
        }

        public bool AddMovie(MovieDto movie)
        {
            try
            {
                context.Movies.Add(movie.Movie); //Adding Movie data in movie table
                foreach (var actor in movie.Actors) // Adding actors related to movie (as a new record ) => in a movie-actor mapping table
                {
                    context.MovieActors.Add(new MovieActor
                    {
                        Movie = movie.Movie,
                        Actor = context.Actors.Find(actor),
                    });
                    context.SaveChanges();
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateMovie(MovieDto movie)
        {
            try
            {
                context.Movies.Update(movie.Movie); //Update Movie data in movie table
                var movieActors = context.MovieActors.Where(ma => ma.Movie == movie.Movie); //find existing mapping table records
                context.MovieActors.RemoveRange(movieActors); //delete existing relationship records

                foreach (var actor in movie.Actors) // Add new mapping record=> in a movie-actor mapping table
                {
                    context.MovieActors.Add(new MovieActor
                    {
                        Movie = movie.Movie,
                        Actor = context.Actors.Find(actor),
                    });
                    context.SaveChanges();
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteMovie(Movie movie)
        {
            try
            {
                context.Movies.Remove(movie);
                //var movieActors = context.MovieActors.Where(ma => ma.Movie == movie); //find existing mapping table records
                //context.MovieActors.RemoveRange(movieActors);

                int result = context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Movie> GetMovieByActors(int actorId)
        {
            var movies = from m in this.context.Movies
                         join ma in this.context.MovieActors on m.Id equals ma.MovieId
                         where ma.ActorId == actorId
                         select m;
            return movies;
        }

        public IEnumerable<Movie> GetMovieByGenre(Genre genre)
        {
            return this.context.Movies.Where(m => m.Genre == (Genre)genre);
        }

        public IEnumerable<Actor> GetActorsByMovie(int movieId)
        {
            var actors = from a in context.Actors
                         join ma in context.MovieActors on a.Id equals ma.ActorId
                         where ma.MovieId == movieId
                         select a;
            return actors;
        }
    }
}
