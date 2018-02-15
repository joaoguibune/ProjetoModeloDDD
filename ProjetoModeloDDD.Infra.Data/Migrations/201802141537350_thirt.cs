namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Phone", c => c.String());
        }
    }
}
