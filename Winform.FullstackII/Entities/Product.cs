namespace Winform.FullstackII.Entities
{
    public class Product
    {
        internal string? name;

        public int Id { get; internal set; }
        public string? Name { get; internal set; }

        public int? Stock { get; internal set;}
    }
}