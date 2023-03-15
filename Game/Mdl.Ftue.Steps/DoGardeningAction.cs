using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Mdl.Activities;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x2000594")]
	[CreateAssetMenu]
	public class DoGardeningAction : FtueStep
	{
		[Cpp2IlInjected.Token(Token = "0x2000595")]
		public enum ActionType
		{
			[Cpp2IlInjected.Token(Token = "0x400226B")]
			Harvest,
			[Cpp2IlInjected.Token(Token = "0x400226C")]
			Plant,
			[Cpp2IlInjected.Token(Token = "0x400226D")]
			Water
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002261")]
		public bool stopGardeningAtEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002262")]
		public ActionType actionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002263")]
		public string messageKey = "tutorial_gardening_harvest";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002264")]
		[ItemID]
		public int seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002265")]
		private bool done;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002266")]
		private List<GardeningSlot> validSlots = (List<GardeningSlot>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002267")]
		private Garden garden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002268")]
		private Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002269")]
		private bool wasTouch;

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public Item SeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x60018EB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				int num = seed;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018EC")]
		[Cpp2IlInjected.Address(RVA = "0x19CF650", Offset = "0x19CE050", VA = "0x1819CF650", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__12))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018ED")]
		[Cpp2IlInjected.Address(RVA = "0x19CF960", Offset = "0x19CE360", VA = "0x1819CF960")]
		private void SelectSlot()
		{
			//Discarded unreachable code: IL_00af
			//IL_00a4: Expected O, but got I4
			if (done)
			{
				return;
			}
			ActionType actionType = this.actionType;
			List<GardeningSlot> list = validSlots;
			if (actionType != 0)
			{
				if (actionType != 0)
				{
					if (actionType != ActionType.Plant)
					{
						goto IL_0067;
					}
					Client client = this.client;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client.TransactionContext;
					Profile profile = client.profile;
					List<GardeningSlot> list2 = (List<GardeningSlot>)(object)GardeningUtil.FindWaterableSlots((List<>)(object)list, profile, (ITransactionContext)_003CTransactionContext_003Ek__BackingField);
				}
				Client client2 = this.client;
				int num = seed;
			}
			Client client3 = this.client;
			int num2 = seed;
			goto IL_0067;
			IL_0067:
			validSlots = list;
			List<GardeningSlot> list3 = validSlots;
			Collider component = garden.GetComponent<Collider>();
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = Vector3.forward.z;
			int num3 = 0;
			GardeningSlot gardeningSlot = default(GardeningSlot);
			if (!(gardeningSlot != (Object)num3))
			{
				done = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018EE")]
		[Cpp2IlInjected.Address(RVA = "0x19CF740", Offset = "0x19CE140", VA = "0x1819CF740")]
		private GardeningSlot FindClosestToTopLeftCorner(List<GardeningSlot> validSlots, Garden garden)
		{
			//Discarded unreachable code: IL_001d
			Collider component = garden.GetComponent<Collider>();
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = Vector3.forward.z;
			GardeningSlot result = default(GardeningSlot);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60018EF")]
		[Cpp2IlInjected.Address(RVA = "0x19CF8B0", Offset = "0x19CE2B0", VA = "0x1819CF8B0")]
		private List<GardeningSlot> FindValidSlots(List<GardeningSlot> slots)
		{
			//Discarded unreachable code: IL_0059
			ActionType actionType = this.actionType;
			if (actionType != 0)
			{
				switch (actionType)
				{
				default:
					return slots;
				case ActionType.Plant:
				{
					Client client2 = this.client;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
					Profile profile = client2.profile;
					return (List<GardeningSlot>)(object)GardeningUtil.FindWaterableSlots((List<>)(object)slots, profile, (ITransactionContext)_003CTransactionContext_003Ek__BackingField);
				}
				case ActionType.Harvest:
				{
					Client client = this.client;
					int num = seed;
					List<GardeningSlot> result = default(List<GardeningSlot>);
					return result;
				}
				}
			}
			Client client3 = this.client;
			int num2 = seed;
			List<GardeningSlot> result2 = default(List<GardeningSlot>);
			return result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018F0")]
		[Cpp2IlInjected.Address(RVA = "0x19CFC00", Offset = "0x19CE600", VA = "0x1819CFC00")]
		public DoGardeningAction()
		{
		}
	}
}
