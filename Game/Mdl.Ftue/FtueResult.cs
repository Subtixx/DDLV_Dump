using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x200057A")]
	public class FtueResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40021D7")]
		public bool failed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40021D8")]
		public uint hudStateDiff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021D9")]
		public List<int> rewardChoices = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6001894")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F40", Offset = "0x8B3940", VA = "0x1808B4F40")]
		public FtueResult()
		{
		}
	}
}
