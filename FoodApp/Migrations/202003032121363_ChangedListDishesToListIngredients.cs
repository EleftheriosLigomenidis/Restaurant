namespace FoodApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedListDishesToListIngredients : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "Dish_DishId", "dbo.Dishes");
            DropForeignKey("dbo.Dishes", "Ingredient_IngredientId", "dbo.Ingredients");
            DropIndex("dbo.Dishes", new[] { "Dish_DishId" });
            DropIndex("dbo.Dishes", new[] { "Ingredient_IngredientId" });
            CreateTable(
                "dbo.IngredientDishes",
                c => new
                    {
                        Ingredient_IngredientId = c.Int(nullable: false),
                        Dish_DishId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_IngredientId, t.Dish_DishId })
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_IngredientId, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_DishId, cascadeDelete: true)
                .Index(t => t.Ingredient_IngredientId)
                .Index(t => t.Dish_DishId);
            
            AddColumn("dbo.Dishes", "DishType", c => c.Int(nullable: false));
            AddColumn("dbo.Tables", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Dishes", "Dish_DishId");
            DropColumn("dbo.Dishes", "Ingredient_IngredientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "Ingredient_IngredientId", c => c.Int());
            AddColumn("dbo.Dishes", "Dish_DishId", c => c.Int());
            DropForeignKey("dbo.IngredientDishes", "Dish_DishId", "dbo.Dishes");
            DropForeignKey("dbo.IngredientDishes", "Ingredient_IngredientId", "dbo.Ingredients");
            DropIndex("dbo.IngredientDishes", new[] { "Dish_DishId" });
            DropIndex("dbo.IngredientDishes", new[] { "Ingredient_IngredientId" });
            DropColumn("dbo.Tables", "MyProperty");
            DropColumn("dbo.Dishes", "DishType");
            DropTable("dbo.IngredientDishes");
            CreateIndex("dbo.Dishes", "Ingredient_IngredientId");
            CreateIndex("dbo.Dishes", "Dish_DishId");
            AddForeignKey("dbo.Dishes", "Ingredient_IngredientId", "dbo.Ingredients", "IngredientId");
            AddForeignKey("dbo.Dishes", "Dish_DishId", "dbo.Dishes", "DishId");
        }
    }
}
