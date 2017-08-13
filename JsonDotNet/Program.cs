using System;
using System.Text;
using XmlParseTest;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace JsonDotNet
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			SampleClass sample = new SampleClass { Name = "Taro Yamada", Id = 1, Member = new SampleClassMember { key = 999, value = "sample value." } };

			var setting = new JsonSerializerSettings { MissingMemberHandling= MissingMemberHandling.Ignore,  NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented, ContractResolver = new CamelCasePropertyNamesContractResolver() };
			var str = JsonConvert.SerializeObject(sample, setting);

			File.WriteAllText("test1.json", str, Encoding.UTF8);
			var read = File.ReadAllText("test1.json", Encoding.UTF8);

			var x = JsonConvert.DeserializeObject<SampleClass>(read, setting);

			Console.ReadKey();
		}
	}
}