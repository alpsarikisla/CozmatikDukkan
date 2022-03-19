namespace CozmatikDukkan.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CozmatikDukkan.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CozmatikDukkan.Models.CozmatikModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CozmatikDukkan.Models.CozmatikModel context)
        {
            context.ManagerTypes.AddOrUpdate(m => m.ID, new ManagerType() { ID = 1, Name = "Yönetici" });
            context.ManagerTypes.AddOrUpdate(m => m.ID, new ManagerType() { ID = 2, Name = "Moderatör" });

            context.Managers.AddOrUpdate(m => m.ID, new Manager() { ID = 1, ManagerType_ID = 1, Name = "Alp", Surname = "Sarýkýþla", Mail = "a.sarikisla@hotmail.com", Password = "1234", Status = true });

        }
    }
}
