using Invicta.Net.SisoRef010.Attributes;
using Invicta.Net.SisoRef010.CodeGeneration.Xml;

using Microsoft.CSharp;

using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;


namespace Invicta.Net.SisoRef010.CodeGeneration {

	public class Processor {
		private readonly CodeDomProvider CodeDomProvider = new CSharpCodeProvider();

		private readonly CodeGeneratorOptions CodeGeneratorOptions = new() {
			BlankLinesBetweenMembers = false,
			BracingStyle = "Block",
			ElseOnClosing = false,
			IndentString = "\t",
			VerbatimOrder = true
		};

		private readonly NameSanitizer NameSanitizer;

		private const string Namespace = "Invicta.Net.SisoRef010";


		public Processor(NameSanitizer nameSanitizer) {
			NameSanitizer = nameSanitizer;
		}


		public void Process(ebv ebv) {
			Console.WriteLine($"Processing {ebv.title} (released {ebv.date})...");

			Directory.CreateDirectory(Namespace);

			XmlNode CopyrightNode = ((XmlNode[]) ebv.copyright).First();
			string Copyright = CopyrightNode.InnerText;

			Copyright = Regex.Replace(Copyright, "(\r\n|\r|\n)", Environment.NewLine);


			foreach (var Item in ebv.Items) {
				if (Item is enum_t Enum)
					ProcessEnumeration(Enum, Copyright);
			}
		}


		private void ProcessEnumeration(enum_t @enum, string copyright) {
			Console.WriteLine($"Processing '{@enum.name}'...");

			if (@enum.Items1?.Any(g => g is enumrow_range_t) ?? false)
				GenerateConstantsClass(@enum, copyright);

			else
				GenerateEnumeration(@enum, copyright);
		}


		private void GenerateEnumeration(enum_t @enum, string copyright) {
			CodeCompileUnit CodeCompileUnit = new();

			CodeNamespace CodeNamespace = new(Namespace);
			CodeNamespace.Comments.Add(new CodeCommentStatement(copyright));

			string EnumerationName = NameSanitizer.Sanitize(@enum.name);
			CodeTypeDeclaration EnumerationDeclaration = new() {
				Name = EnumerationName,
				IsEnum = true,
				TypeAttributes = TypeAttributes.Public,
			};

			Type UnderlyingType = GetUnderlyingTypeForBitLength(int.Parse(@enum.size));
			EnumerationDeclaration.BaseTypes.Add(UnderlyingType);

			EnumerationDeclaration.CustomAttributes.Add(GenerateSisoEnumerationAttribute(@enum));

			if (@enum.deprecated) {
				CodeAttributeDeclaration ObsoleteAttributeDeclaration = new(
					new CodeTypeReference(typeof(ObsoleteAttribute))
				);

				if (@enum.footnote != null)
					ObsoleteAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(@enum.footnote)));

				EnumerationDeclaration.CustomAttributes.Add(ObsoleteAttributeDeclaration);
			}

			IDictionary<string, int> DuplicateCounts = new Dictionary<string, int>();
			foreach (var Item in @enum.Items1 ?? Array.Empty<genericentry_t>()) {
				if (Item is not enumrow_t Enumerant)
					throw new NotImplementedException();

				string EnumerantName = GetEnumerantName(Enumerant);

				if (DuplicateCounts.TryGetValue(EnumerantName, out int Count)) {
					DuplicateCounts[EnumerantName]++;
					EnumerantName = $"{EnumerantName}_{Count}";

					Console.WriteLine($"Renamed {Enumerant.uuid} to '{EnumerantName}' to resolve a duplicate name");
				}

				else {
					DuplicateCounts.Add(EnumerantName, 1);
				}

				object EnumerantValue = Convert.ChangeType(Enumerant.value, UnderlyingType);

				CodeMemberField EnumerantField = new(EnumerationName, EnumerantName) {
					InitExpression = new CodePrimitiveExpression(EnumerantValue),
				};

				EnumerantField.CustomAttributes.Add(GenerateSisoEnumerantAttribute(Enumerant));

				if (Enumerant.deprecated) {
					CodeAttributeDeclaration ObsoleteAttributeDeclaration = new(
						new CodeTypeReference(typeof(ObsoleteAttribute))
					);

					if (Enumerant.footnote != null)
						ObsoleteAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(Enumerant.footnote)));

