using Corlib.Core.Domain;
using Corlib.Migrations.SeedHelpers;
using Corlib.Persistence;
using NLog;
using System;
using System.Data.Entity.Migrations;

namespace Corlib.Migrations
{
	public sealed class Configuration : DbMigrationsConfiguration<ZigguratContext>
	{
		private static Logger _logger = LogManager.GetCurrentClassLogger();

		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(ZigguratContext context)
		{
			context.Users.AddOrUpdate(x => x.Id, new User() { Id = 1, Username = "admin", PasswordHash = "$MYHASH$V1$10000$GsAtpV/2zZb/aQBSSWO/UqlXXnb43aV3VM2vpJvYJhCIWyRl" });
			context.SaveChanges();

			var citiesHelper = new CitiesSeedHelper(context);
			context.States.AddOrUpdate(c => c.Id, citiesHelper.GetStates());
			context.SaveChanges();

			context.Cities.AddOrUpdate(c => c.Id, citiesHelper.GetCities());
			context.SaveChanges();

			context.Parameters.AddOrUpdate(p => p.Id, new Parameter()
			{
				GymName = "Mi Gimnasio",
				GymAddress = "Calle 123",
				GymCityId = 1,
				GymPhone = "555 55555555",
				GymEmail = "migimnasio@gmail.com",
				GymFacebook = "facebook.com/migimnasio",
				GymTwitter = "",
				GymInstagram = "",
				RequiredField = "Campo requerido",
				InvalidEmailAddress = "La dirección no es válida",
				EnterAtLeastAPhone = "Ingresa al menos un teléfono",
				EnterMobilePhoneAreaCode = "Ingresa la característica",
				EnterPhoneNumber = "Ingresa el número",
				SelectAtLeastOne = "Selecciona al menos uno",
				Skin = "Office 2016 Colorful",
				SplitContainerMembersVerticalSplitterPosition = 922,
				SplitContainerMembersHorizontalSplitterPosition = 79
			});

			context.SaveChanges();
		}

		public void SafeSeed()
		{
			try
			{
				Seed(new ZigguratContext());
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
			}
		}
	}
}
