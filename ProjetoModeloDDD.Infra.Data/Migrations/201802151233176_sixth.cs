namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "Cliente");
            RenameColumn(table: "dbo.Cliente", name: "Name", newName: "Nome");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cliente", name: "Nome", newName: "Name");
            RenameTable(name: "dbo.Cliente", newName: "Clients");
        }
    }
}
