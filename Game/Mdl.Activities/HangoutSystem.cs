using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Mdl.Characters;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B68")]
	public class HangoutSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x2000B69")]
		public delegate void HangoutEventDelegate(Item characterItem, HangoutEvent hangoutEvent, bool affectHangoutAudio);

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003F69")]
		[SerializeField]
		private GameObject hangoutFriendshipGainedVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F6A")]
		[SerializeField]
		private GameObject hangoutFriendshipGainedPreferredVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003F6B")]
		private CancellationTokenSource HangoutSystemCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003F6C")]
		[SerializeField]
		private RewardSpawnAnimationData _rewardSpawnAnimationData;

		[Cpp2IlInjected.Token(Token = "0x4003F6E")]
		private static FriendshipSource[] HangoutFriendshipSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003F6F")]
		private Vector3? pendingRewardSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003F70")]
		private Vector3 pendingRewardGatherPosition;

		[Cpp2IlInjected.Token(Token = "0x1700072D")]
		internal Meta.Character MetaCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60034D1")]
			[Cpp2IlInjected.Address(RVA = "0x154C990", Offset = "0x154B390", VA = "0x18154C990")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.MetaClient.profile.HangoutState.HangingOutWithCharacter;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072E")]
		internal Mdl.Characters.Character Character
		{
			[Cpp2IlInjected.Token(Token = "0x60034D2")]
			[Cpp2IlInjected.Address(RVA = "0x154C860", Offset = "0x154B260", VA = "0x18154C860")]
			get
			{
				if (MetaCharacter != null)
				{
					CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
					int iD = MetaCharacter.Data.ID;
					Mdl.Characters.Character result = default(Mdl.Characters.Character);
					return result;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072F")]
		internal RewardSpawnAnimationData RewardSpawnAnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x60034D3")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return _rewardSpawnAnimationData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000095")]
		public event HangoutEventDelegate HangoutEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60034D4")]
			[Cpp2IlInjected.Address(RVA = "0x154C7C0", Offset = "0x154B1C0", VA = "0x18154C7C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D5")]
			[Cpp2IlInjected.Address(RVA = "0x154CA60", Offset = "0x154B460", VA = "0x18154CA60")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034D6")]
		[Cpp2IlInjected.Address(RVA = "0x154C330", Offset = "0x154AD30", VA = "0x18154C330")]
		[AsyncStateMachine(typeof(_003CStartHangout_003Ed__14))]
		internal Task<bool> StartHangout(StartHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken, bool affectHangoutAudio = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034D7")]
		[Cpp2IlInjected.Address(RVA = "0x154C4A0", Offset = "0x154AEA0", VA = "0x18154C4A0")]
		[AsyncStateMachine(typeof(_003CStopHangout_003Ed__15))]
		internal Task<bool> StopHangout(StopHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken, bool affectHangoutAudio = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034D8")]
		[Cpp2IlInjected.Address(RVA = "0x154B3D0", Offset = "0x1549DD0", VA = "0x18154B3D0")]
		public Task CancelHangout(CancellationToken cancellationToken)
		{
			//IL_0010: Expected O, but got I4
			Mdl.Characters.Character character = Character;
			int num = 0;
			if (!(character != (UnityEngine.Object)num))
			{
				int num2 = 0;
				Task completedTask = Task.CompletedTask;
			}
			Mdl.Characters.Character character2 = Character;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034D9")]
		[Cpp2IlInjected.Address(RVA = "0x154B5B0", Offset = "0x1549FB0", VA = "0x18154B5B0")]
		[AsyncStateMachine(typeof(_003CCancelHangout_003Ed__17))]
		public Task CancelHangout(Mdl.Characters.Character character, CancellationToken cancellationToken, bool cancelHangoutAudio = true, bool isTemporary = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DA")]
		[Cpp2IlInjected.Address(RVA = "0x154C1D0", Offset = "0x154ABD0", VA = "0x18154C1D0")]
		[AsyncStateMachine(typeof(_003CSpawnHangoutRewardsForCharacter_003Ed__18))]
		internal Task<bool> SpawnHangoutRewardsForCharacter(SpawnHangoutRewardsForCharacter.Types.Request request, CancellationToken cancellationToken)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DB")]
		[Cpp2IlInjected.Address(RVA = "0x154B780", Offset = "0x154A180", VA = "0x18154B780")]
		internal bool IsHangingOutWithAvatar(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_0007
			return character._isHangingOutWithAvatar;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DC")]
		[Cpp2IlInjected.Address(RVA = "0x154B160", Offset = "0x1549B60", VA = "0x18154B160")]
		internal bool CanHangoutWithAvatar(Mdl.Characters.Character character)
		{
			//IL_005c: Expected O, but got I4
			CharacterItemData _003CData_003Ek__BackingField = character.Data;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			int canOverride = 0;
			if (_003CData_003Ek__BackingField.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField, (byte)canOverride != 0) != ScheduleType.SpecificLocation && character.CanHangoutWithPlayer && !character.IsAquatic)
			{
				GameObject _003CConversationPartner_003Ek__BackingField = character.ConversationPartner;
				int num = 0;
				CurseSystem curseSystem = default(CurseSystem);
				if (_003CConversationPartner_003Ek__BackingField == (UnityEngine.Object)num && !character.IsMovingToTargetPosition && !character.IsMovingToTargetObject)
				{
					return !curseSystem.isActive;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034DD")]
		[Cpp2IlInjected.Address(RVA = "0x154B7A0", Offset = "0x154A1A0", VA = "0x18154B7A0")]
		internal bool IsHangoutLockedForCharacter(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_001a
			if (!character.InVillage)
			{
				return true;
			}
			return character.MetaCharacter.friendshipLevel_ < 2;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DE")]
		[Cpp2IlInjected.Address(RVA = "0x154BD00", Offset = "0x154A700", VA = "0x18154BD00", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0058
			CancellationTokenSource cancellationTokenSource = (HangoutSystemCancellationToken = new CancellationTokenSource());
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterFriendshipChanged value = OnCharacterFriendshipChanged;
			_003CDispatcher_003Ek__BackingField.OnCharacterFriendshipChanged += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.HangoutGatherReward value2 = OnHangoutGatherReward;
			_003CDispatcher_003Ek__BackingField2.OnHangoutGatherReward += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DF")]
		[Cpp2IlInjected.Address(RVA = "0x154B700", Offset = "0x154A100", VA = "0x18154B700")]
		public static bool IsFriendshipSourceFromHangout(FriendshipSource source)
		{
			FriendshipSource[] hangoutFriendshipSources = HangoutFriendshipSources;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E0")]
		[Cpp2IlInjected.Address(RVA = "0x154B7F0", Offset = "0x154A1F0", VA = "0x18154B7F0")]
		private void OnCharacterFriendshipChanged(Meta.Character metaCharacter, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			//Discarded unreachable code: IL_004a
			//IL_0020: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int iD = metaCharacter.Data.ID;
			int num = 0;
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			if (character != (UnityEngine.Object)num && character._isHangingOutWithAvatar)
			{
				FriendshipSource[] hangoutFriendshipSources = HangoutFriendshipSources;
				bool flag = default(bool);
				if (flag)
				{
					GameObject vfx = hangoutFriendshipGainedPreferredVFX;
					AddVfxToCharacter(character, vfx);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034E1")]
		[Cpp2IlInjected.Address(RVA = "0x154B060", Offset = "0x1549A60", VA = "0x18154B060")]
		private void AddVfxToCharacter(Mdl.Characters.Character character, GameObject vfx)
		{
			//Discarded unreachable code: IL_002b
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (vfx != (UnityEngine.Object)num)
			{
				Transform parent = character.CharacterVisualNodes.HeadIcon.transform;
				DestroyOnEnable destroyOnEnable = UnityEngine.Object.Instantiate(vfx, parent).AddComponent<DestroyOnEnable>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034E4")]
		[Cpp2IlInjected.Address(RVA = "0x154BF20", Offset = "0x154A920", VA = "0x18154BF20", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0073
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CharacterFriendshipChanged value = OnCharacterFriendshipChanged;
				_003CDispatcher_003Ek__BackingField.OnCharacterFriendshipChanged -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.HangoutGatherReward value2 = OnHangoutGatherReward;
				_003CDispatcher_003Ek__BackingField2.OnHangoutGatherReward -= value2;
			}
			HangoutSystemCancellationToken?.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x60034E5")]
		[Cpp2IlInjected.Address(RVA = "0x154C610", Offset = "0x154B010", VA = "0x18154C610")]
		public unsafe void UpdateGatherRewardSource(Vector3 rewardSourcePosition, [System.Runtime.InteropServices.Optional] Vector3? rewardGatherPosition)
		{
			//IL_0010: Expected O, but got I4
			//IL_001c: Expected F4, but got I4
			//IL_0017: Expected native int or pointer, but got O
			float z = rewardSourcePosition.z;
			int num = 0;
			pendingRewardSource = (Vector3?)(object)num;
			((Vector3*)(IntPtr)pendingRewardGatherPosition)->z = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E6")]
		[Cpp2IlInjected.Address(RVA = "0x154BA30", Offset = "0x154A430", VA = "0x18154BA30")]
		private unsafe void OnHangoutGatherReward(ItemReward[] _)
		{
			//Discarded unreachable code: IL_00b6
			//IL_0014: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_00a8: Expected native int or pointer, but got O
			//IL_00b5: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Mdl.Characters.Character character = Character;
			int num3 = 0;
			if (character != (UnityEngine.Object)num3)
			{
				if ((object)character != null)
				{
				}
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
				float z2 = pendingRewardGatherPosition.z;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				int agentTypeID = Character.NavMeshAgentComponent.agentTypeID;
				int walkableMask = Character.NavMeshAgentComponent.walkableMask;
				bool flag = default(bool);
				if (flag)
				{
				}
				Mdl.Characters.Character character2 = Character;
				int num4 = 0;
				character2.RewardPosition = (Vector3?)(object)num4;
				Mdl.Characters.Character character3 = Character;
				int num5 = 0;
				((Vector3*)(IntPtr)character3.RewardSourcePosition)->z = z;
				pendingRewardSource = (Vector3?)(object)num5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034E7")]
		[Cpp2IlInjected.Address(RVA = "0x154C780", Offset = "0x154B180", VA = "0x18154C780")]
		public unsafe HangoutSystem()
		{
			//IL_0012: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)pendingRewardGatherPosition)->z = z;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60034E8")]
		[Cpp2IlInjected.Address(RVA = "0x154C6E0", Offset = "0x154B0E0", VA = "0x18154C6E0")]
		static HangoutSystem()
		{
			//IL_0018: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			FriendshipSource[] array = new FriendshipSource[2];
			int length = array.Length;
			array[0] = FriendshipSource.HangoutActivity;
			array[0] = FriendshipSource.HangoutActivityPreferred;
			HangoutFriendshipSources = array;
			throw new NullReferenceException();
		}
	}
}
