namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AcunMedyaFestavaLive.DataAccess.Context.FestavaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AcunMedyaFestavaLive.DataAccess.Context.FestavaContext context)
        {

        }
    }
}
