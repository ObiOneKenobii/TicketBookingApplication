using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Data;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
              return _context.Movies != null ? 
                          View(await _context.Movies.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movieWithGenres = await _context.Movies
                .Include(m => m.GenreMovies)
                    .ThenInclude(gm => gm.Genres)
                .FirstOrDefaultAsync(m => m.MovieId == id);

            if (movieWithGenres == null)
            {
                return NotFound();
            }

            return View(movieWithGenres);
        }


        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieId,Title,Description,ContentRating,ReleaseDate,GenreMovies")] Movies movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name", movie.GenreMovies);
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieId,Title,Description,ContentRating,ReleaseDate,GenreMovies")] Movies movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoviesExists(movie.MovieId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name", movie.GenreMovies);
            return View(movie);
        }




      

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
            }
            var movies = await _context.Movies.FindAsync(id);
            if (movies != null)
            {
                _context.Movies.Remove(movies);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoviesExists(int id)
        {
          return (_context.Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
