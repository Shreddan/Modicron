using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Items
{
    public class SuperSonicStabber : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BasciSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Stabbin' around at the speed of sound!");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 2;
            item.useAnimation = 1;
            item.useStyle = 3;
            item.knockBack = 1;
            item.value = 1;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            
            
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