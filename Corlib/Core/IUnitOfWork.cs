using Corlib.Core.Repositories;
using System;

namespace Corlib.Core
{
   internal interface IUnitOfWork : IDisposable
   {
      IMemberRepository Members { get; }
      IUserRepository Users { get; }
      ICityRepository Cities { get; }
      IContactRepository Contacts { get; }
      INoteRepository Notes { get; }
      IParameterRepository Parameters { get; }
      ITrainerRepository Trainers { get; }
      ITrainingRepository Trainings { get; }
      IMessageRepository Messages { get; }
      IShiftRepository Shifts { get; }
      IMembershipRepository Memberships { get; }
      ICheckinRepository Checkins { get; }
      IPaymentRepository Payments { get; }
      IProductTypeRepository ProductTypes { get; }
      IProductRepository Products { get; }
      ISaleRepository Sales { get; }
      ISaleItemRepository SaleItems { get; }
      IMemberFinancialMovementRepository MemberFinancialMovements { get; }
      IPersonalTrainingRecordRepository PersonalTrainingRecords { get; }
      IDatabaseBackupRecordRepository DatabaseBackupRecords { get; }
      IAdRepository Ads { get; }

      int Complete();
   }
}
