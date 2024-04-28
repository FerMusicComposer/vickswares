using System;
using ViksWares.Models;

namespace ViksWares.Application.Abstractions;

public static class ValueModifier
{
    public static void IncreaseValue(Item item, int amount = 1)
    {
        item.Value = Math.Min(item.Value + amount, 50);
    }

    public static void DecreaseValue(Item item, int amount = 1)
    {
        item.Value = Math.Max(item.Value - amount, 0);
    }
}