					EnumerantField.CustomAttributes.Add(ObsoleteAttributeDeclaration);
				}

				EnumerationDeclaration.Members.Add(EnumerantField);
			}

			CodeNamespace.Types.Add(EnumerationDeclaration);
			CodeCompileUnit.Namespaces.Add(CodeNamespace);

			using StreamWriter StreamWriter = new($"{Namespace}/{EnumerationName}.{CodeDomProvider.FileExtension}");
			CodeDomProvider.GenerateCodeFromCompileUnit(CodeCompileUnit, StreamWriter, CodeGeneratorOptions);
		}


		private void GenerateConstantsClass(enum_t @enum, string copyright) {
			CodeCompileUnit CodeCompileUnit = new();

			CodeNamespace CodeNamespace = new(Namespace);
			CodeNamespace.Comments.Add(new CodeCommentStatement(copyright));

			string EnumerationName = NameSanitizer.Sanitize(@enum.name);
			CodeTypeDeclaration ClassDeclaration = new() {
				Name = EnumerationName,
				IsClass = true,
				TypeAttributes = TypeAttributes.Public
			};

			Type UnderlyingType = GetUnderlyingTypeForBitLength(int.Parse(@enum.size));

			ClassDeclaration.CustomAttributes.Add(GenerateSisoEnumerationAttribute(@enum));

			if (@enum.deprecated) {
				CodeAttributeDeclaration ObsoleteAttributeDeclaration = new(
					new CodeTypeReference(typeof(ObsoleteAttribute))
				);

				if (@enum.footnote != null)
					ObsoleteAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(@enum.footnote)));

				ClassDeclaration.CustomAttributes.Add(ObsoleteAttributeDeclaration);
			}

			IDictionary<string, int> DuplicateCounts = new Dictionary<string, int>();
			foreach (var Item in @enum.Items1 ?? Array.Empty<genericentry_t>()) {
				if (Item is enumrow_t Enumerant) {
					string EnumerantName = GetEnumerantName(Enumerant);

					if (DuplicateCounts.TryGetValue(EnumerantName, out int Count)) {
						DuplicateCounts[EnumerantName]++;
						EnumerantName = $"{EnumerantName}_{Count}";

						Console.WriteLine($"Renamed {Enumerant.uuid} to '{EnumerantName}' to resolve a duplicate name");
					}

					else {
						DuplicateCounts.Add(EnumerantName, 1);
					}

					object EnumerantValue = Convert.ChangeType(Enumerant.value, UnderlyingType);

					CodeMemberField EnumerantField = new(EnumerationName, EnumerantName) {
						Attributes = MemberAttributes.Public | MemberAttributes.Const,
						Type = new(UnderlyingType),
						InitExpression = new CodePrimitiveExpression(EnumerantValue),
					};

					EnumerantField.CustomAttributes.Add(GenerateSisoEnumerantAttribute(Enumerant));

					if (Enumerant.deprecated) {
						CodeAttributeDeclaration ObsoleteAttributeDeclaration = new(
							new CodeTypeReference(typeof(ObsoleteAttribute))
						);

						if (Enumerant.footnote != null)
							ObsoleteAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(Enumerant.footnote)));

						EnumerantField.CustomAttributes.Add(ObsoleteAttributeDeclaration);
					}

					ClassDeclaration.Members.Add(EnumerantField);
				}

				else if (Item is not enumrow_range_t)
					throw new NotImplementedException();
			}

			CodeNamespace.Types.Add(ClassDeclaration);
			CodeCompileUnit.Namespaces.Add(CodeNamespace);

			using StreamWriter StreamWriter = new($"{Namespace}/{EnumerationName}.{CodeDomProvider.FileExtension}");
			CodeDomProvider.GenerateCodeFromCompileUnit(CodeCompileUnit, StreamWriter, CodeGeneratorOptions);
		}


		private static CodeAttributeDeclaration GenerateSisoEnumerationAttribute(enum_t @enum) {
			CodeAttributeDeclaration SisoEnumerationAttributeDeclaration = new(
				new CodeTypeReference(typeof(SisoEnumerationAttribute))
			);

			SisoEnumerationAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(int.Parse(@enum.uid))));
			SisoEnumerationAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(@enum.name)));
			SisoEnumerationAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(int.Parse(@enum.size))));

			return SisoEnumerationAttributeDeclaration;
		}


		private static CodeAttributeDeclaration GenerateSisoEnumerantAttribute(enumrow_t enumerant) {
			CodeAttributeDeclaration SisoEnumerantAttributeDeclaration = new(
				new CodeTypeReference(typeof(SisoEnumerantAttribute))
			);

			SisoEnumerantAttributeDeclaration.Arguments.Add(new(new CodePrimitiveExpression(enumerant.uuid)));
			SisoEnumerantAttributeDeclaration.Arguments.Add(new(nameof(SisoEnumerantAttribute.Description), new CodePrimitiveExpression(enumerant.description)));

			return SisoEnumerantAttributeDeclaration;
		}


		private string GetEnumerantName(enumrow_t enumerant) {
			string Name;

			if (!string.IsNullOrWhiteSpace(enumerant.description))
				Name = enumerant.description;

			else if (enumerant.meta?.Any() ?? false) {
				meta_t Meta = enumerant.meta.First();
				Console.WriteLine($"{enumerant.uuid} has no description, using '{Meta.key}' instead ({Meta.value})");

				Name = Meta.value;
			}

			else
				throw new ArgumentException("No name found", nameof(enumerant));

			return NameSanitizer.Sanitize(Name);
		}


		private static Type GetUnderlyingTypeForBitLength(int bitLength) {
			return bitLength switch {
				<= 8 => typeof(byte),
				<= 16 => typeof(ushort),
				<= 32 => typeof(uint),
				<= 64 => typeof(ulong),

				_ => throw new NotImplementedException()
			};
		}
	}
}
