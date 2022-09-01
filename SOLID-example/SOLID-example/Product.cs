namespace SOLID_example
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} - {Name} - {this.GetPriceTagMaker().MakePriceTagForProduct(this)}";
        }
    }

}