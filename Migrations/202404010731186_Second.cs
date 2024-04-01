namespace Mini_projekat_2___Entity_Framework_MVVM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "Course");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Course", c => c.String());
        }
    }
}
