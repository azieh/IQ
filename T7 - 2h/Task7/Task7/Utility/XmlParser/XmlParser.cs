using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;
using Task7.ExchangeRates;

namespace Task7.Utility.XmlParser
{
    public class XmlParser<T> : IXmlParser<T>
    {
        public XDocument ReadXmlData(string filePath)
        {
            filePath = GetRelativeFilePath(filePath);
            XDocument doc = XDocument.Load(filePath);

            return doc;
        }

        public T MapToModel(XDocument doc)
        {
            XmlSerializer s = new XmlSerializer(typeof(web_dis_rates));
            return (T)s.Deserialize(doc.CreateReader());
        }

        private string GetRelativeFilePath(string filePath)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            return Path.Combine(outPutDirectory, filePath);
        }
    }
}