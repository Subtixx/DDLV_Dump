using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class OpenIdAPI<T> : IOpenIdAPI where T : IHttpContent, new()
	{
		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ((OpenIdAPI<>)(object)this)._003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				((OpenIdAPI<>)(object)this)._003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public string ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return ((OpenIdAPI<>)(object)this)._003CContentType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "7")]
			[CompilerGenerated]
			set
			{
				((OpenIdAPI<>)(object)this)._003CContentType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public IHttpContent HttpContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return ((OpenIdAPI<>)(object)this)._003CHttpContent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "9")]
			[CompilerGenerated]
			set
			{
				((OpenIdAPI<>)(object)this)._003CHttpContent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400028F")]
		public bool ApplyFixedParams
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x25BF420", Offset = "0x25BDE20", VA = "0x1825BF420")]
		public OpenIdAPI()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
