﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using HarmonyLib;
using RimWorld;

namespace PokeWorld
{
	[HarmonyPatch(typeof(PriceUtility))]
	[HarmonyPatch("PawnQualityPriceFactor")]
	class PriceUtility_PawnQualityPriceFactor_Patch
	{
		public static void Postfix(Pawn __0, StringBuilder __1, ref float __result)
		{
			CompPokemon comp = __0.TryGetComp<CompPokemon>();
			if (comp != null)
			{
				__1?.AppendLine("PW_Pokemon".Translate());
				float levelFactor = comp.levelTracker.level / 20f;
				__1?.AppendLine("   " + "PW_PriceFactorLevel".Translate(comp.levelTracker.level, levelFactor.ToStringPercent()));
				__result *= levelFactor;
				if (comp.shinyTracker.isShiny)
                {
					float shinyFactor = 4;
					__1?.AppendLine("   " + "PW_PriceFactorShiny".Translate(shinyFactor.ToStringPercent()));
					__result *= shinyFactor;
				}
						
			}
		}
	}
}
