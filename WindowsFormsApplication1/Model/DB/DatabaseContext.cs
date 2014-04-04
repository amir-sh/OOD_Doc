using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.label;

using WindowsFormsApplication1.model.maintenance;
using WindowsFormsApplication1.model.maintenance.function;
using MyAction = WindowsFormsApplication1.model.maintenance.function.Action;
using WindowsFormsApplication1.model.maintenance.occurrence;
using WindowsFormsApplication1.model.management;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;

namespace WindowsFormsApplication1.model.DB
{
    public class DatabaseContext : DbContext
    {

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyAction>().HasMany<MyAction>(s => s.Courses).WithMany(c => c.Students).Map(c =>
            {
                c.MapLeftKey("Student_id");
                c.MapRightKey("Course_id");
                c.ToTable("StudentAndCourse");
            });
            base.OnModelCreating(modelBuilder);
        }*/
        public DatabaseContext()
            : base("SQLConnection")
        {
           
        }
        //Asset
        public DbSet<Asset> Assets { get; set; }
        public DbSet<FeatureThing> featureThings { get; set; }
        public DbSet<AssignedLabel> AssignedLabels { get; set; }

        //Label
        public DbSet<Label> Labels { get; set; }

        //Maintenance
        public DbSet<WindowsFormsApplication1.model.maintenance.function.Action> GeneralActions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventManager> EventManagers { get; set; }



        //Management
        public DbSet<Configuration> Configurations { get; set; }

        //Util
        public DbSet<Thing> Things { get; set; }
        public DbSet<Constthing> Constthings { get; set; }
        //public DbSet<Thing> Things { get; set; }

        //Validation
        public DbSet<Constraint> constraints { get; set; }


    }

}
