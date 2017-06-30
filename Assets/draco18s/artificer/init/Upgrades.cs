﻿using Assets.draco18s.artificer.upgrades;
using Assets.draco18s.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koopakiller.Numerics;

namespace Assets.draco18s.artificer.init {
	public static class Upgrades {
		public static class Cash {
			//public static Upgrade VENDOR_VALUE1 =				new UpgradeVendorEffectiveness(new BigInteger(5, 3), 0.25f);
			public static Upgrade HALVE_DOUBLE_WOOD1 =			new UpgradeHalveDouble  (new BigInteger(5, 5), Industries.WOOD, "HALVE_DOUBLE_WOOD1");
			public static Upgrade HALVE_DOUBLE_RED_BERRIES1 =	new UpgradeHalveDouble  (new BigInteger(75, 4), Industries.RED_BERRIES, "HALVE_DOUBLE_RED_BERRIES1");
			public static Upgrade HALVE_DOUBLE_BLUE_BERRIES1 =	new UpgradeHalveDouble  (new BigInteger(75, 4), Industries.BLUE_BERRIES, "HALVE_DOUBLE_BLUE_BERRIES1");
			public static Upgrade HALVE_DOUBLE_LEATHER1 =		new UpgradeHalveDouble  (new BigInteger(1, 6), Industries.LEATHER, "HALVE_DOUBLE_LEATHER1");
			public static Upgrade LEATHER_BOOTS1 =				new UpgradeIndustryValue(new BigInteger(5, 6), 5, Industries.LEATHER_BOOTS, "LEATHER_BOOTS1");
			//torches. What to do: don't repeat them
			public static Upgrade HALVE_DOUBLE_TORCHES =		new UpgradeHalveDouble  (new BigInteger(5, 6), Industries.TORCHES, "HALVE_DOUBLE_TORCHES1");
				public static Upgrade QUEST_RECHARGE1 =				new UpgradeQuestSpeed   (new BigInteger(1, 7), 120, "QUEST_RECHARGE1");
			//torches. What to do: don't repeat them
			public static Upgrade TORCHES =						new UpgradeIndustryValue(new BigInteger(5, 7), 5, Industries.TORCHES, "TORCHES1");
			public static Upgrade LEATHER_ARMOR1 =				new UpgradeIndustryValue(new BigInteger(5, 7), 5, Industries.ARMOR_LEATHER, "LEATHER_ARMOR1");
			public static Upgrade SIMPLE_TOOLS1 =				new UpgradeIndustryValue(new BigInteger(75, 6), 5, Industries.SIMPLE_TOOLS, "SIMPLE_TOOLS1");
			public static Upgrade QUARTERSTAFF1 =				new UpgradeIndustryValue(new BigInteger(1, 8), 5, Industries.QUARTERSTAFF, "QUARTERSTAFF1");
			public static Upgrade LIGHT_CROSSBOW1 =				new UpgradeIndustryValue(new BigInteger(5, 8), 5, Industries.LIGHT_CROSSBOW, "LIGHT_CROSSBOW1");
			public static Upgrade HALVE_DOUBLE_GLASS1 =			new UpgradeHalveDouble	(new BigInteger(1, 9), Industries.GLASS, "HALVE_DOUBLE_GLASS1");
				public static Upgrade CLICK_RATE1 =					new UpgradeClickRate	(new BigInteger(2, 9), 0.25f, "CLICK_RATE1");
			public static Upgrade HALVE_DOUBLE_NIGHTSHADE1 =	new UpgradeHalveDouble  (new BigInteger(5, 9), Industries.NIGHTSHADE, "HALVE_DOUBLE_NIGHTSHADE1");
			//health/mana potions aren't end-tier. What to do: don't repeat them
			public static Upgrade HEALTH =						new UpgradeIndustryValue(new BigInteger(5, 9), 5, Industries.POT_HEALTH, "HEALTH1");
			public static Upgrade MANA =						new UpgradeIndustryValue(new BigInteger(5, 9), 5, Industries.POT_MANA, "MANA1");
			public static Upgrade WOOD_BUCKLER1 =				new UpgradeIndustryValue(new BigInteger(1, 10), 5, Industries.WOOD_BUCKLER, "WOOD_BUCKLER1");
			public static Upgrade HALVE_DOUBLE_MANDRAKE1 =		new UpgradeHalveDouble  (new BigInteger(2, 10), Industries.MANDRAKE, "HALVE_DOUBLE_MANDRAKE1");
			public static Upgrade HALVE_DOUBLE_BLOOD_MOSS1 =	new UpgradeHalveDouble  (new BigInteger(2, 10), Industries.BLOOD_MOSS, "HALVE_DOUBLE_BLOOD_MOSS1");
			public static Upgrade HALVE_DOUBLE_BANROOT1 =		new UpgradeHalveDouble  (new BigInteger(2, 10), Industries.BANROOT, "HALVE_DOUBLE_BANROOT1");
			public static Upgrade HALVE_DOUBLE_MUSHROOMS1 =		new UpgradeHalveDouble  (new BigInteger(2, 10), Industries.MUSHROOMS, "HALVE_DOUBLE_MUSHROOMS1");
				public static Upgrade JOURNEYMAN_RATE1 =			new UpgradeJourneymanRate(new BigInteger(5, 10), 600, "JOURNEYMAN_RATE1");
			public static Upgrade STR1 =						new UpgradeIndustryValue(new BigInteger(1, 11), 5, Industries.POT_STRENGTH, "STR1");
			public static Upgrade AGL1 =						new UpgradeIndustryValue(new BigInteger(1, 11), 5, Industries.POT_AGILITY, "AGL1");
			public static Upgrade INT1 =						new UpgradeIndustryValue(new BigInteger(1, 11), 5, Industries.POT_INTELLIGENCE, "INT1");
			public static Upgrade CHA1 =						new UpgradeIndustryValue(new BigInteger(1, 11), 5, Industries.POT_CHARISMA, "CHA1");
			public static Upgrade POT_RESTORATION1 =			new UpgradeIndustryValue(new BigInteger(5, 11), 5, Industries.POT_RESTORATION, "POT_RESTORATION1");
			public static Upgrade HALVE_DOUBLE_IRON_ORE1 =		new UpgradeHalveDouble  (new BigInteger(1, 12), Industries.IRON_ORE, "HALVE_DOUBLE_IRON_ORE1");
				public static Upgrade ITEM_CASH_VALUE1 =			new UpgradeCashValue	(new BigInteger(1, 13), 0.1f, "ITEM_CASH_VALUE1");
				public static Upgrade QUEST_RECHARGE2 =				new UpgradeQuestSpeed   (new BigInteger(1, 14), 120, "QUEST_RECHARGE2");
			public static Upgrade IRON_SWORD1 =					new UpgradeIndustryValue(new BigInteger(1, 16), 5, Industries.IRON_SWORD, "IRON_SWORD1");
			public static Upgrade LANTERN1 =					new UpgradeIndustryValue(new BigInteger(5, 16), 5, Industries.LANTERN, "LANTERN1");
			public static Upgrade IMPROVED_CLOAK1 =				new UpgradeIndustryValue(new BigInteger(1, 17), 5, Industries.IMPROVED_CLOAK, "IMPROVED_CLOAK1");
			public static Upgrade IRON_HELMET1 =				new UpgradeIndustryValue(new BigInteger(1, 18), 5, Industries.IRON_HELMET, "IRON_HELMET1");
			public static Upgrade IRON_RING1 =					new UpgradeIndustryValue(new BigInteger(1, 19), 5, Industries.IRON_RING, "IRON_RING1");
			public static Upgrade IRON_BOOTS1 =					new UpgradeIndustryValue(new BigInteger(1, 20), 5, Industries.IRON_RING, "IRON_BOOTS1");
			public static Upgrade HALVE_DOUBLE_GOLD_ORE1 =		new UpgradeHalveDouble  (new BigInteger(5, 20), Industries.GOLD_ORE, "HALVE_DOUBLE_GOLD_ORE1");
			public static Upgrade HOLY_SYMBOL1 =				new UpgradeIndustryValue(new BigInteger(1, 21), 5, Industries.HOLY_SYMBOL, "HOLY_SYMBOL1");
			public static Upgrade UNHOLY_SYMBOL1 =				new UpgradeIndustryValue(new BigInteger(1, 21), 5, Industries.UNHOLY_SYMBOL, "UNHOLY_SYMBOL1");
			public static Upgrade ARMOR_CHAIN1 =				new UpgradeIndustryValue(new BigInteger(5, 21), 5, Industries.ARMOR_CHAIN, "ARMOR_CHAIN1");
				public static Upgrade CLICK_RATE2 =					new UpgradeClickRate	(new BigInteger(1, 22), 0.25f, "CLICK_RATE2");
			public static Upgrade IRON_SHIELD1 =				new UpgradeIndustryValue(new BigInteger(5, 22), 5, Industries.IRON_SHIELD, "IRON_SHIELD1");
			public static Upgrade HOLY_WATER1 =					new UpgradeIndustryValue(new BigInteger(1, 23), 5, Industries.HOLY_WATER, "HOLY_WATER1");
			public static Upgrade UNHOLY_WATER1 =				new UpgradeIndustryValue(new BigInteger(1, 23), 5, Industries.UNHOLY_WATER, "UNHOLY_WATER1");
			public static Upgrade HALVE_DOUBLE_KELPWEED1 =		new UpgradeHalveDouble  (new BigInteger(5, 20), Industries.KELPWEED, "HALVE_DOUBLE_KELPWEED1");
			public static Upgrade HALVE_DOUBLE_STONEROOT1 =		new UpgradeHalveDouble  (new BigInteger(5, 20), Industries.STONEROOT, "HALVE_DOUBLE_STONEROOT1");
			public static Upgrade HALVE_DOUBLE_SAGE_GRASS1 =	new UpgradeHalveDouble  (new BigInteger(5, 20), Industries.SAGE_GRASS, "HALVE_DOUBLE_SAGE_GRASS1");
			public static Upgrade HALVE_DOUBLE_PHOENIX1 =		new UpgradeHalveDouble  (new BigInteger(5, 20), Industries.PHOENIX_FEATHERS, "HALVE_DOUBLE_PHOENIX_FEATHERS1");
				public static Upgrade QUEST_MULTI1 =				new UpgradeQuestRenown	(new BigInteger(1, 24), 0.5f, "QUEST_MULTI1");
				public static Upgrade RESEARCH1 =					new UpgradeResearchSpeed(new BigInteger(1, 25), 0.05f, "RESEARCH1");
			public static Upgrade POT_WATER_BREATH1 =			new UpgradeIndustryValue(new BigInteger(5, 25), 5, Industries.POT_WATER_BREATH, "POT_WATER_BREATH1");
			public static Upgrade POT_BARKSKIN1 =				new UpgradeIndustryValue(new BigInteger(1, 26), 5, Industries.POT_BARKSKIN, "POT_BARKSKIN1");
			public static Upgrade POT_ALERTNESS1 =				new UpgradeIndustryValue(new BigInteger(5, 26), 5, Industries.POT_ALERTNESS, "POT_ALERTNESS1");
			public static Upgrade POT_REVIVE1 =					new UpgradeIndustryValue(new BigInteger(1, 27), 5, Industries.POT_REVIVE, "POT_REVIVE1");
			public static Upgrade GOLD_RING1 =					new UpgradeIndustryValue(new BigInteger(5, 27), 5, Industries.GOLD_RING, "GOLD_RING1");
			public static Upgrade INCOME1 =						new UpgradeIncome		(new BigInteger(1, 28), 3, "INCOME1");
			
