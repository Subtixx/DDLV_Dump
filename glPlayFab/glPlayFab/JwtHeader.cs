using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class JwtHeader
	{
		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[JsonProperty]
		public string Kid
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CKid_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CKid_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[JsonProperty]
		public string Alg
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CAlg_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CAlg_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public JwtHeader()
		{
		}
	}
}
