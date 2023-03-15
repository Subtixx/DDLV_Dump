using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Avatar;
using Meta;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BC5")]
	internal class HarvestAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40041AB")]
		public string animationTrigger = "Interact";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40041AC")]
		public string animationName = "interact_01";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40041AD")]
		public AssetReferenceGameObject gardeningResultInfoGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x6003625")]
		[Cpp2IlInjected.Address(RVA = "0x154CB40", Offset = "0x154B540", VA = "0x18154CB40", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__3))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003626")]
		[Cpp2IlInjected.Address(RVA = "0x154CCA0", Offset = "0x154B6A0", VA = "0x18154CCA0")]
		[AsyncStateMachine(typeof(_003CHarvest_003Ed__4))]
		private Task Harvest(HarvestGardeningSlot.Types.Request request, GardeningSlot gardeningSlot, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003627")]
		[Cpp2IlInjected.Address(RVA = "0x154CE00", Offset = "0x154B800", VA = "0x18154CE00")]
		public HarvestAction()
		{
		}
	}
}
