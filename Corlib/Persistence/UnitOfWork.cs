using Corlib.Core;
using Corlib.Core.Repositories;
using Corlib.Persistence.Repositories;

namespace Corlib.Persistence
{
   internal class UnitOfWork : IUnitOfWork
   {
      private readonly ZigguratContext _context;

      public IMemberRepository Members { get; private set; }
      public IUserRepository Users { get; private set; }
      public ICityRepository Cities { get; private set; }
      public IContactRepository Contacts { get; private set; }
      public INoteRepository Notes { get; private set; }
      public IParameterRepository Parameters { get; private set; }
      public ITrainerRepository Trainers { get; private set; }
      public ITrainingRepository Trainings { get; private set; }
      public IMessageRepository Messages { get; private set; }
      public IShiftRepository Shifts { get; private set; }
      public IMembershipRepository Memberships { get; private set; }
      public ICheckinRepository Checkins { get; private set; }
      public IPaymentRepository Payments { get; private set; }
      public IProductTypeRepository ProductTypes { get; private set; }
      public IProductRepository Products { get; private set; }
      public ISaleRepository Sales { get; private set; }
      public ISaleItemRepository SaleItems { get; private set; }
      public IMemberFinancialMovementRepository MemberFinancialMovements { get; private set; }
      public IPersonalTrainingRecordRepository PersonalTrainingRecords { get; private set; }
      public IDatabaseBackupRecordRepository DatabaseBackupRecords { get; private set; }
      public IAdRepository Ads { get; private set; }

      public UnitOfWork(ZigguratContext context)
      {
         _context = context;
         Members = new MemberRepository(_context);
         Users = new UserRepository(_context);
         Cities = new CityRepository(_context);
         Contacts = new ContactRepository(_context);
         Notes = new NoteRepository(_context);
         Parameters = new ParameterRepository(_context);
         Trainers = new TrainerRepository(_context);
         Trainings = new TrainingRepository(_context);
         Messages = new MessageRepository(_context);
         Shifts = new ShiftRepository(_context);
         Memberships = new MembershipRepository(_context);
         Checkins = new CheckinRepository(_context);
         Payments = new PaymentRepository(_context);
         ProductTypes = new ProductTypeRepository(_context);
         Products = new ProductRepository(_context);
         Sales = new SaleRepository(_context);
         SaleItems = new SaleItemRepository(_context);
         MemberFinancialMovements = new MemberFinancialMovementRepository(_context);
         PersonalTrainingRecords = new PersonalTrainingRecordRepository(_context);
         DatabaseBackupRecords = new DatabaseBackupRecordRepository(_context);
         Ads = new AdRepository(_context);
      }

      public int Complete()
      {
         return _context.SaveChanges();
      }

      public void Dispose()
      {
         _context.Dispose();
      }
   }
}
