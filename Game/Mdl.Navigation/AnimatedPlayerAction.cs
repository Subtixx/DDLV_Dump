using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C54")]
	public abstract class AnimatedPlayerAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40044B6")]
		public bool AllowAnimationCancelling = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40044B7")]
		public string ActionEventName = "action";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40044B8")]
		public float WaitForActionFrameDurationInSeconds = 1f;

		[Cpp2IlInjected.Token(Token = "0x60038B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D680", Offset = "0xA3C080", VA = "0x180A3D680")]
		protected Task PlayAnimationAndWait(Animator animator, string animationTrigger, string animationName, CancellationToken ct, [System.Runtime.InteropServices.Optional] Action onAnimationStarted)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60038B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D890", Offset = "0xA3C290", VA = "0x180A3D890")]
		[AsyncStateMachine(typeof(_003CWaitForActionFrame_003Ed__4))]
		protected Task WaitForActionFrame(AnimationEventDispatcher animationEventDispatcher, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60038B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9D0", Offset = "0xA3C3D0", VA = "0x180A3D9D0")]
		protected AnimatedPlayerAction()
		{
		}
	}
}
