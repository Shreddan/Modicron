using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Projectiles
{
    public class Binary : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30; //sprite is 2 pixels wide
            projectile.height = 30; //sprite is 20 pixels tall
            projectile.aiStyle = 0; //projectile moves in a straight line
            projectile.friendly = true; //player projectile
            projectile.melee = true; //ranged projectile
            projectile.timeLeft = 600; //lasts for 600 frames/ticks. Terraria runs at 60FPS, so it lasts 10 seconds.
            aiType = ProjectileID.Bullet; //This clones the exact AI of the vanilla projectile Bullet.
        }

        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 46, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f);   //spawns dust behind it, this is a spectral light blue dust
        }

        public override void Kill(int timeLeft)
        {
            
        }
    }
}
