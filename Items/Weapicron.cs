using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Items
{
    public class Weapicron : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BasciSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The Weapon of Lord Danicron of OLC");
        }

        public override void SetDefaults()
        {
            item.damage = 999;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 69420;
            item.value = 999999;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Binary");
            item.shootSpeed = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenChair, 42);
            //recipe.AddIngredient(ItemID.Wrench, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
