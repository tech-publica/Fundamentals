using System.Xml;
using System;
using System.Xml.Linq;

public class UseXmlReader
{
  public void ParseFile(string filename)
  {
    XmlReaderSettings settings = new XmlReaderSettings();
    settings.IgnoreWhitespace = true;
    using XmlReader r = XmlReader.Create(filename, settings);
    r.MoveToContent();
    while (r.Read())
    {
      if (r.NodeType == XmlNodeType.EndElement && r.LocalName == "p")
      {
        Console.WriteLine("found p");
        while (r.Read())
          if (r.NodeType == XmlNodeType.Text)
          {
            Console.WriteLine("text");
            Console.WriteLine(r.Value);
            break;
          }

      }
    }

  }


}