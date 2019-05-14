using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib
{
    class CoCSettings
    {
        public bool SillyMode { get; set; } = false;
        public bool GrimDarkMode { get; set; } = false;

        /// <summary>
        /// Don't show scenes that are clearly rape, including sex scenes
        /// resulting from an HP-based loss.
        /// <para>
        /// <list type="bullet">
        /// <item>If PC lost, then they simply pass out.</item>
        /// <item>If PC won, then sex options aren't presented.</item>
        /// <item>Rapey bad ends are replaced with death or something non-sexual.</item>
        /// <item>Same goes for all sexual bad ends if <c>LustLossCounts</c> is true.</item>
        /// </list>
        /// </para>
        /// </summary>
        /// 
        /// <remarks>
        /// <para>
        /// If <c>LustLossCounts</c> is false, some lust-based loss scenes may be
        /// altered to be consensual, more obviously consensual, or removed.
        /// </para>
        /// 
        /// <para>
        /// This setting does NOT affect declarations of intent to rape by
        /// non-PC characters (such as the starter imp).
        /// </para>
        /// 
        /// <para>
        /// Story note: if true, Mareth can be considered to be altered such
        /// that being passed-out is a universal turn-off.  Perhaps the doing 
        /// of Marae?
        /// </para>
        /// </remarks>
        public bool NoRape { get; set; } = true;
        /// <summary>
        /// Fucking or getting fucked as a result of a lust-based loss
        /// may or may not count as rape depending on how you interpret
        /// the game world.  Set this to true for lust-based loss scenes
        /// to be included in the "No Rape" setting.
        /// </summary>
        public bool LustLossCounts { get; set; } = false;
    }
}