			//basically, repeat now

		}
		public static class Renown {

			public static Upgrade CLICK_RATE1 =				new UpgradeClickRate	(10, 0.25f, "CLICK_RATE1");
			public static Upgrade JOURNEYMAN_RATE1 =		new UpgradeJourneymanRate(25, 600, "JOURNEYMAN_RATE1");
			public static Upgrade LOOTING1 =				new UpgradeTheLoots     (50, 0.5f, "LOOTING1");
			public static Upgrade RESEARCH1 =				new UpgradeResearchSpeed(75, 0.5f, "RESEARCH1");
			public static Upgrade START_CASH1 =				new UpgradeStartingCash	(90, 10, "START_CASH1");
			public static Upgrade ITEM_CASH_VALUE1 =		new UpgradeCashValue	(100, 0.1f, "ITEM_CASH_VALUE1");
			public static Upgrade QUEST_MULTI1 =			new UpgradeQuestRenown	(250, 1.5f, "QUEST_MULTI1");
			public static Upgrade INCOME1 =					new UpgradeIncome		(500, 2, "INCOME1");
			public static Upgrade RENOWN_MULTI1 =			new UpgradeRenownMulti	(750, 0.01f, "RENOWN_MULTI1");
			public static Upgrade START_CASH2 =				new UpgradeStartingCash	(1000, 10, "START_CASH2");
			public static Upgrade JOURNEYMAN_RATE2 =		new UpgradeJourneymanRate(2500, 600, "JOURNEYMAN_RATE2");
			public static Upgrade LOOTING2 =				new UpgradeTheLoots     (5000, 0.5f, "LOOTING2");
			public static Upgrade RESEARCH2 =				new UpgradeResearchSpeed(7500, 0.5f, "RESEARCH2");
			public static Upgrade ITEM_CASH_VALUE2 =		new UpgradeCashValue	(10000, 0.1f, "ITEM_CASH_VALUE2");
			public static Upgrade QUEST_MULTI2 =			new UpgradeQuestRenown	(25000, 1.5f, "QUEST_MULTI2");
			public static Upgrade INCOME2 =					new UpgradeIncome		(50000, 5, "INCOME2");
			public static Upgrade RENOWN_MULTI2 =			new UpgradeRenownMulti	(75000, 0.01f, "RENOWN_MULTI2");
			//repeat:
			public static Upgrade CLICK_RATE2 =				new UpgradeClickRate	(100000, 0.25f, "CLICK_RATE2");
			public static Upgrade JOURNEYMAN_RATE3 =		new UpgradeJourneymanRate(250000, 600, "JOURNEYMAN_RATE3");
			public static Upgrade LOOTING3 =				new UpgradeTheLoots     (500000, 0.5f, "LOOTING3");
			public static Upgrade RESEARCH3 =				new UpgradeResearchSpeed(750000, 0.5f, "RESEARCH3");
			public static Upgrade ITEM_CASH_VALUE3 =		new UpgradeCashValue	(1000000, 0.1f, "ITEM_CASH_VALUE3");
			public static Upgrade QUEST_MULTI3 =			new UpgradeQuestRenown	(2500000, 1.5f, "QUEST_MULTI3");
			public static Upgrade INCOME3 =					new UpgradeIncome		(5000000, 2, "INCOME3");
			public static Upgrade RENOWN_MULTI3 =			new UpgradeRenownMulti	(7500000, 0.01f, "RENOWN_MULTI3");
			public static Upgrade START_CASH3 =				new UpgradeStartingCash	(10000000, 10, "START_CASH4");
			public static Upgrade JOURNEYMAN_RATE4 =		new UpgradeJourneymanRate(25000000, 600, "JOURNEYMAN_RATE4");
			public static Upgrade LOOTING4 =				new UpgradeTheLoots     (50000000, 0.5f, "LOOTING4");
			public static Upgrade RESEARCH4 =				new UpgradeResearchSpeed(75000000, 0.5f, "RESEARCH4");
			public static Upgrade ITEM_CASH_VALUE4 =		new UpgradeCashValue	(100000000, 0.2f, "ITEM_CASH_VALUE4");
			public static Upgrade QUEST_MULTI4 =			new UpgradeQuestRenown	(250000000, 1.5f, "QUEST_MULTI4");
			public static Upgrade INCOME4 =					new UpgradeIncome		(500000000, 5, "INCOME4");
			public static Upgrade RENOWN_MULTI4 =			new UpgradeRenownMulti	(750000000, 0.02f, "RENOWN_MULTI4");
			//decrease enchantment costs?
		}
		#region hidden
		//public static Upgrade WOOD_LEVEL1 =				new UpgradeIndustryLevel(10000, 10, Industries.WOOD, "WOOD_LEVEL1");
		//public static Upgrade CHARCOAL_LEVEL1 =			new UpgradeIndustryLevel(25000, 10, Industries.CHARCOAL, "CHARCOAL_LEVEL1");
		//public static Upgrade RED_BERRIES_LEVEL1 =		new UpgradeIndustryLevel(50000, 10, Industries.RED_BERRIES, "RED_BERRIES_LEVEL1");
		//public static Upgrade BLUE_BERRIES_LEVEL1 =		new UpgradeIndustryLevel(50000, 10, Industries.BLUE_BERRIES, "BLUE_BERRIES_LEVEL1");
		//public static Upgrade LEATHER_LEVEL1 =			new UpgradeIndustryLevel(250000, 10, Industries.LEATHER, "LEATHER_LEVEL1");
		//public static Upgrade GLASS_LEVEL1 =			new UpgradeIndustryLevel(500000, 10, Industries.GLASS, "GLASS_LEVEL1");
		//public static Upgrade IRON_ORE_LEVEL1 =			new UpgradeIndustryLevel(750000, 10, Industries.IRON_ORE, "IRON_ORE_LEVEL1");
		//public static Upgrade GOLD_ORE_LEVEL1 =			new UpgradeIndustryLevel(100000, 10, Industries.GOLD_ORE, "GOLD_ORE_LEVEL1");
		#endregion

		//skill & guildmaster bonus ideas:
		//TYPE is defined as [WOOD,ANIMAL,IRON,GOLD,GLASS,HERB, etc]
		//increase all income based on #of TYPE owned
		//increase all income of TYPE
		//reduce build cost of TYPE
		//reduce quest demands of TYPE
		//gain $ when quest buys TYPE

		//temporary boosty things
		//NEEDS SUPPORTING ARCHITECTURE
		//clicking gives 5 seconds increased income
		//clicking makes that industry faster for 5 seconds
	}
}
