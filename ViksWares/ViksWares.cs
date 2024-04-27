using System.Collections.Generic;

namespace csharp
{
    public class ViksWares
    {
        IList<Item> Items;
        public ViksWares(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateValue()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Parmigiano" && Items[i].Name != "Concert tickets to Talkins Festival")
                {
                    if (Items[i].Value > 0)
                    {
                        if (Items[i].Name != "Saffron Powder")
                        {
                            Items[i].Value = Items[i].Value - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Value < 50)
                    {
                        Items[i].Value = Items[i].Value + 1;

                        if (Items[i].Name == "Concert tickets to Talkins Festival")
                        {
                            if (Items[i].SellBy < 11)
                            {
                                if (Items[i].Value < 50)
                                {
                                    Items[i].Value = Items[i].Value + 1;
                                }
                            }

                            if (Items[i].SellBy < 6)
                            {
                                if (Items[i].Value < 50)
                                {
                                    Items[i].Value = Items[i].Value + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Saffron Powder")
                {
                    Items[i].SellBy = Items[i].SellBy - 1;
                }

                if (Items[i].SellBy < 0)
                {
                    if (Items[i].Name != "Aged Parmigiano")
                    {
                        if (Items[i].Name != "Concert tickets to Talkins Festival")
                        {
                            if (Items[i].Value > 0)
                            {
                                if (Items[i].Name != "Saffron Powder")
                                {
                                    Items[i].Value = Items[i].Value - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Value = Items[i].Value - Items[i].Value;
                        }
                    }
                    else
                    {
                        if (Items[i].Value < 50)
                        {
                            Items[i].Value = Items[i].Value + 1;
                        }
                    }
                }
            }
        }
    }
}
