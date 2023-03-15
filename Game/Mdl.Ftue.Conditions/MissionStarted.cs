using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000618")]
	[CreateAssetMenu]
	public class MissionStarted : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40024A2")]
		[ItemID]
		public int mission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40024A3")]
		public MissionSlotState missionState = MissionSlotState.OnGoing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40024A4")]
		public int currentStepIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40024A5")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001B09")]
		[Cpp2IlInjected.Address(RVA = "0xEF9EB0", Offset = "0xEF88B0", VA = "0x180EF9EB0", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_003e
			this.client = client;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value = OnMissionUpdated;
			_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value2 = OnMissionUpdated;
			_003CDispatcher_003Ek__BackingField2.OnMissionSlotUpdated += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0A")]
		[Cpp2IlInjected.Address(RVA = "0xEF9FA0", Offset = "0xEF89A0", VA = "0x180EF9FA0", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6
			ICollection<MissionQueue> values;
			uint num3 = default(uint);
			int num4 = default(int);
			MissionSlot missionSlot = default(MissionSlot);
			MissionSlot missionSlot2 = default(MissionSlot);
			MissionSlot missionSlot3 = default(MissionSlot);
			int num7 = default(int);
			int num2;
			while (true)
			{
				int num = 0;
				num2 = 0;
				values = (ICollection<MissionQueue>)((MapField<TKey, TValue>)(object)client.profile.world_.missionSlots_).get_Values();
				if (values == null)
				{
					break;
				}
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_0072;
					}
					num2++;
				}
				while (num4 <= 0)
				{
				}
				int num5 = 0;
				if (missionSlot.missionId_ != mission)
				{
					continue;
				}
				int num6 = 0;
				if (missionSlot2.state_ != missionState)
				{
					continue;
				}
				num7 = 0;
				if (missionSlot3.currentStepIndex_ != currentStepIndex)
				{
					continue;
				}
				num2++;
				goto IL_0072;
				IL_0072:
				num7 += num7;
				num2 += 312;
				break;
			}
			num2++;
			if (values != null)
			{
			}
			if (num2 != 0)
			{
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnMissionUpdated(MissionSlotClass SlotClass, int SlotId, MissionItemData missionData, SlotUpdatedReason reason, [System.Runtime.InteropServices.Optional] List<AnyReward> rewards)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0C")]
		[Cpp2IlInjected.Address(RVA = "0xEF9E10", Offset = "0xEF8810", VA = "0x180EF9E10", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value = OnMissionUpdated;
				_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0D")]
		[Cpp2IlInjected.Address(RVA = "0xEFA2D0", Offset = "0xEF8CD0", VA = "0x180EFA2D0")]
		public MissionStarted()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
