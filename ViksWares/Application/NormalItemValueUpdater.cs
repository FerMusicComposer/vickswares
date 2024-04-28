using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class NormalItemValueUpdater : IValueUpdater
{
    public void UpdateValue(Item item)
    {
        if (item.SellBy <= 0)
        {
            ValueModifier.DecreaseValue(item, 2);
        }
        
        ValueModifier.DecreaseValue(item);
        item.SellBy--;
    }

}