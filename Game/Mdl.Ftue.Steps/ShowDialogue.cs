using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Motion;
using Meta.Online;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005AE")]
	[CreateAssetMenu]
	public class ShowDialogue : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002301")]
		public DialogueTree dialogueTree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002302")]
		public string talkableObjectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002303")]
		public bool doTransition = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002304")]
		public float transitionDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002305")]
		public EasingType easingType = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.Token(Token = "0x600194E")]
		[Cpp2IlInjected.Address(RVA = "0xF4FE70", Offset = "0xF4E870", VA = "0x180F4FE70", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__5))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600194F")]
		[Cpp2IlInjected.Address(RVA = "0xF50010", Offset = "0xF4EA10", VA = "0x180F50010")]
		public ShowDialogue()
		{
		}//IL_001c: Expected I4, but got I8

	}
}
