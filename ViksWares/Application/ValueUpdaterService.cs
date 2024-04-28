using System;
using System.Collections.Generic;
using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class ValueUpdaterService
{
    private NormalItemValueUpdater _normalItem = new();

    private readonly Dictionary<Func<Item, bool>, Func<IValueUpdater>> _valueUpdaterMap = new()
    {
        {
            item => item.Name.Contains("Parmigiano", System.StringComparison.CurrentCultureIgnoreCase),
            () => new ParmigianoValueUpdater()
        },
        {
            item => item.Name.Contains("Concert tickets to Talkins Festival", System.StringComparison.CurrentCultureIgnoreCase),
            () => new ConcertTicketsValueUpdater()
        },
        {
            item => item.Name.Contains("Refrigerated", System.StringComparison.CurrentCultureIgnoreCase),
            () => new RefrigeratedValueUpdater()
        }
    };
    
    public void UpdateItemValue(Item item)
    {
        foreach (var updater in _valueUpdaterMap)
        {
            if (!updater.Key(item)) continue;
            
            updater.Value().UpdateValue(item);
            return;
        }
        _normalItem.UpdateValue(item);
    }
}