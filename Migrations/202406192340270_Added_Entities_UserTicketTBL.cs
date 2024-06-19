namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Entities_UserTicketTBL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTickets",
                c => new
                    {
                        UserTicketID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        TicketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserTicketID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTickets");
        }
    }
}
