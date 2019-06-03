using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    /// <summary>
    /// Delegate for modifying incoming adjustments.
    /// </summary>
    /// <param name="value">The base adjustment value.</param>
    /// <returns>The amount to adjust the adjustment value.</returns>
    public delegate decimal AdjustmentModifier(decimal adjustment);

    /// <summary>
    /// Delegate for modifying a value.
    /// </summary>
    /// <param name="value">The base value.</param>
    /// <returns>The amount to adjust the value.</returns>
    public delegate decimal DynamicModifier(decimal value);

    /// <summary>
    /// Delegate for setting a value.
    /// </summary>
    /// <returns>The amount to set the value to.</returns>
    public delegate decimal DynamicSetter();
}
