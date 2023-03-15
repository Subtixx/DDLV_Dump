using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Serialization;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ExtendedStorageOptions : StorageOptions
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40000A6")]
		public SerializationFormat DataFormat
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28C19E0", Offset = "0x28C03E0", VA = "0x1828C19E0")]
		public ExtendedStorageOptions()
		{
		}
	}
}
