using HarmonyLib;
using XRL.UI;
using XRL.World;
using XRL.World.Parts;
using GameOptions = XRL.UI.Options;
using QudUXOptions = QudUX.Concepts.Options;

namespace QudUX.HarmonyPatches
{
    /// <summary>
    /// This patch is related to QudUX's trader dialog feature (ask when the trader will restock)
    /// </summary>
    [HarmonyPatch(typeof(TradeUI))]
    class Patch_XRL_UI_TradeUI
    {
        [HarmonyPrefix]
        [HarmonyPatch("ShowTradeScreen")]
        public static void Prefix(GameObject Trader)
        {
            QudUX_ConversationHelper.SetTraderInteraction(Trader);
        }
    }
}
