using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000707")]
	public static class AnimatorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x40028F7")]
		private static bool EnableDebugLog;

		[Cpp2IlInjected.Token(Token = "0x6001F3A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E440", Offset = "0xA3CE40", VA = "0x180A3E440")]
		[Conditional("DEBUG")]
		private static void DebugLog(string message)
		{
			int num = 0;
			float time = Time.time;
			object[] args = Array.Empty<object>();
			string msg = default(string);
			GameLog.Info(msg, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC40", Offset = "0xA3D640", VA = "0x180A3EC40")]
		[AsyncStateMachine(typeof(_003CWaitForAnimationNameToStart_003Ed__2))]
		public static Task WaitForAnimationNameToStart(this Animator animator, string animationName, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E810", Offset = "0xA3D210", VA = "0x180A3E810")]
		[AsyncStateMachine(typeof(_003CPlayAnimationAndWait_003Ed__3))]
		public static Task PlayAnimationAndWait(this Animator animator, string animationTrigger, string animationStartName, string animationEndName, bool allowAnimationCancel, CancellationToken ct, [System.Runtime.InteropServices.Optional] Action onAnimationStarted, [System.Runtime.InteropServices.Optional] Action onAnimationEnded)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E640", Offset = "0xA3D040", VA = "0x180A3E640")]
		public static Task PlayAnimationAndWait(this Animator animator, string animationTrigger, string animationName, bool allowAnimationCancel, CancellationToken ct, [System.Runtime.InteropServices.Optional] Action onAnimationStarted, [System.Runtime.InteropServices.Optional] Action onAnimationEnded)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E520", Offset = "0xA3CF20", VA = "0x180A3E520")]
		[AsyncStateMachine(typeof(_003CDelayAnimEnding_003Ed__5))]
		private static Task DelayAnimEnding(float duration, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9B0", Offset = "0xA3D3B0", VA = "0x180A3E9B0")]
		[AsyncStateMachine(typeof(_003CWaitForAnimationNameToEnd_003Ed__6))]
		public static Task WaitForAnimationNameToEnd(this Animator animator, string animationName, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F40")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB00", Offset = "0xA3D500", VA = "0x180A3EB00")]
		[AsyncStateMachine(typeof(_003CWaitForAnimationNameToStartAndEnd_003Ed__7))]
		public static Task WaitForAnimationNameToStartAndEnd(this Animator animator, string animationName, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F41")]
		[Cpp2IlInjected.Address(RVA = "0xA3EEE0", Offset = "0xA3D8E0", VA = "0x180A3EEE0")]
		[AsyncStateMachine(typeof(_003CWaitForAnimationTagToStart_003Ed__8))]
		public static Task WaitForAnimationTagToStart(this Animator animator, string animationTag, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F42")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED90", Offset = "0xA3D790", VA = "0x180A3ED90")]
		[AsyncStateMachine(typeof(_003CWaitForAnimationTagToEnd_003Ed__9))]
		public static Task WaitForAnimationTagToEnd(this Animator animator, string animationTag, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F43")]
		[Cpp2IlInjected.Address(RVA = "0xA3F030", Offset = "0xA3DA30", VA = "0x180A3F030")]
		[AsyncStateMachine(typeof(_003CWaitForCurrentAnimationToComplete_003Ed__10))]
		public static Task WaitForCurrentAnimationToComplete(this Animator animator, CancellationToken ct, float cycleAmount = 1f)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F44")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static AnimatorExtensions()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
