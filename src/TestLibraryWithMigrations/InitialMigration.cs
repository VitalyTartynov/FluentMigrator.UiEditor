using FluentMigrator;

namespace TestLibraryWithMigrations
{
    [Migration(1, "Some description")]
    public class InitialMigration : Migration
    {
        public override void Up()
        {
            throw new System.NotImplementedException();
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}