namespace Invicta.Net.SisoRef010.Attributes {

	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class SisoEnumerantAttribute : Attribute {
		public string Uuid { get; }

		public SisoEnumerantAttribute(string uuid) {
			Uuid = uuid;
		}


		public string Description { get; set; } = string.Empty;
	}
}