using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C0A")]
	internal class UnlockAreaAction : DialogueAction
	{
		[Cpp2IlInjected.Token(Token = "0x60036E9")]
		[Cpp2IlInjected.Address(RVA = "0xD37D20", Offset = "0xD36720", VA = "0x180D37D20", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EA")]
		[Cpp2IlInjected.Address(RVA = "0xD37E70", Offset = "0xD36870", VA = "0x180D37E70")]
		[AsyncStateMachine(typeof(_003CStartUnlock_003Ed__1))]
		public Task<bool> StartUnlock(UnlockArea actionData, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EB")]
		[Cpp2IlInjected.Address(RVA = "0xD37F90", Offset = "0xD36990", VA = "0x180D37F90", Slot = "9")]
		public override bool TryGetActionCost(GameObject target, PlayerTaskDefinition playerTaskDefinition, out Item currencyItem, out int amount)
		{
			//IL_007e: Expected I4, but got O
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			Village village = SystemRoot.Instance.MetaClient.profile.Village;
			bool flag = default(bool);
			if (flag)
			{
				UnlockArea unlockArea = target.GetComponent<UnlockArea>();
				Func<VillageAreaData.Types.Data, bool> func = (Func<VillageAreaData.Types.Data, bool>)(object)(Func<T, TResult>)delegate(VillageAreaData.Types.Data x)
				{
					//Discarded unreachable code: IL_0016
					VillageAreaType areaType = unlockArea._areaType;
					return x.areaType_ == areaType;
				};
				VillageAreaData.Types.Data data = default(VillageAreaData.Types.Data);
				if (data != null && ((RepeatedField<T>)(object)data.unlockCost_).Count > 0)
				{
					RepeatedField<CurrencyCost> unlockCost_ = data.unlockCost_;
					int index = 0;
					Item item = ((CurrencyCost)((RepeatedField<T>)(object)unlockCost_)[index]).Item;
					currencyItem.ItemID = (int)item;
					return true;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036EC")]
		[Cpp2IlInjected.Address(RVA = "0xD382F0", Offset = "0xD36CF0", VA = "0x180D382F0")]
		public UnlockAreaAction()
		{
		}
	}
}
