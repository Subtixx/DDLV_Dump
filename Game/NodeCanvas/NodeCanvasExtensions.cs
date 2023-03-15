using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Services;

namespace NodeCanvas
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public static class NodeCanvasExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public struct MessageRouterCallbackRegistration : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private readonly MessageRouter messageRouter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private readonly Action callback;

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x12053C0", Offset = "0x1203DC0", VA = "0x1812053C0")]
			public MessageRouterCallbackRegistration(MessageRouter messageRouter, string message, Action callback)
			{
				//Discarded unreachable code: IL_0017
				this.messageRouter = messageRouter;
				this.callback = callback;
				messageRouter.RegisterCallback(message, callback);
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x1205390", Offset = "0x1203D90", VA = "0x181205390", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0008
				Action action = callback;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xF03280", Offset = "0xF01C80", VA = "0x180F03280")]
		[AsyncStateMachine(typeof(_003CStartDialogueAsync_003Ed__0))]
		public static Task<bool> StartDialogueAsync(this DialogueTree dialogueTree, [Optional] IDialogueActor instigator, [Optional] IBlackboard blackboard, [Optional] CancellationToken ct, bool releaseOnStop = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xF03250", Offset = "0xF01C50", VA = "0x180F03250")]
		public static MessageRouterCallbackRegistration RegisterCallbackScope(this MessageRouter messageRouter, string message, Action callback)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
