using Invicta.Net.SisoRef010.CodeGeneration.Xml;

using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;


namespace Invicta.Net.SisoRef010.CodeGeneration {

	public static class Program {
		private static readonly JsonSerializerOptions JsonSerializerOptions = new() {
			PropertyNameCaseInsensitive = true
		};


		public static void Main(string[] args) {
			if (args.Length < 1 || !File.Exists(args[0]))
				throw new ArgumentException("arg[0] must be a valid path to a rules.json file");

			if (args.Length < 2 || !File.Exists(args[1]))
				throw new ArgumentException("arg[1] must be a valid path to a SISO-REF-010 .xml file");

			Rules Rules = JsonSerializer.Deserialize<Rules>(File.ReadAllText(args[0]), JsonSerializerOptions);

			using XmlReader XmlReader = XmlReader.Create(args[1]);
			ebv Ebv = new XmlSerializer(typeof(ebv)).Deserialize(XmlReader) as ebv;

			new Processor(new NameSanitizer(Rules)).Process(Ebv);
		}
	}
}
