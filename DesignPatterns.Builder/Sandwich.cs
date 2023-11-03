namespace DesignPatterns.Builder
{
    public class Sandwich
    {
        public string Bread { get; set; } = string.Empty;
        public string Veggies { get; set; } = string.Empty;
        public string Protein { get; set; } = string.Empty;
        public string Condiments { get; set; } = string.Empty;
        public string Cheese { get; set; } = string.Empty;

        public Sandwich()
        {
        }

        public Sandwich(string bread, string veggies, string protein, string condiments, string cheese)
        {
            Bread = bread;
            Veggies = veggies;
            Protein = protein;
            Condiments = condiments;
            Cheese = cheese;
        }
    }
}