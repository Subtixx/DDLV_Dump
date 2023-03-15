using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000702")]
	public class ActionAnimationEventDispatcher : AnimationEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6001F1C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C120", Offset = "0xA3AB20", VA = "0x180A3C120")]
		public void action()
		{
			AnimationEventArgs args = default(AnimationEventArgs);
			base.AnimationEvent?.Invoke("action", args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F1D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ActionAnimationEventDispatcher()
		{
		}
	}
}
