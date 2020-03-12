namespace LibDatosEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblPaciente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        PacienteID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DNI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PacienteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
