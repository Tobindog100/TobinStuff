using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TobinStuff.Items
{
	public class The_Tubasaber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The_Tubasaber"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Magic;
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
			Item.scale = 3f;
			Item.ArmorPenetration = 10;
		}

				// still in your item
		public override void AddRecipes()
		{
			CreateRecipe()
				//.AddIngredient<Items.Weapons.ExampleSword>()
				.AddIngredient<Items.Squirrellium>(7)
				.AddCondition(Recipe.Condition.TimeDay)
				.AddIngredient(ItemID.PurplePhaseblade, 5)
//				.AddIngredient(this, "Squirrellium");
				.Register();
		}
		}
}