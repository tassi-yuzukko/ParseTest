using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XmlParseTest
{
    public class SampleClass
    {
		public string Name { get; set; }
		public int Id { get; set; }
		public SampleClassMember Member { get; set; }
		public Colections colections = new Colections();
	}

	public class SampleClassMember
	{
		public int key;
		public string value;

		static int _cnt;

		public SampleClassMember()
		{
			key = _cnt++;
			value = "sample" + key;
		}
	}

	public class Colections
	{
		public Dictionary<int, SampleClassMember> dict = new Dictionary<int, SampleClassMember>
		{
			{1, new SampleClassMember{key=1, value="test"} },
			{2, new SampleClassMember() },
		};

		public List<int> list = new List<int>();

		public Colections()
		{
			for(int i=0; i < 100; i++)
			{
				list.Add(i);
			}
		}
	}

	public class SampleClass2
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}
