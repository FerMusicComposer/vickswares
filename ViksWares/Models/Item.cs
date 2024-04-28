namespace ViksWares.Models
{ 
    public class Item
    {
        public string Name { get; set; }
        public int SellBy { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return $"{Name,-36} {SellBy,-10} {Value,-5}";
        }  
    }
}
