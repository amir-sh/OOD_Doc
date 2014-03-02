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
using WindowsFormsApplication1.model.label.autoUpdate;
using WindowsFormsApplication1.model.maintenance;
using WindowsFormsApplication1.model.maintenance.function;
using WindowsFormsApplication1.model.maintenance.occurrence;
using WindowsFormsApplication1.model.management;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;

namespace WindowsFormsApplication1.Model
{
    class DatabaseContext : DbContext
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
        //Asset
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetManager> AssetManagers { get; set; }
        public DbSet<FeatureThing> featureThings { get; set; }
        public DbSet<AssignedLabel> AssignedLabels { get; set; }

        //Label
        public DbSet<Label> Labels { get; set; }
        public DbSet<LabelManager> LabelManagers { get; set; }

        //Maintenance
        public DbSet<ActionManager> ActionManagers { get; set; }
        public DbSet<GeneralAction> GeneralActions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventManager> EventManagers { get; set; }
        public DbSet<History> Histories;
        public DbSet<PluginCode> pluginCodes;

        //Management
        public DbSet<Configuration> Configuration { get; set; }

        //Util
        public DbSet<Thing> things { get; set; }

        //Validation
        public DbSet<Constraint> constraints { get; set; }
        public DbSet<Relation> relations { get; set; }

    }

}
