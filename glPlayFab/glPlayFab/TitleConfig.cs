using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class TitleConfig
	{
		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public string PortalUrl
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPortalUrl_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPortalUrl_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public string DeltaDNA
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDeltaDNA_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CDeltaDNA_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public List<PortalDefinition> Portals
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CPortals_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CPortals_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public User MinUser
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CMinUser_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CMinUser_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public User MaxUser
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CMaxUser_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CMaxUser_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public List<User> NewsfeedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CNewsfeedUsers_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CNewsfeedUsers_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x14F8160", Offset = "0x14F6B60", VA = "0x1814F8160")]
		public PortalDefinition GetPortalByEnvironment(int envIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleConfig()
		{
		}
	}
}
