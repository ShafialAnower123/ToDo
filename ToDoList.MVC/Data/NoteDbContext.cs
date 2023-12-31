﻿using Microsoft.EntityFrameworkCore;
using System.Data;
using ToDoList.MVC.Models;

namespace ToDoList.MVC.Data
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
