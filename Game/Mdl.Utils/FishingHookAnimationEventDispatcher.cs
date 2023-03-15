using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000705")]
	internal class FishingHookAnimationEventDispatcher : AnimationEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6001F35")]
		[Cpp2IlInjected.Address(RVA = "0x1370600", Offset = "0x136F000", VA = "0x181370600")]
		public void hookCast()
		{
			DispatchAnimationEvent("hookCast");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F36")]
		[Cpp2IlInjected.Address(RVA = "0x1370680", Offset = "0x136F080", VA = "0x181370680")]
		public void splash()
		{
			DispatchAnimationEvent("splash");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F37")]
		[Cpp2IlInjected.Address(RVA = "0x1370640", Offset = "0x136F040", VA = "0x181370640")]
		public void lowestPoint()
		{
			DispatchAnimationEvent("lowestPoint");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F38")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public FishingHookAnimationEventDispatcher()
		{
		}
	}
}
