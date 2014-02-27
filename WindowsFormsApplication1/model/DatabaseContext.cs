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
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.Model
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
        }

        public DatabaseContext()
            : base("SQLConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<DatabaseContext>());
            this.Database.Initialize(true);
            
        }

        public DbSet<Thing> Things { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<LabelInstance> LabelInstances { get; set; }
    }

}
