namespace SorteoRifa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Persona_Id", c => c.Int());
            CreateIndex("dbo.Tickets", "Persona_Id");
            AddForeignKey("dbo.Tickets", "Persona_Id", "dbo.Personas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Persona_Id", "dbo.Personas");
            DropIndex("dbo.Tickets", new[] { "Persona_Id" });
            DropColumn("dbo.Tickets", "Persona_Id");
        }
    }
}
