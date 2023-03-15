using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Buildings;
using Mdl.Display;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BC9")]
	internal class InteractWithDisplayAction : DialogueAction
	{
		[Cpp2IlInjected.Token(Token = "0x600362E")]
		[Cpp2IlInjected.Address(RVA = "0x11B8830", Offset = "0x11B7230", VA = "0x1811B8830", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600362F")]
		[Cpp2IlInjected.Address(RVA = "0x11B8980", Offset = "0x11B7380", VA = "0x1811B8980", Slot = "9")]
		public override bool TryGetActionCost(GameObject target, PlayerTaskDefinition playerTaskDefinition, out Item currencyItem, out int amount)
		{
			//IL_000a: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			int num = 0;
			IPlayerTaskData[] result = (IPlayerTaskData[])((Task<TResult>)(object)PlayerTask.CreateTaskDataArray(playerTaskDefinition, target, (CancellationToken)num)).Result;
			int num2 = 0;
			DisplaySlotData displaySlotData = default(DisplaySlotData);
			if (displaySlotData == (UnityEngine.Object)num2)
			{
			}
			ItemSupport component = displaySlotData.RootObject.GetComponent<ItemSupport>();
			int num3 = 0;
			int num4 = default(int);
			if (!(displaySlotData != (UnityEngine.Object)num3))
			{
				if ((object)component != null)
				{
					DisplaySlotData componentInChildren = component.GetComponentInChildren<DisplaySlotData>(includeInactive: true);
				}
				num4 = 0;
			}
			int num5 = 0;
			bool flag = (UnityEngine.Object)num4 != (UnityEngine.Object)num5;
			if (flag && flag && num4 != 0 && (long)(IntPtr)component > 0L)
			{
				Item item = default(Item);
				int itemID = item.ItemID;
				bool flag2 = default(bool);
				if (flag2)
				{
					currencyItem.ItemID = (flag2 ? 1 : 0);
					return true;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003630")]
		[Cpp2IlInjected.Address(RVA = "0xD382F0", Offset = "0xD36CF0", VA = "0x180D382F0")]
		public InteractWithDisplayAction()
		{
		}
	}
}
