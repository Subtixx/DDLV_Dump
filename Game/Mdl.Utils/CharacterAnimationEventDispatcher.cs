using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000704")]
	public class CharacterAnimationEventDispatcher : AnimationEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6001F30")]
		[Cpp2IlInjected.Address(RVA = "0x12DAAB0", Offset = "0x12D94B0", VA = "0x1812DAAB0")]
		public void sitting()
		{
			DispatchAnimationEvent("sitting");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F31")]
		[Cpp2IlInjected.Address(RVA = "0x12DAAF0", Offset = "0x12D94F0", VA = "0x1812DAAF0")]
		public void standing()
		{
			DispatchAnimationEvent("standing");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F32")]
		[Cpp2IlInjected.Address(RVA = "0x12DAA30", Offset = "0x12D9430", VA = "0x1812DAA30")]
		public void give()
		{
			DispatchAnimationEvent("give");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F33")]
		[Cpp2IlInjected.Address(RVA = "0x12DAA70", Offset = "0x12D9470", VA = "0x1812DAA70")]
		public void resetRoot()
		{
			DispatchAnimationEvent("resetRoot");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F34")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public CharacterAnimationEventDispatcher()
		{
		}
	}
}
