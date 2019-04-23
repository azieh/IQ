using System.Xml.Linq;

namespace Task7.Utility.XmlParser
{
    public interface IXmlParser<T>
    {
        XDocument ReadXmlData(string filePath);
        T MapToModel(XDocument doc);
    }
}