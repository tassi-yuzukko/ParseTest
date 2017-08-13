using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlParseTest
{
    class XmlParseClass
    {
		IEnumerable<XElement> _xelements = XDocument.Load("XmlTestFile.xml").Root.Elements();

		public XmlParseClass()
		{
			var aa = _xelements.Elements("aa");

			foreach (var x in aa) {
				Console.WriteLine((string)x);
			}
		}
    }
}
