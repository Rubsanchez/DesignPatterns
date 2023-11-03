using DesignPatterns.Adapter.Models;
using System.Xml.Linq;

namespace DesignPatterns.Adapter.Implementations
{
    public class XmlConverter
    {
        public XDocument GetXml()
        {
            var xDoc = new XDocument();
            var xElem = new XElement("Products");
            var xAttr = ProductDataProvider.GetProducts()
                .Select(x => new XElement("Product",
                    new XAttribute("Name", x.Name),
                    new XAttribute("Price", x.Price)));

            xElem.Add(xAttr);
            xDoc.Add(xElem);

            return xDoc;
        }
    }
}
