using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x200039E")]
	public class ProfileSlotUploader : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200039F")]
		public enum Checkpoints
		{
			[Cpp2IlInjected.Token(Token = "0x400188F")]
			PostFTUE
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400188C")]
		[SerializeField]
		[ItemID]
		private List<int> uploadProfileOnMissionCompletion = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		private Meta.Online.Client client
		{
			[Cpp2IlInjected.Token(Token = "0x6000F7E")]
			[Cpp2IlInjected.Address(RVA = "0xCB9610", Offset = "0xCB8010", VA = "0x180CB9610")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		private Profile profile
		{
			[Cpp2IlInjected.Token(Token = "0x6000F7F")]
			[Cpp2IlInjected.Address(RVA = "0xCB96C0", Offset = "0xCB80C0", VA = "0x180CB96C0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return client.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400188D")]
		public bool AutoUpload
		{
			[Cpp2IlInjected.Token(Token = "0x6000F80")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000F81")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F82")]
		[Cpp2IlInjected.Address(RVA = "0xCB91E0", Offset = "0xCB7BE0", VA = "0x180CB91E0")]
		public void Start()
		{
			//Discarded unreachable code: IL_004a
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value = OnMissionSlotUpdated;
				_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value2 = OnMissionSlotUpdated;
				_003CDispatcher_003Ek__BackingField2.OnMissionSlotUpdated += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0xCB8F20", Offset = "0xCB7920", VA = "0x180CB8F20", Slot = "4")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value = OnMissionSlotUpdated;
					_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0xCB90E0", Offset = "0xCB7AE0", VA = "0x180CB90E0")]
		[AsyncStateMachine(typeof(_003COnMissionSlotUpdated_003Ed__12))]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [System.Runtime.InteropServices.Optional] List<AnyReward> rewards)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0xCB9440", Offset = "0xCB7E40", VA = "0x180CB9440")]
		[AsyncStateMachine(typeof(_003CUploadProfileToPlayfab_003Ed__13))]
		public Task<bool> UploadProfileToPlayfab(Checkpoints checkpoint, string suffix = "")
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0xCB92F0", Offset = "0xCB7CF0", VA = "0x180CB92F0")]
		[AsyncStateMachine(typeof(_003CUploadProfileToPlayfab_003Ed__14))]
		public Task<bool> UploadProfileToPlayfab(string profileName, bool force = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0xCB9590", Offset = "0xCB7F90", VA = "0x180CB9590")]
		public ProfileSlotUploader()
		{
		}
	}
}
