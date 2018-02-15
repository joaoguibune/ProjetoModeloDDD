namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Sobrenome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Phone", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Phone", c => c.String());
            AlterColumn("dbo.Cliente", "Email", c => c.String());
            AlterColumn("dbo.Cliente", "Sobrenome", c => c.String());
            AlterColumn("dbo.Cliente", "Nome", c => c.String());
        }
    }
}
