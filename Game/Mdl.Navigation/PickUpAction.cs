using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Grid;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BDC")]
	public class PickUpAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400420F")]
		[SerializeField]
		private AssetReferenceGameObject _pickUpResultInfoGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x600365B")]
		[Cpp2IlInjected.Address(RVA = "0xF11350", Offset = "0xF0FD50", VA = "0x180F11350", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600365C")]
		[Cpp2IlInjected.Address(RVA = "0xF114A0", Offset = "0xF0FEA0", VA = "0x180F114A0")]
		[AsyncStateMachine(typeof(_003CPickUpItemWithGizmo_003Ed__2))]
		private Task<PickUpItem.Types.Response> PickUpItemWithGizmo(GridObjectScript gridObjectScript)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PickUpItem.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600365D")]
		[Cpp2IlInjected.Address(RVA = "0xF11230", Offset = "0xF0FC30", VA = "0x180F11230")]
		public static void DisplayPickUpGizmo(Item item, int amount, (Vector3 position, Quaternion rotation) originalTransform, AssetReferenceGameObject gizmoPrefab, bool isAlreadyInInventory = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600365E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public PickUpAction()
		{
		}
	}
}
