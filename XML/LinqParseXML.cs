using System.Linq;
using System.Xml.Linq;
using System;
using System.IO;

public class LinqParseXMl
{
  XNamespace defSpace = "http://www.plcopen.org/xml/tc6.xsd";
  XNamespace html = "http://www.w3.org/1999/xhtml";
  public void ParseDocument(string filename)
  {

    XDocument xml = XDocument.Load(filename);
    var cInfoXml = xml.Descendants(DNS("coordinateInfo"))
            .First();

    var info = new CoordinateInfo
    {
      PageSize = new Coordinates((int)cInfoXml.Element(DNS("pageSize")).Attribute("x"),
                                   (int)cInfoXml.Element(DNS("pageSize")).Attribute("y")),
      FwbScaling = new Coordinates((int)cInfoXml.Element(DNS("fbd")).Element(DNS("scaling")).Attribute("x"),
                                  (int)cInfoXml.Element(DNS("fbd")).Element(DNS("scaling")).Attribute("y")),
      LdScaling = new Coordinates((int)cInfoXml.Element(DNS("ld")).Element(DNS("scaling")).Attribute("x"),
                                  (int)cInfoXml.Element(DNS("ld")).Element(DNS("scaling")).Attribute("y")),
      SfcScaling = new Coordinates((int)cInfoXml.Element(DNS("sfc")).Element(DNS("scaling")).Attribute("x"),
                                  (int)cInfoXml.Element(DNS("sfc")).Element(DNS("scaling")).Attribute("y"))
    };

    var htmlParagraph = xml.Descendants().Where(e => e.Name == HtmlNS("p")).First();
    Console.WriteLine(htmlParagraph);
    File.WriteAllText("output.txt", htmlParagraph.ToString());

  }

  public XName DNS(string elementName)
  {
    return defSpace + elementName;
  }

  public XName HtmlNS(string elementName)
  {
    return html + elementName;
  }
}