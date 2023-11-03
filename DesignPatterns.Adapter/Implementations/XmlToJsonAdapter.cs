using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter.Implementations
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private XmlConverter _converter;

        public XmlToJsonAdapter(XmlConverter converter)
        {
            _converter = converter;
        }

        public void ConvertXmlToJson()
        {
            var products = _converter.GetXml()!
                .Element("Products")!
                .Elements("Product")
                .Select(x => new Product
                {
                    Name = x.Attribute("Name")!.Value,
                    Price = int.Parse(x.Attribute("Price")!.Value)
                });

            new JsonConverter(products).ConvertToJson();
        }
    }
}
