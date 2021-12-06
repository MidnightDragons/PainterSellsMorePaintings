using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace VanillaNPCShop
{
	public class VanillaNPCShop : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			switch (type)
			{
				case NPCID.Painter:
					// Cavern:
					shop.item[nextSlot].SetDefaults(ItemID.AmericanExplosive);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.CrownoDevoursHisLunch);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Discover);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.FatherofSomeone);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.FindingGold);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.GloriousNight);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.GuidePicasso);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Land);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheMerchant);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.NurseLisa);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.OldMiner);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.RareEnchantment);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Sunflowers);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TerrarianGothic);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Waldo);
					nextSlot++;
					// Dungeon:
					shop.item[nextSlot].SetDefaults(ItemID.BloodMoonRising);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.BoneWarp);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheCreationoftheGuide);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheCursedMan);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheDestroyer);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Dryadisque);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheEyeSeestheEnd);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.FacingtheCerebralMastermind);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.GloryoftheFire);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.GoblinsPlayingPoker);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.GreatWave);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheGuardiansGaze);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheHangedMan);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Impact);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.ThePersistencyofEyes);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.PoweredbyBirds);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheScreamer);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.SkellingtonJSkellingsworth);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.SparkyPainting);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.SomethingEvilisWatchingYou);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.StarryNight);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TrioSuperHeroes);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TheTwinsHaveAwoken);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.UnicornCrossingtheHallows);
					nextSlot++;
					// Hell:
					shop.item[nextSlot].SetDefaults(ItemID.DarkSoulReaper);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Darkness);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.DemonsEye);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.FlowingMagma);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.HandEarth);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.ImpFace);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.LakeofFire);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.LivingGore);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.OminousPresence);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.ShiningMoon);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.Skelehead);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.TrappedGhost);
					nextSlot++;
					// Goodie bags:
					shop.item[nextSlot].SetDefaults(ItemID.BitterHarvest);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.BloodMoonCountess);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.HallowsEve);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.JackingSkeletron);
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ItemID.MorbidCuriosity);
					nextSlot++;
					// Angler quest:
					shop.item[nextSlot].SetDefaults(ItemID.PillaginMePixels);
					nextSlot++;
					break;
			}
		}
	}
}