using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Buildings;
using Meta;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000B9C")]
	internal class CollectGardenStallSlot : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40040A7")]
		public AssetReferenceGameObject collectResultInfoGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x60035AA")]
		[Cpp2IlInjected.Address(RVA = "0xA8B1E0", Offset = "0xA89BE0", VA = "0x180A8B1E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035AB")]
		[Cpp2IlInjected.Address(RVA = "0xA8B080", Offset = "0xA89A80", VA = "0x180A8B080")]
		[AsyncStateMachine(typeof(_003CCollect_003Ed__2))]
		private Task Collect(Meta.CollectGardenStallSlot.Types.Request request, GardenStallFakeSlot gardeningSlot, Item seedItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035AC")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public CollectGardenStallSlot()
		{
		}
	}
}
