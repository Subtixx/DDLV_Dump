using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	public abstract class GetLiveopsDataRequest : ILiveopsDataParams
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Dictionary<string, KnownConfig> KnownConfigIds
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003CKnownConfigIds_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003CKnownConfigIds_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public string CurrentLanguage
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentLanguage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "7")]
			[CompilerGenerated]
			set
			{
				_003CCurrentLanguage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000688")]
		public bool IncludeScheduled
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public abstract ServerDataType ServerDataType
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public abstract string OnlineFlagKey
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected GetLiveopsDataRequest()
		{
		}
	}
}
