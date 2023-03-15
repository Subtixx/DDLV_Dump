using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BB6")]
	internal class EatItemAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400414A")]
		[SerializeField]
		private string _successAnimationTrigger = "Eat";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400414B")]
		[SerializeField]
		private string _successAnimationTag = "Eating";

		[Cpp2IlInjected.Token(Token = "0x6003600")]
		[Cpp2IlInjected.Address(RVA = "0x19DAFC0", Offset = "0x19D99C0", VA = "0x1819DAFC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__2))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003601")]
		[Cpp2IlInjected.Address(RVA = "0x19DB110", Offset = "0x19D9B10", VA = "0x1819DB110")]
		public EatItemAction()
		{
		}
	}
}
