using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Items;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000B9F")]
	public class CollectLootPresentAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40040BD")]
		[SerializeField]
		private AssetReferenceGameObject _pickUpResultInfoGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x60035B1")]
		[Cpp2IlInjected.Address(RVA = "0xA8B460", Offset = "0xA89E60", VA = "0x180A8B460", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035B2")]
		[Cpp2IlInjected.Address(RVA = "0xA8B5B0", Offset = "0xA89FB0", VA = "0x180A8B5B0")]
		[AsyncStateMachine(typeof(_003COpenChestAsync_003Ed__2))]
		private Task OpenChestAsync(Animator chestAnimator, GameObject chestObj)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035B3")]
		[Cpp2IlInjected.Address(RVA = "0xA8B6D0", Offset = "0xA8A0D0", VA = "0x180A8B6D0")]
		public void PickupChestFail(GameObject chestObj)
		{
			//Discarded unreachable code: IL_0029
			//IL_0009: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			int num = 0;
			if (chestObj != (Object)num)
			{
				AudioChestOpen componentInChildren = chestObj.GetComponentInChildren<AudioChestOpen>(includeInactive: true);
				int num2 = 0;
				if (componentInChildren != (Object)num2)
				{
					componentInChildren.ChestOpenFail((GameObject)num2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035B4")]
		[Cpp2IlInjected.Address(RVA = "0xA8B340", Offset = "0xA89D40", VA = "0x180A8B340")]
		[AsyncStateMachine(typeof(_003CCollectLootPresent_003Ed__4))]
		private Task CollectLootPresent(ItemScript itemScript)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035B5")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public CollectLootPresentAction()
		{
		}
	}
}
