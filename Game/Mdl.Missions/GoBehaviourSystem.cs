using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Avatar;
using Mdl.Buildings;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Missions;
using Meta.Online;
using Meta.Util;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000237")]
	public class GoBehaviourSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400132C")]
		[SerializeField]
		private PlayerTaskDefinition _taskExitEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400132D")]
		[ItemID]
		[SerializeField]
		private int _castleItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400132E")]
		[ItemID]
		[SerializeField]
		private int _restaurantItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400132F")]
		[SerializeField]
		[ItemID]
		private int _storeItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001330")]
		[ItemID]
		[SerializeField]
		private int _wellItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001331")]
		[SerializeField]
		[ItemID]
		private int _pickaxeToolItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001332")]
		private PlayerNavigation playerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001333")]
		private CharacterManager characterManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001334")]
		private TrailSystem trailSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001335")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001336")]
		private bool waitingForTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001337")]
		private Meta.Character goCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001338")]
		private GoBehavior goBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001339")]
		private MissionSlot goMissionSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400133A")]
		private GridFloorType? goMoveGridFloorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400133B")]
		private SceneType targetLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400133C")]
		private Item trailTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400133D")]
		private bool trailTargetFinal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400133E")]
		private int trailTargetEdit;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public Item CastleItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D6730", Offset = "0x8D5130", VA = "0x1808D6730")]
			get
			{
				long num = Convert.ToInt64((uint)_castleItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Item PlayerHouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D67F0", Offset = "0x8D51F0", VA = "0x1808D67F0")]
			get
			{
				//Discarded unreachable code: IL_001f
				return SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.HouseItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Item RestaurantItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D6990", Offset = "0x8D5390", VA = "0x1808D6990")]
			get
			{
				long num = Convert.ToInt64((uint)_restaurantItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public Item StoreItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x8D69F0", Offset = "0x8D53F0", VA = "0x1808D69F0")]
			get
			{
				long num = Convert.ToInt64((uint)_storeItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Item WellItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A60", Offset = "0x8D5460", VA = "0x1808D6A60")]
			get
			{
				long num = Convert.ToInt64((uint)_wellItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Item PickaxeToolItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x8D6790", Offset = "0x8D5190", VA = "0x1808D6790")]
			get
			{
				long num = Convert.ToInt64((uint)_pickaxeToolItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D68D0", Offset = "0x8D52D0", VA = "0x1808D68D0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public Item TrailTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A50", Offset = "0x8D5450", VA = "0x1808D6A50")]
			get
			{
				return trailTarget;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x8D6AC0", Offset = "0x8D54C0", VA = "0x1808D6AC0")]
			set
			{
				//IL_000b: Expected O, but got I4
				bool flag = default(bool);
				if (flag)
				{
					trailTarget = (Item)0;
					UpdateTrailTarget();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D52A0", Offset = "0x8D3CA0", VA = "0x1808D52A0")]
		private void TrailSystem_TargetChangedEvent(object sender, EventArgs e)
		{
			if (trailTargetEdit == 0)
			{
				Item item = (TrailTarget = Item.Invalid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D5220", Offset = "0x8D3C20", VA = "0x1808D5220")]
		private void TrailSystem_AutoCancelledEvent(object sender, EventArgs e)
		{
			if (trailTargetFinal)
			{
				Item item = (TrailTarget = Item.Invalid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0F0", Offset = "0x8CCAF0", VA = "0x1808CE0F0")]
		private void Environment_AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			UpdateTrailTarget();
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4600", Offset = "0x8D3000", VA = "0x1808D4600")]
		private unsafe void OnMissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex)
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			ProfileWorld world_ = Profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot != null)
			{
				int itemID = missionSlot.MissionItem.ItemID;
			}
			Item item = trailTarget;
			if (num != 0 && *(Item*)num == *(Item*)item)
			{
				UpdateTrailTarget();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D6650", Offset = "0x8D5050", VA = "0x1808D6650")]
		private void UpdateTrailTarget()
		{
			//Discarded unreachable code: IL_006a
			//IL_0012: Expected O, but got I4
			int num = 0;
			TrailSystem trailSystem = this.trailSystem;
			int num2 = 0;
			trailSystem.Target = (Transform)num2;
			trailTargetFinal = true;
			Item item = trailTarget;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Character)
			{
				Item item2 = trailTarget;
				bool flag = UpdateCharacterTrail(item2);
			}
			if (itemType == ItemType.Building)
			{
				Item item3 = trailTarget;
				bool flag2 = UpdateBuildingTrail(item3);
			}
			if (itemType == ItemType.Mission)
			{
				Item item4 = trailTarget;
				bool flag3 = UpdateMisionAreaTrail(item4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D5900", Offset = "0x8D4300", VA = "0x1808D5900")]
		private bool UpdateCharacterTrail(Item item)
		{
			//IL_00df: Expected O, but got I4
			int itemID = item.ItemID;
			CharacterManager characterManager = this.characterManager;
			CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
			if (characterInstance != null)
			{
				ProfileWorld world_ = Profile.world_;
				bool flag = default(bool);
				if (flag)
				{
					if (!characterInstance.Active)
					{
						bool flag2 = default(bool);
						if (flag2)
						{
							goto IL_004e;
						}
						bool flag3 = default(bool);
						if (!flag3)
						{
							Client client = default(Client);
							DateTime localTime = client.LocalTime;
							bool flag4 = default(bool);
							if (!flag4)
							{
								goto IL_004e;
							}
						}
						goto IL_0072;
					}
					goto IL_0103;
				}
			}
			goto IL_012a;
			IL_012a:
			throw new NullReferenceException();
			IL_004e:
			CharacterManager characterManager2 = this.characterManager;
			ScheduleType scheduleType = default(ScheduleType);
			if (scheduleType <= ScheduleType.PlayerHouse)
			{
				bool flag5 = string.Equals(characterInstance.Data.name_, "Ratatouille!Remy");
			}
			goto IL_0072;
			IL_0103:
			Mdl.Characters.Character _003CCharacter_003Ek__BackingField = characterInstance.Character;
			TrailSystem trailSystem = this.trailSystem;
			Transform transform = (trailSystem.Target = _003CCharacter_003Ek__BackingField.GetComponent<PlayerTaskCollider>().Destination);
			goto IL_012a;
			IL_0072:
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			AsyncOperation operation2 = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig2 = sceneData.EditCameraConfig;
			uint num = num + 2;
			(bool, PlayerTaskCollider, SceneType) tuple = default((bool, PlayerTaskCollider, SceneType));
			bool flag6 = default(bool);
			PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
			if ((object)tuple != null && flag6)
			{
				GameObject gameObject = default(GameObject);
				PlayerTaskCollider[] componentsInChildren = gameObject.GetComponentsInChildren<PlayerTaskCollider>();
				Func<PlayerTaskCollider, bool> func = (Func<PlayerTaskCollider, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskCollider x)
				{
					//Discarded unreachable code: IL_001c
					IEnumerable<PlayerTaskDefinition> tasks = (IEnumerable<PlayerTaskDefinition>)x.GetTasks();
					Func<PlayerTaskDefinition, bool> cpp2il__autoParamName__idx_ = (Func<PlayerTaskDefinition, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskDefinition y)
					{
						//Discarded unreachable code: IL_001b
						string taskId = y._taskId;
						string taskId2 = _taskExitEnv._taskId;
						return string.Equals(taskId, taskId2);
					};
					return ((IEnumerable<>)tasks).Any<PlayerTaskDefinition>((Func<, >)(object)cpp2il__autoParamName__idx_);
				};
				playerTaskCollider = Enumerable.FirstOrDefault<PlayerTaskCollider>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			}
			int num2 = 0;
			if (playerTaskCollider != (UnityEngine.Object)num2)
			{
				TrailSystem trailSystem2 = this.trailSystem;
				Transform transform2 = (trailSystem2.Target = playerTaskCollider.Destination);
				trailTargetFinal = false;
				goto IL_0103;
			}
			goto IL_012a;
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D54D0", Offset = "0x8D3ED0", VA = "0x1808D54D0")]
		private bool UpdateBuildingTrail(Item item)
		{
			//IL_0014: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			ItemScript[] componentsInChildren = gameObject.GetComponentsInChildren<ItemScript>();
			Func<ItemScript, bool> func = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
			{
				//Discarded unreachable code: IL_0015
				if ((object)x.Item == null)
				{
				}
				return x.gameObject.activeSelf;
			};
			IEnumerable<ItemScript> enumerable = (IEnumerable<ItemScript>)Enumerable.Where<ItemScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			Func<ItemScript, PlayerTaskCollider> _003C_003E9__42_ = _003C_003Ec._003C_003E9__42_1;
			if (_003C_003E9__42_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemScript x) => x.GetComponent<PlayerTaskCollider>());
			}
			IEnumerable<ItemScript> enumerable2 = (IEnumerable<ItemScript>)Enumerable.Select<ItemScript, PlayerTaskCollider>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__42_);
			Func<PlayerTaskCollider, bool> func2 = default(Func<PlayerTaskCollider, bool>);
			if (_003C_003Ec._003C_003E9__42_2 == null)
			{
				func2 = (Func<PlayerTaskCollider, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(PlayerTaskCollider x)
				{
					//IL_0009: Expected O, but got I4
					int num2 = 0;
					return x != (UnityEngine.Object)num2;
				});
			}
			PlayerTaskCollider playerTaskCollider = Enumerable.FirstOrDefault<PlayerTaskCollider>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
			int num = 0;
			bool flag = playerTaskCollider != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			TrailSystem trailSystem = this.trailSystem;
			Transform transform = (trailSystem.Target = playerTaskCollider.Destination);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DD0", Offset = "0x8D47D0", VA = "0x1808D5DD0")]
		private bool UpdateMisionAreaTrail(Item item)
		{
			int num = 0;
			ProfileWorld world_ = Profile.world_;
			bool flag = default(bool);
			if (flag)
			{
				MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
				MissionSlot slot = default(MissionSlot);
				MissionSlot missionSlot = slot;
				if (missionSlot.state_ == MissionSlotState.Available)
				{
					Item characterItem = missionSlot.CharacterItem;
					Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)((MissionSlot x) => x == slot);
					IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
					if (Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)func) == null)
					{
						Item characterItem2 = slot.CharacterItem;
					}
				}
				MissionSlot missionSlot2 = slot;
				if (missionSlot2.state_ == MissionSlotState.OnGoing)
				{
					MissionStep currentStep = missionSlot2.CurrentStep;
					MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
					TrailSystem trailSystem = default(TrailSystem);
					if (currentStep != null && currentStep.Data != null && missionObjectiveData != null && (missionObjectiveData.VisitArea.locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.SpecificLocation || missionObjectiveData.VisitArea.locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.VillageArea))
					{
						LocationSourceWithRadius specificLocation = missionObjectiveData.VisitArea.SpecificLocation;
						MissionSlot missionSlot3 = slot;
						LocationSource location_ = specificLocation.location_;
						CharacterManager characterManager = this.characterManager;
						Item characterItem3 = missionSlot3.CharacterItem;
						bool flag2 = default(bool);
						if (flag2)
						{
							trailSystem = this.trailSystem;
						}
					}
					MissionStep currentStep2 = slot.CurrentStep;
					if (currentStep2 != null)
					{
						IEnumerable<MissionObjective> activeObjectives = (IEnumerable<MissionObjective>)currentStep2.get_ActiveObjectives();
						Func<MissionObjective, bool> func2 = default(Func<MissionObjective, bool>);
						if (_003C_003Ec._003C_003E9__43_1 == null)
						{
							func2 = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective obj)
							{
								int goBehaviorInt2 = obj.GoBehaviorInt;
								throw new NullReferenceException();
							});
						}
						MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)activeObjectives, (Func<, >)(object)func2);
						if (missionObjective != null)
						{
							int goBehaviorInt = missionObjective.GoBehaviorInt;
						}
					}
					if ((long)trailSystem != 4)
					{
						if ((long)trailSystem > 1024)
						{
							if ((long)trailSystem == 2048)
							{
								int castleItemID = _castleItemID;
							}
							if ((long)trailSystem == 4096)
							{
							}
							if ((long)trailSystem != 131072)
							{
								goto IL_01d1;
							}
						}
						if ((long)trailSystem == 256)
						{
							Item houseItem = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.HouseItem;
						}
						if ((long)trailSystem == 1024)
						{
							Item characterItem4 = slot.CharacterItem;
							bool flag3 = default(bool);
							if (!flag3)
							{
							}
						}
						goto IL_01d1;
					}
				}
			}
			goto IL_01d6;
			IL_01d6:
			Item item2 = (TrailTarget = Item.Invalid);
			throw new NullReferenceException();
			IL_01d1:
			bool flag4 = default(bool);
			if (!flag4)
			{
			}
			goto IL_01d6;
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3210", Offset = "0x8D1C10", VA = "0x1808D3210")]
		public static bool InTheRightScene(GoBehavior goBehavior, SceneData newScene, Item characterItem)
		{
			//Discarded unreachable code: IL_0063
			if (goBehavior > GoBehavior.GoToCharacterHouse)
			{
				if (goBehavior > GoBehavior.GoToRestaurant)
				{
					switch (goBehavior)
					{
					case GoBehavior.GoToStore:
						return (long)"{il2cpp field on {'constant12' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 8;
					case GoBehavior.GoToCave:
						return (long)"{il2cpp field on {'constant19' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 9;
					default:
					{
						int num = 0;
						throw new NullReferenceException();
					}
					}
				}
				if (goBehavior == GoBehavior.GoToCastle)
				{
					return (long)"{il2cpp field on {'constant26' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 2;
				}
				bool result = default(bool);
				return result;
			}
			if (goBehavior == GoBehavior.GoToPlayerHouse)
			{
				return (long)"{il2cpp field on {'constant38' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 3;
			}
			bool result2 = default(bool);
			return result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D30", Offset = "0x8D0730", VA = "0x1808D1D30")]
		public unsafe void GoRedirect(GoBehavior behavior, Meta.Character character, bool redirected = false, [System.Runtime.InteropServices.Optional] MissionSlot missionSlot, [System.Runtime.InteropServices.Optional] GridFloorType? moveGridFloorType)
		{
			//IL_0013: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_012a: Expected O, but got I4
			//IL_02a8: Expected O, but got I4
			//IL_02a8: Expected O, but got I4
			//IL_02a8: Expected O, but got I4
			//IL_02fb: Expected native int or pointer, but got O
			//IL_034c: Expected O, but got I4
			bool flag = default(bool);
			SceneData sceneData = default(SceneData);
			Mdl.Characters.Character characterInstance = default(Mdl.Characters.Character);
			Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
			ItemFilterData itemFilterData = default(ItemFilterData);
			ItemFilterData itemFilterData2 = default(ItemFilterData);
			SceneType sceneType = default(SceneType);
			bool flag2 = default(bool);
			ItemScript itemScript = default(ItemScript);
			GameObject gameObject = default(GameObject);
			bool flag3 = default(bool);
			ItemFilterData itemFilterData3 = default(ItemFilterData);
			SceneData sceneData2 = default(SceneData);
			GameObject gameObject2 = default(GameObject);
			uint num9 = default(uint);
			uint num10 = default(uint);
			GridFloorType gridFloorType = default(GridFloorType);
			GridFloorType gridFloorType2 = default(GridFloorType);
			Vector3 vector = default(Vector3);
			Vector3 position = default(Vector3);
			Task asyncTask = default(Task);
			int num12 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				GridFloorType? moveGridFloorType2 = (GridFloorType?)(object)0;
				switch (behavior)
				{
				case GoBehavior.TalkToCharacter:
				{
					CharacterManager characterManager = this.characterManager;
					Item item = character.base_.Item;
					if (flag)
					{
						return;
					}
					break;
				}
				case GoBehavior.None:
					return;
				}
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				if (behavior > GoBehavior.Move)
				{
					if (behavior == GoBehavior.TalkToCharacter)
					{
						if (LocateCharacterScene(character) != 0)
						{
							goto IL_0115;
						}
						goCharacter = (Meta.Character)num;
						goMissionSlot = (MissionSlot)num;
						int num3 = 0;
						goMoveGridFloorType = (GridFloorType?)(object)num3;
						targetLocation = (SceneType)num;
						CheckRedirectionTask();
						CharacterManager characterManager2 = this.characterManager;
						Item item2 = character.base_.Item;
						characterInstance = character2;
						if (behavior <= GoBehavior.Move || behavior != GoBehavior.TalkToCharacter)
						{
							goto IL_01ec;
						}
						PlayerTaskCollider component = characterInstance.GetComponent<PlayerTaskCollider>();
						InteractWithPlayerTask(component);
					}
					while (behavior == GoBehavior.RoyalDuties)
					{
					}
				}
				if (behavior == GoBehavior.Item)
				{
					if (itemFilterData.type_ > ItemType.Clothing || itemFilterData2.activityItemType_ > ActivityItemType.Ingredient)
					{
						continue;
					}
					while ((long)"{il2cpp array field local24->}" == 6)
					{
					}
					goto IL_0115;
				}
				goto IL_0170;
				IL_0170:
				if (sceneType != (SceneType)(-129))
				{
				}
				while (flag2)
				{
				}
				while ((IntPtr)"{il2cpp array field local24->}" != (IntPtr)num)
				{
				}
				int num4 = 0;
				Debug.LogError("GoBehavior: Failed to find a valid shop.");
				while (-8192L == 4294959103L)
				{
				}
				if (num4 > 512 && num4 == 1024)
				{
					itemScript = gameObject.GetComponent<Mdl.Environments.Environment>().GetComponent<EnteredEnvironmentOrigin>().Door.GetItemScript();
					int house = character.Data.House;
					Item item3 = itemScript.Item;
					int num5 = 0;
					while (!flag3)
					{
					}
				}
				goto IL_01ec;
				IL_01ec:
				OptionalField normality_ = itemFilterData3.normality_;
				AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
				GridScript[] componentsInChildren = gameObject2.GetComponentsInChildren<GridScript>();
				Func<GridScript, bool> func = (Func<GridScript, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass45_0)(object)itemScript)._003CGoRedirect_003Eb__0);
				GridScript[] array = Enumerable.Where<GridScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func).ToArray<GridScript>();
				while (array.Length == num)
				{
				}
				System.Random random = new System.Random();
				int length = array.Length;
				int num6 = random.Next(length);
				GridScript gridScript = array[num6];
				int sizeX_ = gridScript.GridData.sizeX_;
				int num7 = random.Next(sizeX_);
				int sizeY_ = gridScript.GridData.sizeY_;
				int num8 = random.Next(sizeY_);
				sizeY_ = num7;
				IEnumerable<GridPosition> enumerable = (IEnumerable<GridPosition>)gridScript.EnumeratePositionsInSpiralOrder((GridPosition)num, num8, (int)num9, (Func<, >)num, (Action<>)num);
				if (enumerable != null)
				{
					if (num < (int)num10)
					{
						num += num;
						if (num == (int)num10)
						{
							goto IL_0350;
						}
						num++;
					}
					GridData gridData = gridScript.GridData;
					if (gridFloorType != gridFloorType2)
					{
						continue;
					}
					_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = (_003C_003Ec__DisplayClass45_0)(object)itemScript;
					float z = vector.z;
					((Vector3*)(IntPtr)position)->z = z;
					int num11 = 0;
					if (DebugSettings.Settings.UseDebugGoButton)
					{
						float z2 = position.z;
						Func<Task> func2 = (Func<Task>)(object)(Func<TResult>)delegate
						{
							//Discarded unreachable code: IL_0025
							PlayerNavigation playerNavigation = _003C_003Ec__DisplayClass45_._003C_003E4__this.playerNavigation;
							float z3 = position.z;
							int num16 = 0;
							return Task.CompletedTask;
						};
						asyncTask.FireAndForgetTask();
						num++;
					}
					TrailSystem trailSystem = this.trailSystem;
					num12 = 0;
					trailSystem.set_TargetPosition((Nullable<>)num12);
					num++;
					goto IL_0350;
				}
				goto IL_0358;
				IL_0350:
				num += 312;
				goto IL_0358;
				IL_0358:
				num++;
				if (enumerable != null)
				{
				}
				if (num12 == 0)
				{
					if (num != 0)
					{
					}
					PlayerTaskCollider component2 = characterInstance.GetComponent<PlayerTaskCollider>();
					int num13 = 0;
					if (!DebugSettings.Settings.UseDebugGoButton)
					{
						break;
					}
				}
				continue;
				IL_0115:
				goCharacter = character;
				goBehavior = (GoBehavior)0;
				goMissionSlot = (MissionSlot)0;
				CheckRedirectionTask();
				if (((long)"{il2cpp array field local24->}" >= 6 || (long)"{il2cpp array field local24->}" == 3) && ((long)"{il2cpp array field local24->}" >= 3 || (long)"{il2cpp array field local24->}" == 1))
				{
					sceneType = LocateCharacterWorld(character);
					while ((IntPtr)"{il2cpp array field local24->}" == (IntPtr)(void*)(int)sceneType)
					{
					}
					goto IL_0170;
				}
				goto IL_01ec;
			}
			MissionManager missionManager2 = default(MissionManager);
			MissionManager missionManager = missionManager2;
			MissionManager missionManager3 = missionManager;
			EventHandler<Item> eventHandler = (EventHandler<Item>)(object)new EventHandler<TEventArgs>(ListenTaskEnded);
			missionManager3.add_ListenTaskEnded((EventHandler<>)(object)eventHandler);
			PlayerTaskCollider component3 = characterInstance.GetComponent<PlayerTaskCollider>();
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0x1052350", Offset = "0x1050D50", VA = "0x181052350")]
			void ListenTaskEnded(object sender, Item e)
			{
				//Discarded unreachable code: IL_007b
				//IL_007a: Expected O, but got I4
				int num14 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				NpcDiscussionItemData npcDiscussionItemData = default(NpcDiscussionItemData);
				int character1ItemID = npcDiscussionItemData.Character1ItemID;
				if ((object)characterInstance.Item == null)
				{
					int character2ItemID = npcDiscussionItemData.Character2ItemID;
					if ((object)characterInstance.Item == null)
					{
						return;
					}
				}
				MissionManager missionManager4 = missionManager;
				EventHandler<Item> eventHandler2 = (EventHandler<Item>)(object)new EventHandler<TEventArgs>(ListenTaskEnded);
				missionManager4.remove_ListenTaskEnded((EventHandler<>)(object)eventHandler2);
				TrailSystem trailSystem2 = this.trailSystem;
				int num15 = 0;
				trailSystem2.Target = (Transform)num15;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D0E40", Offset = "0x8CF840", VA = "0x1808D0E40")]
		private bool FindShop(GoBehavior behavior, ItemFilterData itemFilters, out SceneType sceneId)
		{
			//Discarded unreachable code: IL_01ff, IL_0205, IL_020b, IL_0211, IL_0217, IL_021d, IL_0223, IL_0229, IL_022f, IL_0235, IL_023b, IL_0241
			//IL_0086: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			bool flag = default(bool);
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num4 = default(uint);
			Profile profile = default(Profile);
			Predicate<ShopSlot> predicate = default(Predicate<ShopSlot>);
			Predicate<ShopSlot> predicate2 = default(Predicate<ShopSlot>);
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			Func<ShoppingStall, bool> func = default(Func<ShoppingStall, bool>);
			PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
			ulong num8 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (!flag || (IntPtr)itemFilters == (IntPtr)num3)
				{
					break;
				}
				Func<StallBuildingItemData, bool> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_1;
				if (_003C_003E9__46_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(StallBuildingItemData building)
					{
						//Discarded unreachable code: IL_000c
						string shopData_ = building.shopData_;
						return building == null;
					};
				}
				IEnumerable<StallBuildingItemData> enumerable2 = (IEnumerable<StallBuildingItemData>)Enumerable.Where<StallBuildingItemData>(enumerable, (Func<, >)(object)_003C_003E9__46_);
				if (enumerable2 != null)
				{
					if (num3 < (int)num4)
					{
						num3 += num3;
						if (num3 == (int)num4)
						{
							goto IL_0140;
						}
						num3++;
					}
					int num5 = 0;
					Shop shop = profile.world_.GetShop((string)num5);
					while (shop == null)
					{
					}
					RepeatedField<ShopSlot> slots_ = shop.data_.slots_;
					if (predicate == null)
					{
						predicate2 = (predicate = (Predicate<ShopSlot>)(object)(Predicate<T>)delegate(ShopSlot x)
						{
							ItemAmount item_ = x.item_;
							if (item_ != null)
							{
								Item item = item_.Item;
								ItemType itemType = default(ItemType);
								if (itemType == ItemType.ActivityItem)
								{
									Item item2 = x.item_.Item;
									ItemFilterData itemFilterData = itemFilters;
									ActivityItemType activityItemType = default(ActivityItemType);
									return activityItemType == itemFilterData.activityItemType_;
								}
							}
							int num10 = 0;
							throw new NullReferenceException();
						});
					}
					if (!((RepeatedField<>)(object)slots_).Any<ShopSlot>((Predicate<>)(object)predicate2))
					{
						continue;
					}
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					SceneItemData sceneItemData = sceneData.sceneItemData;
					ShoppingStall[] componentsInChildren = gameObject.GetComponentsInChildren<ShoppingStall>();
					if (_003C_003Ec._003C_003E9__46_3 == null)
					{
						func = (Func<ShoppingStall, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ShoppingStall x) => x.GetShop() != null));
					}
					ShoppingStall shoppingStall = Enumerable.FirstOrDefault<ShoppingStall>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
					int num6 = 0;
					if (!(shoppingStall != (UnityEngine.Object)num6))
					{
						continue;
					}
					playerTaskCollider = shoppingStall.GetComponent<PlayerTaskCollider>();
					num3++;
					goto IL_0140;
				}
				goto IL_0156;
				IL_0140:
				playerTaskCollider = (PlayerTaskCollider)(object)((object)playerTaskCollider + (object)playerTaskCollider);
				num3 += 312;
				int num7 = 0;
				num3++;
				goto IL_0156;
				IL_0156:
				num3++;
				if (enumerable2 != null)
				{
				}
				if (num8 == 0)
				{
					if (num3 == 0)
					{
					}
					break;
				}
			}
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData2 = default(SceneData);
			AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
			SceneItemData sceneItemData2 = sceneData2.sceneItemData;
			GameObject gameObject2 = default(GameObject);
			ShoppingStall[] componentsInChildren2 = gameObject2.GetComponentsInChildren<ShoppingStall>();
			Func<ShoppingStall, bool> func2 = default(Func<ShoppingStall, bool>);
			if (_003C_003Ec._003C_003E9__46_0 == null)
			{
				func2 = (Func<ShoppingStall, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ShoppingStall x) => x.GetShop() != null));
			}
			IEnumerable<ShoppingStall> enumerable3 = (IEnumerable<ShoppingStall>)Enumerable.Where<ShoppingStall>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func2);
			int num9 = Enumerable.Count<ShoppingStall>((IEnumerable<>)enumerable3);
			List<ShoppingStall> list = (List<ShoppingStall>)(object)Enumerable.ToList<ShoppingStall>((IEnumerable<>)enumerable3);
			PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			PlayerTaskCollider playerTaskCollider2 = default(PlayerTaskCollider);
			InteractWithPlayerTask(playerTaskCollider2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D02B0", Offset = "0x8CECB0", VA = "0x1808D02B0")]
		private void FindItem(GoBehavior behavior, ItemFilterData itemFilters, Meta.Character character, MissionSlot missionSlot)
		{
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
			GridEditMode gridEditMode = default(GridEditMode);
			do
			{
				int num = 0;
				ItemType type_ = itemFilters.type_;
				if (type_ > ItemType.Clothing)
				{
					return;
				}
				ActivityItemType activityItemType_ = itemFilters.activityItemType_;
				if (activityItemType_ > ActivityItemType.Meal)
				{
					switch (activityItemType_)
					{
					}
					return;
				}
				if (type_ == ItemType.Building)
				{
				}
				while (type_ != ItemType.ActivityItem)
				{
				}
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				CookingStall[] componentsInChildren = gameObject.GetComponentsInChildren<CookingStall>();
				int length = componentsInChildren.Length;
				while (num >= length)
				{
				}
				CookingStall cookingStall = componentsInChildren[num];
				if (cookingStall.State == CookingStallState.PlayerCookingStation)
				{
					PlayerTaskCollider component = cookingStall.GetComponent<PlayerTaskCollider>();
					InteractWithPlayerTask(component);
				}
				num++;
				CharacterManager characterManager = this.characterManager;
				int length2 = componentsInChildren.Length;
				PlayerTaskCollider component2 = character2.GetComponent<PlayerTaskCollider>();
				InteractWithPlayerTask(component2);
			}
			while (!gridEditMode.CanStartEditMode);
			GridEditModeStartData gridEditModeStartData = new GridEditModeStartData();
			gridEditModeStartData.ItemFilters = (ItemFilterData)(object)character2;
			gridEditMode.StartSystem(gridEditModeStartData);
			Item _003CItem_003Ek__BackingField = character2.Item;
			int num2 = 0;
			Item ticketCurrencyItem = CurrencyItem.TicketCurrencyItem;
			if ((object)_003CItem_003Ek__BackingField != (object)ticketCurrencyItem)
			{
				Item _003CItem_003Ek__BackingField2 = character2.Item;
				int num3 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				while ((object)_003CItem_003Ek__BackingField2 != (object)softCurrencyItem)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB90", Offset = "0x8CD590", VA = "0x1808CEB90")]
		private void FindCrop(GoBehavior behavior, ItemFilterData itemFilters, MissionSlot missionSlot)
		{
			//IL_016c: Expected O, but got I4
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			CropItemData cropItemData = default(CropItemData);
			ulong num5 = default(ulong);
			SceneData sceneData2 = default(SceneData);
			GameObject gameObject2 = default(GameObject);
			Func<Garden, bool> func2 = default(Func<Garden, bool>);
			Garden garden;
			Func<GardeningSlot, (GardeningSlot, Item)> func4 = default(Func<GardeningSlot, (GardeningSlot, Item)>);
			IEnumerable<GardeningSlot> enumerable2 = default(IEnumerable<GardeningSlot>);
			Func<(GardeningSlot, Item), Item> func5 = default(Func<(GardeningSlot, Item), Item>);
			IEnumerable<GardeningSlot> enumerable3 = default(IEnumerable<GardeningSlot>);
			bool flag = default(bool);
			Func<(GardeningSlot, Item), bool> func7 = default(Func<(GardeningSlot, Item), bool>);
			bool result = default(bool);
			Func<(GardeningSlot, Item), GardeningSlot> func8 = default(Func<(GardeningSlot, Item), GardeningSlot>);
			List<GardeningSlot> list7 = default(List<GardeningSlot>);
			Func<(GardeningSlot, Item), GardeningSlot> func9 = default(Func<(GardeningSlot, Item), GardeningSlot>);
			Func<GardeningSlot, bool> func10 = default(Func<GardeningSlot, bool>);
			while (true)
			{
				int num = 0;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				GardeningSlot[] componentsInChildren = gameObject.GetComponentsInChildren<GardeningSlot>();
				Func<GardeningSlot, bool> _003C_003E9__48_ = _003C_003Ec._003C_003E9__48_0;
				if (_003C_003E9__48_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GardeningSlot x) => !((GridObjectStateUser)x).GridObjectScript.GridScript.Locked);
				}
				List<GardeningSlot> list = (List<GardeningSlot>)(object)Enumerable.ToList<GardeningSlot>(Enumerable.Where<GardeningSlot>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__48_));
				CropTypeCondition cropTypeCondition = itemFilters.cropType_;
				int item_ = itemFilters.item_;
				int item_2 = itemFilters.item_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				cropTypeCondition = cropItemData.cropType_.ToCropTypeCondition();
				if (cropTypeCondition == CropTypeCondition.Any)
				{
					continue;
				}
				Func<GardeningSlot, bool> func = (Func<GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(GardeningSlot x)
				{
					if ((object)x == null)
					{
						int num9 = 0;
						/*Error: Unexpected end of block*/;
					}
					Garden _003CGarden_003Ek__BackingField = x.Garden;
					if ((object)_003CGarden_003Ek__BackingField != null)
					{
						GardenItemData data2 = _003CGarden_003Ek__BackingField.Data;
						if (data2 != null)
						{
							CropTypeCondition other2 = cropTypeCondition;
							bool flag3 = data2.cropType_.IsSameAs(other2);
							return 0 == 1;
						}
					}
					return 0 == 1;
				};
				List<GardeningSlot> list2 = (List<GardeningSlot>)(object)Enumerable.ToList<GardeningSlot>(Enumerable.Where<GardeningSlot>((IEnumerable<>)list, (Func<, >)(object)func));
				if (cropTypeCondition == CropTypeCondition.Fruit)
				{
					MissionStep currentStep = missionSlot.CurrentStep;
					if (currentStep != null)
					{
						MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(currentStep.get_AllObjectives());
						if (missionObjective != null)
						{
							int num2 = 0;
							float currentAmount = missionObjective.CurrentAmount;
						}
						int num3 = 0;
						int num4 = 0;
						if (num5 == (ulong)num3)
						{
						}
					}
				}
				if (cropTypeCondition == CropTypeCondition.Vegetable)
				{
					SceneItemData sceneItemData2 = sceneData2.sceneItemData;
					Garden[] componentsInChildren2 = gameObject2.GetComponentsInChildren<Garden>();
					if (_003C_003Ec._003C_003E9__48_3 == null)
					{
						func2 = (Func<Garden, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Garden x) => !((GridObjectStateUser)x).GridObjectScript.GridScript.Locked));
					}
					IEnumerable<Garden> enumerable = (IEnumerable<Garden>)Enumerable.Where<Garden>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func2);
					Func<Garden, bool> func3 = (Func<Garden, bool>)(object)(Func<T, TResult>)delegate(Garden x)
					{
						GardenItemData data = x.Data;
						if (data != null)
						{
							CropTypeCondition other = cropTypeCondition;
							return data.cropType_.IsSameAs(other);
						}
						throw new NullReferenceException();
					};
					garden = Enumerable.FirstOrDefault<Garden>((IEnumerable<>)enumerable, (Func<, >)(object)func3);
					int num6 = 0;
					if (garden != (UnityEngine.Object)num6)
					{
						break;
					}
				}
				if (_003C_003Ec._003C_003E9__48_6 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardeningSlot slot)
					{
						//Discarded unreachable code: IL_0009
						Item plantedSeedItem3 = slot.PlantedSeedItem;
						bool result3 = default(bool);
						return result3;
					};
				}
				if (_003C_003Ec._003C_003E9__48_7 == null)
				{
					func4 = (Func<GardeningSlot, (GardeningSlot, Item)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						SeedItemData seedItemData = default(SeedItemData);
						Item producedItem = seedItemData.ProducedItem;
						int num8 = 0;
						throw new NullReferenceException();
					});
				}
				List<(GardeningSlot, Item)> list3 = (List<(GardeningSlot, Item)>)(object)Enumerable.ToList<(GardeningSlot, Item)>(Enumerable.Select<GardeningSlot, (GardeningSlot, Item)>((IEnumerable<>)enumerable2, (Func<, >)(object)func4));
				int item_3 = itemFilters.item_;
				if (list3 != null)
				{
					ItemFilter itemFilter = new ItemFilter();
					itemFilter.data_ = itemFilters;
					if (_003C_003Ec._003C_003E9__48_8 == null)
					{
						func5 = (Func<(GardeningSlot, Item), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					List<Item> list4 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<(GardeningSlot, Item), Item>((IEnumerable<>)list3, (Func<, >)(object)func5));
					List<Item> list5 = (List<Item>)(object)itemFilter.ApplyFilter((IEnumerable<>)list4);
				}
				List<Item> validProducedList = (List<Item>)(object)new List<T>();
				Func<(GardeningSlot, Item), bool> func6 = (Func<(GardeningSlot, Item), bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0009
					List<Item> list9 = validProducedList;
					bool result2 = default(bool);
					return result2;
				};
				List<(GardeningSlot, Item)> list6 = (List<(GardeningSlot, Item)>)(object)Enumerable.ToList<(GardeningSlot, Item)>(Enumerable.Where<(GardeningSlot, Item)>((IEnumerable<>)list3, (Func<, >)(object)func6));
				if (!Enumerable.Any<(GardeningSlot, Item)>((IEnumerable<>)list6))
				{
					if (cropTypeCondition != CropTypeCondition.Fruit)
					{
						if (_003C_003Ec._003C_003E9__48_13 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardeningSlot x)
							{
								Item plantedSeedItem2 = x.PlantedSeedItem;
								throw new NullReferenceException();
							};
						}
						if (!Enumerable.Any<GardeningSlot>((IEnumerable<>)Enumerable.ToList<GardeningSlot>((IEnumerable<>)enumerable3)))
						{
							goto IL_03aa;
						}
					}
					if (flag)
					{
						goto IL_03aa;
					}
					Debug.LogError("GoBehavior: FindCrop() failed to find fruit and shop.");
				}
				if (_003C_003Ec._003C_003E9__48_10 == null)
				{
					func7 = (Func<(GardeningSlot, Item), bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(((GardeningSlot slot, Item ProducedItem) x) => result));
				}
				if (!Enumerable.Any<(GardeningSlot, Item)>((IEnumerable<>)Enumerable.ToList<(GardeningSlot, Item)>(Enumerable.Where<(GardeningSlot, Item)>((IEnumerable<>)list6, (Func<, >)(object)func7))))
				{
					if (_003C_003Ec._003C_003E9__48_12 == null)
					{
						func8 = (Func<(GardeningSlot, Item), GardeningSlot>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					list7 = (List<GardeningSlot>)(object)Enumerable.ToList<GardeningSlot>(Enumerable.Select<(GardeningSlot, Item), GardeningSlot>((IEnumerable<>)list6, (Func<, >)(object)func8));
				}
				if (_003C_003Ec._003C_003E9__48_11 == null)
				{
					func9 = (Func<(GardeningSlot, Item), GardeningSlot>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				List<GardeningSlot> list8 = (List<GardeningSlot>)(object)Enumerable.ToList<GardeningSlot>(Enumerable.Select<(GardeningSlot, Item), GardeningSlot>((IEnumerable<>)list7, (Func<, >)(object)func9));
				if (_003C_003Ec._003C_003E9__48_5 == null)
				{
					func10 = (Func<GardeningSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardeningSlot x)
					{
						Item plantedSeedItem = x.PlantedSeedItem;
						throw new NullReferenceException();
					});
				}
				bool flag2 = Enumerable.Any<GardeningSlot>((IEnumerable<>)Enumerable.ToList<GardeningSlot>(Enumerable.Where<GardeningSlot>((IEnumerable<>)list8, (Func<, >)(object)func10)));
				goto IL_03aa;
				IL_03aa:
				if (_003C_003Ec._003C_003E9__48_2 == null)
				{
					/*Error: Could not find block for branch target IL_03b5*/;
				}
			}
			int num7 = 0;
			if (DebugSettings.Settings.UseDebugGoButton)
			{
				PlayerTaskCollider component = garden.GetComponent<PlayerTaskCollider>();
				InteractWithPlayerTask(component);
			}
			TrailSystem trailSystem = this.trailSystem;
			Transform transform2 = (trailSystem.Target = garden.transform);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x8CE100", Offset = "0x8CCB00", VA = "0x1808CE100")]
		private void FindActivityItem(ItemFilterData itemFilters, MissionSlot missionSlot)
		{
			//IL_00e1: Expected O, but got I4
			//IL_0172: Expected O, but got I4
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			Func<ItemScript, Item> func2 = default(Func<ItemScript, Item>);
			Func<ItemScript, bool> func4 = default(Func<ItemScript, bool>);
			bool flag2 = default(bool);
			int num5 = default(int);
			int isDefaultGamepadFocus = default(int);
			while (true)
			{
				MissionStep currentStep = missionSlot.CurrentStep;
				int num = 0;
				if (currentStep != null)
				{
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(currentStep.get_AllObjectives());
					if (missionObjective != null)
					{
						int num2 = 0;
						float currentAmount = missionObjective.CurrentAmount;
					}
					int num3 = 0;
					if (num != num3)
					{
						BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
						return;
					}
				}
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				ItemScript[] componentsInChildren = gameObject.GetComponentsInChildren<ItemScript>();
				Func<ItemScript, bool> func = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
				{
					//Discarded unreachable code: IL_0028
					Item item2 = x.Item;
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.ActivityItem)
					{
						int num9 = 0;
					}
					Item item3 = x.Item;
					ItemFilterData itemFilterData = itemFilters;
					ActivityItemType activityItemType = default(ActivityItemType);
					return activityItemType == itemFilterData.activityItemType_;
				};
				List<ItemScript> list = (List<ItemScript>)(object)Enumerable.ToList<ItemScript>(Enumerable.Where<ItemScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func));
				if (_003C_003Ec._003C_003E9__49_1 == null)
				{
					func2 = (Func<ItemScript, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemScript x) => x.Item));
				}
				List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<ItemScript, Item>((IEnumerable<>)list, (Func<, >)(object)func2));
				if (list2 != null)
				{
					ItemFilter itemFilter = new ItemFilter();
					int num4 = 0;
					itemFilter.data_ = (ItemFilterData)num4;
					List<Item> list3 = (List<Item>)(object)itemFilter.ApplyFilter((IEnumerable<>)list2);
				}
				List<Item> validItems = (List<Item>)(object)new List<T>();
				Func<ItemScript, bool> func3 = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
				{
					//Discarded unreachable code: IL_0010
					List<Item> list5 = validItems;
					Item item = x.Item;
					bool result = default(bool);
					return result;
				};
				List<ItemScript> list4 = (List<ItemScript>)(object)Enumerable.ToList<ItemScript>(Enumerable.Where<ItemScript>((IEnumerable<>)list, (Func<, >)(object)func3));
				if (_003C_003Ec._003C_003E9__49_3 == null)
				{
					func4 = (Func<ItemScript, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemScript x)
					{
						while (true)
						{
							GridObjectScript component = x.GetComponent<GridObjectScript>();
							if ((object)component == null)
							{
								break;
							}
							GridObject _003CGridObject_003Ek__BackingField = component.GridObject;
							if (_003CGridObject_003Ek__BackingField != null)
							{
								GridState state_ = _003CGridObject_003Ek__BackingField.state_;
								if (state_ != null)
								{
									FlowerData flowerData = state_.FlowerData;
									int num8 = 0;
									if (flowerData != null)
									{
										bool dry_ = flowerData.dry_;
										return num8 == 0;
									}
									continue;
								}
							}
							return 0 == 0;
						}
						throw new NullReferenceException();
					});
				}
				bool flag = Enumerable.Any<ItemScript>((IEnumerable<>)Enumerable.ToList<ItemScript>(Enumerable.Where<ItemScript>((IEnumerable<>)list4, (Func<, >)(object)func4)));
				PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
				if (flag2)
				{
					break;
				}
				AlertButton[] array = new AlertButton[1];
				AlertButton alertButton = new AlertButton(AlertButtonStyle.Confirm, (string)num5, (byte)isDefaultGamepadFocus != 0);
				isDefaultGamepadFocus = 0;
				num5 = 0;
				if (alertButton == null || alertButton != null)
				{
					array[0] = alertButton;
					int num6 = 0;
					int num7 = 0;
					break;
				}
			}
			PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
			InteractWithPlayerTask(playerTaskCollider);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC820", VA = "0x1808CDE20")]
		public bool CharacterIsAvailable(Meta.Character character)
		{
			//Discarded unreachable code: IL_0018
			CharacterManager characterManager = this.characterManager;
			Item item = character.base_.Item;
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C50", Offset = "0x8D2650", VA = "0x1808D3C50")]
		public unsafe SceneType LocateCharacterScene(Meta.Character character)
		{
			//IL_0042: Expected O, but got I4
			int num = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			CharacterManager characterManager = this.characterManager;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			Item item = character.base_.Item;
			int num2 = 0;
			Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
			if (character2 != (UnityEngine.Object)num2 && character2.gameObject.activeSelf)
			{
				int num3 = 0;
			}
			if (!character.IsUnlocked)
			{
				if (!character.InEvent)
				{
					Client client = default(Client);
					DateTime localTime = client.LocalTime;
					if (!character.IsSecretCharacterVisiting(localTime) && (long)"{il2cpp array field local8->}" == 5)
					{
						GameObject gameObject = default(GameObject);
						BaseEnvironmentDoor door = gameObject.GetComponent<Mdl.Environments.Environment>().GetComponent<EnteredEnvironmentOrigin>().Door;
						CharacterItemData data = character.Data;
						int num4 = 0;
						Item universeTag = data.GetUniverseTag();
						int num5 = 0;
						int num6 = 0;
						Item item2 = default(Item);
						if (!(*(Item*)item2 != *(Item*)universeTag))
						{
							goto IL_0176;
						}
					}
				}
				if ((long)"{il2cpp array field local8->}" == 1)
				{
					goto IL_0176;
				}
			}
			BaseItem base_ = character.base_;
			CharacterManager characterManager2 = this.characterManager;
			Item item3 = base_.Item;
			ScheduleType scheduleType = default(ScheduleType);
			uint num7 = default(uint);
			if (scheduleType <= ScheduleType.PlayerHouse && (IntPtr)"{il2cpp array field local8->}" == (IntPtr)(int)num7)
			{
				GameObject gameObject2 = default(GameObject);
				ItemScript itemScript = gameObject2.GetComponent<Mdl.Environments.Environment>().GetComponent<EnteredEnvironmentOrigin>().Door.GetItemScript();
				int house = character.Data.House;
				if ((object)itemScript.Item != null)
				{
					CharacterItemData data2 = character.Data;
					string name_ = data2.name_;
					if (data2 != null)
					{
					}
					CharacterItemData data3 = character.Data;
					string name_2 = data3.name_;
					if (data3 != null && (long)"{il2cpp array field local8->}" != 6 && (long)"{il2cpp array field local8->}" != 3 && (long)"{il2cpp array field local8->}" == 8)
					{
					}
				}
			}
			goto IL_0176;
			IL_0176:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4300", Offset = "0x8D2D00", VA = "0x1808D4300")]
		public SceneType LocateCharacterWorld(Meta.Character character)
		{
			//IL_0035: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			bool inVillage = character.InVillage;
			BaseItem base_ = character.base_;
			CharacterManager characterManager = this.characterManager;
			Item item = base_.Item;
			int num = 0;
			Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
			if (character2 == (UnityEngine.Object)num || !character2.isActiveAndEnabled)
			{
				return SceneType.Castle;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE70", Offset = "0x8CC870", VA = "0x1808CDE70")]
		private void CheckRedirectionTask()
		{
			//Discarded unreachable code: IL_005c
			//IL_0026: Expected O, but got I8
			//IL_002f: Expected O, but got I4
			if (!waitingForTask && (long)goCharacter != 0)
			{
				if (targetLocation != 0)
				{
					goCharacter = (Meta.Character)0;
					int num = 0;
					goMoveGridFloorType = (GridFloorType?)(object)num;
				}
				else
				{
					GridFloorType? gridFloorType = goMoveGridFloorType;
					Meta.Character character = goCharacter;
					GoBehavior goBehavior = this.goBehavior;
					MissionSlot missionSlot = goMissionSlot;
					this.GoRedirect(goBehavior, character, true, missionSlot, (Nullable<>)gridFloorType);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D2ED0", Offset = "0x8D18D0", VA = "0x1808D2ED0")]
		public void GoToLocation(SceneType targetSceneType, Meta.Character character)
		{
			//Discarded unreachable code: IL_00bf
			int num = 0;
			if (character == null)
			{
				return;
			}
			PlayerNavigation playerNavigation = this.playerNavigation;
			PlayerNavigation.TaskCompleted value = OnPlayerNavigationTaskCompleted;
			playerNavigation.OnTaskCompleted += value;
			PlayerNavigation playerNavigation2 = this.playerNavigation;
			PlayerNavigation.TaskCancelled value2 = OnPlayerNavigationTaskCanceled;
			playerNavigation2.OnTaskCancelled += value2;
			int num2 = 0;
			waitingForTask = true;
			targetLocation = (SceneType)num2;
			bool flag = default(bool);
			if (!flag)
			{
				waitingForTask = flag;
			}
			targetLocation = SceneType.Main;
			targetLocation = SceneType.Main;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			PlayerTaskCollider[] componentsInChildren = gameObject.GetComponentsInChildren<PlayerTaskCollider>();
			Func<PlayerTaskCollider, bool> func = (Func<PlayerTaskCollider, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskCollider x)
			{
				//Discarded unreachable code: IL_001c
				IEnumerable<PlayerTaskDefinition> tasks = (IEnumerable<PlayerTaskDefinition>)x.GetTasks();
				Func<PlayerTaskDefinition, bool> cpp2il__autoParamName__idx_ = (Func<PlayerTaskDefinition, bool>)(object)(Func<T, TResult>)delegate(PlayerTaskDefinition y)
				{
					//Discarded unreachable code: IL_001b
					string taskId = y._taskId;
					string taskId2 = _taskExitEnv._taskId;
					return string.Equals(taskId, taskId2);
				};
				return ((IEnumerable<>)tasks).Any<PlayerTaskDefinition>((Func<, >)(object)cpp2il__autoParamName__idx_);
			};
			PlayerTaskCollider playerTaskCollider = Enumerable.FirstOrDefault<PlayerTaskCollider>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			InteractWithPlayerTask(playerTaskCollider);
			CheckRedirectionTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D0770", Offset = "0x8CF170", VA = "0x1808D0770")]
		private unsafe (bool, PlayerTaskCollider, SceneType) FindLocationToGo(SceneType targetSceneType, Meta.Character character)
		{
			//IL_000f: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			//IL_0191: Expected O, but got I4
			int num = 0;
			GoBehaviourSystem goBehaviourSystem = (GoBehaviourSystem)targetSceneType;
			Meta.Character character2 = default(Meta.Character);
			if ((long)character2 != 0)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				int num2 = 0;
				GameObject gameObject = default(GameObject);
				EnvironmentDoor[] componentsInChildren = gameObject.GetComponentsInChildren<EnvironmentDoor>();
				Func<EnvironmentDoor, bool> func = (Func<EnvironmentDoor, bool>)(object)(Func<T, TResult>)delegate(EnvironmentDoor x)
				{
					//Discarded unreachable code: IL_0020
					Item item5 = x.GetComponent<ItemScript>().Item;
					Item playerHouseItem = goBehaviourSystem.PlayerHouseItem;
					return *(Item*)item5 == *(Item*)playerHouseItem;
				};
				EnvironmentDoor environmentDoor = Enumerable.FirstOrDefault<EnvironmentDoor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
				if ((object)environmentDoor != null)
				{
					Transform transform = environmentDoor.transform;
				}
				GameObject gameObject2 = default(GameObject);
				EnvironmentDoor[] componentsInChildren2 = gameObject2.GetComponentsInChildren<EnvironmentDoor>();
				Func<EnvironmentDoor, bool> func2 = (Func<EnvironmentDoor, bool>)(object)(Func<T, TResult>)delegate(EnvironmentDoor x)
				{
					Item item4 = x.GetComponent<ItemScript>().Item;
					int house = character2.Data.House;
					throw new NullReferenceException();
				};
				EnvironmentDoor environmentDoor2 = Enumerable.FirstOrDefault<EnvironmentDoor>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func2);
				if ((object)environmentDoor2 != null)
				{
					Transform transform2 = environmentDoor2.transform;
				}
				GameObject gameObject3 = default(GameObject);
				EnvironmentDoor[] componentsInChildren3 = gameObject3.GetComponentsInChildren<EnvironmentDoor>();
				Func<EnvironmentDoor, bool> func3 = (Func<EnvironmentDoor, bool>)(object)(Func<T, TResult>)delegate(EnvironmentDoor x)
				{
					//Discarded unreachable code: IL_0020
					Item item3 = x.GetComponent<ItemScript>().Item;
					Item castleItem = goBehaviourSystem.CastleItem;
					return *(Item*)item3 == *(Item*)castleItem;
				};
				EnvironmentDoor environmentDoor3 = Enumerable.FirstOrDefault<EnvironmentDoor>((IEnumerable<>)(object)componentsInChildren3, (Func<, >)(object)func3);
				if ((object)environmentDoor3 != null)
				{
					Transform transform3 = environmentDoor3.transform;
				}
				GameObject gameObject4 = default(GameObject);
				EnvironmentDoor[] componentsInChildren4 = gameObject4.GetComponentsInChildren<EnvironmentDoor>();
				Func<EnvironmentDoor, bool> func4 = (Func<EnvironmentDoor, bool>)(object)(Func<T, TResult>)delegate(EnvironmentDoor x)
				{
					//Discarded unreachable code: IL_0020
					Item item2 = x.GetComponent<ItemScript>().Item;
					Item restaurantItem = goBehaviourSystem.RestaurantItem;
					return *(Item*)item2 == *(Item*)restaurantItem;
				};
				EnvironmentDoor environmentDoor4 = Enumerable.FirstOrDefault<EnvironmentDoor>((IEnumerable<>)(object)componentsInChildren4, (Func<, >)(object)func4);
				if ((object)environmentDoor4 != null)
				{
					Transform transform4 = environmentDoor4.transform;
				}
				GameObject gameObject5 = default(GameObject);
				EnvironmentDoor[] componentsInChildren5 = gameObject5.GetComponentsInChildren<EnvironmentDoor>();
				Func<EnvironmentDoor, bool> func5 = (Func<EnvironmentDoor, bool>)(object)(Func<T, TResult>)delegate(EnvironmentDoor x)
				{
					//Discarded unreachable code: IL_0020
					Item item = x.GetComponent<ItemScript>().Item;
					Item storeItem = goBehaviourSystem.StoreItem;
					return *(Item*)item == *(Item*)storeItem;
				};
				EnvironmentDoor environmentDoor5 = Enumerable.FirstOrDefault<EnvironmentDoor>((IEnumerable<>)(object)componentsInChildren5, (Func<, >)(object)func5);
				if ((object)environmentDoor5 != null)
				{
					Transform transform5 = environmentDoor5.transform;
				}
				int num3 = 0;
				if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
					if (playerTaskCollider != (UnityEngine.Object)num4)
					{
						int num5 = 0;
						int num6 = 0;
						((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num5;
						int num7 = 0;
						if ((long)character != 5)
						{
							int num8 = 0;
							int num9 = 0;
							((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num8;
						}
						PlayerTaskCollider component = GetRealmDoor(character2).GetComponent<PlayerTaskCollider>();
						int num10 = 0;
						if (component != (UnityEngine.Object)num10)
						{
							int num11 = 0;
							int num12 = 0;
							((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num11;
							int num13 = 0;
							int num14 = 0;
							((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num13;
						}
					}
				}
			}
			int num15 = 0;
			int num16 = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num15;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4910", Offset = "0x8D3310", VA = "0x1808D4910")]
		public void OnPlayerNavigationTaskCompleted(PlayerTask task, int index)
		{
			//Discarded unreachable code: IL_0029
			PlayerNavigation playerNavigation = this.playerNavigation;
			PlayerNavigation.TaskCompleted value = OnPlayerNavigationTaskCompleted;
			playerNavigation.OnTaskCompleted -= value;
			waitingForTask = false;
			CheckRedirectionTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4730", Offset = "0x8D3130", VA = "0x1808D4730")]
		public void OnPlayerNavigationTaskCanceled(PlayerTask task, int index)
		{
			//IL_002d: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			PlayerNavigation playerNavigation = this.playerNavigation;
			PlayerNavigation.TaskCancelled value = OnPlayerNavigationTaskCanceled;
			int num = 0;
			playerNavigation.OnTaskCancelled -= value;
			waitingForTask = false;
			int num2 = 0;
			goCharacter = (Meta.Character)num2;
			int num3 = 0;
			goMissionSlot = (MissionSlot)num2;
			int num4 = 0;
			goMoveGridFloorType = (GridFloorType?)(object)num4;
			if ((waitingForTask ? 1 : 0) == num2)
			{
				if (targetLocation == SceneType.Main)
				{
					GridFloorType? gridFloorType = goMoveGridFloorType;
					GoBehavior goBehavior = this.goBehavior;
					MissionSlot missionSlot = goMissionSlot;
					this.GoRedirect(goBehavior, (Meta.Character)num, true, missionSlot, (Nullable<>)gridFloorType);
					throw new NullReferenceException();
				}
				goCharacter = (Meta.Character)num2;
				goMissionSlot = (MissionSlot)num2;
				int num5 = 0;
				goMoveGridFloorType = (GridFloorType?)(object)num5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D03B0", VA = "0x1808D19B0")]
		private unsafe static GameObject GetRealmDoor(Meta.Character character)
		{
			int num = 0;
			IEnumerable<Item> itemTags = (IEnumerable<Item>)ItemDataExtensions.GetItemTags((IHasTags)character.Data);
			Func<Item, bool> _003C_003E9__58_ = _003C_003Ec._003C_003E9__58_0;
			if (_003C_003E9__58_ == null)
			{
				TagItemType tagItemType = default(TagItemType);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => tagItemType == TagItemType.Universe);
			}
			Item item = Enumerable.FirstOrDefault<Item>((IEnumerable<>)itemTags, (Func<, >)(object)_003C_003E9__58_);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			RealmEnvironmentDoor[] componentsInChildren = gameObject.GetComponentsInChildren<RealmEnvironmentDoor>();
			int length = componentsInChildren.Length;
			if (num < length)
			{
				RealmEnvironmentDoor realmEnvironmentDoor = componentsInChildren[num];
				WorldData.Types.World currentWorld = realmEnvironmentDoor.currentWorld;
				if (currentWorld == null || !(*(Item*)currentWorld.UniverseTagItem == *(Item*)item))
				{
					num++;
				}
				return realmEnvironmentDoor.gameObject;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3530", Offset = "0x8D1F30", VA = "0x1808D3530")]
		private void InteractWithLock(VillageAreaType areaType)
		{
			//IL_0018: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			int num = 0;
			VillageAreaLock areaLock = (VillageAreaLock)num;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			GridScript[] array = ((IEnumerable<>)(object)gameObject.GetComponentsInChildren<GridScript>()).ToArray<GridScript>();
			int length = array.Length;
			if (num < length)
			{
				VillageArea component = array[num].GetComponent<VillageArea>();
				if ((object)component != null && component._areaType == areaType)
				{
					int size = ((List<>)(object)component._entryPoints)._size;
				}
				num++;
				areaLock = (VillageAreaLock)(object)sceneItemData._unknownFields.lastField;
			}
			VillageAreaLock villageAreaLock = areaLock;
			int num2 = 0;
			if (!(villageAreaLock == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				bool useDebugGoButton = DebugSettings.Settings.UseDebugGoButton;
				VillageAreaLock villageAreaLock2 = areaLock;
				if (!useDebugGoButton)
				{
					Transform target = default(Transform);
					trailSystem.Target = target;
					throw new NullReferenceException();
				}
				Transform transform = villageAreaLock2.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Func<Task> func = (Func<Task>)(object)(Func<TResult>)delegate
				{
					//Discarded unreachable code: IL_003b
					GoBehaviourSystem goBehaviourSystem = this;
					VillageAreaLock villageAreaLock3 = areaLock;
					PlayerNavigation playerNavigation = goBehaviourSystem.playerNavigation;
					Transform transform2 = villageAreaLock3.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					bool flag = areaLock.Interact();
					int num4 = 0;
					return Task.CompletedTask;
				};
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D44D0", Offset = "0x8D2ED0", VA = "0x1808D44D0")]
		[AsyncStateMachine(typeof(_003CMoveCameraBeforeRedirectTask_003Ed__60))]
		private Task MoveCameraBeforeRedirectTask(Vector3 target, Func<Task> redirectTask)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3980", Offset = "0x8D2380", VA = "0x1808D3980")]
		private void InteractWithPlayerTask(Component targetComp)
		{
			//Discarded unreachable code: IL_000f
			PlayerTaskCollider component = targetComp.GetComponent<PlayerTaskCollider>();
			InteractWithPlayerTask(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D39E0", Offset = "0x8D23E0", VA = "0x1808D39E0")]
		private void InteractWithPlayerTask(PlayerTaskCollider playerTaskCollider)
		{
			//Discarded unreachable code: IL_0091
			//IL_0048: Expected O, but got I4
			int num = 0;
			bool useDebugGoButton = DebugSettings.Settings.UseDebugGoButton;
			PlayerTaskCollider playerTaskCollider2 = playerTaskCollider;
			if (useDebugGoButton)
			{
				Mdl.Characters.Character character2 = default(Mdl.Characters.Character);
				Mdl.Characters.Character character = character2;
				Mdl.Characters.Character character3 = character;
				int num2 = 0;
				if (character3 != (UnityEngine.Object)num2)
				{
					character.TalkingToRequestor = true;
				}
				Transform destination = playerTaskCollider.Destination;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Func<Task> func = (Func<Task>)(object)(Func<TResult>)delegate
				{
					//IL_0010: Expected O, but got I4
					Mdl.Characters.Character character4 = character;
					int num3 = 0;
					if (character4 != (UnityEngine.Object)num3)
					{
						Mdl.Characters.Character character5 = character;
						int num4 = ((character5.TalkingToRequestor = false) ? 1 : 0);
					}
					GoBehaviourSystem goBehaviourSystem = this;
					PlayerTaskCollider playerTaskCollider3 = playerTaskCollider;
					PlayerNavigation playerNavigation = goBehaviourSystem.playerNavigation;
					PlayerTaskDefinition playerTaskDefinition = Enumerable.First<PlayerTaskDefinition>(playerTaskCollider3.GetAllTasks());
					GoBehaviourSystem goBehaviourSystem2 = this;
					PlayerTaskCollider playerTaskCollider4 = playerTaskCollider;
					CancellationToken cancellationToken = goBehaviourSystem2.cancellationTokenProvider.CancellationToken;
					Task<int> task = (Task<int>)(object)playerNavigation.QueueTask(playerTaskDefinition, playerTaskCollider4, cancellationToken);
					throw new NullReferenceException();
				};
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			else
			{
				Transform target = default(Transform);
				trailSystem.Target = target;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D5040", Offset = "0x8D3A40", VA = "0x1808D5040")]
		private unsafe void TaskGoto(PlayerTaskCollider playerTaskCollider, float distance)
		{
			int num = 0;
			bool useDebugGoButton = DebugSettings.Settings.UseDebugGoButton;
			PlayerTaskCollider playerTaskCollider2 = playerTaskCollider;
			if (useDebugGoButton)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Func<Task> func = (Func<Task>)(object)(Func<TResult>)delegate
				{
					float num2 = distance;
					Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
					Transform transform = playerTaskCollider.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					float num3 = default(float);
					if (!(num3 <= num2))
					{
						Transform destination = playerTaskCollider.Destination;
						Vector3 vector3 = default(Vector3);
						float z3 = vector3.z;
						NavMeshPath navMeshPath = new NavMeshPath();
						Transform _003Ctransform_003Ek__BackingField2 = SystemRoot.Instance._avatar.transform;
						Vector3 vector4 = default(Vector3);
						float z4 = vector4.z;
						int walkableMask = SystemRoot.Instance._avatar.Agent.walkableMask;
						int num4 = 0;
						bool flag = default(bool);
						if (flag)
						{
							Transform destination2 = playerTaskCollider.Destination;
							Vector3 vector5 = default(Vector3);
							float z5 = vector5.z;
							int num5 = 0;
							bool flag2 = default(bool);
							if (flag2)
							{
								Vector3[] corners = navMeshPath.corners;
								int length = navMeshPath.corners.Length;
								Vector3[] corners2 = navMeshPath.corners;
								int num6 = 0;
								Vector3[] corners3 = navMeshPath.corners;
								int num7 = length + 1;
								if (MathExtensions.DistanceSq(in *(Vector3*)corners3, in *(Vector3*)num6) > num2)
								{
									throw new NullReferenceException();
								}
							}
						}
						PlayerNavigation playerNavigation = this.playerNavigation;
					}
					int num8 = 0;
					return Task.CompletedTask;
				};
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				return;
			}
			Transform target = default(Transform);
			trailSystem.Target = target;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CDFC0", Offset = "0x8CC9C0", VA = "0x1808CDFC0")]
		[AsyncStateMachine(typeof(_003CEndOfMissionFlow_003Ed__64))]
		public Task EndOfMissionFlow(Meta.Character character)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D49B0", Offset = "0x8D33B0", VA = "0x1808D49B0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_00bc
			PlayerNavigation playerNavigation = (this.playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
			CharacterManager characterManager = (this.characterManager = SystemRoot.Instance.GetSystem<CharacterManager>());
			TrailSystem trailSystem = (this.trailSystem = SystemRoot.Instance.GetSystem<TrailSystem>());
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = this.GetOrAddComponent<CancellationTokenProvider>());
			TrailSystem trailSystem2 = this.trailSystem;
			EventHandler value = TrailSystem_TargetChangedEvent;
			trailSystem2.TrailSystemTargetChanged += value;
			TrailSystem trailSystem3 = this.trailSystem;
			EventHandler value2 = TrailSystem_AutoCancelledEvent;
			trailSystem3.TrailSystemAutoCancelled += value2;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += Environment_AnyEnvironmentEnteredEvent;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionCurrentStepChanged value3 = OnMissionCurrentStepChanged;
			_003CDispatcher_003Ek__BackingField.OnMissionCurrentStepChanged += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D80", Offset = "0x8D3780", VA = "0x1808D4D80", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0086
			//IL_005a: Expected O, but got I4
			TrailSystem trailSystem = this.trailSystem;
			EventHandler value = TrailSystem_TargetChangedEvent;
			trailSystem.TrailSystemTargetChanged -= value;
			TrailSystem trailSystem2 = this.trailSystem;
			EventHandler value2 = TrailSystem_AutoCancelledEvent;
			trailSystem2.TrailSystemAutoCancelled -= value2;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.MissionCurrentStepChanged value3 = OnMissionCurrentStepChanged;
				_003CDispatcher_003Ek__BackingField.OnMissionCurrentStepChanged -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public GoBehaviourSystem()
		{
		}
	}
}
