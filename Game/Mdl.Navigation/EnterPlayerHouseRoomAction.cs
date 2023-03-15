using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BC0")]
	internal class EnterPlayerHouseRoomAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003619")]
		[Cpp2IlInjected.Address(RVA = "0x19DBFD0", Offset = "0x19DA9D0", VA = "0x1819DBFD0", Slot = "8")]
		public override Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			//IL_0018: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			int num = 0;
			int num2 = 0;
			PlayerRoomDoor playerRoomDoor = default(PlayerRoomDoor);
			if (playerRoomDoor != (Object)num2)
			{
			}
			EnterPlayerHouseFloorTaskData enterPlayerHouseFloorTaskData = default(EnterPlayerHouseFloorTaskData);
			return (Task<bool>)(object)Task.FromResult(enterPlayerHouseFloorTaskData != null);
		}

		[Cpp2IlInjected.Token(Token = "0x600361A")]
		[Cpp2IlInjected.Address(RVA = "0x19DC1A0", Offset = "0x19DABA0", VA = "0x1819DC1A0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600361B")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public EnterPlayerHouseRoomAction()
		{
		}
	}
}
