using BookReader.Interfaces;
using System;
using System.Xml.Linq;

namespace BookReader.Infrastructure
{
    public class XmlProvider : IProvider
    {
        public void Preview(string[] text)
        {

            var root = new XElement($"root");

            var len = text.Length;

            for (int i = 0; i < len; i++)
            {
                root.Add(new XElement($"page{i}", text[i]));
            }

            var xml = new XDocument(root);

            Console.WriteLine(xml);

            Console.WriteLine("\n");
        }
    }

}
