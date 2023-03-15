using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Dialogues;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Missions;
using Meta.Online;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	public class MissionManager : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x200024C")]
		public delegate void MissionsInitialized();

		[Cpp2IlInjected.Token(Token = "0x200024D")]
		private class FollowTaskInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001393")]
			public Item MissionItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001394")]
			public string StepName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001395")]
			public CancellationTokenSource TokenSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001396")]
			public Item CharacterItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4001397")]
			public SceneType SceneType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001398")]
			public Vector3? Target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001399")]
			public float TargetRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400139A")]
			public float AvatarRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400139B")]
			public bool IsRunning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x400139C")]
			public bool Unspawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400139D")]
			public FollowTaskInfo NextTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400139E")]
			public CharacterManager.CharacterInstance _CharacterInstance;

			[Cpp2IlInjected.Token(Token = "0x1700015A")]
			public CharacterManager.CharacterInstance CharacterInstance
			{
				[Cpp2IlInjected.Token(Token = "0x6000AA1")]
				[Cpp2IlInjected.Address(RVA = "0x1205170", Offset = "0x1203B70", VA = "0x181205170")]
				get
				{
					//IL_003b: Expected O, but got I4
					CharacterManager.CharacterInstance characterInstance = _CharacterInstance;
					if (characterInstance == null)
					{
						SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
						if ((object)_003CInstance_003Ek__BackingField != null)
						{
							CharacterManager system = _003CInstance_003Ek__BackingField.GetSystem<CharacterManager>();
							if ((object)system != null)
							{
								Item characterItem = CharacterItem;
								CharacterManager.CharacterInstance characterInstance2 = system.GetCharacterInstance(characterItem);
							}
						}
						int num = 0;
						_CharacterInstance = (CharacterManager.CharacterInstance)num;
					}
					return characterInstance;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015B")]
			public Mdl.Characters.Character Character
			{
				[Cpp2IlInjected.Token(Token = "0x6000AA2")]
				[Cpp2IlInjected.Address(RVA = "0x1205270", Offset = "0x1203C70", VA = "0x181205270")]
				get
				{
					//IL_003b: Expected O, but got I4
					CharacterManager.CharacterInstance characterInstance = _CharacterInstance;
					if (characterInstance == null)
					{
						SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
						if ((object)_003CInstance_003Ek__BackingField != null)
						{
							CharacterManager system = _003CInstance_003Ek__BackingField.GetSystem<CharacterManager>();
							if ((object)system != null)
							{
								Item characterItem = CharacterItem;
								CharacterManager.CharacterInstance characterInstance2 = system.GetCharacterInstance(characterItem);
							}
						}
						int num = 0;
						_CharacterInstance = (CharacterManager.CharacterInstance)num;
						if (_CharacterInstance == null)
						{
							Mdl.Characters.Character result = default(Mdl.Characters.Character);
							return result;
						}
					}
					return characterInstance.Character;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x1204B30", Offset = "0x1203530", VA = "0x181204B30")]
			public bool NpcInTargetRange(Mdl.Characters.Character npc, float offset = 0f)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA4")]
			[Cpp2IlInjected.Address(RVA = "0x12046D0", Offset = "0x12030D0", VA = "0x1812046D0")]
			public bool AvatarInNpcRange(PlayerAvatar avatar, Mdl.Characters.Character npc, float offset = 0f)
			{
				//IL_0009: Expected O, but got I4
				//IL_0015: Expected O, but got I4
				int num = 0;
				if (npc != (UnityEngine.Object)num)
				{
					int num2 = 0;
					if (avatar != (UnityEngine.Object)num2)
					{
						Transform _003Ctransform_003Ek__BackingField = npc.transform;
						Vector3 vector = default(Vector3);
						float z = vector.z;
						Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
						Vector3 vector2 = default(Vector3);
						float z2 = vector2.z;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x12049C0", Offset = "0x12033C0", VA = "0x1812049C0")]
			public void MoveToTarget(Mdl.Characters.Character character)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x1204820", Offset = "0x1203220", VA = "0x181204820")]
			public CustomStepFollowCharacter GetObjectiveData()
			{
				//IL_0026: Expected O, but got I4
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				Item missionItem = MissionItem;
				int num = 0;
				MissionSlot missionSlot = world_.GetMissionSlot(missionItem, (Func<, >)num);
				if (missionSlot != null)
				{
					IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)missionSlot.get_AllStepsObjectives();
					Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_0019
						string stepName_ = x.Data.stepName_;
						return string.Equals(StepName, stepName_);
					};
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
					if (missionObjective != null)
					{
						MissionObjectiveData _003CData_003Ek__BackingField = missionObjective.Data;
						if (_003CData_003Ek__BackingField != null)
						{
							return _003CData_003Ek__BackingField.FollowCharacter;
						}
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x1204C50", Offset = "0x1203650", VA = "0x181204C50")]
			public void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions addObjectOptions)
			{
				//Discarded unreachable code: IL_0072
				int num = 0;
				if (operation != (GridChangedOperation)(-3))
				{
					return;
				}
				CustomStepFollowCharacter objectiveData = GetObjectiveData();
				if (objectiveData != null)
				{
					LocationSource targetLocation_ = objectiveData.targetLocation_;
					if (targetLocation_ != null)
					{
						LocationBuilding building = targetLocation_.Building;
						if (building != null)
						{
							int building_ = building.building_;
						}
					}
				}
				bool flag = num == gridObject.itemID_;
				if (num == (flag ? 1 : 0))
				{
					if (num == 0)
					{
						return;
					}
					int itemID = gridObject.ItemID;
					Client client = default(Client);
					if ((object)client.profile.world_.playerHouse_.HouseItem == null)
					{
						return;
					}
				}
				RefreshTarget();
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0x1204E20", Offset = "0x1203820", VA = "0x181204E20")]
			public void RefreshTarget(bool moveToTarget = true)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FollowTaskInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200024E")]
		private class ListenTaskInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400139F")]
			public MissionObjective MissionObjective;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40013A0")]
			public Task<bool> ListenTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40013A1")]
			public Item ListenedDialogue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40013A2")]
			public CancellationTokenSource TokenSource;

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ListenTaskInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200024F")]
		private class LocationTaskInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40013A3")]
			public Item MissionItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40013A4")]
			public string StepName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40013A5")]
			public CancellationTokenSource CancellationTokenSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40013A6")]
			public Vector3? Target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40013A7")]
			public float Distance;

			[Cpp2IlInjected.Token(Token = "0x6000AAC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LocationTaskInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001384")]
		[SerializeField]
		[ItemID]
		private int _castleSceneDefinitionItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001385")]
		[SerializeField]
		private PlayerTaskDefinition _taskExitEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001386")]
		private Dictionary<string, FollowLocation> _locationSceneDef = (Dictionary<string, FollowLocation>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001387")]
		private bool IsLoadingAnyEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001388")]
		public PlayerTaskDefinition TalkDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001389")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400138B")]
		private CancellationTokenSource _ctsMissionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400138C")]
		private List<FollowTaskInfo> _followTasks = (List<FollowTaskInfo>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400138D")]
		private List<ListenTaskInfo> _listenTasks = (List<ListenTaskInfo>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400138F")]
		private List<MissionObjective> CurrentChases = (List<MissionObjective>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001390")]
		private List<LocationTaskInfo> _visitAreaTasks = (List<LocationTaskInfo>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001391")]
		private int ActiveInteractionObjectiveCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001392")]
		private readonly List<FriendshipChoice> FriendshipChoices = (List<FriendshipChoice>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public SceneItemData CastleSceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0xBD6060", Offset = "0xBD4A60", VA = "0x180BD6060")]
			get
			{
				//Discarded unreachable code: IL_0016
				int castleSceneDefinitionItem = _castleSceneDefinitionItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)castleSceneDefinitionItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get
			{
				return _isInit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		private Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xBD6340", Offset = "0xBD4D40", VA = "0x180BD6340")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xBD63F0", Offset = "0xBD4DF0", VA = "0x180BD63F0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		private CharacterManager CharacterManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xBD6170", Offset = "0xBD4B70", VA = "0x180BD6170")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CharacterManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		private CurseSystem CurseSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xBD6230", Offset = "0xBD4C30", VA = "0x180BD6230")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CurseSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		private bool HasListenTasks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0xBD62F0", Offset = "0xBD4CF0", VA = "0x180BD62F0")]
			get
			{
				return Enumerable.Any<ListenTaskInfo>((IEnumerable<>)_listenTasks);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event MissionsInitialized OnMissionsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0xBD5FC0", Offset = "0xBD49C0", VA = "0x180BD5FC0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0xBD6550", Offset = "0xBD4F50", VA = "0x180BD6550")]
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

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event EventHandler<Item> ListenTaskEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0xBD5F20", Offset = "0xBD4920", VA = "0x180BD5F20")]
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
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xBD64B0", Offset = "0xBD4EB0", VA = "0x180BD64B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xBCBE20", Offset = "0xBCA820", VA = "0x180BCBE20")]
		[AsyncStateMachine(typeof(_003CDebugTestMissionAsync_003Ed__0))]
		public Task<DebugTestMission.Types.Response> DebugTestMissionAsync(int missionId, bool autoStart = false, int stepIndex = 0, MissionChoice missionChoice = MissionChoice.Any, [System.Runtime.InteropServices.Optional] Action callback)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DebugTestMission.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xBCBD50", Offset = "0xBCA750", VA = "0x180BCBD50")]
		[AsyncStateMachine(typeof(_003CDebugCompleteAllTriggeredEvents_003Ed__1))]
		private System.Threading.Tasks.Task DebugCompleteAllTriggeredEvents()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xBC93B0", Offset = "0xBC7DB0", VA = "0x180BC93B0")]
		[AsyncStateMachine(typeof(_003CCompletePendingFTUEEvents_003Ed__2))]
		private System.Threading.Tasks.Task CompletePendingFTUEEvents(bool originalDebugDisableUI, bool originalSkipAllCutscenes)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xBCBCE0", Offset = "0xBCA6E0", VA = "0x180BCBCE0")]
		public void DebugAddQuestStepItems(Item missionItem)
		{
			//Discarded unreachable code: IL_0028
			ProfileWorld world_ = Profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot != null && missionSlot.state_ == MissionSlotState.OnGoing)
			{
				MissionStep currentStep = missionSlot.CurrentStep;
				DebugAddQuestStepItems(currentStep);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xBC94D0", Offset = "0xBC7ED0", VA = "0x180BC94D0")]
		public void DebugAddQuestStepItems(MissionSlot missionSlot)
		{
			if (missionSlot != null && missionSlot.state_ == MissionSlotState.OnGoing)
			{
				MissionStep currentStep = missionSlot.CurrentStep;
				DebugAddQuestStepItems(currentStep);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xBC9510", Offset = "0xBC7F10", VA = "0x180BC9510")]
		public void DebugAddQuestStepItems(MissionStep currentStep)
		{
			//IL_0018: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_00ea: Expected I4, but got I8
			//IL_00ea: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_011c: Expected O, but got I4
			//IL_0202: Expected O, but got I4
			//IL_0219: Expected I4, but got I8
			//IL_0219: Expected I4, but got I8
			//IL_0219: Expected O, but got I4
			uint num4 = default(uint);
			_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass5_1);
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num5 = default(int);
			int num6 = default(int);
			CustomStepFeedCritter customStepFeedCritter = default(CustomStepFeedCritter);
			CustomStepFeedCritter customStepFeedCritter2 = default(CustomStepFeedCritter);
			CustomStepFeedCritter customStepFeedCritter3 = default(CustomStepFeedCritter);
			IEnumerable<> enumerable = default(IEnumerable<>);
			CustomStepFeedCritter customStepFeedCritter4 = default(CustomStepFeedCritter);
			IEnumerable<Item> enumerable2 = default(IEnumerable<Item>);
			int num8 = default(int);
			Profile profile = default(Profile);
			ulong num9 = default(ulong);
			ulong num10 = default(ulong);
			Func<IItemData, Item> func = default(Func<IItemData, Item>);
			IEnumerable<IItemData> enumerable3 = default(IEnumerable<IItemData>);
			IEnumerable<Item> enumerable5 = default(IEnumerable<Item>);
			int num11 = default(int);
			int num14 = default(int);
			bool flag3 = default(bool);
			CustomStepParty customStepParty = default(CustomStepParty);
			List<(Item, int)> list6 = default(List<(Item, int)>);
			bool flag4 = default(bool);
			ulong num15 = default(ulong);
			int num16 = default(int);
			IEnumerable<(Item, int)> enumerable6 = default(IEnumerable<(Item, int)>);
			bool flag5 = default(bool);
			Profile profile2 = default(Profile);
			Func<CharacterRestaurantOrder, bool> func2 = default(Func<CharacterRestaurantOrder, bool>);
			int num18 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (currentStep == null)
				{
					continue;
				}
				List<MissionObjectiveData.CustomStepOneofCase> list = (List<MissionObjectiveData.CustomStepOneofCase>)(object)new List<T>();
				((List<T>)(object)list).Add((T)100);
				((List<T>)(object)list).Add((T)110);
				((List<T>)(object)list).Add((T)120);
				((List<T>)(object)list).Add((T)125);
				List<MissionObjectiveData.CustomStepOneofCase> list2 = (List<MissionObjectiveData.CustomStepOneofCase>)(object)new List<T>();
				IEnumerable<MissionObjective> activeObjectives = (IEnumerable<MissionObjective>)currentStep.get_ActiveObjectives();
				if (activeObjectives == null)
				{
					continue;
				}
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_0082;
					}
					num++;
				}
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_1();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				List<(Item, int)> list3 = (CS_0024_003C_003E8__locals0.finalItems = (List<(Item item, int amount)>)(object)new List<T>());
				if (!flag)
				{
					while (!flag2)
					{
					}
					num5 = 0;
					goto IL_0082;
				}
				goto IL_0089;
				IL_019a:
				num6 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				goto IL_01a4;
				IL_01a4:
				if (num6 != 160)
				{
					continue;
				}
				while (customStepFeedCritter.action_ == CustomStepFeedCritter.Types.FeedAction.SpecificItem)
				{
				}
				if (customStepFeedCritter2.conditionCase_ != 0)
				{
					while (customStepFeedCritter3.conditionCase_ != CustomStepFeedCritter.ConditionOneofCase.Location)
					{
					}
					if (enumerable != null)
					{
						int num7 = 0;
						VillageAreaType location = customStepFeedCritter4.Location;
						if (!Enumerable.Any<Item>((IEnumerable<>)enumerable2))
						{
							System.Random random = new System.Random();
							string debugName = $"AddQuestStepItems:{num8}";
							int onlySeedCrop = 0;
							ItemFilter itemFilter = ItemFilter.New((ItemSelector)num, profile, random, (byte)onlySeedCrop != 0, (byte)num9 != 0, (byte)num10 != 0, debugName);
							if (_003C_003Ec._003C_003E9__5_5 == null)
							{
								func = (Func<IItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
								{
									throw new NullReferenceException();
								});
							}
							IEnumerable<IItemData> enumerable4 = (IEnumerable<IItemData>)Enumerable.Select<IItemData, Item>((IEnumerable<>)enumerable3, (Func<, >)(object)func);
							List<Item> list4 = (List<Item>)(object)itemFilter.ApplyFilter((IEnumerable<>)enumerable4);
							if (!Enumerable.Any<Item>((IEnumerable<>)list4))
							{
								continue;
							}
							Item item = Enumerable.First<Item>((IEnumerable<>)list4);
						}
						Item item2 = Enumerable.First<Item>((IEnumerable<>)enumerable5);
					}
					num11++;
					int num12 = 0;
					if (enumerable != null)
					{
					}
					if (num != 0)
					{
						continue;
					}
					if (num11 != 0)
					{
						int num13 = num11 - 1;
					}
				}
				while (num14 <= 0)
				{
				}
				List<Item> list5 = (List<Item>)(object)new List<T>();
				if (!flag3 && (long)list5 > 135 && (long)list5 == 145)
				{
					/*Error: Could not find block for branch target IL_02c1*/;
				}
				continue;
				IL_0082:
				num5 += num5;
				goto IL_0089;
				IL_0089:
				if ((long)list > 165)
				{
					if ((long)list == 215)
					{
						Item partyItem = customStepParty.PartyItem;
						RemoveOwnedItems();
						if ((long)activeObjectives != 130 && (long)activeObjectives != 125)
						{
							continue;
						}
						list6 = (List<(Item, int)>)(object)new List<T>();
						List<(Item, int)> finalItems = CS_0024_003C_003E8__locals0.finalItems;
						if (!flag4)
						{
							continue;
						}
						string localizedDisplayName = ((Item)num3).GetLocalizedDisplayName((Localizator)num3, (byte)num15 != 0);
						string text = $"[CHEAT] Transformed: {num16}x {localizedDisplayName}";
						if (enumerable6 == null)
						{
							continue;
						}
						while (!flag5)
						{
						}
						while ((long)(IntPtr)enumerable6 <= 0L)
						{
						}
						IEnumerable<(Item, int)> enumerable7 = (IEnumerable<(Item, int)>)(enumerable6 * num3);
						((List<T>)(object)list6).Add((T)num);
					}
					if ((long)list6 == 235)
					{
						goto IL_019a;
					}
					if ((long)list6 != 255)
					{
						continue;
					}
					RepeatedField<CharacterRestaurantOrder> characterRestaurantOrders_ = profile2.world_.characterRestaurantOrders_;
					if (_003C_003Ec._003C_003E9__5_7 == null)
					{
						func2 = (Func<CharacterRestaurantOrder, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterRestaurantOrder x) => !x.fulfilled_));
					}
					IEnumerable<CharacterRestaurantOrder> enumerable8 = (IEnumerable<CharacterRestaurantOrder>)Enumerable.Where<CharacterRestaurantOrder>((IEnumerable<>)(object)characterRestaurantOrders_, (Func<, >)(object)func2);
					if (enumerable8 != null)
					{
					}
					num++;
					int num17 = 0;
					if (enumerable8 != null)
					{
						num18 = 0;
					}
					if (num != 0 || num == 0)
					{
						continue;
					}
				}
				if (num18 == 155)
				{
					goto IL_019a;
				}
				goto IL_01a4;
				Func<(Item, int), (Item, int)> func3;
				ProfilePlayer player_;
				int num19;
				int includePantry;
				int num20;
				Item item3;
				int itemAmount;
				Item item4;
				Func<(Item, int), bool> _003C_003E9__5_;
				List<(Item, int)> list7;
				IEnumerable<(Item, int)> enumerable9 = default(IEnumerable<(Item, int)>);
				[Cpp2IlInjected.Token(Token = "0x6000AD6")]
				[Cpp2IlInjected.Address(RVA = "0xF741F0", Offset = "0xF72BF0", VA = "0x180F741F0")]
				unsafe void RemoveOwnedItems()
				{
					func3 = (Func<(Item, int), (Item, int)>)(object)(Func<T, TResult>)delegate((Item item, int amount) x)
					{
						//IL_0024: Expected O, but got I4
						player_ = CS_0024_003C_003E8__locals0._003C_003E4__this.Profile.player_;
						num19 = 0;
						includePantry = 0;
						num20 = 0;
						item3 = (Item)((ValueTuple<, >*)(&x))->Item1;
						itemAmount = player_.GetItemAmount(item3, (ItemState)num20, (byte)includePantry != 0);
						item4 = (Item)((ValueTuple<, >*)(&x))->Item1;
						throw new NullReferenceException();
					};
					_003C_003E9__5_ = _003C_003Ec._003C_003E9__5_21;
					if (_003C_003E9__5_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x111E20", Offset = "0x111220")] (Item, int) x) => (long)(IntPtr)x > 0L);
					}
					list7 = (CS_0024_003C_003E8__locals0.finalItems = (List<(Item item, int amount)>)(object)Enumerable.ToList<(Item, int)>(Enumerable.Where<(Item, int)>((IEnumerable<>)enumerable9, (Func<, >)(object)_003C_003E9__5_)));
					/*Error: Unexpected end of block*/;
				}
				[Cpp2IlInjected.Token(Token = "0x6000AD6")]
				[Cpp2IlInjected.Address(RVA = "0xF741F0", Offset = "0xF72BF0", VA = "0x180F741F0")]
				unsafe void RemoveOwnedItems()
				{
					func3 = (Func<(Item, int), (Item, int)>)(object)(Func<T, TResult>)delegate((Item item, int amount) x)
					{
						//IL_0024: Expected O, but got I4
						player_ = CS_0024_003C_003E8__locals0._003C_003E4__this.Profile.player_;
						num19 = 0;
						includePantry = 0;
						num20 = 0;
						item3 = (Item)((ValueTuple<, >*)(&x))->Item1;
						itemAmount = player_.GetItemAmount(item3, (ItemState)num20, (byte)includePantry != 0);
						item4 = (Item)((ValueTuple<, >*)(&x))->Item1;
						throw new NullReferenceException();
					};
					_003C_003E9__5_ = _003C_003Ec._003C_003E9__5_21;
					if (_003C_003E9__5_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x111E20", Offset = "0x111220")] (Item, int) x) => (long)(IntPtr)x > 0L);
					}
					list7 = (CS_0024_003C_003E8__locals0.finalItems = (List<(Item item, int amount)>)(object)Enumerable.ToList<(Item, int)>(Enumerable.Where<(Item, int)>((IEnumerable<>)enumerable9, (Func<, >)(object)_003C_003E9__5_)));
					/*Error: Unexpected end of block*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xBCF480", Offset = "0xBCDE80", VA = "0x180BCF480")]
		[IteratorStateMachine(typeof(_003CGetRequiredRecipeItems_003Ed__6))]
		private IEnumerable<(Item, int)> GetRequiredRecipeItems(MissionObjectiveData.CustomStepOneofCase stepCase, Item item)
		{
			//IL_001f: Expected O, but got I4
			int itemID = item.ItemID;
			_003CGetRequiredRecipeItems_003Ed__6 _003CGetRequiredRecipeItems_003Ed__ = new _003CGetRequiredRecipeItems_003Ed__6(-2);
			_003CGetRequiredRecipeItems_003Ed__._003C_003E3__stepCase = stepCase;
			_003CGetRequiredRecipeItems_003Ed__._003C_003E3__item = (Item)itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xBD4D00", Offset = "0xBD3700", VA = "0x180BD4D00")]
		public bool TryGetLocationPosition(string name, out Vector3 position)
		{
			//Discarded unreachable code: IL_0037
			//IL_0014: Expected F4, but got I4
			//IL_001b: Expected F4, but got I4
			Dictionary<string, FollowLocation> locationSceneDef = _locationSceneDef;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				position.x = num;
				position.z = num;
			}
			GameObject gameObject = default(GameObject);
			Transform transform = gameObject.transform;
			Vector3 vector = default(Vector3);
			float num2 = (position.z = vector.z);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xBC88F0", Offset = "0xBC72F0", VA = "0x180BC88F0")]
		public void AddFollowLocation(string name, FollowLocation location)
		{
			//Discarded unreachable code: IL_000e
			((Dictionary<TKey, TValue>)(object)_locationSceneDef)[(TKey)name] = (TValue)location;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0xBCEBB0", Offset = "0xBCD5B0", VA = "0x180BCEBB0")]
		private FollowTaskInfo GetFollowTask(MissionObjective obj)
		{
			//Discarded unreachable code: IL_0029
			List<FollowTaskInfo> followTasks = _followTasks;
			Func<FollowTaskInfo, bool> func = (Func<FollowTaskInfo, bool>)(object)(Func<T, TResult>)delegate(FollowTaskInfo x)
			{
				//Discarded unreachable code: IL_0036
				if (obj.MissionSlot.Data.ID == 0)
				{
				}
				string stepName_ = obj.Data.stepName_;
				return string.Equals(x.StepName, stepName_);
			};
			return Enumerable.FirstOrDefault<FollowTaskInfo>((IEnumerable<>)followTasks, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0xBCEAD0", Offset = "0xBCD4D0", VA = "0x180BCEAD0")]
		private FollowTaskInfo GetFollowTaskForCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<FollowTaskInfo> followTasks = _followTasks;
			Func<FollowTaskInfo, bool> func = (Func<FollowTaskInfo, bool>)(object)(Func<T, TResult>)((FollowTaskInfo x) => (byte)(int)typeof(Item).TypeHandle != 0);
			return Enumerable.FirstOrDefault<FollowTaskInfo>((IEnumerable<>)followTasks, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0xBD2E30", Offset = "0xBD1830", VA = "0x180BD2E30")]
		public void RefreshFollowTaskForCharacter(Item characterItem, bool moveToTarget = true)
		{
			//Discarded unreachable code: IL_003f
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<FollowTaskInfo> followTasks = _followTasks;
			Func<FollowTaskInfo, bool> func = (Func<FollowTaskInfo, bool>)(object)(Func<T, TResult>)((FollowTaskInfo x) => (byte)(int)typeof(Item).TypeHandle != 0);
			Enumerable.FirstOrDefault<FollowTaskInfo>((IEnumerable<>)followTasks, (Func<, >)(object)func)?.RefreshTarget(moveToTarget);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xBD3A40", Offset = "0xBD2440", VA = "0x180BD3A40")]
		private void StartFollowTask(MissionObjective obj)
		{
			//IL_003e: Expected O, but got I4
			CharacterManager characterManager = CharacterManager;
			MissionSlot missionSlot = default(MissionSlot);
			Item characterItem = missionSlot.CharacterItem;
			Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
			Mdl.Characters.Character character = character2;
			Mdl.Characters.Character character3 = character;
			int num = 0;
			CustomStepFollowCharacter followStep;
			CancellationTokenSource cts;
			SceneType sceneType = default(SceneType);
			Func<PlayerTaskDefinition, bool> func = default(Func<PlayerTaskDefinition, bool>);
			if (!(character3 == (UnityEngine.Object)num))
			{
				Transform levelUpStartCamera = character3.levelUpStartCamera;
				CustomStepFollowCharacter customStepFollowCharacter = default(CustomStepFollowCharacter);
				followStep = customStepFollowCharacter;
				CustomStepFollowCharacter customStepFollowCharacter2 = followStep;
				int num2 = 0;
				if (customStepFollowCharacter2 != null)
				{
				}
				bool flag = default(bool);
				if (flag)
				{
					int onlyCancelTest = 0;
					MissionSlot slot = default(MissionSlot);
					StopFollowTasksForMission(slot, (byte)onlyCancelTest != 0);
					cts = new CancellationTokenSource();
					FollowTaskInfo followTaskInfo = CreateFollowTask();
					((List<T>)(object)_followTasks).Add((T)followTaskInfo);
					Mdl.Characters.Character character4 = character;
					followTaskInfo.MoveToTarget(character4);
					int num3 = 0;
					System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
					asyncTask.FireAndForgetTask();
					return;
				}
			}
			MissionSlot missionSlot2 = default(MissionSlot);
			Item characterItem2 = missionSlot2.CharacterItem;
			Profile profile = Profile;
			if (profile != null)
			{
				ProfileWorld world_ = profile.world_;
				MissionSlot missionSlot3 = default(MissionSlot);
				Item characterItem3 = missionSlot3.CharacterItem;
				Meta.Character character5 = default(Meta.Character);
				if (character5 != null)
				{
					Meta.Character.Types.CharacterStatus status_ = character5.status_;
				}
			}
			Debug.LogError($"StartFollowTask: Character not loaded, id={characterItem2}, status={profile}");
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0xF72360", Offset = "0xF70D60", VA = "0x180F72360")]
			FollowTaskInfo CreateFollowTask()
			{
				//IL_0023: Expected O, but got I4
				//IL_0069: Expected O, but got I4
				//IL_010f: Expected O, but got I4
				//IL_0181: Expected O, but got I4
				//IL_01f1: Expected O, but got I4
				FollowTaskInfo followTaskInfo2 = new FollowTaskInfo();
				int iD = obj.MissionSlot.Data.ID;
				followTaskInfo2.MissionItem = (Item)iD;
				string text = (followTaskInfo2.StepName = obj.Data.stepName_);
				Item item = (followTaskInfo2.CharacterItem = character.Item);
				SceneType sceneType2 = sceneType;
				int num4 = 0;
				followTaskInfo2.SceneType = sceneType2;
				followTaskInfo2.Target = (Vector3?)(object)num4;
				float num5 = (followTaskInfo2.TargetRadius = followStep.targetRadius_);
				float num6 = (followTaskInfo2.AvatarRadius = followStep.avatarRadius_);
				bool flag2 = (followTaskInfo2.IsRunning = followStep.run_);
				CancellationTokenSource cancellationTokenSource = (followTaskInfo2.TokenSource = cts);
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneType sceneType3 = sceneType;
				SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				SceneItemData sceneItemData = sceneData.sceneItemData;
				GameObject gameObject = default(GameObject);
				PlayerTaskCollider[] componentsInChildren = gameObject.GetComponentsInChildren<PlayerTaskCollider>();
				Func<PlayerTaskCollider, bool> func2 = (Func<PlayerTaskCollider, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskCollider x)
				{
					//Discarded unreachable code: IL_002e
					IEnumerable<PlayerTaskDefinition> tasks = (IEnumerable<PlayerTaskDefinition>)x.GetTasks();
					Func<PlayerTaskDefinition, bool> func3 = func;
					if (func3 == null)
					{
						func = (Func<PlayerTaskDefinition, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskDefinition y)
						{
							PlayerTaskDefinition taskExitEnv = _taskExitEnv;
							string taskId = y._taskId;
							throw new NullReferenceException();
						};
					}
					return ((IEnumerable<>)tasks).Any<PlayerTaskDefinition>((Func<, >)(object)func3);
				};
				PlayerTaskCollider playerTaskCollider = Enumerable.FirstOrDefault<PlayerTaskCollider>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func2);
				int num7 = 0;
				if (!(playerTaskCollider != (UnityEngine.Object)num7))
				{
					Debug.LogError("StartFollowTask: No valid Exit found.. MissionManager prefab error?");
					return followTaskInfo2;
				}
				CharacterManager?.UpdateScheduleOnNextSceneEntered();
				CharacterManager characterManager2 = CharacterManager;
				if ((object)characterManager2 != null)
				{
					Mdl.Characters.Character character6 = character;
					characterManager2.NotifyOverrideCharacterSchedule(character6);
				}
				FollowTaskInfo followTaskInfo3 = new FollowTaskInfo();
				int iD2 = obj.MissionSlot.Data.ID;
				followTaskInfo3.MissionItem = (Item)iD2;
				string text2 = (followTaskInfo3.StepName = obj.Data.stepName_);
				Item item2 = (followTaskInfo3.CharacterItem = character.Item);
				int num8 = 0;
				Transform destination = playerTaskCollider.Destination;
				Transform transform = destination.transform;
				Vector3 position = destination.position;
				int num9 = 0;
				float z = position.z;
				followTaskInfo3.TargetRadius = 1f;
				followTaskInfo3.Target = (Vector3?)(object)num9;
				float num10 = (followTaskInfo3.AvatarRadius = followStep.avatarRadius_);
				bool flag3 = (followTaskInfo3.IsRunning = followStep.run_);
				followTaskInfo3.NextTask = followTaskInfo2;
				followTaskInfo3.Unspawn = true;
				CancellationTokenSource cancellationTokenSource2 = (followTaskInfo3.TokenSource = cts);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0xBD0490", Offset = "0xBCEE90", VA = "0x180BD0490")]
		private FollowTaskInfo NextFollowTask(FollowTaskInfo task)
		{
			//Discarded unreachable code: IL_004b
			List<FollowTaskInfo> followTasks = _followTasks;
			Predicate<FollowTaskInfo> predicate = (Predicate<FollowTaskInfo>)(object)(Predicate<T>)((FollowTaskInfo x) => x == task);
			int num = ((List<T>)(object)followTasks).FindIndex((Predicate<>)(object)predicate);
			if (num > -1)
			{
				FollowTaskInfo followTaskInfo = task;
				FollowTaskInfo followTaskInfo2 = default(FollowTaskInfo);
				if (followTaskInfo2 != null)
				{
					((List<T>)(object)_followTasks)[num] = (T)followTaskInfo2;
					return followTaskInfo2;
				}
			}
			string message = default(string);
			Exception ex = new Exception(message);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0xBD4510", Offset = "0xBD2F10", VA = "0x180BD4510")]
		private void StopFollowTasksForMission(MissionSlot slot, bool onlyCancelTest = false)
		{
			//Discarded unreachable code: IL_0071
			List<FollowTaskInfo> followTasks = _followTasks;
			Func<FollowTaskInfo, bool> func = (Func<FollowTaskInfo, bool>)(object)(Func<T, TResult>)delegate
			{
				Item missionItem2 = slot.MissionItem;
				throw new NullReferenceException();
			};
			IEnumerable<FollowTaskInfo> enumerable = (IEnumerable<FollowTaskInfo>)Enumerable.Where<FollowTaskInfo>((IEnumerable<>)followTasks, (Func<, >)(object)func);
			Action<FollowTaskInfo> action = (Action<FollowTaskInfo>)(object)new Action<T>(StopFollow);
			MoreLinq.ForEach<FollowTaskInfo>((IEnumerable<>)enumerable, (Action<>)(object)action);
			if (!onlyCancelTest)
			{
				List<FollowTaskInfo> followTasks2 = _followTasks;
				Predicate<FollowTaskInfo> predicate = (Predicate<FollowTaskInfo>)(object)(Predicate<T>)delegate
				{
					Item missionItem = slot.MissionItem;
					throw new NullReferenceException();
				};
				int num = ((List<T>)(object)followTasks2).RemoveAll((Predicate<>)(object)predicate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFC")]
			[Cpp2IlInjected.Address(RVA = "0xF72C90", Offset = "0xF71690", VA = "0x180F72C90")]
			void StopFollow(FollowTaskInfo info)
			{
				//Discarded unreachable code: IL_0026
				info.TokenSource.Cancel();
				if (!onlyCancelTest)
				{
					info.Character?.CancelMoveToTargetPosition();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0xBC8D90", Offset = "0xBC7790", VA = "0x180BC8D90")]
		public void CancelTestFollowCharacter(MissionSlot slot)
		{
			StopFollowTasksForMission(slot, onlyCancelTest: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0xBD4700", Offset = "0xBD3100", VA = "0x180BD4700")]
		[AsyncStateMachine(typeof(_003CTestFollowCharacter_003Ed__41))]
		private System.Threading.Tasks.Task TestFollowCharacter(MissionObjective obj, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0xBCCA30", Offset = "0xBCB430", VA = "0x180BCCA30")]
		public bool FindLocationPosition(LocationSource location, Mdl.Characters.Character character, out SceneType sceneType, out Vector3 target_position)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0xBCCA70", Offset = "0xBCB470", VA = "0x180BCCA70")]
		public bool FindLocationPosition(LocationSource location, Mdl.Characters.Character character, out SceneType sceneType, out Vector3 target_position, out Quaternion target_rotation)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xBCC440", Offset = "0xBCAE40", VA = "0x180BCC440")]
		public static bool FindCustomPosition(LocationCustom locationCustom, out SceneType sceneType, out Transform targetTransform)
		{
			//Discarded unreachable code: IL_0128, IL_012e, IL_0134, IL_013a, IL_0140
			//IL_0085: Expected O, but got I4
			//IL_0091: Expected I4, but got I8
			//IL_00c9: Expected O, but got I4
			uint num4 = default(uint);
			GameObject gameObject = default(GameObject);
			Func<MissionCustomLocation, bool> func = default(Func<MissionCustomLocation, bool>);
			Func<MissionCustomLocation, bool> func2 = default(Func<MissionCustomLocation, bool>);
			GameObject gameObject2 = default(GameObject);
			ulong num6 = default(ulong);
			Func<MissionCustomLocation, bool> func3 = default(Func<MissionCustomLocation, bool>);
			Func<MissionCustomLocation, bool> func4 = default(Func<MissionCustomLocation, bool>);
			MissionCustomLocation missionCustomLocation2 = default(MissionCustomLocation);
			Transform transform = default(Transform);
			int num3;
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				num3 = 0;
				IEnumerable<SceneData> enumerable = (IEnumerable<SceneData>)Enumerable.Reverse<SceneData>((IEnumerable<>)SystemRoot.Instance._sceneStack._sceneStack);
				if (enumerable != null)
				{
					if (num3 < (int)num4)
					{
						num3 += num3;
						if (num3 == (int)num4)
						{
							goto IL_00dc;
						}
						num3++;
					}
					MissionCustomLocation[] componentsInChildren = gameObject.GetComponentsInChildren<MissionCustomLocation>();
					if (func == null)
					{
						func2 = (func = (Func<MissionCustomLocation, bool>)(object)(Func<T, TResult>)delegate(MissionCustomLocation x)
						{
							//Discarded unreachable code: IL_001b
							string customLocation2 = x._customLocation;
							string gUID_3 = locationCustom.gUID_;
							return string.Equals(customLocation2, gUID_3);
						});
					}
					MissionCustomLocation missionCustomLocation = Enumerable.FirstOrDefault<MissionCustomLocation>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func2);
					int num5 = 0;
					if (missionCustomLocation == (UnityEngine.Object)num5)
					{
						MissionCustomLocation[] componentsInChildren2 = gameObject2.GetComponentsInChildren<MissionCustomLocation>((byte)num6 != 0);
						if (func3 == null)
						{
							func4 = (func3 = (Func<MissionCustomLocation, bool>)(object)(Func<T, TResult>)delegate(MissionCustomLocation x)
							{
								//Discarded unreachable code: IL_001b
								string customLocation = x._customLocation;
								string gUID_2 = locationCustom.gUID_;
								return string.Equals(customLocation, gUID_2);
							});
						}
						missionCustomLocation2 = Enumerable.FirstOrDefault<MissionCustomLocation>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func4);
					}
					int num7 = 0;
					if (!(missionCustomLocation2 != (UnityEngine.Object)num7))
					{
						goto IL_0000;
					}
					transform = missionCustomLocation2.transform;
					num3++;
					goto IL_00dc;
				}
				goto IL_00eb;
				IL_00eb:
				num3++;
				if (enumerable != null)
				{
				}
				continue;
				IL_00dc:
				transform = (Transform)(object)((object)transform + (object)transform);
				num3 += 312;
				goto IL_00eb;
			}
			while (num3 != 0);
			if (num3 != 0)
			{
			}
			string gUID_ = locationCustom.gUID_;
			Debug.LogError("FindLocationPosition: CustomLocationPositions for {" + gUID_ + "} not found in loaded scenes.");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0xBD3FA0", Offset = "0xBD29A0", VA = "0x180BD3FA0")]
		private void StartListenTask(MissionObjective obj)
		{
			//Discarded unreachable code: IL_009d
			//IL_007f: Expected O, but got I8
			//IL_0093: Expected O, but got I4
			List<ListenTaskInfo> listenTasks = _listenTasks;
			Predicate<ListenTaskInfo> predicate = (Predicate<ListenTaskInfo>)(object)(Predicate<T>)delegate(ListenTaskInfo x)
			{
				//Discarded unreachable code: IL_0011
				MissionObjective missionObjective = obj;
				return x.MissionObjective == missionObjective;
			};
			bool flag = default(bool);
			if (((List<T>)(object)listenTasks).Find((Predicate<>)(object)predicate) == null && flag)
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				CharacterManager characterManager = CharacterManager;
				CancellationToken token = cancellationTokenSource.Token;
				CustomStepListen customStepListen = default(CustomStepListen);
				bool run_ = customStepListen.run_;
				Task<bool> task = default(Task<bool>);
				task.FireAndForgetTask();
				List<ListenTaskInfo> listenTasks2 = _listenTasks;
				ListenTaskInfo listenTaskInfo = new ListenTaskInfo();
				listenTaskInfo.ListenTask = task;
				listenTaskInfo.MissionObjective = (MissionObjective)(object)task;
				ulong num = default(ulong);
				int price = ((BattlePassReward)num).Price;
				listenTaskInfo.TokenSource = cancellationTokenSource;
				listenTaskInfo.ListenedDialogue = (Item)price;
				((List<T>)(object)listenTasks2).Add((T)listenTaskInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0xBC8B10", Offset = "0xBC7510", VA = "0x180BC8B10")]
		private void CancelListenTask(MissionObjective obj)
		{
			//Discarded unreachable code: IL_0074
			List<ListenTaskInfo> listenTasks = _listenTasks;
			Func<ListenTaskInfo, bool> func = (Func<ListenTaskInfo, bool>)(object)(Func<T, TResult>)delegate(ListenTaskInfo x)
			{
				//Discarded unreachable code: IL_0011
				MissionObjective missionObjective2 = obj;
				return x.MissionObjective == missionObjective2;
			};
			IEnumerable<ListenTaskInfo> enumerable = (IEnumerable<ListenTaskInfo>)Enumerable.Where<ListenTaskInfo>((IEnumerable<>)listenTasks, (Func<, >)(object)func);
			Action<ListenTaskInfo> _003C_003E9__48_ = _003C_003Ec._003C_003E9__48_1;
			if (_003C_003E9__48_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ListenTaskInfo x)
				{
					//Discarded unreachable code: IL_000c
					x.TokenSource.Cancel();
				};
			}
			MoreLinq.ForEach<ListenTaskInfo>((IEnumerable<>)enumerable, (Action<>)(object)_003C_003E9__48_);
			List<ListenTaskInfo> listenTasks2 = _listenTasks;
			Predicate<ListenTaskInfo> predicate = (Predicate<ListenTaskInfo>)(object)(Predicate<T>)delegate(ListenTaskInfo x)
			{
				//Discarded unreachable code: IL_0011
				MissionObjective missionObjective = obj;
				return x.MissionObjective == missionObjective;
			};
			int num = ((List<T>)(object)listenTasks2).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0xBD37B0", Offset = "0xBD21B0", VA = "0x180BD37B0")]
		private void StartChaseTask(MissionObjective obj)
		{
			//Discarded unreachable code: IL_004c
			MissionObjective obj2 = obj;
			if ((long)obj2 != 0)
			{
				List<MissionObjective> currentChases = CurrentChases;
				Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_001b
					string fullIdentifierID = x.FullIdentifierID;
					string fullIdentifierID2 = obj2.FullIdentifierID;
					return string.Equals(fullIdentifierID, fullIdentifierID2);
				};
				if (((IEnumerable<>)currentChases).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					return;
				}
			}
			((List<T>)(object)CurrentChases).Add((T)obj);
			int num = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xBC8A20", Offset = "0xBC7420", VA = "0x180BC8A20")]
		private void CancelChaseTask(MissionObjective obj)
		{
			//Discarded unreachable code: IL_002a
			List<MissionObjective> currentChases = CurrentChases;
			Predicate<MissionObjective> predicate = (Predicate<MissionObjective>)(object)(Predicate<T>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_001b
				string fullIdentifierID = x.FullIdentifierID;
				string fullIdentifierID2 = obj.FullIdentifierID;
				return string.Equals(fullIdentifierID, fullIdentifierID2);
			};
			int num = ((List<T>)(object)currentChases).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xBCF930", Offset = "0xBCE330", VA = "0x180BCF930")]
		private bool HasChaseRunning(MissionObjective obj)
		{
			if ((long)obj == 0)
			{
				int num = 0;
			}
			List<MissionObjective> currentChases = CurrentChases;
			Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_001b
				string fullIdentifierID = x.FullIdentifierID;
				string fullIdentifierID2 = obj.FullIdentifierID;
				return string.Equals(fullIdentifierID, fullIdentifierID2);
			};
			bool flag = ((IEnumerable<>)currentChases).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0xBD3250", Offset = "0xBD1C50", VA = "0x180BD3250")]
		[AsyncStateMachine(typeof(_003CRunChase_003Ed__56))]
		private System.Threading.Tasks.Task RunChase(MissionObjective obj, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xBC8960", Offset = "0xBC7360", VA = "0x180BC8960")]
		private void AddVisitAreaTask(LocationTaskInfo task)
		{
			//Discarded unreachable code: IL_0025
			((List<T>)(object)_visitAreaTasks).Add((T)task);
			List<LocationTaskInfo> visitAreaTasks = _visitAreaTasks;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += Environment_AnyEnvironmentEnteredEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xBD2F30", Offset = "0xBD1930", VA = "0x180BD2F30")]
		private void RemoveVisitAreaTask(LocationTaskInfo task)
		{
			//Discarded unreachable code: IL_0040
			if (task != null)
			{
				task.CancellationTokenSource.Cancel();
				task.CancellationTokenSource.Dispose();
				bool flag = ((List<T>)(object)_visitAreaTasks).Remove((T)task);
				List<LocationTaskInfo> visitAreaTasks = _visitAreaTasks;
				Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xBD1BE0", Offset = "0xBD05E0", VA = "0x180BD1BE0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0127
			CharacterManager characterManager = CharacterManager;
			CharacterManager.CharacterLoaded value = OnCharacterLoaded;
			characterManager.OnCharacterLoaded += value;
			Mdl.Environments.Environment.add_AnyEnvironmentLoadingStateChangeEvent((Action<>)(object)new Action<T>(Environment_AnyEnvironmentLoadingStateChangeEvent));
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value2 = OnMissionSlotUpdated;
			_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionCurrentStepChanged value3 = OnMissionCurrentStepChanged;
			_003CDispatcher_003Ek__BackingField2.OnMissionCurrentStepChanged += value3;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionObjectiveStatusChanged value4 = OnObjectiveStatusChanged;
			_003CDispatcher_003Ek__BackingField3.OnMissionObjectiveStatusChanged += value4;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = MetaClient.Dispatcher;
			ProfileEventDispatcher.TrackedMissionChanged value5 = OnTrackedMissionChanged;
			_003CDispatcher_003Ek__BackingField4.OnTrackedMissionChanged += value5;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = MetaClient.Dispatcher;
			ProfileEventDispatcher.EventStarted value6 = OnEventStarted;
			_003CDispatcher_003Ek__BackingField5.OnEventStarted += value6;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = MetaClient.Dispatcher;
			ProfileEventDispatcher.GridChanged value7 = OnGridChanged;
			_003CDispatcher_003Ek__BackingField6.OnGridChanged += value7;
			CancellationTokenSource cancellationTokenSource = (_ctsMissionManager = new CancellationTokenSource());
			CancellationToken token = _ctsMissionManager.Token;
			int num = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xBD20F0", Offset = "0xBD0AF0", VA = "0x180BD20F0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_018d
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				CharacterManager characterManager = CharacterManager;
				CharacterManager.CharacterLoaded value = OnCharacterLoaded;
				characterManager.OnCharacterLoaded -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = MetaClient.Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value2 = OnMissionSlotUpdated;
				_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = MetaClient.Dispatcher;
				ProfileEventDispatcher.MissionCurrentStepChanged value3 = OnMissionCurrentStepChanged;
				_003CDispatcher_003Ek__BackingField2.OnMissionCurrentStepChanged -= value3;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = MetaClient.Dispatcher;
				ProfileEventDispatcher.MissionObjectiveStatusChanged value4 = OnObjectiveStatusChanged;
				_003CDispatcher_003Ek__BackingField3.OnMissionObjectiveStatusChanged -= value4;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = MetaClient.Dispatcher;
				ProfileEventDispatcher.TrackedMissionChanged value5 = OnTrackedMissionChanged;
				_003CDispatcher_003Ek__BackingField4.OnTrackedMissionChanged -= value5;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = MetaClient.Dispatcher;
				ProfileEventDispatcher.EventStarted value6 = OnEventStarted;
				_003CDispatcher_003Ek__BackingField5.OnEventStarted -= value6;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = MetaClient.Dispatcher;
				ProfileEventDispatcher.GridChanged value7 = OnGridChanged;
				_003CDispatcher_003Ek__BackingField6.OnGridChanged -= value7;
			}
			StopAllCoroutines();
			_ctsMissionManager?.Cancel();
			List<FollowTaskInfo> followTasks = _followTasks;
			Action<FollowTaskInfo> action = default(Action<FollowTaskInfo>);
			if (_003C_003Ec._003C_003E9__62_0 == null)
			{
				action = (Action<FollowTaskInfo>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(FollowTaskInfo x)
				{
					//Discarded unreachable code: IL_000c
					x.TokenSource.Cancel();
				});
			}
			((List<T>)(object)followTasks).ForEach((Action<>)(object)action);
			((List<T>)(object)_followTasks).Clear();
			((List<T>)(object)CurrentChases).Clear();
			Mdl.Environments.Environment.remove_AnyEnvironmentLoadingStateChangeEvent((Action<>)(object)new Action<T>(Environment_AnyEnvironmentLoadingStateChangeEvent));
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xBD0940", Offset = "0xBCF340", VA = "0x180BD0940")]
		private void OnEventStarted(List<Item> characters)
		{
			//Discarded unreachable code: IL_0024
			Client metaClient = SystemRoot.Instance.MetaClient;
			CancellationToken token = _ctsMissionManager.Token;
			metaClient.InitTLEAsync(token).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xBD0A60", Offset = "0xBCF460", VA = "0x180BD0A60")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_0047
			//IL_002b: Expected O, but got I4
			bool automatic2 = false;
			GridAddObjectOptions addObjectOptions2 = (GridAddObjectOptions)0;
			List<FollowTaskInfo> followTasks = _followTasks;
			Action<FollowTaskInfo> action = (Action<FollowTaskInfo>)(object)(Action<T>)delegate(FollowTaskInfo x)
			{
				//Discarded unreachable code: IL_0031
				GridAddObjectOptions addObjectOptions3 = addObjectOptions2;
				GridObject gridObject2 = gridObject;
				GridChangedOperation operation2 = operation;
				IGrid grid2 = grid;
				bool automatic3 = automatic2;
				x.OnGridChanged(grid2, operation2, gridObject2, automatic3, addObjectOptions3);
			};
			((List<T>)(object)followTasks).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xBCFED0", Offset = "0xBCE8D0", VA = "0x180BCFED0")]
		[AsyncStateMachine(typeof(_003CInitMissionsAsync_003Ed__67))]
		private System.Threading.Tasks.Task InitMissionsAsync(CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xBCFDB0", Offset = "0xBCE7B0", VA = "0x180BCFDB0")]
		[AsyncStateMachine(typeof(_003CInitMissionSlots_003Ed__68))]
		private System.Threading.Tasks.Task InitMissionSlots(MissionSlotClass slotClass, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xBD01F0", Offset = "0xBCEBF0", VA = "0x180BD01F0")]
		[AsyncStateMachine(typeof(_003CInitVillageMissionsAsync_003Ed__69))]
		private System.Threading.Tasks.Task InitVillageMissionsAsync(CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xBCFC90", Offset = "0xBCE690", VA = "0x180BCFC90")]
		[AsyncStateMachine(typeof(_003CInitMainStoryAsync_003Ed__70))]
		public System.Threading.Tasks.Task InitMainStoryAsync(CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xBD00D0", Offset = "0xBCEAD0", VA = "0x180BD00D0")]
		[AsyncStateMachine(typeof(_003CInitTleMissionsAsync_003Ed__71))]
		private System.Threading.Tasks.Task InitTleMissionsAsync(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xBD0650", Offset = "0xBCF050", VA = "0x180BD0650")]
		private unsafe void OnCharacterLoaded(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_006e
			//IL_005b: Expected O, but got I4
			Item _003CItem_003Ek__BackingField = character.Item;
			int slotClass = 0;
			CheckForCompletedStates((MissionSlotClass)slotClass, _003CItem_003Ek__BackingField).FireAndForgetTask();
			Item _003CItem_003Ek__BackingField2 = character.Item;
			CheckForCompletedStates(MissionSlotClass.Village, _003CItem_003Ek__BackingField2).FireAndForgetTask();
			Item _003CItem_003Ek__BackingField3 = character.Item;
			bool flag = *(Item*)GetCurrentFollowerItem() == *(Item*)_003CItem_003Ek__BackingField3;
			int num = 0;
			if (flag)
			{
				PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
			}
			character.CharacterToFollow = (GameObject)num;
			Item _003CItem_003Ek__BackingField4 = character.Item;
			int num2 = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xBD0D30", Offset = "0xBCF730", VA = "0x180BD0D30")]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [System.Runtime.InteropServices.Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0028
			ProfileWorld world_ = Profile.world_;
			int num = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
			RefreshCurrentFollower();
			int onlyCancelTest = 0;
			MissionSlot slot = default(MissionSlot);
			StopFollowTasksForMission(slot, (byte)onlyCancelTest != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xBD0BA0", Offset = "0xBCF5A0", VA = "0x180BD0BA0")]
		public void OnItemInteraction(Item item)
		{
			//Discarded unreachable code: IL_0069
			//IL_0014: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			if (ActiveInteractionObjectiveCount <= 0)
			{
				return;
			}
			ProfileWorld world_ = Profile.world_;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_002a
				//IL_0029: Expected O, but got I4
				//IL_0029: Expected O, but got I4
				if (x.Data.Interaction == null)
				{
				}
				ItemFilter itemFilter_ = x.itemFilter_;
				Item item4 = item2;
				int num2 = 0;
				int num3 = 0;
				return itemFilter_.ApplyFilter(item4, (ItemState)num3, (IProfile)num2);
			};
			if (Enumerable.Any<MissionObjective>(world_.GetOnGoingMissionObjectives((Func<, >)(object)func)))
			{
				Client metaClient = MetaClient;
				Item item3 = item2;
				int num = 0;
				metaClient.MissionItemInteractionAsync(item3, (CancellationToken)num).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xBCE5B0", Offset = "0xBCCFB0", VA = "0x180BCE5B0")]
		public Item GetCurrentFollowerItem()
		{
			if ((object)Profile.TrackedMissionItem == null && !SystemRoot.Instance.GetSystem<CurseSystem>().isActive)
			{
				ProfileWorld world_ = Profile.world_;
				Item trackedMissionItem = Profile.TrackedMissionItem;
				if (_003C_003Ec._003C_003E9__75_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.MissionSubStep.Data.isOwnerFollowing_);
				}
				IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)enumerable);
				if (missionObjective != null)
				{
					Item characterItem = missionObjective.MissionSubStep.GetFollower();
					ProfileWorld world_2 = Profile.world_;
					Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
					{
						//Discarded unreachable code: IL_000f
						Item characterItem2 = characterItem;
						return obj.IsCharacterToListen(characterItem2);
					};
					if (!Enumerable.Any<MissionObjective>(world_2.GetOnGoingMissionObjectives((Func<, >)(object)func)))
					{
						return characterItem;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xBCE980", Offset = "0xBCD380", VA = "0x180BCE980")]
		private Mdl.Characters.Character GetCurrentFollower(bool allowSpawn = false)
		{
			Item currentFollowerItem = GetCurrentFollowerItem();
			if ((object)currentFollowerItem == null)
			{
				CharacterManager.CharacterInstance characterInstance = CharacterManager.GetCharacterInstance(currentFollowerItem);
				if (allowSpawn && (characterInstance == null || !characterInstance.Active))
				{
					CharacterManager.ForceCharacterToFollowAvatar(currentFollowerItem).FireAndForgetTask();
				}
				if (characterInstance != null)
				{
					return characterInstance.Character;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xBD29C0", Offset = "0xBD13C0", VA = "0x180BD29C0")]
		private void RefreshCurrentFollower()
		{
			//Discarded unreachable code: IL_00e5, IL_00eb, IL_00f1
			//IL_004c: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0092: Expected I4, but got I8
			int num = 0;
			Item currentFollowerItem = GetCurrentFollowerItem();
			if ((object)currentFollowerItem == null)
			{
				CharacterManager.CharacterInstance characterInstance = CharacterManager.GetCharacterInstance(currentFollowerItem);
				if (characterInstance == null || !characterInstance.Active)
				{
					CharacterManager.ForceCharacterToFollowAvatar(currentFollowerItem).FireAndForgetTask();
				}
				if (characterInstance == null)
				{
				}
			}
			Mdl.Characters.Character followerCharacter = (Mdl.Characters.Character)num;
			Mdl.Characters.Character character = followerCharacter;
			int num2 = 0;
			if (character != (UnityEngine.Object)num2)
			{
				Mdl.Characters.Character character2 = followerCharacter;
				GameObject gameObject = (character2.CharacterToFollow = SystemRoot.Instance._avatar.gameObject);
			}
			ulong num3 = default(ulong);
			IEnumerable<Mdl.Characters.Character> activeCharacters = (IEnumerable<Mdl.Characters.Character>)CharacterManager.GetActiveCharacters((byte)num3 != 0);
			Func<Mdl.Characters.Character, bool> func = default(Func<Mdl.Characters.Character, bool>);
			Func<Mdl.Characters.Character, bool> func2 = default(Func<Mdl.Characters.Character, bool>);
			if (func == null)
			{
				func2 = (func = (Func<Mdl.Characters.Character, bool>)(object)(Func<T, TResult>)delegate(Mdl.Characters.Character x)
				{
					Mdl.Characters.Character character3 = followerCharacter;
					return x != character3;
				});
			}
			IEnumerable<Mdl.Characters.Character> enumerable = (IEnumerable<Mdl.Characters.Character>)Enumerable.Where<Mdl.Characters.Character>((IEnumerable<>)activeCharacters, (Func<, >)(object)func2);
			int num5 = default(int);
			if (enumerable != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_00d8;
					}
					num++;
				}
				num5 = 0;
				goto IL_00d8;
			}
			goto IL_00df;
			IL_00df:
			if (enumerable == null)
			{
			}
			return;
			IL_00d8:
			num5 += num5;
			goto IL_00df;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xBD0310", Offset = "0xBCED10", VA = "0x180BD0310")]
		private bool IsCurrentFollower(Item characterItem)
		{
			Item currentFollowerItem = GetCurrentFollowerItem();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xBD0D20", Offset = "0xBCF720", VA = "0x180BD0D20")]
		private void OnMissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex)
		{
			RefreshCurrentFollower();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xBD0F00", Offset = "0xBCF900", VA = "0x180BD0F00")]
		private unsafe void OnObjectiveStatusChanged(MissionObjective obj, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_036d
			//IL_004b: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			//IL_02e4: Expected O, but got I4
			//IL_02ed: Expected O, but got I4
			//IL_0357: Expected O, but got I4
			int num = 0;
			if (previousStatus == newStatus || previousStatus == MissionStepStatus.Ongoing || newStatus == MissionStepStatus.Ongoing)
			{
			}
			bool flag = default(bool);
			if (flag && previousStatus < MissionStepStatus.Completed)
			{
				CharacterManager characterManager = CharacterManager;
				List<FollowTaskInfo> followTasks = _followTasks;
				int num2 = 0;
				Mdl.Characters.Character character = default(Mdl.Characters.Character);
				if (character != (UnityEngine.Object)num2)
				{
					GameObject characterToFollow = character.characterToFollow;
					int num3 = 0;
					if (characterToFollow != (UnityEngine.Object)num3)
					{
						Item _003CItem_003Ek__BackingField = character.Item;
						if (!IsCurrentFollower(_003CItem_003Ek__BackingField))
						{
							int num4 = 0;
							character.CharacterToFollow = (GameObject)num4;
						}
					}
				}
			}
			MissionSlot missionSlot = default(MissionSlot);
			Item characterItem = missionSlot.CharacterItem;
			Item item = default(Item);
			System.Threading.Tasks.Task task = default(System.Threading.Tasks.Task);
			if (*(Item*)item != *(Item*)characterItem)
			{
				ProfileWorld world_ = Profile.world_;
				Meta.Character character2 = default(Meta.Character);
				if (character2 != null)
				{
					Profile profile = Profile;
					if (character2.IsInactiveAndTargetedByMission(profile))
					{
						CharacterManager characterManager2 = CharacterManager;
						task.FireAndForgetTask();
					}
				}
			}
			System.Threading.Tasks.Task task4 = default(System.Threading.Tasks.Task);
			if (newStatus == MissionStepStatus.Ongoing)
			{
				CharacterManager characterManager3 = default(CharacterManager);
				if ((long)task.m_continuationObject == 270)
				{
					int num5 = 0;
					MissionSlot missionSlot2 = default(MissionSlot);
					if (missionSlot2.TalkToCharacterNeedToSpawnOutside((MissionObjective)num5, out *(Item*)num))
					{
						characterManager3 = CharacterManager;
						int isCheat = 0;
						int createInstance = 0;
						System.Threading.Tasks.Task task2 = characterManager3.ForceCharacterOutsideNow((Item)num, (byte)createInstance != 0, (byte)isCheat != 0);
					}
				}
				float maximumMinutesBetweenBarks = characterManager3.MaximumMinutesBetweenBarks;
				if (maximumMinutesBetweenBarks != 3.01E-43f)
				{
					if (maximumMinutesBetweenBarks != 3.92E-43f)
					{
						goto IL_0155;
					}
					bool flag2 = default(bool);
					if (!flag2)
					{
						System.Threading.Tasks.Task task3 = InviteToVillage();
					}
					CharacterManager.UpdateScheduleOnNextSceneEntered();
				}
				task4 = InitPartyWithDelay();
				task4.FireAndForgetTask();
			}
			goto IL_0155;
			IL_022e:
			CustomStepUnlockCharacter customStepUnlockCharacter = default(CustomStepUnlockCharacter);
			System.Threading.Tasks.Task task5 = default(System.Threading.Tasks.Task);
			if (customStepUnlockCharacter.skipCinematic_ && newStatus == MissionStepStatus.Confirmed)
			{
				MissionSlot missionSlot3 = default(MissionSlot);
				MissionItemData data = missionSlot3.Data;
				CustomStepUnlockCharacter customStepUnlockCharacter2 = default(CustomStepUnlockCharacter);
				Item targetCharacter = customStepUnlockCharacter2.GetTargetCharacter(data);
				CharacterManager characterManager4 = CharacterManager;
				task5.FireAndForgetTask();
			}
			object continuationObject = task5.m_continuationObject;
			List<MissionObjective> currentChases = default(List<MissionObjective>);
			if ((long)continuationObject != 200)
			{
				if ((long)continuationObject != 108)
				{
					goto IL_035f;
				}
				if (newStatus != MissionStepStatus.Ongoing)
				{
					MissionObjective obj2 = (MissionObjective)(object)task5;
					currentChases = CurrentChases;
					Predicate<MissionObjective> predicate = (Predicate<MissionObjective>)(object)(Predicate<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_001b
						string fullIdentifierID = x.FullIdentifierID;
						string fullIdentifierID2 = obj2.FullIdentifierID;
						return string.Equals(fullIdentifierID, fullIdentifierID2);
					};
					int num6 = ((List<T>)(object)currentChases).RemoveAll((Predicate<>)(object)predicate);
					goto IL_02ba;
				}
			}
			goto IL_0357;
			IL_022b:
			int num7 = 0;
			goto IL_022e;
			IL_01e6:
			LocationTaskInfo locationTaskInfo;
			if (locationTaskInfo != null)
			{
				locationTaskInfo.CancellationTokenSource.Cancel();
				locationTaskInfo.CancellationTokenSource.Dispose();
				bool flag3 = ((List<T>)(object)_visitAreaTasks).Remove((T)locationTaskInfo);
				List<LocationTaskInfo> visitAreaTasks = _visitAreaTasks;
				Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			}
			goto IL_022b;
			IL_0357:
			switch (newStatus)
			{
			}
			goto IL_035f;
			IL_02ba:
			while (currentChases != null)
			{
			}
			LocationTaskInfo locationTaskInfo2 = new LocationTaskInfo();
			string stepName = locationTaskInfo2.StepName;
			MissionSlot missionSlot4 = default(MissionSlot);
			MissionItemData data2 = missionSlot4.Data;
			int num8 = 0;
			int num9 = default(int);
			locationTaskInfo2.MissionItem = (Item)num9;
			locationTaskInfo2.StepName = (string)num8;
			CancellationTokenSource cancellationTokenSource = (locationTaskInfo2.CancellationTokenSource = new CancellationTokenSource());
			((List<T>)(object)_visitAreaTasks).Add((T)locationTaskInfo2);
			List<LocationTaskInfo> visitAreaTasks2 = _visitAreaTasks;
			EventHandler eventHandler = Environment_AnyEnvironmentEnteredEvent;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += eventHandler;
			int num10 = 0;
			MethodInfo original_method_info = ((Delegate)eventHandler).original_method_info;
			CancellationTokenSource cancellationTokenSource2 = locationTaskInfo2.CancellationTokenSource;
			int num11 = 0;
			CancellationToken token = cancellationTokenSource2.Token;
			int num12 = 0;
			TestVisitArea((SceneData)num11, locationTaskInfo2, token);
			goto IL_0357;
			IL_035f:
			int num13 = 0;
			int num14 = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
			return;
			IL_0155:
			CustomStepVisitArea customStepVisitArea = default(CustomStepVisitArea);
			if ((long)task4.m_continuationObject != 290 || customStepVisitArea.IsPerformedServerSide)
			{
				goto IL_022e;
			}
			int iD = obj.MissionSlot.Data.ID;
			Item missionItem = (Item)iD;
			List<LocationTaskInfo> visitAreaTasks3 = _visitAreaTasks;
			Func<LocationTaskInfo, bool> func = (Func<LocationTaskInfo, bool>)(object)(Func<T, TResult>)delegate(LocationTaskInfo x)
			{
				//Discarded unreachable code: IL_0031
				//IL_000e: Expected I4, but got O
				if ((object)typeof(Item).TypeHandle == null)
				{
					return (byte)(int)typeof(Item).TypeHandle != 0;
				}
				string stepName_ = obj.Data.stepName_;
				return string.Equals(x.StepName, stepName_);
			};
			locationTaskInfo = Enumerable.FirstOrDefault<LocationTaskInfo>((IEnumerable<>)visitAreaTasks3, (Func<, >)(object)func);
			if (newStatus == MissionStepStatus.NotStarted)
			{
				goto IL_01e6;
			}
			if (newStatus != 0)
			{
				if (newStatus != 0)
				{
					if (newStatus == MissionStepStatus.NotStarted)
					{
						goto IL_02ba;
					}
					if (newStatus == MissionStepStatus.Ongoing)
					{
						goto IL_01e6;
					}
				}
				goto IL_022b;
			}
			goto IL_02ba;
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0xF74B60", Offset = "0xF73560", VA = "0x180F74B60")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass81_0._003C_003COnObjectiveStatusChanged_003Eg__InitPartyWithDelay_007C1_003Ed))]
			System.Threading.Tasks.Task InitPartyWithDelay()
			{
				int num15 = 0;
				int num16 = 0;
				int num17 = 0;
				System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
				return result;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xF74C60", Offset = "0xF73660", VA = "0x180F74C60")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass81_0._003C_003COnObjectiveStatusChanged_003Eg__InviteToVillage_007C2_003Ed))]
			System.Threading.Tasks.Task InviteToVillage()
			{
				int num18 = 0;
				System.Threading.Tasks.Task result2 = default(System.Threading.Tasks.Task);
				return result2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xBD36A0", Offset = "0xBD20A0", VA = "0x180BD36A0")]
		[AsyncStateMachine(typeof(_003CSetupFollowCharacter_003Ed__82))]
		private System.Threading.Tasks.Task SetupFollowCharacter(Item characterItem)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xBD3560", Offset = "0xBD1F60", VA = "0x180BD3560")]
		[AsyncStateMachine(typeof(_003CSetupFollowCharacterForMission_003Ed__83))]
		private System.Threading.Tasks.Task SetupFollowCharacterForMission(MissionSlot missionSlot, bool needRefresh = false)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xBD0D20", Offset = "0xBCF720", VA = "0x180BD0D20")]
		private void OnTrackedMissionChanged(Item missionItem)
		{
			RefreshCurrentFollower();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5940", Offset = "0xBD4340", VA = "0x180BD5940")]
		private bool UpdateLocationSubTaskInfo(LocationTaskInfo taskInfo, MissionObjective obj, SceneData newScene)
		{
			//IL_0079: Expected F4, but got I4
			//IL_0080: Expected O, but got I4
			int num = 0;
			CustomStepVisitArea visitArea = obj.Data.VisitArea;
			int num2 = 0;
			int num3 = 0;
			CustomStepVisitArea.LocationTypeOneofCase locationTypeCase_ = visitArea.locationTypeCase_;
			if (locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.VillageArea)
			{
				int num4 = 0;
			}
			if (locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.SpecificLocation)
			{
				CharacterManager characterManager = CharacterManager;
				Item characterItem = obj.MissionSlot.CharacterItem;
				LocationSourceWithRadius specificLocation = visitArea.SpecificLocation;
				int num5 = 0;
				bool flag = default(bool);
				if (flag)
				{
					LocationSourceWithRadius specificLocation2 = visitArea.SpecificLocation;
				}
				Debug.LogError("FindLocationPosition failed");
			}
			if ((long)"FindLocationPosition failed" == 6)
			{
				CharacterWithRadius character = visitArea.Character;
			}
			taskInfo.Distance = num3;
			taskInfo.Target = (Vector3?)(object)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xBCC430", Offset = "0xBCAE30", VA = "0x180BCC430")]
		private void Environment_AnyEnvironmentLoadingStateChangeEvent(bool isLoading)
		{
			IsLoadingAnyEnvironment = isLoading;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xBCC1E0", Offset = "0xBCABE0", VA = "0x180BCC1E0")]
		private void Environment_AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_002c, IL_0032, IL_0038, IL_003e, IL_0044, IL_004a
			int num = 0;
			List<LocationTaskInfo> visitAreaTasks = _visitAreaTasks;
			bool flag = default(bool);
			if (flag)
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xBD4840", Offset = "0xBD3240", VA = "0x180BD4840")]
		private void TestVisitArea(SceneData newScene, LocationTaskInfo visitAreaTaskInfo, CancellationToken cancellationToken)
		{
			//IL_0036: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			Item item = default(Item);
			int num2;
			bool flag = default(bool);
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			while (true)
			{
				Profile profile = Profile;
				LocationTaskInfo locationTaskInfo = visitAreaTaskInfo;
				ProfileWorld world_ = profile.world_;
				int num = 0;
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)world_.GetMissionSlot(item, (Func<, >)num).get_AllStepsObjectives();
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_0020
					MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
					string stepName2 = visitAreaTaskInfo.StepName;
					return string.Equals(_003CData_003Ek__BackingField.stepName_, stepName2);
				};
				MissionObjective visitObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
				CustomStepVisitArea visitAreaStep = visitObjective.Data.VisitArea;
				num2 = 0;
				AsyncOperation operation = newScene.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = newScene.EditCameraConfig;
				if (flag)
				{
					CustomStepVisitArea.LocationTypeOneofCase locationTypeCase_ = visitAreaStep.locationTypeCase_;
					if (locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.VillageArea)
					{
						AsyncOperation operation2 = sceneData.sceneInstance.m_Operation;
						CameraNavigationConfig editCameraConfig2 = sceneData.EditCameraConfig;
						Mdl.Environments.Environment currentEnvironment = gameObject.GetComponent<Mdl.Environments.Environment>();
						System.Threading.Tasks.Task task = TestGridFloorType(cancellationToken);
					}
					if (locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.SpecificLocation)
					{
						LocationTaskInfo locationTaskInfo2 = visitAreaTaskInfo;
						System.Threading.Tasks.Task task2 = TestLocation(cancellationToken);
					}
					if (locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.Character)
					{
						CharacterManager characterManager = CharacterManager;
						int character_ = visitAreaStep.Character.character_;
						Mdl.Characters.Character characterTarget = character;
						TestNextToCharacter(cancellationToken).FireAndForgetTask();
					}
					return;
				}
				if (visitObjective.status_ == MissionStepStatus.Completed)
				{
					break;
				}
				continue;
				int num9;
				int num10;
				int num11;
				System.Threading.Tasks.Task result3 = default(System.Threading.Tasks.Task);
				[Cpp2IlInjected.Token(Token = "0x6000B52")]
				[Cpp2IlInjected.Address(RVA = "0xF75050", Offset = "0xF73A50", VA = "0x180F75050")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_1._003C_003CTestVisitArea_003Eg__TestGridFloorType_007C1_003Ed))]
				System.Threading.Tasks.Task TestGridFloorType(CancellationToken ct)
				{
					num9 = 0;
					num10 = 0;
					num11 = 0;
					return result3;
				}
				int num6;
				int num7;
				int num8;
				System.Threading.Tasks.Task result2 = default(System.Threading.Tasks.Task);
				[Cpp2IlInjected.Token(Token = "0x6000B4E")]
				[Cpp2IlInjected.Address(RVA = "0xF74F20", Offset = "0xF73920", VA = "0x180F74F20")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_0._003C_003CTestVisitArea_003Eg__TestLocation_007C2_003Ed))]
				System.Threading.Tasks.Task TestLocation(CancellationToken ct)
				{
					num6 = 0;
					num7 = 0;
					num8 = 0;
					return result2;
				}
				int num3;
				int num4;
				int num5;
				System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
				[Cpp2IlInjected.Token(Token = "0x6000B54")]
				[Cpp2IlInjected.Address(RVA = "0xF75180", Offset = "0xF73B80", VA = "0x180F75180")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_1._003C_003CTestVisitArea_003Eg__TestNextToCharacter_007C3_003Ed))]
				System.Threading.Tasks.Task TestNextToCharacter(CancellationToken ct)
				{
					num3 = 0;
					num4 = 0;
					num5 = 0;
					return result;
				}
				[Cpp2IlInjected.Token(Token = "0x6000B52")]
				[Cpp2IlInjected.Address(RVA = "0xF75050", Offset = "0xF73A50", VA = "0x180F75050")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_1._003C_003CTestVisitArea_003Eg__TestGridFloorType_007C1_003Ed))]
				System.Threading.Tasks.Task TestGridFloorType(CancellationToken ct)
				{
					num9 = 0;
					num10 = 0;
					num11 = 0;
					return result3;
				}
				[Cpp2IlInjected.Token(Token = "0x6000B4E")]
				[Cpp2IlInjected.Address(RVA = "0xF74F20", Offset = "0xF73920", VA = "0x180F74F20")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_0._003C_003CTestVisitArea_003Eg__TestLocation_007C2_003Ed))]
				System.Threading.Tasks.Task TestLocation(CancellationToken ct)
				{
					num6 = 0;
					num7 = 0;
					num8 = 0;
					return result2;
				}
				[Cpp2IlInjected.Token(Token = "0x6000B54")]
				[Cpp2IlInjected.Address(RVA = "0xF75180", Offset = "0xF73B80", VA = "0x180F75180")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass88_1._003C_003CTestVisitArea_003Eg__TestNextToCharacter_007C3_003Ed))]
				System.Threading.Tasks.Task TestNextToCharacter(CancellationToken ct)
				{
					num3 = 0;
					num4 = 0;
					num5 = 0;
					return result;
				}
			}
			LocationTaskInfo locationTaskInfo3 = visitAreaTaskInfo;
			string stepName = locationTaskInfo3.StepName;
			Item missionItem = locationTaskInfo3.MissionItem;
			Client client = default(Client);
			Task<MissionCompleteStep.Types.Response> task3 = (Task<MissionCompleteStep.Types.Response>)(object)client.MissionCompleteStepAsync(missionItem, stepName, MissionCompleteStep.Types.Condition.VisitExitLocation, (CancellationToken)num2, (InventoryFullResolution)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0xBCE380", Offset = "0xBCCD80", VA = "0x180BCE380")]
		public IEnumerable<MissionSlot> GetCharacterMissionSlots(Item characterItem)
		{
			//Discarded unreachable code: IL_003c
			//IL_001b: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = Profile.world_;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot slot)
			{
				if ((object)slot.CharacterItem == null)
				{
				}
				if (Profile.settings_.isDev_)
				{
					return true;
				}
				throw new NullReferenceException();
			};
			return (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0xBCE470", Offset = "0xBCCE70", VA = "0x180BCE470")]
		public IEnumerable<MissionSlot> GetCharacterStartedMissionSlots(Item characterItem)
		{
			Func<MissionSlot, bool> _003C_003E9__90_ = _003C_003Ec._003C_003E9__90_0;
			if (_003C_003E9__90_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot slot) => slot.IsMissionStarted);
			}
			IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
			return (IEnumerable<MissionSlot>)Enumerable.Where<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__90_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0xBCE290", Offset = "0xBCCC90", VA = "0x180BCE290")]
		public MissionSlot GetCharacterMissionSlot(Item characterItem, Item missionItem)
		{
			//Discarded unreachable code: IL_0029
			//IL_0014: Expected O, but got I4
			int itemID = missionItem.ItemID;
			Item missionItem2 = (Item)itemID;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
			{
				Item missionItem3 = x.MissionItem;
				throw new NullReferenceException();
			};
			IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
			return Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0xBD0380", Offset = "0xBCED80", VA = "0x180BD0380")]
		public bool IsMissionOngoing(Item characterItem, Item missionItem)
		{
			//IL_0014: Expected O, but got I4
			int itemID = missionItem.ItemID;
			Item missionItem2 = (Item)itemID;
			IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
			if (enumerable != null)
			{
				Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					Item missionItem3 = x.MissionItem;
					throw new NullReferenceException();
				};
				return Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func).state_ == MissionSlotState.OnGoing;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0xBCF2C0", Offset = "0xBCDCC0", VA = "0x180BCF2C0")]
		public IEnumerable<MissionObjective> GetObjectivesWithTargetCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0035
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = Profile.world_;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				Item targetCharacterItem = x.TargetCharacterItem;
				throw new NullReferenceException();
			};
			return (IEnumerable<MissionObjective>)world_.GetOnGoingMissionObjectives((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0xBCF0C0", Offset = "0xBCDAC0", VA = "0x180BCF0C0")]
		public IEnumerable<MissionObjective> GetObjectivesWithTargetCharacterDlg(Item characterItem)
		{
			//Discarded unreachable code: IL_0061
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = Profile.world_;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				Item targetCharacterItem = x.TargetCharacterItem;
				throw new NullReferenceException();
			};
			IEnumerable<MissionObjective> onGoingMissionObjectives = (IEnumerable<MissionObjective>)world_.GetOnGoingMissionObjectives((Func<, >)(object)func);
			Func<MissionObjective, bool> _003C_003E9__94_ = _003C_003Ec._003C_003E9__94_0;
			if (_003C_003E9__94_ == null)
			{
				bool result = default(bool);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => result);
			}
			return (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)onGoingMissionObjectives, (Func<, >)(object)_003C_003E9__94_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0xBCF5E0", Offset = "0xBCDFE0", VA = "0x180BCF5E0")]
		public IEnumerable<MissionSlot> GetSlotsWithTargetCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0035
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = Profile.world_;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot slot)
			{
				//Discarded unreachable code: IL_000f
				Item targetCharacterItem = characterItem2;
				return slot.IsTargetingCharacter(targetCharacterItem);
			};
			return (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xBCF3A0", Offset = "0xBCDDA0", VA = "0x180BCF3A0")]
		public IEnumerable<MissionSlot> GetOnGoingSlotsWithTargetCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0035
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = Profile.world_;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot slot)
			{
				//Discarded unreachable code: IL_001a
				if (slot.state_ != MissionSlotState.OnGoing)
				{
					int num = 0;
				}
				Item targetCharacterItem = characterItem2;
				return slot.IsTargetingCharacter(targetCharacterItem);
			};
			return (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0xBCF500", Offset = "0xBCDF00", VA = "0x180BCF500")]
		public IEnumerable<MissionSlot> GetSlotsWithTargetCharacterReadyToGiveItems(Item characterItem)
		{
			//Discarded unreachable code: IL_0029
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_000f
				Item targetCharacterItem = characterItem2;
				return x.IsCurrentStepReadyToGiveItems(targetCharacterItem);
			};
			IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
			return (IEnumerable<MissionSlot>)Enumerable.Where<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0xBCF6C0", Offset = "0xBCE0C0", VA = "0x180BCF6C0")]
		public bool HasActiveFollowObjective(Item characterItem)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0xBCF6E0", Offset = "0xBCE0E0", VA = "0x180BCF6E0")]
		public bool HasActiveFollowObjective(Item characterItem, out MissionObjective obj)
		{
			//Discarded unreachable code: IL_0063, IL_0069
			//IL_0022: Expected O, but got I4
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			ProfileWorld world_ = Profile.world_;
			int num3 = 0;
			IEnumerable<MissionSlot> allMissionSlot = (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)num3);
			if (allMissionSlot != null)
			{
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					if (num2 == (int)num4)
					{
						goto IL_0044;
					}
					num2++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				num2++;
				goto IL_0044;
			}
			goto IL_0050;
			IL_0044:
			itemID += itemID;
			num2 += 312;
			goto IL_0050;
			IL_0050:
			num2++;
			if (allMissionSlot != null)
			{
			}
			if (num2 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0xBCECA0", Offset = "0xBCD6A0", VA = "0x180BCECA0")]
		public MissionSubStep GetLostBringItemForTargetCharacter(Item characterItem)
		{
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			_003C_003Ec__DisplayClass100_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass100_0();
			CS_0024_003C_003E8__locals0.characterItem = (Item)itemID;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				Item characterItem2 = CS_0024_003C_003E8__locals0.characterItem;
				IEnumerable<MissionSlot> onGoingSlotsWithTargetCharacter = (IEnumerable<MissionSlot>)this.GetOnGoingSlotsWithTargetCharacter(characterItem2);
				Func<MissionSlot, IEnumerable<MissionSubStep>> _003C_003E9__100_ = _003C_003Ec._003C_003E9__100_0;
				if (_003C_003E9__100_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot slot)
					{
						RepeatedField<MissionSubStep> subSteps_ = slot.CurrentStep.subSteps_;
						throw new NullReferenceException();
					};
				}
				IEnumerable<MissionSlot> enumerable = (IEnumerable<MissionSlot>)Enumerable.SelectMany<MissionSlot, MissionSubStep>((IEnumerable<>)onGoingSlotsWithTargetCharacter, (Func<, >)(object)_003C_003E9__100_);
				Func<MissionSubStep, bool> func = (Func<MissionSubStep, bool>)(object)(Func<T, TResult>)delegate(MissionSubStep substep)
				{
					int num2 = default(int);
					if (substep != null)
					{
						MissionSubStepData _003CData_003Ek__BackingField = substep.Data;
						if (_003CData_003Ek__BackingField != null)
						{
							MissionSubStepData.Types.ExtraBringItem bringItem = _003CData_003Ek__BackingField.BringItem;
							int num = 0;
							if (bringItem == null)
							{
								goto IL_0026;
							}
							BringDialogueTypeOptions bringDialogueType_ = bringItem.bringDialogueType_;
						}
						num2 = 0;
						goto IL_0026;
					}
					goto IL_0066;
					IL_0066:
					int num3 = 0;
					throw new NullReferenceException();
					IL_0026:
					if (((num2 == 2) ? 1 : 0) != num2 && substep.Status == MissionStepStatus.ReadyToBeCompleted)
					{
						MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)substep.objectives_);
						if (missionObjective != null && missionObjective.AnyItemCollected())
						{
							Item targetCharacterItem = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)substep.objectives_).TargetCharacterItem;
						}
					}
					goto IL_0066;
				};
				return Enumerable.FirstOrDefault<MissionSubStep>(Enumerable.Where<MissionSubStep>((IEnumerable<>)enumerable, (Func<, >)(object)func));
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0xBCF040", Offset = "0xBCDA40", VA = "0x180BCF040")]
		[IteratorStateMachine(typeof(_003CGetMissionDialogChoices_003Ed__101))]
		public IEnumerable<(MissionSlot, MissionSlotState, string)> GetMissionDialogChoices(Item characterItem)
		{
			//IL_001d: Expected O, but got I4
			int itemID = characterItem.ItemID;
			_003CGetMissionDialogChoices_003Ed__101 _003CGetMissionDialogChoices_003Ed__ = new _003CGetMissionDialogChoices_003Ed__101(-2);
			_003CGetMissionDialogChoices_003Ed__._003C_003E4__this = this;
			_003CGetMissionDialogChoices_003Ed__._003C_003E3__characterItem = (Item)itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xBD42A0", Offset = "0xBD2CA0", VA = "0x180BD42A0")]
		[AsyncStateMachine(typeof(_003CStartMissionIntroDialog_003Ed__102))]
		public System.Threading.Tasks.Task StartMissionIntroDialog(MissionSlot missionSlot)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xBD43D0", Offset = "0xBD2DD0", VA = "0x180BD43D0")]
		[AsyncStateMachine(typeof(_003CStartMissionOutroDialog_003Ed__103))]
		public System.Threading.Tasks.Task StartMissionOutroDialog(MissionSlot missionSlot, bool allowPreferred = true, bool awaitDialogue = false)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xBCFC10", Offset = "0xBCE610", VA = "0x180BCFC10")]
		public Task<(DialogueTree, Blackboard)> InitIntroDialog(MissionSlot slot, Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_000d
			if (slot != null)
			{
				MissionItemData data = slot.Data;
			}
			Task<(DialogueTree, Blackboard)> result = default(Task<(DialogueTree, Blackboard)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xBCFFF0", Offset = "0xBCE9F0", VA = "0x180BCFFF0")]
		public Task<(DialogueTree, Blackboard)> InitOngoingDialog(MissionSlot slot, Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_000d
			if (slot != null)
			{
				string ongoingDialog = slot.OngoingDialog;
			}
			Task<(DialogueTree, Blackboard)> result = default(Task<(DialogueTree, Blackboard)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0xBD0060", Offset = "0xBCEA60", VA = "0x180BD0060")]
		public Task<(DialogueTree, Blackboard)> InitOutroDialog(MissionSlot slot, Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_000d
			if (slot != null)
			{
				string outroDialogue = slot.OutroDialogue;
			}
			Task<(DialogueTree, Blackboard)> result = default(Task<(DialogueTree, Blackboard)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xBCFA30", Offset = "0xBCE430", VA = "0x180BCFA30")]
		[AsyncStateMachine(typeof(_003CInitDialog_003Ed__107))]
		public Task<(DialogueTree, Blackboard)> InitDialog(MissionSlot slot, Mdl.Characters.Character character, string dialogAddress, [System.Runtime.InteropServices.Optional] IResolver resolver)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(DialogueTree, Blackboard)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0xBD5BA0", Offset = "0xBD45A0", VA = "0x180BD5BA0")]
		private void Update()
		{
			bool flag = Enumerable.Any<ListenTaskInfo>((IEnumerable<>)_listenTasks);
			int num = 0;
			if (flag)
			{
				int num2 = 0;
				int num3 = 0;
				System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0xBC9160", Offset = "0xBC7B60", VA = "0x180BC9160")]
		[AsyncStateMachine(typeof(_003CCheckListenTasks_003Ed__111))]
		private System.Threading.Tasks.Task CheckListenTasks()
		{
			int num = 0;
			int num2 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0xBD3130", Offset = "0xBD1B30", VA = "0x180BD3130")]
		[AsyncStateMachine(typeof(_003CRestartListenAfterPlayerDialogue_003Ed__112))]
		private System.Threading.Tasks.Task RestartListenAfterPlayerDialogue(MissionObjective missionObjective)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0xBD3450", Offset = "0xBD1E50", VA = "0x180BD3450")]
		public void SetMissionChoice(MissionSlot slot, MissionChoice choice)
		{
			//Discarded unreachable code: IL_0051
			if (slot == null)
			{
				return;
			}
			slot.missionChoice_ = choice;
			if (!slot.IsMissionStarted)
			{
				int currentStepIndex_ = slot.currentStepIndex_;
				int count = ((RepeatedField<T>)(object)slot.missionSteps_).Count;
				if (currentStepIndex_ >= count)
				{
					return;
				}
				int currentStepIndex_2 = slot.currentStepIndex_;
				if (slot.IsValidStepIndex(currentStepIndex_2))
				{
					return;
				}
			}
			Client metaClient = MetaClient;
			int num = 0;
			Task<SetMissionNextChoice.Types.Response> asyncTask = default(Task<SetMissionNextChoice.Types.Response>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0xBCEF00", Offset = "0xBCD900", VA = "0x180BCEF00")]
		public MissionChoice GetMissionChoice(MissionSlot slot, Item characterItem)
		{
			MissionSlot missionSlot = slot;
			if (missionSlot == null)
			{
				Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)((MissionSlot x) => x == slot);
				IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
				MissionSlot missionSlot2 = Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
			slot = missionSlot;
			if (slot == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0xBD2840", Offset = "0xBD1240", VA = "0x180BD2840")]
		public bool PrepareMissionItemsToGive(MissionSlot missionSlot)
		{
			if (missionSlot != null)
			{
				if (missionSlot.state_ == MissionSlotState.Available && ((RepeatedField<T>)(object)missionSlot.itemsToGive_).Count > 0)
				{
					MultiItemInstance itemsToGive = missionSlot.GetItemsToGive();
					bool result = default(bool);
					return result;
				}
				if (missionSlot.state_ == MissionSlotState.Completed)
				{
					MultiReward additionalRewards_ = missionSlot.additionalRewards_;
					if (additionalRewards_ != null && ((RepeatedField<T>)(object)additionalRewards_.rewards_).Count > 0)
					{
						MultiItemInstance rewards = new MultiItemInstance();
						int givenItems = missionSlot.additionalRewards_.GetGivenItems(rewards);
						bool result2 = default(bool);
						return result2;
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0xBC8760", Offset = "0xBC7160", VA = "0x180BC8760")]
		public void AcceptMission(MissionSlot missionSlot, bool accept)
		{
			//Discarded unreachable code: IL_006b
			MultiReward additionalRewards_;
			do
			{
				if (missionSlot != null)
				{
					missionSlot.MissionAccepted = accept;
					if (accept && missionSlot != null)
					{
						if (missionSlot.state_ == MissionSlotState.Available && ((RepeatedField<T>)(object)missionSlot.itemsToGive_).Count > 0)
						{
							MultiItemInstance itemsToGive = missionSlot.GetItemsToGive();
							return;
						}
						while (missionSlot.state_ != MissionSlotState.Completed)
						{
						}
						additionalRewards_ = missionSlot.additionalRewards_;
						while (additionalRewards_ == null)
						{
						}
						continue;
					}
					return;
				}
				return;
			}
			while (((RepeatedField<T>)(object)additionalRewards_.rewards_).Count <= 0);
			MultiItemInstance rewards = new MultiItemInstance();
			int givenItems = missionSlot.additionalRewards_.GetGivenItems(rewards);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0xBCFBC0", Offset = "0xBCE5C0", VA = "0x180BCFBC0")]
		public void InitFriendshipChoices()
		{
			//Discarded unreachable code: IL_000c
			((List<T>)(object)FriendshipChoices).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0xBD3380", Offset = "0xBD1D80", VA = "0x180BD3380")]
		public void SelectFriendshipChoice(string choiceId, int xpIndex)
		{
			//Discarded unreachable code: IL_0023
			List<FriendshipChoice> friendshipChoices = FriendshipChoices;
			FriendshipChoice friendshipChoice = new FriendshipChoice();
			friendshipChoice.ID = choiceId;
			friendshipChoice.xpIndex_ = xpIndex;
			((List<T>)(object)friendshipChoices).Add((T)friendshipChoice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0xBCBF90", Offset = "0xBCA990", VA = "0x180BCBF90")]
		[AsyncStateMachine(typeof(_003CDiscussWithCharacterAsync_003Ed__120))]
		public System.Threading.Tasks.Task DiscussWithCharacterAsync(Item character, Item discussion)
		{
			int itemID = discussion.ItemID;
			int itemID2 = character.ItemID;
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0xBD3020", Offset = "0xBD1A20", VA = "0x180BD3020")]
		public System.Threading.Tasks.Task ResetCharacterDiscussions(Item character)
		{
			//IL_0029: Expected O, but got I4
			int itemID = character.ItemID;
			ResetCharacterDiscussions.Types.Request request = new ResetCharacterDiscussions.Types.Request();
			request.characterID_ = itemID;
			Client metaClient = SystemRoot.Instance.MetaClient;
			int num = 0;
			Task<ResetCharacterDiscussions.Types.Response> task = (Task<ResetCharacterDiscussions.Types.Response>)(object)metaClient.ResetCharacterDiscussions(request, (CancellationToken)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0xBCC0B0", Offset = "0xBCAAB0", VA = "0x180BCC0B0")]
		[AsyncStateMachine(typeof(_003CEndMissionAsync_003Ed__122))]
		public System.Threading.Tasks.Task EndMissionAsync(MissionSlot missionSlot, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xBC9270", Offset = "0xBC7C70", VA = "0x180BC9270")]
		public bool CheckMissionChoice(MissionSlot missionSlot, Item characterItem, MissionChoice choice)
		{
			MissionSlot missionSlot2 = missionSlot;
			if (missionSlot2 == null)
			{
				Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)((MissionSlot x) => x == missionSlot);
				IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
				MissionSlot missionSlot3 = Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
			missionSlot = missionSlot2;
			if (missionSlot == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0xBC9030", Offset = "0xBC7A30", VA = "0x180BC9030")]
		[AsyncStateMachine(typeof(_003CCheckForCompletedStates_003Ed__124))]
		private System.Threading.Tasks.Task CheckForCompletedStates(MissionSlotClass slotClass, Item characterItem)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0xBC8F10", Offset = "0xBC7910", VA = "0x180BC8F10")]
		[AsyncStateMachine(typeof(_003CCheckForCompletedState_003Ed__125))]
		private System.Threading.Tasks.Task CheckForCompletedState(MissionSlot missionSlot)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xBC8DA0", Offset = "0xBC77A0", VA = "0x180BC8DA0")]
		private System.Threading.Tasks.Task CheckForAdvanceStep(MissionCompleteStep.Types.Condition condition, MissionSlot missionSlot, string stepName)
		{
			int num = 0;
			if (condition == MissionCompleteStep.Types.Condition.DialogueEnd)
			{
				DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
			}
			Client metaClient = MetaClient;
			Item missionItem = missionSlot.MissionItem;
			CancellationToken token = _ctsMissionManager.Token;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0xBD2700", Offset = "0xBD1100", VA = "0x180BD2700")]
		public void PartyEnded(MissionObjective partyObjective)
		{
			//Discarded unreachable code: IL_0034
			MissionSlot missionSlot = partyObjective.MissionSlot;
			MissionObjectiveData _003CData_003Ek__BackingField = partyObjective.Data;
			Client metaClient = MetaClient;
			Item missionItem = missionSlot.MissionItem;
			CancellationToken token = _ctsMissionManager.Token;
			int num = 0;
			Task<MissionCompleteStep.Types.Response> asyncTask = default(Task<MissionCompleteStep.Types.Response>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0xBD5850", Offset = "0xBD4250", VA = "0x180BD5850")]
		public System.Threading.Tasks.Task UnlockCharacterMissionCompleteStep(MissionObjective obj)
		{
			MissionSlot missionSlot = obj.MissionSlot;
			MissionObjectiveData _003CData_003Ek__BackingField = obj.Data;
			Client metaClient = MetaClient;
			Item missionItem = missionSlot.MissionItem;
			CancellationToken token = _ctsMissionManager.Token;
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0xBD5D30", Offset = "0xBD4730", VA = "0x180BD5D30")]
		public MissionManager()
		{
		}
	}
}
