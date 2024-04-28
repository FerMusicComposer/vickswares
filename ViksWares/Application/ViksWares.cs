using System.Collections.Generic;
using ViksWares.Models;

namespace ViksWares.Application
{
    public class ViksWares(IList<Item> items)
    {
        private IList<Item> _items = items;
        private ValueUpdaterService _valueUpdater = new ValueUpdaterService();
        
        public void UpdateValue()
        {
            foreach (var item in _items)
            {
                _valueUpdater.UpdateItemValue(item);
            }
        }
    }
}
