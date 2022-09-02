using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TobinStuff.Items
{
	public class SquirrelTooth : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Squireltooth"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("An extra long sword which inflicts debuffs.");
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 10; //40
			Item.height = 100; //40
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.scale = 2.5f;
			Item.ArmorPenetration = 10;

		}

				// still in your item
		public override void AddRecipes()
		{
			CreateRecipe()

				.AddIngredient<Items.Squirrellium>(7)
				.AddCondition(Recipe.Condition.TimeDay)
				.AddIngredient(ItemID.PurplePhaseblade, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
		

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(39 , 180, false);
			target.AddBuff(164 , 180, false);
			target.AddBuff(33 , 180, false);
		}
	}
}