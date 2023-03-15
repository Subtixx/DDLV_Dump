using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Scene;
using Mdl.Activities;
using Mdl.Buildings;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Items;
using Mdl.Missions;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees.Gameloft.Flux
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[Category("Branch")]
	[Description("Prompt a Flux Greeting Dialogue Switcher. It will automatically add request and discussion options if they are available.")]
	[Color("10ADF6")]
	[Name("Flux Greeting Dialogue Switcher", 0)]
	[Icon("List", false, "")]
	public class FluxGreetingDialogueSwitcherNode : DTNode, ISubTasksContainer
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private static class Options
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			public static class Indexes
			{
				[Cpp2IlInjected.Token(Token = "0x40004AD")]
				public const int Discussion = 100;

				[Cpp2IlInjected.Token(Token = "0x40004AE")]
				public const int Gift = 200;

				[Cpp2IlInjected.Token(Token = "0x40004AF")]
				public const int Hangout = 220;

				[Cpp2IlInjected.Token(Token = "0x40004B0")]
				public const int HangoutLocked = 221;

				[Cpp2IlInjected.Token(Token = "0x40004B1")]
				public const int HangoutWithoutProfession = 222;

				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				public const int RestaurantOrder = 300;

				[Cpp2IlInjected.Token(Token = "0x40004B3")]
				public const int Target = 400;

				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				public const int Give = 500;

				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				public const int StoreDelivery = 600;

				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				public const int Visit = 700;

				[Cpp2IlInjected.Token(Token = "0x40004B7")]
				public const int VisitLocked = 701;

				[Cpp2IlInjected.Token(Token = "0x40004B8")]
				public const int RequestLocked = 999;

				[Cpp2IlInjected.Token(Token = "0x40004B9")]
				public const int Request = 1000;
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x11DA710", Offset = "0x11D9110", VA = "0x1811DA710")]
			public static StoreEnvironment.OwnerDialogue AddStoreOwnerDelivery(Dictionary<IStatement, int> options, bool showNonMissionChoice, SceneType currentSceneType, Item? currentStoreOwner, Item characterItem, IBlackboard bb)
			{
				//Discarded unreachable code: IL_0036
				int num = 0;
				if (showNonMissionChoice && currentSceneType == SceneType.Store && currentStoreOwner != null && currentStoreOwner != null)
				{
					FluxStatement fluxStatement = new FluxStatement();
					fluxStatement._locId = "menu.Delivery_Dialogue_Text";
					fluxStatement._meta = "icon_shop";
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x11D94F0", Offset = "0x11D7EF0", VA = "0x1811D94F0")]
			public static void AddCompletedMissions(Dictionary<IStatement, int> options, Item characterItem, MissionManager missionManager, HashSet<MissionSlot> usedMissionSlots, IBlackboard bb)
			{
				//Discarded unreachable code: IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f, IL_0125
				int num = 0;
				Func<MissionSlot, bool> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => default(bool));
				}
				IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
				IEnumerable<MissionSlot> enumerable2 = (IEnumerable<MissionSlot>)Enumerable.Where<MissionSlot>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__2_);
				string text2 = default(string);
				string[] array = default(string[]);
				string text3 = default(string);
				FluxStatement fluxStatement4 = default(FluxStatement);
				if (enumerable2 != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_00a3;
						}
						num++;
					}
					bool flag = default(bool);
					while (flag)
					{
					}
					FluxStatement fluxStatement = new FluxStatement();
					MissionItemData missionItemData = default(MissionItemData);
					string text = (fluxStatement._locId = missionItemData.displayName_);
					FluxStatement fluxStatement2 = default(FluxStatement);
					text2 = fluxStatement2._text;
					FluxStatement fluxStatement3 = new FluxStatement();
					fluxStatement3._locId = "menu.common_complete";
					fluxStatement3._meta = "icon_request_completed";
					array = new string[2];
					text3 = fluxStatement4._text;
					if (text3 != null && array == null)
					{
						throw new IndexOutOfRangeException();
					}
					goto IL_00a3;
				}
				if (enumerable2 == null)
				{
				}
				return;
				IL_00a3:
				array[0] = text3;
				if (text2 == null || array != null)
				{
					array[1] = text2;
					string text4 = (fluxStatement4._text = string.Join(" ", array));
					throw new NullReferenceException();
				}
				throw new IndexOutOfRangeException();
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x11DA950", Offset = "0x11D9350", VA = "0x1811DA950")]
			public static void AddTargetedMissions(Dictionary<IStatement, int> options, Item characterItem, MissionManager missionManager, HashSet<MissionSlot> usedMissionSlots, IBlackboard bb)
			{
				//Discarded unreachable code: IL_0051, IL_006c, IL_0072, IL_0078, IL_007e, IL_0084, IL_008a, IL_0090
				int num = 0;
				IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
				if (enumerable != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0060;
						}
						num++;
					}
					MissionSlot item = default(MissionSlot);
					if (!((HashSet<T>)(object)usedMissionSlots).Contains((T)item))
					{
						FluxStatement fluxStatement = new FluxStatement();
						MissionSlot missionSlot = default(MissionSlot);
						string text = (fluxStatement._locId = missionSlot.Data.displayName_);
						fluxStatement._meta = "icon_request_ongoing";
						throw new NullReferenceException();
					}
					uint num3 = num3 + 1;
					goto IL_0060;
				}
				goto IL_0067;
				IL_0067:
				if (enumerable == null)
				{
				}
				return;
				IL_0060:
				MissionSlot missionSlot2 = (MissionSlot)(object)((object)missionSlot2 + (object)missionSlot2);
				goto IL_0067;
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x11D9F80", Offset = "0x11D8980", VA = "0x1811D9F80")]
			public static void AddReadyToGiveItems(Dictionary<IStatement, int> options, Item characterItem, MissionManager missionManager, HashSet<MissionSlot> usedMissionSlots, IBlackboard bb)
			{
				//Discarded unreachable code: IL_0041, IL_0046, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072
				int num = 0;
				IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
				if (enumerable != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							enumerable = (IEnumerable<MissionSlot>)(object)((object)enumerable + (object)enumerable);
							goto IL_004f;
						}
						num++;
					}
					FluxStatement fluxStatement = new FluxStatement();
					MissionItemData missionItemData = default(MissionItemData);
					string text = (fluxStatement._locId = missionItemData.displayName_);
					fluxStatement._meta = "icon_request_ongoing";
					throw new NullReferenceException();
				}
				goto IL_004f;
				IL_004f:
				if (enumerable == null)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x11D93C0", Offset = "0x11D7DC0", VA = "0x1811D93C0")]
			public static void AddCharacterRestaurantOrder(Dictionary<IStatement, int> options, Mdl.Characters.Character character, bool showNonMissionChoice, out CharacterRestaurantOrder restaurantOrder, IBlackboard bb)
			{
				//Discarded unreachable code: IL_0031
				if (showNonMissionChoice && character.CanServeRestaurantOrder(out restaurantOrder))
				{
					FluxStatement fluxStatement = new FluxStatement();
					fluxStatement._locId = "menu.Give_Restaurant_Order";
					fluxStatement._meta = "icon_restaurant_order";
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x11D9A50", Offset = "0x11D8450", VA = "0x1811D9A50")]
			public static DialogueItemData AddDailyUndiscussed(Dictionary<IStatement, int> options, Mdl.Characters.Character character, CharacterManager characterManager, IBlackboard bb)
			{
				//IL_004f: Expected O, but got I4
				int num = 0;
				if (!character.DiscussedWithTheAvatarToday)
				{
					int iD = character.Data.ID;
					DialogueItemData dialogueItemData = default(DialogueItemData);
					if (dialogueItemData != null)
					{
						string displayName_ = dialogueItemData.displayName_;
						FluxStatement fluxStatement = new FluxStatement();
						fluxStatement._locId = displayName_;
						fluxStatement._meta = "icon_discussion";
						int checkText = 0;
						int num2 = 0;
						FluxStatement fluxStatement2 = fluxStatement.BlackboardReplace(bb, (MissionSlot)num2, (byte)checkText != 0);
						throw new NullReferenceException();
					}
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x11D9BA0", Offset = "0x11D85A0", VA = "0x1811D9BA0")]
			public static void AddGiftItem(Dictionary<IStatement, int> options, Mdl.Characters.Character character, IBlackboard bb)
			{
				//Discarded unreachable code: IL_003b
				//IL_0032: Expected O, but got I4
				if (character.CanGiftItem)
				{
					FluxStatement fluxStatement = new FluxStatement();
					fluxStatement._locId = "menu.Give_Dialogue_Text";
					fluxStatement._meta = "icon_gift";
					int checkText = 0;
					int num = 0;
					FluxStatement fluxStatement2 = fluxStatement.BlackboardReplace(bb, (MissionSlot)num, (byte)checkText != 0);
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x11D9CA0", Offset = "0x11D86A0", VA = "0x1811D9CA0")]
			public unsafe static void AddHangout(Dictionary<IStatement, int> options, Mdl.Characters.Character character, HangoutSystem hangoutSystem, IBlackboard bb)
			{
				//IL_005c: Expected O, but got I4
				//IL_0070: Expected I4, but got O
				//IL_007b: Expected I4, but got O
				bool flag = hangoutSystem.CanHangoutWithAvatar(character);
				if (!flag)
				{
					return;
				}
				if (!hangoutSystem.IsHangingOutWithAvatar(character))
				{
					if (!hangoutSystem.IsHangoutLockedForCharacter(character))
					{
						if (character.MetaCharacter.Profession != null)
						{
							FluxStatement fluxStatement = new FluxStatement();
							fluxStatement._locId = "menu.Start_Hangout_Text";
							fluxStatement._meta = "icon_hangout_start";
							int checkText = 0;
							int num = 0;
							FluxStatement fluxStatement2 = fluxStatement.BlackboardReplace(bb, (MissionSlot)num, (byte)checkText != 0);
							throw new NullReferenceException();
						}
						((bool*)(flag ? 1 : 0))->m_value = (byte)(int)"menu.Start_Hangout_Text" != 0;
						((bool*)(flag ? 1 : 0))->m_value = (byte)(int)"icon_hangout_start_without_profession" != 0;
					}
					FluxStatement fluxStatement3 = new FluxStatement();
					fluxStatement3._locId = "menu.Locked_Hangout_Text";
					fluxStatement3._meta = "icon_hangout_start_locked";
				}
				new FluxStatement()._locId = "menu.Stop_Hangout_Text";
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x11DAC50", Offset = "0x11D9650", VA = "0x1811DAC50")]
			public static void AddVisitAquaticHouse(Dictionary<IStatement, int> options, Mdl.Characters.Character character, IBlackboard bb)
			{
				//Discarded unreachable code: IL_0046
				//IL_003d: Expected O, but got I4
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				if (character.HasAquaticHouse && character.IsHouseInVillage)
				{
					FluxStatement fluxStatement = new FluxStatement();
					fluxStatement._locId = "menu.Visit_Aquatic_Text";
					int checkText = 0;
					int num = 0;
					FluxStatement fluxStatement2 = fluxStatement.BlackboardReplace(bb, (MissionSlot)num, (byte)checkText != 0);
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x11DA250", Offset = "0x11D8C50", VA = "0x1811DA250")]
			public static void AddRemainingMissionsOfInterest(Dictionary<IStatement, int> options, Mdl.Characters.Character character, MissionManager missionManager, HashSet<MissionSlot> usedMissionSlots, QuestInformation questInformation, IBlackboard bb)
			{
				//Discarded unreachable code: IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1, IL_00f7, IL_00fd
				//IL_005b: Expected O, but got I4
				//IL_0073: Expected O, but got I4
				int num = 0;
				if (!character.InVillage && !character.IsInRealm && !character.InEvent)
				{
					return;
				}
				Item _003CItem_003Ek__BackingField = character.Item;
				IEnumerable<(MissionSlot, MissionSlotState, string)> missionDialogChoices = (IEnumerable<(MissionSlot, MissionSlotState, string)>)missionManager.GetMissionDialogChoices(_003CItem_003Ek__BackingField);
				FluxStatement fluxStatement = default(FluxStatement);
				string text = default(string);
				if (missionDialogChoices != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0064;
						}
						num++;
					}
					num++;
					bool flag = default(bool);
					while (flag)
					{
					}
					fluxStatement = new FluxStatement();
					fluxStatement._text = (string)0;
					fluxStatement._meta = text;
					goto IL_0064;
				}
				int num3 = 0;
				if (missionDialogChoices != null)
				{
				}
				if (num == 0)
				{
					int num4 = 0;
					bool flag2 = default(bool);
					IEnumerable<MissionSlot> enumerable = default(IEnumerable<MissionSlot>);
					bool flag3 = default(bool);
					if (flag2 && !Enumerable.Any<MissionSlot>((IEnumerable<>)enumerable) && flag3)
					{
						FluxStatement fluxStatement2 = new FluxStatement();
						fluxStatement2._locId = "menu.Locked_KeepPlaying_Text";
						fluxStatement2._meta = "icon_request_locked";
						throw new NullReferenceException();
					}
				}
				return;
				IL_0064:
				text += text;
				fluxStatement._text = (string)0;
				fluxStatement._meta = "icon_request_ongoing";
				throw new NullReferenceException();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Exit
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			public bool isUnfolded = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			public FluxStatement statement;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public ConditionTask condition;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x11D92E0", Offset = "0x11D7CE0", VA = "0x1811D92E0")]
			public Exit()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x11D92A0", Offset = "0x11D7CA0", VA = "0x1811D92A0")]
			public Exit(FluxStatement statement)
			{
				this.statement = statement;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		[SerializeField]
		private string animation = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[SerializeField]
		private Switch voOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[SliderField(0f, 10f)]
		public float availableTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool saySelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public List<Exit> availableExits = (List<Exit>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public FluxStatement additionalQuote = new FluxStatement("");

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public bool sayAdditionalQuote;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private string errorMessage = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public bool AutoSelectOnlyOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DialogueItemData selectedDiscussion;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private CharacterRestaurantOrder restaurantOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private StoreEnvironment.OwnerDialogue storeOwnerDialogueData;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public override int maxOutConnections
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x145A8F0", Offset = "0x14592F0", VA = "0x18145A8F0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)availableExits)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override bool requireActorSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "39")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private MissionManager MissionManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x145A830", Offset = "0x1459230", VA = "0x18145A830")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<MissionManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private HangoutSystem HangoutSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x145A770", Offset = "0x1459170", VA = "0x18145A770")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<HangoutSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1458050", Offset = "0x1456A50", VA = "0x181458050", Slot = "40")]
		public NodeCanvas.Framework.Task[] GetSubTasks()
		{
			List<Exit> list;
			do
			{
				list = availableExits;
			}
			while (list == null);
			Func<Exit, ConditionTask> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
			if (_003C_003E9__11_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Exit c) => c.condition);
			}
			ConditionTask[] array = Enumerable.Select<Exit, ConditionTask>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__11_).ToArray<ConditionTask>();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x14582C0", Offset = "0x1456CC0", VA = "0x1814582C0", Slot = "27")]
		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x1457A60", Offset = "0x1456460", VA = "0x181457A60")]
		private Dictionary<IStatement, int> GetAvailableOptions(Mdl.Characters.Character character, IBlackboard bb)
		{
			//Discarded unreachable code: IL_0142
			//IL_009d: Expected O, but got I4
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Dictionary<IStatement, int> dictionary = (Dictionary<IStatement, int>)(object)new Dictionary<TKey, TValue>();
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			bool areSwitcherButtonsUnlocked = character.AreSwitcherButtonsUnlocked;
			HashSet<MissionSlot> hashSet = (HashSet<MissionSlot>)(object)new HashSet<T>();
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			int num = 0;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			StoreEnvironment component = gameObject.GetComponent<StoreEnvironment>();
			if ((object)component != null)
			{
				Item storeOwnerItem = component.StoreOwnerItem;
				int num2 = 0;
				int itemID = storeOwnerItem.ItemID;
			}
			int num3 = 0;
			Item _003CItem_003Ek__BackingField = character.Item;
			StoreEnvironment.OwnerDialogue ownerDialogue = (storeOwnerDialogueData = Options.AddStoreOwnerDelivery((Dictionary<, >)(object)dictionary, areSwitcherButtonsUnlocked, (SceneType)num, (Nullable<>)num3, _003CItem_003Ek__BackingField, bb));
			Item _003CItem_003Ek__BackingField2 = character.Item;
			MissionManager missionManager = MissionManager;
			Item _003CItem_003Ek__BackingField3 = character.Item;
			MissionManager missionManager2 = MissionManager;
			Item _003CItem_003Ek__BackingField4 = character.Item;
			MissionManager missionManager3 = MissionManager;
			if (areSwitcherButtonsUnlocked && character.InVillage)
			{
				DialogueItemData dialogueItemData = (selectedDiscussion = Options.AddDailyUndiscussed((Dictionary<, >)(object)dictionary, character, system, bb));
				Options.AddGiftItem((Dictionary<, >)(object)dictionary, character, bb);
				HangoutSystem system2 = SystemRoot.Instance.GetSystem<HangoutSystem>();
				Options.AddHangout((Dictionary<, >)(object)dictionary, character, system2, bb);
				Options.AddVisitAquaticHouse((Dictionary<, >)(object)dictionary, character, bb);
			}
			MissionManager missionManager4 = MissionManager;
			QuestInformation questInfo_ = profile.world_.questInfo_;
			Options.AddRemainingMissionsOfInterest((Dictionary<, >)(object)dictionary, character, missionManager4, (HashSet<>)(object)hashSet, questInfo_, bb);
			return dictionary;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x1458B70", Offset = "0x1457570", VA = "0x181458B70")]
		private void OnOptionSelected(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1458D10", Offset = "0x1457710", VA = "0x181458D10")]
		[AsyncStateMachine(typeof(_003CSelectProfessionAndHangout_003Ed__24))]
		private System.Threading.Tasks.Task SelectProfessionAndHangout()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1459820", Offset = "0x1458220", VA = "0x181459820")]
		[AsyncStateMachine(typeof(_003CStartRequestDialog_003Ed__25))]
		private System.Threading.Tasks.Task StartRequestDialog(Item missionItem)
		{
			int itemID = missionItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1459940", Offset = "0x1458340", VA = "0x181459940")]
		[AsyncStateMachine(typeof(_003CStartTargetDialog_003Ed__26))]
		private System.Threading.Tasks.Task StartTargetDialog(int index)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1459290", Offset = "0x1457C90", VA = "0x181459290")]
		private System.Threading.Tasks.Task StartGiveItems(int index)
		{
			//Discarded unreachable code: IL_0073
			//IL_0058: Expected O, but got I4
			List<DialogueTree.ActorParameter> actorParameters = base.DLGTree._actorParameters;
			Func<DialogueTree.ActorParameter, bool> _003C_003E9__27_ = _003C_003Ec._003C_003E9__27_0;
			if (_003C_003E9__27_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DialogueTree.ActorParameter x) => x._keyName != "INSTIGATOR");
			}
			DialogueTree.ActorParameter actorParameter = Enumerable.FirstOrDefault<DialogueTree.ActorParameter>((IEnumerable<>)actorParameters, (Func<, >)(object)_003C_003E9__27_);
			if (actorParameter != null)
			{
				int num = 0;
				if (actorParameter.actor != null)
				{
					int num2 = 0;
				}
			}
			int num3 = 0;
			int num4 = 0;
			MissionSlot missionSlot = Enumerable.First<MissionSlot>(Enumerable.Skip<MissionSlot>(MissionManager.GetSlotsWithTargetCharacterReadyToGiveItems((Item)num4), index));
			IBlackboard blackboard = base.graphBlackboard;
			int num5 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1459050", Offset = "0x1457A50", VA = "0x181459050")]
		[AsyncStateMachine(typeof(_003CStartDialogueAsync_003Ed__28))]
		private System.Threading.Tasks.Task StartDialogueAsync(IDialogueItemData selectedDiscussion, bool isDiscussion, bool waitForEnd = false)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1459190", Offset = "0x1457B90", VA = "0x181459190")]
		[AsyncStateMachine(typeof(_003CStartGift_003Ed__29))]
		private System.Threading.Tasks.Task StartGift()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x14595D0", Offset = "0x1457FD0", VA = "0x1814595D0")]
		[AsyncStateMachine(typeof(_003CStartHangout_003Ed__30))]
		private System.Threading.Tasks.Task StartHangout(Mdl.Characters.Character character, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1459A50", Offset = "0x1458450", VA = "0x181459A50")]
		[AsyncStateMachine(typeof(_003CStopHangout_003Ed__31))]
		private System.Threading.Tasks.Task StopHangout(Mdl.Characters.Character character, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1459B80", Offset = "0x1458580", VA = "0x181459B80")]
		[AsyncStateMachine(typeof(_003CToggleHangout_003Ed__34))]
		private System.Threading.Tasks.Task ToggleHangout()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1459CB0", Offset = "0x14586B0", VA = "0x181459CB0")]
		private void VisitAquaticHouse()
		{
			//Discarded unreachable code: IL_018c
			//IL_0066: Expected O, but got I4
			//IL_00a1: Expected I4, but got I8
			//IL_00c8: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_018b: Expected I4, but got I8
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			ulong num3 = default(ulong);
			bool flag = default(bool);
			IPlayerTaskData[] array2 = default(IPlayerTaskData[]);
			while (true)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				List<DialogueTree.ActorParameter> actorParameters = base.DLGTree._actorParameters;
				Func<DialogueTree.ActorParameter, bool> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
				if (_003C_003E9__35_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DialogueTree.ActorParameter x) => x.ID != "INSTIGATOR");
				}
				DialogueTree.ActorParameter actorParameter = Enumerable.FirstOrDefault<DialogueTree.ActorParameter>((IEnumerable<>)actorParameters, (Func<, >)(object)_003C_003E9__35_);
				if (actorParameter != null)
				{
					IDialogueActor actor = actorParameter.actor;
				}
				int num = 0;
				if (num == 0)
				{
				}
				int num2 = 0;
				Mdl.Characters.Character character = (Mdl.Characters.Character)num;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				if (_003C_003Ec._003C_003E9__35_1 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SceneData x) => (long)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1);
				}
				SceneItemData sceneItemData = sceneData.sceneItemData;
				ItemScript[] componentsInChildren = gameObject.GetComponentsInChildren<ItemScript>((byte)num3 != 0);
				Func<ItemScript, bool> func = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
				{
					Item item = x.Item;
					int house = character.Data.House;
					throw new NullReferenceException();
				};
				ItemScript itemScript = Enumerable.FirstOrDefault<ItemScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
				int num4 = 0;
				if (itemScript != (UnityEngine.Object)num4)
				{
					UpgradeBuildingData componentInChildren = itemScript.GetComponentInChildren<UpgradeBuildingData>();
				}
				int num5 = 0;
				int num6 = 0;
				if ((UnityEngine.Object)num5 != (UnityEngine.Object)num6)
				{
				}
				int num7 = 0;
				int num8 = 0;
				if (!((UnityEngine.Object)num5 != (UnityEngine.Object)num8) || !flag || !(UnityEngine.Object)num7)
				{
					break;
				}
				int num9 = 0;
				if (!((UnityEngine.Object)num5 != (UnityEngine.Object)num9))
				{
					break;
				}
				IPlayerTaskData[] array = new IPlayerTaskData[1];
				UpgradeAquaticBuildingData upgradeAquaticBuildingData = new UpgradeAquaticBuildingData();
				if (upgradeAquaticBuildingData == null || upgradeAquaticBuildingData != null)
				{
					array[0] = upgradeAquaticBuildingData;
					IPlayerTaskData playerTaskData = Enumerable.Concat<IPlayerTaskData>((IEnumerable<>)(object)array2, (IEnumerable<>)(object)array).ToArray<IPlayerTaskData>()[1];
					break;
				}
			}
			bool flag2 = default(bool);
			EnvironmentDoor environmentDoor = default(EnvironmentDoor);
			if (flag2 && (bool)environmentDoor)
			{
				SceneItemData sceneItemData2 = environmentDoor.SceneItemData;
				ItemScript itemScript2 = environmentDoor.GetItemScript();
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				playerNavigation.EnterSceneItem(sceneItemData2, itemScript2);
			}
			ulong num10 = default(ulong);
			base.DLGTree.Stop((byte)num10 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1459700", Offset = "0x1458100", VA = "0x181459700")]
		[AsyncStateMachine(typeof(_003CStartMissionGift_003Ed__36))]
		private System.Threading.Tasks.Task StartMissionGift(Mdl.Characters.Character character, MissionSlot missionSlot, IBlackboard bb)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x14581C0", Offset = "0x1456BC0", VA = "0x1814581C0")]
		[AsyncStateMachine(typeof(_003CGiveRestaurantOrder_003Ed__37))]
		private System.Threading.Tasks.Task GiveRestaurantOrder()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x1458E10", Offset = "0x1457810", VA = "0x181458E10")]
		private System.Threading.Tasks.Task StartDeliveryFlow()
		{
			//Discarded unreachable code: IL_006f
			//IL_0066: Expected I4, but got I8
			IBlackboard blackboard = base.graphBlackboard;
			StoreEnvironment.OwnerDialogue ownerDialogue = storeOwnerDialogueData;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			DialogueTree dialogueTree = storeOwnerDialogueData.DialogueTree;
			int num3 = 0;
			DialogueTree dialogueTree2 = default(DialogueTree);
			if (blackboard != null)
			{
				dialogueTree2 = UnityEngine.Object.Instantiate(dialogueTree);
			}
			Component component = base.graphAgent;
			IBlackboard blackboard2 = base.graphBlackboard;
			Action<bool> action = (Action<bool>)(object)(Action<T>)delegate(bool success)
			{
				//Discarded unreachable code: IL_000d
				base.DLGTree.Stop(success);
			};
			ulong num4 = default(ulong);
			((Graph)dialogueTree2).StartGraph(component, blackboard2, (byte)num4 != 0, (Action<>)(object)action);
			int num5 = 0;
			return System.Threading.Tasks.Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x145A660", Offset = "0x1459060", VA = "0x18145A660")]
		public FluxGreetingDialogueSwitcherNode()
		{
		}
	}
}
