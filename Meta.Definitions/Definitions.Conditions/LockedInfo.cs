using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007C6")]
	public class LockedInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700158C")]
		public string StrId
		{
			[Cpp2IlInjected.Token(Token = "0x6005571")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CStrId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005572")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CStrId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158D")]
		public Dictionary<string, object> Args
		{
			[Cpp2IlInjected.Token(Token = "0x6005573")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CArgs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005574")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CArgs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005575")]
		[Cpp2IlInjected.Address(RVA = "0x38F2A90", Offset = "0x38F1490", VA = "0x1838F2A90")]
		public static LockedInfo New(string strId, string argName1, object argObj1)
		{
			//Discarded unreachable code: IL_000c, IL_0014, IL_002a
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005576")]
		[Cpp2IlInjected.Address(RVA = "0x38F2BB0", Offset = "0x38F15B0", VA = "0x1838F2BB0")]
		public static LockedInfo New(string strId, [Optional] Dictionary<string, object> args)
		{
			//Discarded unreachable code: IL_0020
			if ((object)typeof(LockedInfo).TypeHandle != null)
			{
				int num = 0;
			}
			LockedInfo lockedInfo = new LockedInfo();
			lockedInfo.StrId = strId;
			lockedInfo.Args = args;
			return lockedInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6005577")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LockedInfo()
		{
		}
	}
}
