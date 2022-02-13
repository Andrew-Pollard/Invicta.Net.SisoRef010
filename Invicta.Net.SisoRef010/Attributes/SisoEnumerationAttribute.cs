namespace Invicta.Net.SisoRef010.Attributes {

	[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public sealed class SisoEnumerationAttribute : Attribute {
		public int Uid { get; }
		public string Name { get; }
		public int Size { get; }

		public SisoEnumerationAttribute(int uid, string name, int size) {
			Uid = uid;
			Name = name;
			Size = size;
		}
	}
}