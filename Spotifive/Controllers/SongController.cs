﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Spotifive.Data;
using Spotifive.Models;

namespace Spotifive.Controllers
{
    public class SongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

       /* // GET: Song
        public async Task<IActionResult> Index()
        {
            return View(await _context.Song.ToListAsync());
        }
       */
       /* // GET: Song/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }
       */
        // GET: Song/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Song/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Editor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("ID,SongName,DateRelease,Genre,CodeQR,LinkYT")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Song));
            }
            return View(song);
        }
        [Authorize(Roles ="Editor")]
        public IActionResult Edit() { return View(); }
		[Authorize(Roles = "Editor,Registered user,Critic")]
		public IActionResult Details() { return View(); }
		public IActionResult Song() { return View(); }
        [Authorize(Roles = "Editor")]
        // GET: Song/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }
        /*
        // POST: Song/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Song.FindAsync(id);
            _context.Song.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    */
        /* public IActionResult SearchResult(string search)
         {
             List<Song> songs = _context.Song.ToList();
             if (search == null)
                 ViewBag.SearchResults = songs;
             else
             {
                 string pattern = $"{Regex.Escape(search)}";
                 List<Song> searchResults = songs.Where(p => Regex.IsMatch(p.SongName, pattern, RegexOptions.IgnoreCase)).ToList();

                 ViewBag.SearchResults = searchResults;
             }
             return View(ViewBag.SearchResults);
         }*/
        /* [ValidateAntiForgeryToken]
         public IActionResult SearchSong(string name)
         {
             var songList = from s in Song select s;
             if (!string.IsNullOrEmpty(name))
             {
                 songList = songList.Where(r => r.name.Contains(name));
             }
             return View(songList.ToList());
         }*/
       
        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.ID == id);
        }
    }
}
