using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp.Study.Buddy.Project.Models;

public class StudentBootCampDbContext : DbContext
{
    public DbSet<Question> Questions { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    public StudentBootCampDbContext(DbContextOptions<StudentBootCampDbContext> options)
        : base(options)
    {
    }   
    
    } 

   