using Cpp2IlInjected;
using UnityEngine.Rendering;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public class PlatformParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "4")]
			get
			{
				return MatcherType.Platform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PlatformParam()
		{
			((VolumeStack)(object)this)._002Ector();
		}
	}
}
