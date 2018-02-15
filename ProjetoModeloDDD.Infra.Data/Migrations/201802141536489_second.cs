namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Phone");
        }
    }
}
