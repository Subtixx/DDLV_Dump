using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C08")]
	internal class ToggleFurnitureStateAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400432B")]
		[SerializeField]
		private AK.Wwise.Event ToggleLightSFX;

		[Cpp2IlInjected.Token(Token = "0x60036E5")]
		[Cpp2IlInjected.Address(RVA = "0x13D4720", Offset = "0x13D3120", VA = "0x1813D4720", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036E6")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public ToggleFurnitureStateAction()
		{
		}
	}
}
