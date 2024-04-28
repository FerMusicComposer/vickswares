using System.Collections.Generic;

namespace ViksWares
{
    public class ViksWares
    {
        private IList<Item> _items;

        public ViksWares(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateValue()
        {
            foreach (var item in _items)
            {
                
            }
        }
    }
}
