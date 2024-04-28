using ViksWares.Application.Abstractions;
using ViksWares.Models;

namespace ViksWares.Application;

public class ValueUpdaterService
{
    private ParmigianoValueUpdater _parmigiano = new ParmigianoValueUpdater();
    private NormalItemValueUpdater _normalItem = new NormalItemValueUpdater();
    
    public void UpdateItemValue(Item item)
    {
        if (item.Name.Contains("Parmigiano"))
        {
            _parmigiano.UpdateValue(item);
        }
        else
        {
            _normalItem.UpdateValue(item);
        }
    }
}