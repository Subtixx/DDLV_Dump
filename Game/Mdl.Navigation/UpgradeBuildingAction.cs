using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C10")]
	internal class UpgradeBuildingAction : DialogueAction
	{
		[Cpp2IlInjected.Token(Token = "0x60036F7")]
		[Cpp2IlInjected.Address(RVA = "0xD3CF00", Offset = "0xD3B900", VA = "0x180D3CF00", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F8")]
		[Cpp2IlInjected.Address(RVA = "0xD3D050", Offset = "0xD3BA50", VA = "0x180D3D050")]
		[AsyncStateMachine(typeof(_003CStartUnlock_003Ed__1))]
		private Task StartUnlock(PlayerTask task, int buildingId, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F9")]
		[Cpp2IlInjected.Address(RVA = "0xD3D160", Offset = "0xD3BB60", VA = "0x180D3D160")]
		[AsyncStateMachine(typeof(_003CStartUpgrade_003Ed__2))]
		private Task StartUpgrade(PlayerTask task, bool isCastle, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036FA")]
		[Cpp2IlInjected.Address(RVA = "0xD382F0", Offset = "0xD36CF0", VA = "0x180D382F0")]
		public UpgradeBuildingAction()
		{
		}
	}
}
