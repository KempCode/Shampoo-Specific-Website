namespace Assignment3._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ImageURL", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ImageAlternativeText", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ImageAlternativeText", c => c.String());
            AlterColumn("dbo.Products", "ImageURL", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Brand", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Type", c => c.String());
        }
    }
}
