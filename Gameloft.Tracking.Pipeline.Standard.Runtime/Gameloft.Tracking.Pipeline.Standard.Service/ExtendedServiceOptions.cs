using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Serialization;
using Gameloft.Tracking.Service;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ExtendedServiceOptions : ServiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000069")]
		public SerializationFormat DataFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		} = SerializationFormat.Binary;


		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x28C19D0", Offset = "0x28C03D0", VA = "0x1828C19D0")]
		public ExtendedServiceOptions()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
