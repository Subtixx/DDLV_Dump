using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000703")]
	public class AvatarAnimationEventDispatcher : AnimationEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6001F1E")]
		[Cpp2IlInjected.Address(RVA = "0x150BAA0", Offset = "0x150A4A0", VA = "0x18150BAA0")]
		public void sitting()
		{
			DispatchAnimationEvent("sitting");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F1F")]
		[Cpp2IlInjected.Address(RVA = "0x150BB60", Offset = "0x150A560", VA = "0x18150BB60")]
		public void standing()
		{
			DispatchAnimationEvent("standing");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F20")]
		[Cpp2IlInjected.Address(RVA = "0x150B860", Offset = "0x150A260", VA = "0x18150B860")]
		public void give()
		{
			DispatchAnimationEvent("give");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F21")]
		[Cpp2IlInjected.Address(RVA = "0x150B920", Offset = "0x150A320", VA = "0x18150B920")]
		public void hookCast()
		{
			DispatchAnimationEvent("hookCast");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F22")]
		[Cpp2IlInjected.Address(RVA = "0x150BB20", Offset = "0x150A520", VA = "0x18150BB20")]
		public void splash()
		{
			DispatchAnimationEvent("splash");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F23")]
		[Cpp2IlInjected.Address(RVA = "0x150B960", Offset = "0x150A360", VA = "0x18150B960")]
		public void lowestPoint()
		{
			DispatchAnimationEvent("lowestPoint");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F24")]
		[Cpp2IlInjected.Address(RVA = "0x150BAE0", Offset = "0x150A4E0", VA = "0x18150BAE0")]
		public void spawn()
		{
			DispatchAnimationEvent("spawn");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F25")]
		[Cpp2IlInjected.Address(RVA = "0x150B9E0", Offset = "0x150A3E0", VA = "0x18150B9E0")]
		public void pop()
		{
			DispatchAnimationEvent("pop");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F26")]
		[Cpp2IlInjected.Address(RVA = "0x150B9A0", Offset = "0x150A3A0", VA = "0x18150B9A0")]
		public void miningHit()
		{
			DispatchAnimationEvent("miningHit");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F27")]
		[Cpp2IlInjected.Address(RVA = "0x150BA20", Offset = "0x150A420", VA = "0x18150BA20")]
		public void shovelFX()
		{
			DispatchAnimationEvent("shovelFX");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F28")]
		[Cpp2IlInjected.Address(RVA = "0x150BA60", Offset = "0x150A460", VA = "0x18150BA60")]
		public void shovelHit()
		{
			DispatchAnimationEvent("shovelHit");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F29")]
		[Cpp2IlInjected.Address(RVA = "0x150B6D0", Offset = "0x150A0D0", VA = "0x18150B6D0")]
		public void AnimCancel()
		{
			Debug.LogWarning("AnimCancel");
			DispatchAnimationEvent("AnimCancel");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2A")]
		[Cpp2IlInjected.Address(RVA = "0x150B7A0", Offset = "0x150A1A0", VA = "0x18150B7A0")]
		public void action()
		{
			Debug.LogWarning("action");
			DispatchAnimationEvent("action");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2B")]
		[Cpp2IlInjected.Address(RVA = "0x150B8A0", Offset = "0x150A2A0", VA = "0x18150B8A0")]
		public void hardTurnFirstFrame()
		{
			DispatchAnimationEvent("hardTurnFirstFrame");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2C")]
		[Cpp2IlInjected.Address(RVA = "0x150B8E0", Offset = "0x150A2E0", VA = "0x18150B8E0")]
		public void hardTurn()
		{
			DispatchAnimationEvent("hardTurn");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2D")]
		[Cpp2IlInjected.Address(RVA = "0x150B820", Offset = "0x150A220", VA = "0x18150B820")]
		public void detachBobberEvent()
		{
			DispatchAnimationEvent("detachBobberEvent");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2E")]
		[Cpp2IlInjected.Address(RVA = "0x150B750", Offset = "0x150A150", VA = "0x18150B750")]
		public void OnFootStep(string inState)
		{
			DispatchAnimationEvent(inState, "OnFootStep");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public AvatarAnimationEventDispatcher()
		{
		}
	}
}
