using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace TobinStuff.Items
{
    public class SquirrelSaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.name = "Squirrel Saw";
            Item.damage = 30;
            Item.melee = true;
            Item.width = 30;
            Item.height = 30;
            Item.toolTip = "A spinning acorn of doom";
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.noUseGraphic = true;
            Item.useStyle = 1;
            Item.knockBack = 3;
            Item.value = 8;
            Item.rare = 6;
            Item.shootSpeed = 12f;
            Item.shoot = mod.ProjectileType("BoomerangProjectile");
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
    }
}