﻿using Microsoft.AspNetCore.Mvc;
using ToDoList.MVC.Data;
using ToDoList.MVC.Models;

namespace ToDoList.MVC.Controllers
{
    public class NoteController : Controller
    {
        private readonly NoteDbContext _context;

        public NoteController(NoteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Note note)
        {
            note.CreatedAt = DateTime.Now;
            note.UpdatedAt = DateTime.Now;
            note.Id = Guid.NewGuid();  
            _context.Notes.Add(note);
            _context.SaveChanges();
            return RedirectToAction("ViewTask");
        }


        public IActionResult ViewTask()
        {
            List<Note> notes = _context.Notes.ToList();
            return View(notes);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}