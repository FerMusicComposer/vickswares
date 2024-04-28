using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class ConcertTicketsValueUpdater : IValueUpdater
{
    public void UpdateValue(Item item)
    {
        if (item.SellBy <= 0)
        {
            item.Value = 0;
        }
        else
        {
            switch (item.SellBy)
            {
                case <=5 when item.Value > 0:
                    ValueModifier.IncreaseValue(item, 3);
                    break;
                case <= 10 when item.Value > 5:
                    ValueModifier.IncreaseValue(item, 2);
                    break;
                default:
                    ValueModifier.IncreaseValue(item);
                    break;
            }
        }
        
        item.SellBy--;
    }
}