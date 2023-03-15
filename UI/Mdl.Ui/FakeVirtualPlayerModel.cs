using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200083C")]
	public class FakeVirtualPlayerModel
	{
		[Cpp2IlInjected.Token(Token = "0x200083D")]
		public enum FakeVirtualPlayerBehavior
		{
			[Cpp2IlInjected.Token(Token = "0x40030A1")]
			Light,
			[Cpp2IlInjected.Token(Token = "0x40030A2")]
			Regular,
			[Cpp2IlInjected.Token(Token = "0x40030A3")]
			Hardcore,
			[Cpp2IlInjected.Token(Token = "0x40030A4")]
			God
		}

		[Cpp2IlInjected.Token(Token = "0x17000765")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600345E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600345F")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000766")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400309E")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6003460")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003461")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000767")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400309F")]
		public FakeVirtualPlayerBehavior Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x6003462")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003463")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003464")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FakeVirtualPlayerModel()
		{
		}
	}
}
