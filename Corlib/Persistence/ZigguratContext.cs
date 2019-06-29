using Corlib.Config.ModelConfiguration;
using Corlib.Core.Domain;
using System.Configuration;
using System.Data.Entity;

namespace Corlib.Persistence
{
   public class ZigguratContext : DbContext
   {
      public ZigguratContext() : base(ConfigurationManager.ConnectionStrings["Ziggurat"].ConnectionString)
      {
         Configuration.LazyLoadingEnabled = false;
      }

      //// para correr migraciones/seed
      //public ZigguratContext() : base("Data Source=(local);Initial Catalog=Ziggurat;User Id=sa;Password=1234")
      //{
      //   Configuration.LazyLoadingEnabled = false;
      //}

      public virtual DbSet<Member> Members { get; set; }
      public virtual DbSet<State> States { get; set; }
      public virtual DbSet<City> Cities { get; set; }
      public virtual DbSet<User> Users { get; set; }
      public virtual DbSet<Contact> Contacts { get; set; }
      public virtual DbSet<Note> Notes { get; set; }
      public virtual DbSet<Parameter> Parameters { get; set; }
      public virtual DbSet<Trainer> Trainers { get; set; }
      public virtual DbSet<Training> Trainings { get; set; }
      public virtual DbSet<Message> Messages { get; set; }
      public virtual DbSet<Membership> Memberships { get; set; }
      public virtual DbSet<Checkin> Checkins { get; set; }
      public virtual DbSet<Payment> Payments { get; set; }
      public virtual DbSet<ProductType> ProductTypes { get; set; }
      public virtual DbSet<Product> Products { get; set; }
      public virtual DbSet<Sale> Sales { get; set; }
      public virtual DbSet<SaleItem> SalesItems { get; set; }
      public virtual DbSet<Shift> Shifts { get; set; }
      public virtual DbSet<MemberFinancialMovement> MemberFinancialMovements { get; set; }
      public virtual DbSet<PersonalTrainingRecord> PersonalTrainingRecords { get; set; }
      public virtual DbSet<DatabaseBackupRecord> DatabaseBackupRecords { get; set; }
      public virtual DbSet<Ad> Ads { get; set; }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Configurations.Add(new MemberModelConfiguration());
         modelBuilder.Configurations.Add(new StateModelConfiguration());
         modelBuilder.Configurations.Add(new CityModelConfiguration());
         modelBuilder.Configurations.Add(new UserModelConfiguration());
         modelBuilder.Configurations.Add(new ContactModelConfiguration());
         modelBuilder.Configurations.Add(new NoteModelConfiguration());
         modelBuilder.Configurations.Add(new ParameterModelConfiguration());

         modelBuilder.Configurations.Add(new TrainerModelConfiguration());
         modelBuilder.Configurations.Add(new TrainingModelConfiguration());
         modelBuilder.Entity<Trainer>()
            .HasMany(trainer => trainer.Trainings)
            .WithMany(training => training.Trainers)
            .Map(tt => { tt.ToTable("TrainerTrainings"); });

         modelBuilder.Configurations.Add(new MessageModelConfiguration());
         modelBuilder.Configurations.Add(new MembershipModelConfiguration());
         modelBuilder.Configurations.Add(new CheckinModelConfiguration());

         modelBuilder.Configurations.Add(new PaymentModelConfiguration());
         modelBuilder.Configurations.Add(new ProductTypeModelConfiguration());
         modelBuilder.Configurations.Add(new ProductModelConfiguration());
         modelBuilder.Configurations.Add(new SaleModelConfiguration());
         modelBuilder.Configurations.Add(new SaleItemModelConfiguration());
         modelBuilder.Configurations.Add(new MemberFinancialMovementModelConfiguration());
         modelBuilder.Configurations.Add(new PersonalTrainingRecordModelConfiguration());
         modelBuilder.Configurations.Add(new DatabaseBackupRecordModelConfiguration());
         modelBuilder.Configurations.Add(new AdModelConfiguration());
      }
   }
}
