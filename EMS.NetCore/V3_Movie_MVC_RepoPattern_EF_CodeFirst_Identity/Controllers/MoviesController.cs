﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Data;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.ViewModels;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Controllers
{
    public class MoviesController : Controller
    {
        IRepository repository = null;
        public MoviesController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET: Movies
        public ActionResult Index()
        {
            return View(repository.GetMovies());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Create
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new MovieViewModel
            {
                Actors = repository.GetActors().Select(a => new SelectListItem(a.Name, a.Id.ToString())).ToList()
            };

            return View(viewModel);
        }

        // POST: Movies/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel viewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    bool result = repository.AddMovie(viewModel);
                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                viewModel = new MovieViewModel
                {
                    Actors = repository.GetActors().Select(a => new SelectListItem(a.Name, a.Id.ToString())).ToList()
                };
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var movie = repository.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Actors = repository.GetActors().Select(a => new SelectListItem(a.Name, a.Id.ToString(), a.Movie?.Id == movie.Id? true : false)).ToList()
            };
            return View(viewModel);

        }

        // POST: Movies/Edit/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MovieViewModel viewModel)
        {
            
            try
            {
                
                // TODO: Add update logic here
                if (ModelState.IsValid && id == viewModel.Movie.Id)
                {

                    bool result = repository.EditMovie(viewModel);
                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                var movie = repository.GetMovieById(id);
                viewModel = new MovieViewModel
                {
                    Movie = movie,
                    Actors = repository.GetActors().Select(a => new SelectListItem(a.Name, a.Id.ToString(), a.Movie?.Id == movie.Id ? true : false)).ToList()
                };
                return View(viewModel);
            }
            catch
            {
                var movie = repository.GetMovieById(id);
                viewModel = new MovieViewModel
                {
                    Movie = movie,
                    Actors = repository.GetActors().Select(a => new SelectListItem(a.Name, a.Id.ToString(), a.Movie?.Id == movie.Id ? true : false)).ToList()
                };
                return View(viewModel);
            }
        }

        // GET: Movies/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            var movie = repository.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: Movies/Delete/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bool result = repository.DeleteMovie(id);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(repository.GetMovieById(id));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetMoviesByActor()
        {
            var viewModel = new ActorMoviesViewModel
            {
                Actors = repository.GetActors().Select(m => new SelectListItem(m.Name, m.Id.ToString())).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult GetMoviesByActor(int id)
        {
            var viewModel = new ActorMoviesViewModel
            {
                Actors = repository.GetActors().Select(m => new SelectListItem(m.Name, m.Id.ToString())).ToList(),
                Movies = repository.GetMoviesByActor(id)
            };
            return View(viewModel);
        }
    }
}