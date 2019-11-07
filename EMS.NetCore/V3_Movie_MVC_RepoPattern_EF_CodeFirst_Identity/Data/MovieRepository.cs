﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Data
{
    public class MovieRepository : IRepository
    {
        ApplicationDbContext context = null;
        public MovieRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool AddActor(Actor actor)
        {
            try
            {
                context.Actors.Add(actor);
                int result = context.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool AddMovie(MovieViewModel movieViewModel)
        {
            try
            {
                context.Movies.Add(movieViewModel.Movie);
                // for every actor selected
                foreach (var actor in movieViewModel.Actors)
                {
                    if (actor.Selected)
                    {
                        var existingActor = context.Actors.Find(
                            Convert.ToInt32(actor.Value));
                        existingActor.Movie = movieViewModel.Movie;
                        context.SaveChanges();
                    }
                }
                int result = context.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
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
                if (result == 1)
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

        public bool DeleteActor(int actorId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMovie(int movieId)
        {
            var movie = context.Movies.Include(m => m.Actors).ToList().Find(m => m.Id == movieId);
            movie.Actors.Clear();

            context.Movies.Find(movieId);
            context.SaveChanges();
            return true;
        }


        public bool EditActor(Actor actor)
        {
            try
            {
                context.Entry<Actor>(actor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                int result = context.SaveChanges();
                if (result == 1)
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

        public bool EditMovie(MovieViewModel viewModel)
        {
            try
            {
                context.Entry<Movie>(viewModel.Movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                // for every actor selected
                foreach (var actor in viewModel.Actors)
                {
                    var existingActor = context.Actors.Find(
                            Convert.ToInt32(actor.Value));
                    if (actor.Selected)
                    {
                        existingActor.Movie = viewModel.Movie;
                    }
                    else
                    {
                        existingActor.Movie = null;
                    }
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

        public Actor GetActorById(int actorId)
        {
            try
            {
                return context.Actors.Find(actorId);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Actor> GetActors()
        {
            return context.Actors.ToList();
        }

        public IEnumerable<Actor> GetActorsByGender(Gender gender)
        {
            try
            {
                return context.Actors.Where(a => a.Gender == gender);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Actor> GetActorsByMovie(int movieId)
        {
            try
            {
                return context.Actors.Where(a => a.Movie.Id == movieId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Movie GetMovieById(int movieId)
        {
            try
            {
                return context.Movies.Find(movieId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            return context.Movies.Include(m => m.Actors).ToList();
        }

        //public IEnumerable<Movie> GetMoviesByActor(int actorId)
        //{
        //    try
        //    {
        //        var actor = context.Actors.Find(actorId);
        //        return context.Movies.Where(m => m.Actors.Contains(actor)).ToList();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public IEnumerable<Movie> GetMoviesByActor(int actorId)
        {
            try
            {
                //var movies = context.Movies.Join(
                //    context.Actors, 
                //    m => m.Id, 
                //    a => a.Movie.Id, 
                //    (m, a) => m
                //);
                var movies = from m in context.Movies
                             join a in context.Actors on m.Id equals a.Movie.Id
                             where a.Id == actorId
                             select m;
                return movies.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }



        public IEnumerable<Movie> GetMoviesByGenre(Genre genre)
        {
            throw new NotImplementedException();
        }


    }
}
