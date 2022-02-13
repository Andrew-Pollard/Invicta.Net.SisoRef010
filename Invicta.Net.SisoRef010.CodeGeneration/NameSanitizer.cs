using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


namespace Invicta.Net.SisoRef010.CodeGeneration {

	public class NameSanitizer {
		private readonly Rules Rules;


		public NameSanitizer(Rules rules) {
			Rules = rules;
		}


		/// <summary>
		/// Sanitize a string such that it becomes a valid C# identifier.
		/// </summary>
		/// <remarks><see href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/lexical-structure#643-identifiers"/></remarks>
		/// <param name="name"></param>
		/// <returns>A sanitized version of <paramref name="name"/>.</returns>
		/// <exception cref="ArgumentNullException">If <paramref name="name"/> is null, empty or whitespace.</exception>
		public string Sanitize(string name) {
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentNullException(nameof(name));

			name = name.Normalize(NormalizationForm.FormC);

			name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(name);

			foreach (var Replacement in Rules.Replacements)
				name = Regex.Replace(name, Replacement.Key, Replacement.Value);

			name = Regex.Replace(name, @"[^\p{L}\p{Nl}\p{Mn}\p{Mc}\p{Nd}\p{Pc}\p{Cf}]", Rules.Default);

			if (!char.IsLetter(name[0]) && name[0] != '_')
				name = '_' + name;

			return name;
		}
	}
}
