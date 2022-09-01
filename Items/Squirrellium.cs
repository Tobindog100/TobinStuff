using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using ExampleMod.Content.Items.Placeable;
//using ExampleMod.Content.Items.Placeable.Furniture;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Terraria;

namespace TobinStuff.Items
{
	public class Squirrellium : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Ingot for the Squirrellium set"); // The (English) text shown below your item's name
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 500; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults()
		{
			Item.width = 20; // The item texture's width
			Item.height = 20; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
			Item.value = Item.buyPrice(silver: 10); // The value of the item in copper coins. Item.buyPrice & Item.sellPrice are helper methods that returns costs in copper coins based on platinum/gold/silver/copper arguments provided to it.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe(5)
				.AddIngredient(ItemID.Squirrel, 5)
				.AddIngredient(ItemID.Obsidian, 4)
				.AddIngredient(ItemID.CrystalShard, 5)
				.AddCondition(Recipe.Condition.TimeDay)
				.AddTile(TileID.WorkBenches)
				.Register();
		}

		/*	// Researching the Example item will give you immediate access to the torch, block, wall and workbench!
			public override void OnResearched(bool fullyResearched)
			{
				if (fullyResearched)
				{
					CreativeUI.ResearchItem(ModContent.ItemType<ExampleTorch>());
					CreativeUI.ResearchItem(ModContent.ItemType<ExampleBlock>());
					CreativeUI.ResearchItem(ModContent.ItemType<ExampleWall>());
					CreativeUI.ResearchItem(ModContent.ItemType<ExampleWorkbench>());
				} 
			} */
	}
} 