using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class ParmigianoValueUpdater : IValueUpdater
{
    public void UpdateValue(Item item)
    {
        ValueModifier.IncreaseValue(item);
        item.SellBy--;
    }
}