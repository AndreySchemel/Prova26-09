namespace DojoArtesMarciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFaixas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Branca', '6k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Amarela', '5k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Roxa', '4k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Verde', '3k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Azul', '2k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Marrom', '1k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Grau) VALUES ('Preta', '1d')");
        }
        
        public override void Down()
        {
        }
    }
}
