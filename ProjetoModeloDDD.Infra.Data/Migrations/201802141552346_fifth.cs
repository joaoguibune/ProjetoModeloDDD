namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Clients");
            RenameColumn(table: "dbo.Clients", name: "Nome", newName: "Name");
            AddColumn("dbo.Clients", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Phone");
            RenameColumn(table: "dbo.Clients", name: "Name", newName: "Nome");
            RenameTable(name: "dbo.Clients", newName: "Clientes");
        }
    }
}
