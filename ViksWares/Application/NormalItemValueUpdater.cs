﻿using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class NormalItemValueUpdater : IValueUpdater
{
    public void UpdateValue(Item item)
    {
        switch (item.SellBy)
        {
            case < 0:
                ValueModifier.DecreaseValue(item, 2);
                break;
            default:
                ValueModifier.DecreaseValue(item);
                break;
        }
        
        item.SellBy--;
    }

}