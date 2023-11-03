using DesignPatterns.Adapter.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Adapter.Implementations
{
    public class JsonConverter
    {

        private IEnumerable<Product> _productData;

        public JsonConverter(IEnumerable<Product> productData)
        {
            _productData = productData;
        }

        public void ConvertToJson()
        {
            Console.WriteLine(JsonConvert.SerializeObject(_productData, Formatting.Indented));
        }
    }
}
