using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Items
{
    public class EnchantedFrostDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BasciSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Throws a returning Frost Dagger that frost burns your foe");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 8;
            item.useAnimation = 1;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 1;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.UseNoGraphic = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.ThrowingKnife, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}