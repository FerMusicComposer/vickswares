using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class ConcertTicketsValueUpdater : IValueUpdater
{
    public void UpdateValue(Item item)
    {
        switch (item.SellBy)
        {
            case < 0:
                item.Value = 0;
                break;
            case <=5:
                ValueModifier.IncreaseValue(item, 3);
                break;
            case <= 10 when item.Value > 5:
                ValueModifier.IncreaseValue(item, 2);
                break;
            default:
                ValueModifier.IncreaseValue(item);
                break;
        }
        
        item.SellBy--;
    }
}