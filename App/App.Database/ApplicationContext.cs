using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using App.Database.DatabaseModels;

namespace App.Database
{
    public sealed class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<UserDB> Users { get; set; }
        public DbSet<ProjectDB> Projects { get; set; }
        public DbSet<ColumnDB> Columns { get; set; }
        public DbSet<ProjectTaskDB> Tasks { get; set; }
        public DbSet<NotificationDB> Notifications { get; set; }
        public DbSet<RMStepDB> RoadMapSteps { get; set; }
        public DbSet<RoadMapDB> RoadMaps { get; set; }
        public DbSet<TagDB> Tags { get; set; }
        
        public DbSet<CommentDB> Comments { get; set; }

        public ApplicationContext()
        { 
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=1828;Database=TaskManager;Username=postgres;Password=progaup");
        }
    }
}