using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class RefrigeratedValueUpdater :IValueUpdater
{
    public void UpdateValue(Item item)
    {
        switch (item.SellBy)
        {
            case < 0:
                ValueModifier.DecreaseValue(item, 4);
                break;
            default:
                ValueModifier.DecreaseValue(item, 2);
                break;
        }
        
        item.SellBy--;
    }
}