using TobinStuff.Items.Projectiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TobinStuff.Items
{
	public class SquirrelTail : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			// This method quickly sets the whip's properties.
			// Mouse over to see its parameters.
			Item.DefaultToWhip(ModContent.ProjectileType<SquirrelTailPro>(), 20, 2, 4);

			Item.shootSpeed = 4;
			Item.rare = ItemRarityID.Green;
			Item.crit = 32;
			Item.channel = true;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(4912, 1)
				.AddIngredient<Items.Squirrellium>(7)
				.AddCondition(Recipe.Condition.TimeDay)
				.AddTile(TileID.Anvils)
				.Register();
		}

		// Makes the whip receive melee prefixes
		//public override bool MeleePrefix()
		//{
			//return true;
		//}
	}
}