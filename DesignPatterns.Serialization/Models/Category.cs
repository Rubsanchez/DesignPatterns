namespace DesignPatterns.Serialization.Models
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; } = string.Empty;

        public Category(string name)
        {
            Name = name;
        }
    }
}
