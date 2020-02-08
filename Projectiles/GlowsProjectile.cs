using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modicron.Projectiles
{
   public class GlowsProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 75; //sprite is 2 pixels wide
            projectile.height = 75; //sprite is 20 pixels tall
            projectile.aiStyle = 0; //projectile moves in a straight line
            projectile.friendly = true; //player projectile
            projectile.melee = true; //ranged projectile
            projectile.timeLeft = 600;
            projectile.tileCollide = false; //lasts for 600 frames/ticks. Terraria runs at 60FPS, so it lasts 10 seconds.
            aiType = ProjectileID.HolyArrow; //This clones the exact AI of the vanilla projectile Bullet.
        }

        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 234, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f);   //spawns dust behind it, this is a spectral light blue dust
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 3f)
            {
                projectile.alpha = 0;
            }
            if (projectile.ai[0] >= 20f)
            {
                projectile.ai[0] = 20f;
                projectile.velocity.Y += 0.075f;
            }
            if (Main.myPlayer == projectile.owner)
            {
                if (projectile.ai[1] >= 0f)
                {
                    projectile.penetrate = -1;
                }
                else if (projectile.penetrate < 0)
                {
                    projectile.penetrate = 1;
                }
                if (projectile.ai[1] >= 0f)
                {
                    projectile.ai[1] += 1f;
                }
                if (projectile.ai[1] > (float)Main.rand.Next(5, 30))
                {
                    projectile.ai[1] = -1000f;
                    float scaleFactor4 = projectile.velocity.Length();
                    Vector2 velocity = projectile.velocity;
                    velocity.Normalize();
                    int num161 = Main.rand.Next(2, 4);
                    if (Main.rand.Next(4) == 0)
                    {
                        num161++;
                    }
                    for (int num162 = 0; num162 < num161; num162++)
                    {
                        Vector2 vector12 = new Vector2((float)Main.rand.Next(-100, 101), (float)Main.rand.Next(-100, 101));
                        vector12.Normalize();
                        vector12 += velocity * 2f;
                        vector12.Normalize();
                        vector12 *= scaleFactor4;
                        Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vector12.X, vector12.Y, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0f, -1000f);
                    }
                }
            }
        }

        public override void Kill(int timeLeft)
        {

        }
    }
}
