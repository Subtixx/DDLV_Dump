using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct Period
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DateTime Start
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x6E07D0", Offset = "0x6DF1D0", VA = "0x1806E07D0")]
			[CompilerGenerated]
			set
			{
				_003CStart_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DateTime? End
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x6E3CB0", Offset = "0x6E26B0", VA = "0x1806E3CB0")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xDD7180", Offset = "0xDD5B80", VA = "0x180DD7180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[JsonIgnore]
		public DateTime RealEnd
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1035840", Offset = "0x1034240", VA = "0x181035840")]
			get
			{
				DateTime? dateTime = End;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
				}
				return DateTime.MaxValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1035780", Offset = "0x1034180", VA = "0x181035780")]
		public bool IsInside(DateTime now)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			DateTime realEnd = RealEnd;
			return now < realEnd;
		}
	}
}
