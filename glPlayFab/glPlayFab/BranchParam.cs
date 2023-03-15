using Cpp2IlInjected;
using UnityEngine.Rendering;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public class BranchParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "4")]
			get
			{
				return MatcherType.Branch;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1024B90", Offset = "0x1023590", VA = "0x181024B90", Slot = "5")]
		public override bool IsMatch(string matcher)
		{
			//Discarded unreachable code: IL_0014
			string text = default(string);
			string pattern = "^" + text;
			return base.IsMatch(pattern);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public BranchParam()
		{
			((VolumeStack)(object)this)._002Ector();
		}
	}
}
