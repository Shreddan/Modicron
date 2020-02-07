using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Items
{
    public class EnchantedFlyingDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BasciSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Throws a seemingly endless stream of daggers");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.thrown = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 1;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 1;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.shoot = 93;
            Items.shootSpeed = 15;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.Gel, 25);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}