using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XmlParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;

			//var xml = new XmlParseClass();

			//SampleClass sample = new SampleClass { Name = "Taro Yamada", Id = 1, /*Member = new SampleClassMember { key = 999, value = "sample value." }*/ };

			//var setting = new XmlWriterSettings
			//{
			//	Encoding = new UTF8Encoding(false),
			//	Indent = true,
			//	IndentChars = "	",
			//};

			//using (var file = File.Create("test.xml"))
			//{
			//	using (var writer = XmlWriter.Create(file, setting))
			//	{
			//		var serializer = new XmlSerializer(sample.GetType());
			//		serializer.Serialize(writer, sample);
			//	}
			//}

			using (var file = File.OpenRead("test.xml"))
			{
				using (var reader = XmlReader.Create(file))
				{
					var serializer = new XmlSerializer(typeof(SampleClass));
					var sample2 = serializer.Deserialize(reader) as SampleClass;
					Console.WriteLine(sample2);
				}
			}

			Console.ReadKey();
		}
    }
}