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
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Dialogues;
using Mdl.Environments;
using Mdl.Furnitures;
using Mdl.Grid;
using Mdl.Missions;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Missions;
using Meta.Online;
using NodeCanvas.BehaviourTrees;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x200085D")]
	public class CharacterManager : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x200085E")]
		public class CharacterInstance
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002F34")]
			public readonly CharacterItemData Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002F35")]
			private readonly CharacterManager characterManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002F36")]
			private readonly CharacterSkinItemData[] characterSkinItemDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4002F37")]
			private readonly CharacterSkinItemData[] selectableCharacterSkinItemDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002F38")]
			private Meta.Character _metaCharacter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4002F3B")]
			private int chosenCharacterSkinIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4002F3C")]
			private int activeCharacterSkinIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4002F3E")]
			private readonly SharedTask sharedLoadTask;

			[Cpp2IlInjected.Token(Token = "0x170005CB")]
			public Meta.Character MetaCharacter
			{
				[Cpp2IlInjected.Token(Token = "0x600271E")]
				[Cpp2IlInjected.Address(RVA = "0x17837D0", Offset = "0x17821D0", VA = "0x1817837D0")]
				get
				{
					//Discarded unreachable code: IL_003b
					Meta.Character metaCharacter = _metaCharacter;
					if (metaCharacter == null)
					{
						Profile profile = SystemRoot.Instance.MetaClient.profile;
						CharacterItemData data = Data;
						ProfileWorld world_ = profile.world_;
						int iD = data.ID;
						Meta.Character metaCharacter2 = default(Meta.Character);
						_metaCharacter = metaCharacter2;
					}
					return metaCharacter;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005CC")]
			public Character Character
			{
				[Cpp2IlInjected.Token(Token = "0x600271F")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CCharacter_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6002720")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				private set
				{
					_003CCharacter_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005CD")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4002F3A")]
			public bool MustStayLoaded
			{
				[Cpp2IlInjected.Token(Token = "0x6002721")]
				[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6002722")]
				[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x170005CE")]
			public bool Active
			{
				[Cpp2IlInjected.Token(Token = "0x6002723")]
				[Cpp2IlInjected.Address(RVA = "0x17836A0", Offset = "0x17820A0", VA = "0x1817836A0")]
				get
				{
					//Discarded unreachable code: IL_0028
					//IL_0010: Expected O, but got I4
					Character character = Character;
					int num = 0;
					bool flag = character != (UnityEngine.Object)num;
					if (!flag)
					{
						return flag;
					}
					return Character.gameObject.activeSelf;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005CF")]
			public bool IsShown
			{
				[Cpp2IlInjected.Token(Token = "0x6002725")]
				[Cpp2IlInjected.Address(RVA = "0x1783740", Offset = "0x1782140", VA = "0x181783740")]
				get
				{
					//Discarded unreachable code: IL_0023
					//IL_0010: Expected O, but got I4
					Character character = Character;
					int num = 0;
					bool flag = character != (UnityEngine.Object)num;
					if (!flag)
					{
						return flag;
					}
					return Character.IsShown;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005D0")]
			public CharacterSkinItemData ActiveCharacterSkin
			{
				[Cpp2IlInjected.Token(Token = "0x6002726")]
				[Cpp2IlInjected.Address(RVA = "0x1783660", Offset = "0x1782060", VA = "0x181783660")]
				get
				{
					int num = activeCharacterSkinIndex;
					return Enumerable.ElementAtOrDefault<CharacterSkinItemData>((IEnumerable<>)(object)characterSkinItemDatas, num);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005D1")]
			public CharacterSkinItemData[] SelectableCharacterSkins
			{
				[Cpp2IlInjected.Token(Token = "0x6002727")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				get
				{
					return selectableCharacterSkinItemDatas;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005D2")]
			public BaseEnvironmentDoor OriginDoor
			{
				[Cpp2IlInjected.Token(Token = "0x600272B")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003COriginDoor_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600272C")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				set
				{
					_003COriginDoor_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005D3")]
			private Character PostponedUnload
			{
				[Cpp2IlInjected.Token(Token = "0x6002732")]
				[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
				[CompilerGenerated]
				get
				{
					return _003CPostponedUnload_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6002733")]
				[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
				[CompilerGenerated]
				set
				{
					_003CPostponedUnload_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002724")]
			[Cpp2IlInjected.Address(RVA = "0x1782070", Offset = "0x1780A70", VA = "0x181782070")]
			public bool IsFollowingAvatar()
			{
				//Discarded unreachable code: IL_0023
				//IL_0010: Expected O, but got I4
				Character character = Character;
				int num = 0;
				bool flag = character != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				return Character.IsFollowingAvatar();
			}

			[Cpp2IlInjected.Token(Token = "0x6002728")]
			[Cpp2IlInjected.Address(RVA = "0x1782720", Offset = "0x1781120", VA = "0x181782720")]
			public bool IsSpecificLocationInCurrentScene(ScheduleType schedule, out bool result)
			{
				return result.m_value = IsSpecificLocationInCurrentScene(schedule);
			}

			[Cpp2IlInjected.Token(Token = "0x6002729")]
			[Cpp2IlInjected.Address(RVA = "0x1782340", Offset = "0x1780D40", VA = "0x181782340")]
			public bool IsSpecificLocationInCurrentScene(ScheduleType schedule)
			{
				//IL_00a9: Expected O, but got I4
				_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
				if (schedule == ScheduleType.SpecificLocation)
				{
					CharacterItemData data = Data;
					Profile profile = SystemRoot.Instance.MetaClient.profile;
					Client metaClient = SystemRoot.Instance.MetaClient;
					bool flag = default(bool);
					if (flag)
					{
						SceneData sceneData = default(SceneData);
						AsyncOperation operation = sceneData.sceneInstance.m_Operation;
						CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
						LocationSource.LocationOneofCase locationCase_ = CS_0024_003C_003E8__locals0.location.locationCase_;
						if (locationCase_ == LocationSource.LocationOneofCase.AnywhereInScene)
						{
							Item sceneItem = CS_0024_003C_003E8__locals0.location.AnywhereInScene.SceneItem;
						}
						if (locationCase_ != LocationSource.LocationOneofCase.Custom)
						{
						}
						GameObject gameObject = default(GameObject);
						MissionCustomLocation[] componentsInChildren = gameObject.GetComponentsInChildren<MissionCustomLocation>();
						Func<MissionCustomLocation, bool> func = (Func<MissionCustomLocation, bool>)(object)(Func<T, TResult>)((MissionCustomLocation x) => default(bool));
						MissionCustomLocation missionCustomLocation = Enumerable.FirstOrDefault<MissionCustomLocation>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
						int num = 0;
						bool flag2 = missionCustomLocation != (UnityEngine.Object)num;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600272A")]
			[Cpp2IlInjected.Address(RVA = "0x1782100", Offset = "0x1780B00", VA = "0x181782100")]
			public bool IsSecretCharacterVisitingCurrentScene()
			{
				//Discarded unreachable code: IL_006a
				Meta.Character metaCharacter = MetaCharacter;
				DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
				if (!metaCharacter.IsSecretCharacterVisiting(localTime))
				{
					int num = 0;
				}
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SecretCharacterLocationFilter spawnedInLocation_ = MetaCharacter.secretCharacterData_.spawnedInLocation_;
				if (spawnedInLocation_.locationTypeCase_ == SecretCharacterLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					return (long)"{il2cpp array field local16->}" == 1;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				int scene = spawnedInLocation_.Scene;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600272D")]
			[Cpp2IlInjected.Address(RVA = "0x17832A0", Offset = "0x1781CA0", VA = "0x1817832A0")]
			public CharacterInstance(CharacterItemData data, CharacterManager characterManager)
			{
				//Discarded unreachable code: IL_00ee
				int runOnlyOnce = default(int);
				SharedTask sharedTask = new SharedTask((byte)runOnlyOnce != 0);
				runOnlyOnce = 0;
				sharedLoadTask = sharedTask;
				base._002Ector();
				Data = data;
				this.characterManager = characterManager;
				int iD = Data.ID;
				CharacterSkinItemData[] array = default(CharacterSkinItemData[]);
				characterSkinItemDatas = array;
				int iD2 = Data.ID;
				CharacterSkinItemData[] array2 = characterSkinItemDatas;
				if (array2 == null)
				{
				}
				Func<CharacterSkinItemData, bool> func = default(Func<CharacterSkinItemData, bool>);
				if (_003C_003Ec._003C_003E9__36_0 == null)
				{
					func = (Func<CharacterSkinItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterSkinItemData x) => default(bool)));
				}
				CharacterSkinItemData[] array3 = (selectableCharacterSkinItemDatas = Enumerable.Where<CharacterSkinItemData>((IEnumerable<>)(object)array2, (Func<, >)(object)func).ToArray<CharacterSkinItemData>());
				if (characterSkinItemDatas.Length == 0)
				{
					return;
				}
				Meta.Character metaCharacter = MetaCharacter;
				int skinID_ = metaCharacter.skinID_;
				_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
				CS_0024_003C_003E8__locals0.characterSkin = (Item)metaCharacter;
				int newSkinIndex = default(int);
				if (CS_0024_003C_003E8__locals0 == null)
				{
					CharacterSkinItemData[] array4 = characterSkinItemDatas;
					Func<CharacterSkinItemData, bool> func2 = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)((CharacterSkinItemData x) => default(bool));
					newSkinIndex = MoreLinq.FindIndex<CharacterSkinItemData>((IEnumerable<>)(object)array4, (Func<, >)(object)func2);
				}
				int doInviteFlow = 0;
				UpdateCharacterSkin(newSkinIndex, (byte)doInviteFlow != 0);
			}

			[Cpp2IlInjected.Token(Token = "0x600272E")]
			[Cpp2IlInjected.Address(RVA = "0x1781D80", Offset = "0x1780780", VA = "0x181781D80")]
			public static CharacterSkinItemData[] GetCharacterSkins(Item item)
			{
				//Discarded unreachable code: IL_003c
				//IL_0014: Expected O, but got I4
				int itemID = item.ItemID;
				_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass35_0();
				CS_0024_003C_003E8__locals0.item = (Item)itemID;
				IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<CharacterSkinItemData>(ItemType.Skin);
				Func<CharacterSkinItemData, bool> func = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)((CharacterSkinItemData x) => default(bool));
				return Enumerable.Where<CharacterSkinItemData>(allByType, (Func<, >)(object)func).ToArray<CharacterSkinItemData>();
			}

			[Cpp2IlInjected.Token(Token = "0x600272F")]
			[Cpp2IlInjected.Address(RVA = "0x1781F20", Offset = "0x1780920", VA = "0x181781F20")]
			public static CharacterSkinItemData[] GetSelectableCharacterSkins(Item item, [System.Runtime.InteropServices.Optional] CharacterSkinItemData[] characterSkins)
			{
				int itemID = item.ItemID;
				if (characterSkins == null)
				{
				}
				Func<CharacterSkinItemData, bool> func = default(Func<CharacterSkinItemData, bool>);
				if (_003C_003Ec._003C_003E9__36_0 == null)
				{
					func = (Func<CharacterSkinItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterSkinItemData x) => default(bool)));
				}
				return Enumerable.Where<CharacterSkinItemData>((IEnumerable<>)(object)characterSkins, (Func<, >)(object)func).ToArray<CharacterSkinItemData>();
			}

			[Cpp2IlInjected.Token(Token = "0x6002730")]
			[Cpp2IlInjected.Address(RVA = "0x1782860", Offset = "0x1781260", VA = "0x181782860")]
			[AsyncStateMachine(typeof(_003CSetActive_003Ed__37))]
			internal Task SetActive(bool active)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002731")]
			[Cpp2IlInjected.Address(RVA = "0x1782740", Offset = "0x1781140", VA = "0x181782740")]
			[AsyncStateMachine(typeof(_003CLoadCharacter_003Ed__38))]
			private Task LoadCharacter()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002734")]
			[Cpp2IlInjected.Address(RVA = "0x1782AC0", Offset = "0x17814C0", VA = "0x181782AC0")]
			private void UnloadCharacterAfterDialogue()
			{
				//Discarded unreachable code: IL_0042
				//IL_0022: Expected O, but got I8
				Character.Hide();
				Character character = (PostponedUnload = Character);
				Character = (Character)0;
				DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
				AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(CurrentDialogueFinishedEvent);
				system.add_CurrentDialogueFinishedEvent((AsyncEventHandler<>)(object)asyncEventHandler);
			}

			[Cpp2IlInjected.Token(Token = "0x6002735")]
			[Cpp2IlInjected.Address(RVA = "0x1781A70", Offset = "0x1780470", VA = "0x181781A70")]
			private Task CurrentDialogueFinishedEvent(object sender, DialogueInstance arg)
			{
				//Discarded unreachable code: IL_0041
				//IL_0028: Expected O, but got I4
				//IL_0038: Expected O, but got I4
				AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(CurrentDialogueFinishedEvent);
				int num = 0;
				int num2 = 0;
				GameObject _003CConversationPartner_003Ek__BackingField = PostponedUnload.ConversationPartner;
				int num3 = 0;
				if (_003CConversationPartner_003Ek__BackingField != (UnityEngine.Object)num3)
				{
					characterManager.CancelConversation((Character)num3);
				}
				int num4 = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x6002736")]
			[Cpp2IlInjected.Address(RVA = "0x1781C80", Offset = "0x1780680", VA = "0x181781C80")]
			private void DoPostponedUnload()
			{
				//IL_0015: Expected O, but got I4
				//IL_0024: Expected O, but got I4
				GameObject _003CConversationPartner_003Ek__BackingField = PostponedUnload.ConversationPartner;
				int num = 0;
				if (_003CConversationPartner_003Ek__BackingField != (UnityEngine.Object)num)
				{
					characterManager.CancelConversation((Character)num);
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002737")]
			[Cpp2IlInjected.Address(RVA = "0x1782C30", Offset = "0x1781630", VA = "0x181782C30")]
			private void UnloadCharacter()
			{
				//IL_0015: Expected O, but got I4
				//IL_0024: Expected O, but got I4
				GameObject _003CConversationPartner_003Ek__BackingField = Character.ConversationPartner;
				int num = 0;
				if (_003CConversationPartner_003Ek__BackingField != (UnityEngine.Object)num)
				{
					characterManager.CancelConversation((Character)num);
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002738")]
			[Cpp2IlInjected.Address(RVA = "0x1782D30", Offset = "0x1781730", VA = "0x181782D30")]
			public void UpdateCharacterSkin(Item characterSkin, bool doInviteFlow)
			{
				//IL_0014: Expected O, but got I4
				int itemID = characterSkin.ItemID;
				_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
				CS_0024_003C_003E8__locals0.characterSkin = (Item)itemID;
				if (CS_0024_003C_003E8__locals0 == null)
				{
					CharacterSkinItemData[] array = characterSkinItemDatas;
					Func<CharacterSkinItemData, bool> func = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)((CharacterSkinItemData x) => default(bool));
					int newSkinIndex = MoreLinq.FindIndex<CharacterSkinItemData>((IEnumerable<>)(object)array, (Func<, >)(object)func);
					UpdateCharacterSkin(newSkinIndex, doInviteFlow);
					return;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002739")]
			[Cpp2IlInjected.Address(RVA = "0x1782E90", Offset = "0x1781890", VA = "0x181782E90")]
			private void UpdateCharacterSkin(int newSkinIndex, bool doInviteFlow)
			{
				//Discarded unreachable code: IL_008f
				//IL_002b: Expected I4, but got O
				//IL_004b: Expected O, but got I4
				//IL_0083: Expected O, but got I4
				_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass48_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.doInviteFlow = doInviteFlow;
				CharacterSkinItemData[] array = characterSkinItemDatas;
				if ((IntPtr)CS_0024_003C_003E8__locals0 == (IntPtr)activeCharacterSkinIndex)
				{
					return;
				}
				chosenCharacterSkinIndex = (int)CS_0024_003C_003E8__locals0;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag && flag2)
				{
					CharacterState characterState = default(CharacterState);
					CS_0024_003C_003E8__locals0.characterState = characterState;
					bool flag3 = default(bool);
					if (flag3)
					{
						int num = 0;
						PostponedUnload = (Character)num;
						DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
						AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(CurrentDialogueFinishedEvent);
						system.add_CurrentDialogueFinishedEvent((AsyncEventHandler<>)(object)asyncEventHandler);
					}
					int num2 = 0;
					bool flag4 = default(bool);
					if (flag4)
					{
						characterManager.CancelConversation((Character)num2);
					}
					Load().FireAndForgetTask();
				}
				[Cpp2IlInjected.Token(Token = "0x6002749")]
				[Cpp2IlInjected.Address(RVA = "0xF96AA0", Offset = "0xF954A0", VA = "0x180F96AA0")]
				[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass48_0._003C_003CUpdateCharacterSkin_003Eg__Load_007C0_003Ed))]
				Task Load()
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000867")]
		public delegate void CharacterLoaded(Character character);

		[Cpp2IlInjected.Token(Token = "0x2000868")]
		public struct MoodController : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002F57")]
			private readonly List<Character> charactersAffected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002F58")]
			private readonly CancellationTokenSource cts;

			[Cpp2IlInjected.Token(Token = "0x6002750")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
			public MoodController(List<Character> charactersAffected, CancellationTokenSource cts)
			{
				this.charactersAffected = charactersAffected;
				this.cts = cts;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002751")]
			[Cpp2IlInjected.Address(RVA = "0x1783A00", Offset = "0x1782400", VA = "0x181783A00", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0007, IL_000d, IL_0013
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000869")]
		public struct InOnEnvEnterCharUpdateScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002F59")]
			private readonly CharacterManager manager;

			[Cpp2IlInjected.Token(Token = "0x6002752")]
			[Cpp2IlInjected.Address(RVA = "0x1783970", Offset = "0x1782370", VA = "0x181783970")]
			public InOnEnvEnterCharUpdateScope(CharacterManager manager)
			{
				//Discarded unreachable code: IL_001b
				//IL_0010: Expected O, but got I4
				this.manager = manager;
				int num = 0;
				if (manager != (UnityEngine.Object)num)
				{
					manager.OnEnterEnvCharacterUpdate = true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002753")]
			[Cpp2IlInjected.Address(RVA = "0x17838F0", Offset = "0x17822F0", VA = "0x1817838F0", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0005
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002F11")]
		[SerializeField]
		private BehaviourTree behaviourTree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002F12")]
		[SerializeField]
		private GameObject requestCompleteVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002F13")]
		public AssetReference CharacterUnlockedPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002F14")]
		public float MinutesBetweenCharactersGoingToAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002F15")]
		private HashSet<CharacterInstance> charactersInTheVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002F16")]
		public int MaximumNumberOfCharactersInTheVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002F17")]
		public float MinimumMinutesBetweenBarks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002F18")]
		public float MaximumMinutesBetweenBarks;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002F19")]
		private DateTime nextBark;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002F1A")]
		public float MinimumMinutesBeforeFirstConversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002F1B")]
		public float MaximumMinutesBeforeFirstConversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002F1C")]
		public float MinimumMinutesBetweenConversations;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002F1D")]
		public float MaximumMinutesBetweenConversations;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4002F1F")]
		[SerializeField]
		[ItemID]
		private int _restaurantItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002F20")]
		[SerializeField]
		[ItemID]
		private int _storeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002F22")]
		private TaskCompletionSource<bool> unlockingCharacterTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002F23")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002F25")]
		private readonly List<CharacterInstance> allCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002F26")]
		private readonly List<CharacterInstance>[] characterPerScheduleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002F27")]
		private HashSet<CharacterInstance> overriddenCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002F28")]
		private bool shouldUpdateSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002F29")]
		private GridEditMode gridEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002F2A")]
		private Mdl.Avatar.AvatarCustomization avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002F2B")]
		private Mdl.Furnitures.FurnitureCustomization furnitureCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002F2C")]
		internal CharacterSpawnTracker SpawnCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002F2D")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x4002F2E")]
		private static readonly Func<CharacterInstance, bool> activeCharacters = (Func<CharacterInstance, bool>)(object)(Func<T, TResult>)((CharacterInstance instance) => instance.Active);

		[Cpp2IlInjected.Token(Token = "0x4002F2F")]
		private static readonly Func<CharacterInstance, bool> activeNonSecretCharacters;

		[Cpp2IlInjected.Token(Token = "0x4002F30")]
		private static readonly Func<CharacterInstance, Character> getCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002F31")]
		private Dictionary<Character, TaskCompletionSource<bool>> readyForConversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002F32")]
		private TaskCompletionSource<bool> conversationTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002F33")]
		private CancellationTokenSource conversationCTS;

		[Cpp2IlInjected.Token(Token = "0x170005C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4002F10")]
		private System.Random Rand
		{
			[Cpp2IlInjected.Token(Token = "0x60026A9")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB8"), Cpp2IlInjected.Token(Token = "0x4002F1E")]
		public bool OnEnterEnvCharacterUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x60026AA")]
			[Cpp2IlInjected.Address(RVA = "0x12E8630", Offset = "0x12E7030", VA = "0x1812E8630")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60026AB")]
			[Cpp2IlInjected.Address(RVA = "0x12E87B0", Offset = "0x12E71B0", VA = "0x1812E87B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C4")]
		public Item RestaurantItem
		{
			[Cpp2IlInjected.Token(Token = "0x60026AC")]
			[Cpp2IlInjected.Address(RVA = "0x12E8640", Offset = "0x12E7040", VA = "0x1812E8640")]
			get
			{
				long num = Convert.ToInt64((uint)_restaurantItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C5")]
		public Item StoreItem
		{
			[Cpp2IlInjected.Token(Token = "0x60026AD")]
			[Cpp2IlInjected.Address(RVA = "0x12E86A0", Offset = "0x12E70A0", VA = "0x1812E86A0")]
			get
			{
				long num = Convert.ToInt64((uint)_storeItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C6")]
		public GameObject RequestCompleteVFX
		{
			[Cpp2IlInjected.Token(Token = "0x60026AE")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return requestCompleteVFX;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C7")]
		public BehaviourTree BehaviourTree
		{
			[Cpp2IlInjected.Token(Token = "0x60026AF")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return behaviourTree;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC4"), Cpp2IlInjected.Token(Token = "0x4002F21")]
		private bool IsUnlockingCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60026B0")]
			[Cpp2IlInjected.Address(RVA = "0x12E8560", Offset = "0x12E6F60", VA = "0x1812E8560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60026B1")]
			[Cpp2IlInjected.Address(RVA = "0x12E87A0", Offset = "0x12E71A0", VA = "0x1812E87A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005C9")]
		private MissionManager MissionManager
		{
			[Cpp2IlInjected.Token(Token = "0x60026B9")]
			[Cpp2IlInjected.Address(RVA = "0x12E8570", Offset = "0x12E6F70", VA = "0x1812E8570")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<MissionManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CA")]
		private CurseSystem CurseSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60026BA")]
			[Cpp2IlInjected.Address(RVA = "0x12E84A0", Offset = "0x12E6EA0", VA = "0x1812E84A0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CurseSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005C")]
		public event CharacterLoaded OnCharacterLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60026B5")]
			[Cpp2IlInjected.Address(RVA = "0x12E8400", Offset = "0x12E6E00", VA = "0x1812E8400")]
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
			[Cpp2IlInjected.Token(Token = "0x60026B6")]
			[Cpp2IlInjected.Address(RVA = "0x12E8700", Offset = "0x12E7100", VA = "0x1812E8700")]
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

		[Cpp2IlInjected.Token(Token = "0x60026B2")]
		[Cpp2IlInjected.Address(RVA = "0x12DCF50", Offset = "0x12DB950", VA = "0x1812DCF50")]
		public void CharacterUnlockInit()
		{
			if ((long)unlockingCharacterTCS == 0)
			{
				TaskCompletionSource<bool> taskCompletionSource = (unlockingCharacterTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026B3")]
		[Cpp2IlInjected.Address(RVA = "0x12DCEF0", Offset = "0x12DB8F0", VA = "0x1812DCEF0")]
		public void CharacterUnlockDone()
		{
			//IL_0012: Expected O, but got I4
			//IL_001c: Expected O, but got I8
			TaskCompletionSource<bool> taskCompletionSource = unlockingCharacterTCS;
			if (taskCompletionSource != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
			}
			unlockingCharacterTCS = (TaskCompletionSource<bool>)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026B4")]
		[Cpp2IlInjected.Address(RVA = "0x12E7980", Offset = "0x12E6380", VA = "0x1812E7980")]
		[AsyncStateMachine(typeof(_003CWaitCharacterUnlockAsync_003Ed__38))]
		public Task<bool> WaitCharacterUnlockAsync(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026B7")]
		[Cpp2IlInjected.Address(RVA = "0x12E5F20", Offset = "0x12E4920", VA = "0x1812E5F20")]
		internal void RaiseCharacterLoaded(Character character)
		{
			this.OnCharacterLoaded?.Invoke(character);
		}

		[Cpp2IlInjected.Token(Token = "0x60026B8")]
		[Cpp2IlInjected.Address(RVA = "0x12E0280", Offset = "0x12DEC80", VA = "0x1812E0280")]
		private List<CharacterInstance> GetCharacterForScheduleType(ScheduleType scheduleType)
		{
			//Discarded unreachable code: IL_0011
			List<CharacterInstance>[] array = characterPerScheduleType;
			return array[(int)scheduleType];
		}

		[Cpp2IlInjected.Token(Token = "0x60026BB")]
		[Cpp2IlInjected.Address(RVA = "0x12DD5F0", Offset = "0x12DBFF0", VA = "0x1812DD5F0")]
		private bool CurseIsActive(CharacterInstance characterInstance)
		{
			//Discarded unreachable code: IL_0025
			if (!CurseSystem.isActive)
			{
				int num = 0;
			}
			CurseSystem curseSystem = CurseSystem;
			int iD = characterInstance.Data.ID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026BC")]
		[Cpp2IlInjected.Address(RVA = "0x12E3C70", Offset = "0x12E2670", VA = "0x1812E3C70")]
		[AsyncStateMachine(typeof(_003COnEnvironmentEntered_003Ed__58))]
		public Task OnEnvironmentEntered(Mdl.Environments.Environment environment)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026BD")]
		[Cpp2IlInjected.Address(RVA = "0x12E7970", Offset = "0x12E6370", VA = "0x1812E7970")]
		public void UpdateScheduleOnNextSceneEntered()
		{
			shouldUpdateSchedule = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60026BE")]
		[Cpp2IlInjected.Address(RVA = "0x12E7300", Offset = "0x12E5D00", VA = "0x1812E7300")]
		[AsyncStateMachine(typeof(_003CUpdateCharacterPositions_003Ed__61))]
		private Task UpdateCharacterPositions(Mdl.Environments.Environment currentEnvironment)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026BF")]
		[Cpp2IlInjected.Address(RVA = "0x12E27F0", Offset = "0x12E11F0", VA = "0x1812E27F0")]
		private ScheduleType NewScheduleBasicOverride(CharacterInstance characterInstance, ScheduleType currentSchedule)
		{
			if (currentSchedule == ScheduleType.Store)
			{
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				int storeItem = _storeItem;
				bool flag = default(bool);
				if (flag)
				{
				}
			}
			if (currentSchedule == ScheduleType.Restaurant)
			{
				ProfileWorld world_2 = SystemRoot.Instance.MetaClient.profile.world_;
				int restaurantItem = _restaurantItem;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				Client client = default(Client);
				GridCollection gridCollection_ = client.profile.world_.gridCollection_;
				int restaurantItem2 = _restaurantItem;
				HouseData houseData = default(HouseData);
				while (houseData == null)
				{
				}
				while ((long)houseData.upgradeState_ == 0)
				{
				}
				Item restaurantItem3 = RestaurantItem;
				HouseData houseData2 = default(HouseData);
				int level_ = houseData2.upgradeState_.level_;
				int useLowerLast = 0;
				IBuildingUpgradable buildingUpgradable = default(IBuildingUpgradable);
				UpgradeData upgradeData = buildingUpgradable.GetUpgradeData(level_, (byte)useLowerLast != 0);
				if (upgradeData != null)
				{
					BenefitsRestaurantData restaurant = upgradeData.Restaurant;
				}
				int num = 0;
				List<CharacterInstance> list = characterPerScheduleType[4];
			}
			while (2L != 2L)
			{
			}
			ProfileWorld world_3 = SystemRoot.Instance.MetaClient.profile.world_;
			int house = characterInstance.Data.House;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026C0")]
		[Cpp2IlInjected.Address(RVA = "0x12DE570", Offset = "0x12DCF70", VA = "0x1812DE570")]
		public Task ForceCharacterToFollowAvatar(Item characterItem)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C1")]
		[Cpp2IlInjected.Address(RVA = "0x12DE450", Offset = "0x12DCE50", VA = "0x1812DE450")]
		[AsyncStateMachine(typeof(_003CForceCharacterToFollowAvatar_003Ed__64))]
		private Task ForceCharacterToFollowAvatar(CharacterInstance characterInstance)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C2")]
		[Cpp2IlInjected.Address(RVA = "0x12DE7B0", Offset = "0x12DD1B0", VA = "0x1812DE7B0")]
		public Task ForceCharacterUnspawnNow(Item characterItem)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C3")]
		[Cpp2IlInjected.Address(RVA = "0x12DE690", Offset = "0x12DD090", VA = "0x1812DE690")]
		[AsyncStateMachine(typeof(_003CForceCharacterUnspawnNow_003Ed__66))]
		private Task ForceCharacterUnspawnNow(CharacterInstance characterInstance)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C4")]
		[Cpp2IlInjected.Address(RVA = "0x12DE310", Offset = "0x12DCD10", VA = "0x1812DE310")]
		[AsyncStateMachine(typeof(_003CForceCharacterOutsideNow_003Ed__67))]
		public Task ForceCharacterOutsideNow(Item characterItem, bool createInstance = false, bool isCheat = false)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C5")]
		[Cpp2IlInjected.Address(RVA = "0x12DE1D0", Offset = "0x12DCBD0", VA = "0x1812DE1D0")]
		[AsyncStateMachine(typeof(_003CForceCharacterOutsideNow_003Ed__68))]
		private Task ForceCharacterOutsideNow(CharacterInstance characterInstance, bool isCheat = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C6")]
		[Cpp2IlInjected.Address(RVA = "0x12DE0A0", Offset = "0x12DCAA0", VA = "0x1812DE0A0")]
		public Task ForceCharacterInsideNow(Item characterItem)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C7")]
		[Cpp2IlInjected.Address(RVA = "0x12DDF80", Offset = "0x12DC980", VA = "0x1812DDF80")]
		[AsyncStateMachine(typeof(_003CForceCharacterInsideNow_003Ed__70))]
		private Task ForceCharacterInsideNow(CharacterInstance characterInstance)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C8")]
		[Cpp2IlInjected.Address(RVA = "0x12E67B0", Offset = "0x12E51B0", VA = "0x1812E67B0")]
		[AsyncStateMachine(typeof(_003CSpawnCharacter_003Ed__71))]
		public Task<Character> SpawnCharacter(Item characterItem, Vector3 position, Quaternion rotation)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Character>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C9")]
		[Cpp2IlInjected.Address(RVA = "0x12E5F40", Offset = "0x12E4940", VA = "0x1812E5F40")]
		private void RegisterFutureActivities()
		{
			//Discarded unreachable code: IL_0073
			//IL_0038: Expected F8, but got I4
			CancellationToken token = cancellationTokenProvider.activeCancellationTokenSource.Token;
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			float maximumMinutesBeforeFirstConversation = MaximumMinutesBeforeFirstConversation;
			float num3 = UnityEngine.Random.Range(MinimumMinutesBeforeFirstConversation, maximumMinutesBeforeFirstConversation);
			TimeSpan timeSpan = TimeSpan.FromMinutes(0.0);
			CancellationToken token2 = cancellationTokenProvider.activeCancellationTokenSource.Token;
			int num4 = 0;
			Task asyncTask2 = default(Task);
			asyncTask2.FireAndForgetTask();
			CancellationToken token3 = cancellationTokenProvider.activeCancellationTokenSource.Token;
			int num5 = 0;
			Task asyncTask3 = default(Task);
			asyncTask3.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60026CA")]
		[Cpp2IlInjected.Address(RVA = "0x12E2150", Offset = "0x12E0B50", VA = "0x1812E2150")]
		[AsyncStateMachine(typeof(_003CLoadCharacter_003Ed__73))]
		private Task<CharacterInstance> LoadCharacter(Item characterItem, bool active = true)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<CharacterInstance>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026CB")]
		[Cpp2IlInjected.Address(RVA = "0x12E22A0", Offset = "0x12E0CA0", VA = "0x1812E22A0")]
		private void LoadCharacters(Profile profile)
		{
			//Discarded unreachable code: IL_0072, IL_0078, IL_007e
			int num = 0;
			RepeatedField<Meta.Character> characters_ = profile.world_.characters_;
			Func<Meta.Character, bool> _003C_003E9__74_ = _003C_003Ec._003C_003E9__74_0;
			if (_003C_003E9__74_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Meta.Character x)
				{
					//Discarded unreachable code: IL_002c
					if (!x.InVillage && !x.IsUnlocked && !x.InEvent)
					{
						Client client = default(Client);
						DateTime localTime = client.LocalTime;
						return x.IsSecretCharacterVisiting(localTime);
					}
					return true;
				};
			}
			IEnumerable<Meta.Character> enumerable = (IEnumerable<Meta.Character>)Enumerable.Where<Meta.Character>((IEnumerable<>)(object)characters_, (Func<, >)(object)_003C_003E9__74_);
			CharacterInstance characterInstance = default(CharacterInstance);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0066;
					}
					num++;
				}
				List<CharacterInstance> list = allCharacters;
				CharacterItemData data = default(CharacterItemData);
				characterInstance = new CharacterInstance(data, this);
				((List<T>)(object)list).Add((T)characterInstance);
				goto IL_0066;
			}
			goto IL_006d;
			IL_0066:
			characterInstance = (CharacterInstance)(object)((object)characterInstance + (object)characterInstance);
			goto IL_006d;
			IL_006d:
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026CC")]
		[Cpp2IlInjected.Address(RVA = "0x12DDA70", Offset = "0x12DC470", VA = "0x1812DDA70")]
		[AsyncStateMachine(typeof(_003CDebugUnlockAndSpawnCharacterOutside_003Ed__75))]
		public Task DebugUnlockAndSpawnCharacterOutside(Item characterItem)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026CD")]
		[Cpp2IlInjected.Address(RVA = "0x12E6640", Offset = "0x12E5040", VA = "0x1812E6640")]
		[AsyncStateMachine(typeof(_003CSpawnCharacterAsync_003Ed__76))]
		private Task<CharacterInstance> SpawnCharacterAsync(Profile profile, Item characterItem, CancellationToken cancellationToken)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CharacterInstance>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026CE")]
		[Cpp2IlInjected.Address(RVA = "0x12DC480", Offset = "0x12DAE80", VA = "0x1812DC480")]
		[AsyncStateMachine(typeof(_003CApplyCharacterProfession_003Ed__77))]
		public Task<bool> ApplyCharacterProfession(Item characterId, Item professionId)
		{
			int itemID = professionId.ItemID;
			int itemID2 = characterId.ItemID;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026CF")]
		[Cpp2IlInjected.Address(RVA = "0x12DC590", Offset = "0x12DAF90", VA = "0x1812DC590")]
		[AsyncStateMachine(typeof(_003CApplyCharacterSkin_003Ed__78))]
		public Task<bool> ApplyCharacterSkin(Item characterItem, Item skinItem)
		{
			int itemID = skinItem.ItemID;
			int itemID2 = characterItem.ItemID;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026D0")]
		[Cpp2IlInjected.Address(RVA = "0x12DD670", Offset = "0x12DC070", VA = "0x1812DD670")]
		[AsyncStateMachine(typeof(_003CDebugAddFriendshipAsync_003Ed__79))]
		public Task<DebugAddFriendship.Types.Response> DebugAddFriendshipAsync(Item characterId, int amount, CancellationToken cancellationToken)
		{
			int itemID = characterId.ItemID;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DebugAddFriendship.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026D1")]
		[Cpp2IlInjected.Address(RVA = "0x12E7AC0", Offset = "0x12E64C0", VA = "0x1812E7AC0")]
		[AsyncStateMachine(typeof(_003CWaitForScheduleUpdate_003Ed__80))]
		private Task WaitForScheduleUpdate(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026D2")]
		[Cpp2IlInjected.Address(RVA = "0x12E4AD0", Offset = "0x12E34D0", VA = "0x1812E4AD0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_027a
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = base.gameObject.GetOrAddComponent<CancellationTokenProvider>());
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			LoadCharacters(profile);
			RegisterFutureActivities();
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			System.Random rand = Rand;
			int num = 0;
			float num2 = rand.NextFloat();
			DateTime dateTime = default(DateTime);
			nextBark = dateTime;
			CreateEventHandler();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterStateChange value = OnCharacterStateChange;
			_003CDispatcher_003Ek__BackingField.OnCharacterStateChange += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterSkinChanged value2 = OnCharacterSkinChanged;
			_003CDispatcher_003Ek__BackingField2.OnCharacterSkinChanged += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.EventStarted value3 = OnEventStarted;
			_003CDispatcher_003Ek__BackingField3.OnEventStarted += value3;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.EventEnded value4 = OnEventEnded;
			_003CDispatcher_003Ek__BackingField4.OnEventEnded += value4;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.SecretCharacterVisitStarted value5 = OnSecretCharacterVisitStarted;
			_003CDispatcher_003Ek__BackingField5.OnSecretCharacterVisitStarted += value5;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value6 = OnMissionSlotUpdated;
			_003CDispatcher_003Ek__BackingField6.OnMissionSlotUpdated += value6;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.BuidingUpgraded value7 = OnBuidingUpgraded;
			_003CDispatcher_003Ek__BackingField7.OnBuidingUpgraded += value7;
			MissionManager missionManager = MissionManager;
			MissionManager.MissionsInitialized value8 = UpdateQuestGivers;
			missionManager.OnMissionsInitialized += value8;
			bool flag = default(bool);
			if (flag)
			{
				GridEditMode gridEditMode = this.gridEditMode;
				SystemEvent value9 = CheckPause;
				gridEditMode.SystemStartedEvent += value9;
				GridEditMode gridEditMode2 = this.gridEditMode;
				SystemEvent value10 = CheckPause;
				gridEditMode2.SystemStoppedEvent += value10;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization = this.avatarCustomization;
				SystemEvent value11 = CheckPause;
				avatarCustomization.SystemStartedEvent += value11;
				Mdl.Avatar.AvatarCustomization avatarCustomization2 = this.avatarCustomization;
				SystemEvent value12 = CheckPause;
				avatarCustomization2.SystemStoppedEvent += value12;
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				Mdl.Furnitures.FurnitureCustomization furnitureCustomization = this.furnitureCustomization;
				SystemEvent value13 = CheckPause;
				furnitureCustomization.SystemStartedEvent += value13;
				Mdl.Furnitures.FurnitureCustomization furnitureCustomization2 = this.furnitureCustomization;
				SystemEvent value14 = CheckPause;
				furnitureCustomization2.SystemStoppedEvent += value14;
			}
			Profile profile2 = SystemRoot.Instance.MetaClient.profile;
			UpdateQuestGivers(profile2);
		}

		[Cpp2IlInjected.Token(Token = "0x60026D3")]
		[Cpp2IlInjected.Address(RVA = "0x12E55E0", Offset = "0x12E3FE0", VA = "0x1812E55E0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0264
			//IL_001a: Expected O, but got I8
			//IL_0029: Expected O, but got I4
			//IL_0178: Expected O, but got I4
			//IL_01cd: Expected O, but got I4
			//IL_0222: Expected O, but got I4
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CharacterStateChange value = OnCharacterStateChange;
				_003CDispatcher_003Ek__BackingField.OnCharacterStateChange -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CharacterSkinChanged value2 = OnCharacterSkinChanged;
				_003CDispatcher_003Ek__BackingField2.OnCharacterSkinChanged -= value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.EventStarted value3 = OnEventStarted;
				_003CDispatcher_003Ek__BackingField3.OnEventStarted -= value3;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.EventEnded value4 = OnEventEnded;
				_003CDispatcher_003Ek__BackingField4.OnEventEnded -= value4;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.SecretCharacterVisitStarted value5 = OnSecretCharacterVisitStarted;
				_003CDispatcher_003Ek__BackingField5.OnSecretCharacterVisitStarted -= value5;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value6 = OnMissionSlotUpdated;
				_003CDispatcher_003Ek__BackingField6.OnMissionSlotUpdated -= value6;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.BuidingUpgraded value7 = OnBuidingUpgraded;
				_003CDispatcher_003Ek__BackingField7.OnBuidingUpgraded -= value7;
				MissionManager missionManager = MissionManager;
				MissionManager.MissionsInitialized value8 = UpdateQuestGivers;
				missionManager.OnMissionsInitialized -= value8;
			}
			GridEditMode gridEditMode = this.gridEditMode;
			int num2 = 0;
			if (gridEditMode != (UnityEngine.Object)num2)
			{
				GridEditMode gridEditMode2 = this.gridEditMode;
				SystemEvent value9 = CheckPause;
				gridEditMode2.SystemStartedEvent -= value9;
				GridEditMode gridEditMode3 = this.gridEditMode;
				SystemEvent value10 = CheckPause;
				gridEditMode3.SystemStoppedEvent -= value10;
			}
			Mdl.Avatar.AvatarCustomization avatarCustomization = this.avatarCustomization;
			int num3 = 0;
			if (avatarCustomization != (UnityEngine.Object)num3)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization2 = this.avatarCustomization;
				SystemEvent value11 = CheckPause;
				avatarCustomization2.SystemStartedEvent -= value11;
				Mdl.Avatar.AvatarCustomization avatarCustomization3 = this.avatarCustomization;
				SystemEvent value12 = CheckPause;
				avatarCustomization3.SystemStoppedEvent -= value12;
			}
			Mdl.Furnitures.FurnitureCustomization furnitureCustomization = this.furnitureCustomization;
			int num4 = 0;
			if (furnitureCustomization != (UnityEngine.Object)num4)
			{
				Mdl.Furnitures.FurnitureCustomization furnitureCustomization2 = this.furnitureCustomization;
				SystemEvent value13 = CheckPause;
				furnitureCustomization2.SystemStartedEvent -= value13;
				Mdl.Furnitures.FurnitureCustomization furnitureCustomization3 = this.furnitureCustomization;
				SystemEvent value14 = CheckPause;
				furnitureCustomization3.SystemStoppedEvent -= value14;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026D4")]
		[Cpp2IlInjected.Address(RVA = "0x12E44D0", Offset = "0x12E2ED0", VA = "0x1812E44D0", Slot = "6")]
		public override void OnSystemPause()
		{
			int num = ((base.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60026D5")]
		[Cpp2IlInjected.Address(RVA = "0x12E44E0", Offset = "0x12E2EE0", VA = "0x1812E44E0", Slot = "7")]
		public unsafe override void OnSystemResume()
		{
			//Discarded unreachable code: IL_0103, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139
			//IL_000d: Expected I4, but got I8
			//IL_0099: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			ulong num4 = default(ulong);
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			IEnumerable<CharacterInstance> enumerable2;
			uint num5 = default(uint);
			Vector3 vector = default(Vector3);
			GridScript gridScript = default(GridScript);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				base.enabled = (byte)num4 != 0;
				RegisterFutureActivities();
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
				List<CharacterInstance> list = allCharacters;
				Func<CharacterInstance, bool> func = activeNonSecretCharacters;
				IEnumerable<CharacterInstance> enumerable = (IEnumerable<CharacterInstance>)Enumerable.Where<CharacterInstance>((IEnumerable<>)list, (Func<, >)(object)func);
				Func<CharacterInstance, Character> func2 = getCharacter;
				enumerable2 = (IEnumerable<CharacterInstance>)Enumerable.Select<CharacterInstance, Character>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
				if (enumerable2 == null)
				{
					break;
				}
				if (num3 < (int)num5)
				{
					num3 += num3;
					if (num3 == (int)num5)
					{
						break;
					}
					num3++;
				}
				int num6 = 0;
				if (!(this == (UnityEngine.Object)num6))
				{
					continue;
				}
				float z = vector.z;
				int num7 = 0;
				if (!(gridScript != (UnityEngine.Object)num7))
				{
					continue;
				}
				while ((long)gridScript.Grid == 0)
				{
				}
				float z2 = vector2.z;
				int allowInvalid = 0;
				GridPosition gridPosition = gridScript.GetGridPosition(in *(Vector3*)num2, 1, (byte)allowInvalid != 0);
				if (gridScript.GetLayersForPosition(in *(GridPosition*)gridPosition) != GridLayers.Blocking)
				{
					float z3 = vector3.z;
					while (!flag)
					{
					}
					break;
				}
			}
			if (enumerable2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026D6")]
		[Cpp2IlInjected.Address(RVA = "0x12DD0D0", Offset = "0x12DBAD0", VA = "0x1812DD0D0")]
		private void CreateEventHandler()
		{
			//Discarded unreachable code: IL_0080, IL_0086, IL_008c, IL_0092, IL_0098, IL_009e
			int num;
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num2 = default(uint);
			IEnumerable<OverrideScheduleData> enumerable2 = default(IEnumerable<OverrideScheduleData>);
			int num4 = default(int);
			do
			{
				num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (enumerable == null)
				{
					continue;
				}
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0044;
					}
					num++;
				}
				if (_003C_003Ec._003C_003E9__86_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((OverrideScheduleData s) => s.schedule_ == ScheduleType.SpecificLocation);
				}
				if (enumerable2 != null)
				{
					int num3 = 0;
					num4 = 0;
					goto IL_0044;
				}
				goto IL_004b;
				IL_004b:
				if (enumerable2 == null)
				{
				}
				continue;
				IL_0044:
				num4 += num4;
				goto IL_004b;
			}
			while (enumerable == null);
			if (false)
			{
			}
			Client client = default(Client);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			if (_003CDispatcher_003Ek__BackingField != null)
			{
				ProfileEventDispatcher.AnyConditionChanged callback = default(ProfileEventDispatcher.AnyConditionChanged);
				conditionEventHandler = _003CDispatcher_003Ek__BackingField.RegisterToAnyConditionChanged((ConditionListener)num, callback);
			}
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026D7")]
		[Cpp2IlInjected.Address(RVA = "0x12DDB80", Offset = "0x12DC580", VA = "0x1812DDB80")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026D8")]
		[Cpp2IlInjected.Address(RVA = "0x12E4330", Offset = "0x12E2D30", VA = "0x1812E4330")]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [System.Runtime.InteropServices.Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0018
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			UpdateQuestGivers(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x60026D9")]
		[Cpp2IlInjected.Address(RVA = "0x12E78A0", Offset = "0x12E62A0", VA = "0x1812E78A0")]
		private void UpdateQuestGivers()
		{
			//Discarded unreachable code: IL_0018
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			UpdateQuestGivers(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x60026DA")]
		[Cpp2IlInjected.Address(RVA = "0x12E7420", Offset = "0x12E5E20", VA = "0x1812E7420")]
		public void UpdateQuestGivers(Profile profile)
		{
			//Discarded unreachable code: IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1, IL_00b7, IL_00bd, IL_00c3, IL_00c9, IL_00cf, IL_00d5
			//IL_0080: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			ICollection<> collection = default(ICollection<>);
			CharacterInstance characterInstance = default(CharacterInstance);
			while (true)
			{
				List<CharacterInstance> list = allCharacters;
				if (flag)
				{
					while (!flag2)
					{
					}
				}
				if (collection == null)
				{
					break;
				}
				_003C_003Ec__DisplayClass90_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass90_0();
				CS_0024_003C_003E8__locals0.queue = (MissionQueue)(object)CS_0024_003C_003E8__locals0;
				if (((RepeatedField<T>)(object)CS_0024_003C_003E8__locals0.queue.slots_).Count <= 0)
				{
					continue;
				}
				RepeatedField<MissionSlot> slots_ = CS_0024_003C_003E8__locals0.queue.slots_;
				int index = 0;
				if (CharacterUtil.QuestIsActive((MissionSlot)((RepeatedField<T>)(object)slots_)[index]))
				{
					Predicate<CharacterInstance> predicate = (Predicate<CharacterInstance>)(object)(Predicate<T>)delegate(CharacterInstance c)
					{
						int iD = c.Data.ID;
						RepeatedField<MissionSlot> slots_2 = CS_0024_003C_003E8__locals0.queue.slots_;
						int index2 = 0;
						Item characterItem = ((MissionSlot)((RepeatedField<T>)(object)slots_2)[index2]).CharacterItem;
						throw new NullReferenceException();
					};
					if (characterInstance != null)
					{
					}
					int num = 0;
					int num2 = 0;
					if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
					{
						characterInstance.Character.IsQuestGiver = true;
						break;
					}
				}
			}
			if (collection == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026DB")]
		[Cpp2IlInjected.Address(RVA = "0x12E3520", Offset = "0x12E1F20", VA = "0x1812E3520")]
		private void OnBuidingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			//Discarded unreachable code: IL_001e
			int itemID = gridObj.ItemID;
			int restaurantItem = _restaurantItem;
			if ((object)typeof(Item).TypeHandle != null)
			{
				shouldUpdateSchedule = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026DC")]
		[Cpp2IlInjected.Address(RVA = "0x12DCFD0", Offset = "0x12DB9D0", VA = "0x1812DCFD0")]
		private void CheckPause(Mdl.Systems.System system)
		{
			//Discarded unreachable code: IL_001c, IL_0023
			GridEditMode gridEditMode = this.gridEditMode;
			Mdl.Avatar.AvatarCustomization avatarCustomization = this.avatarCustomization;
			Mdl.Furnitures.FurnitureCustomization furnitureCustomization = this.furnitureCustomization;
			ResumeSystem();
		}

		[Cpp2IlInjected.Token(Token = "0x60026DD")]
		[Cpp2IlInjected.Address(RVA = "0x12E0430", Offset = "0x12DEE30", VA = "0x1812E0430")]
		public IEnumerable<CharacterInstance> GetCharacterInstances(bool includeSecret = false)
		{
			//Discarded unreachable code: IL_0029
			List<CharacterInstance> list = allCharacters;
			Func<CharacterInstance, bool> func = (Func<CharacterInstance, bool>)(object)(Func<T, TResult>)delegate(CharacterInstance x)
			{
				//Discarded unreachable code: IL_0023
				if (!includeSecret)
				{
					Meta.Character metaCharacter = x.MetaCharacter;
					if (metaCharacter != null)
					{
						return metaCharacter.status_ != Meta.Character.Types.CharacterStatus.Secret;
					}
				}
				return true;
			};
			return (IEnumerable<CharacterInstance>)Enumerable.Where<CharacterInstance>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60026DE")]
		[Cpp2IlInjected.Address(RVA = "0x12DEA90", Offset = "0x12DD490", VA = "0x1812DEA90")]
		public IEnumerable<Character> GetActiveCharacters(bool includeSecret = false)
		{
			List<CharacterInstance> list = allCharacters;
			if (!includeSecret)
			{
			}
			Func<CharacterInstance, bool> func = activeCharacters;
			IEnumerable<CharacterInstance> enumerable = (IEnumerable<CharacterInstance>)Enumerable.Where<CharacterInstance>((IEnumerable<>)list, (Func<, >)(object)func);
			Func<CharacterInstance, Character> func2 = getCharacter;
			return (IEnumerable<Character>)Enumerable.Select<CharacterInstance, Character>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
		}

		[Cpp2IlInjected.Token(Token = "0x60026DF")]
		[Cpp2IlInjected.Address(RVA = "0x12DE8E0", Offset = "0x12DD2E0", VA = "0x1812DE8E0")]
		public NonAllocSelectEnumerator<CharacterInstance, Character, NonAllocWhereEnumerator<CharacterInstance, List<CharacterInstance>.Enumerator>> GetActiveCharactersNonAlloc(bool includeSecret = false)
		{
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E0")]
		[Cpp2IlInjected.Address(RVA = "0x12E0820", Offset = "0x12DF220", VA = "0x1812E0820")]
		public Character GetCharacter(Item characterItem)
		{
			CharacterInstance characterInstance;
			do
			{
				characterInstance = GetCharacterInstance(characterItem);
			}
			while (characterInstance == null);
			return characterInstance.Character;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E1")]
		[Cpp2IlInjected.Address(RVA = "0x12E0790", Offset = "0x12DF190", VA = "0x1812E0790")]
		public Character GetCharacter(Item characterItem, [System.Runtime.InteropServices.Optional] Func<CharacterInstance, bool> predicate)
		{
			CharacterInstance characterInstance = default(CharacterInstance);
			if (characterInstance != null && (predicate == null || predicate((T)characterInstance) != null))
			{
				return characterInstance.Character;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E2")]
		[Cpp2IlInjected.Address(RVA = "0x12E02C0", Offset = "0x12DECC0", VA = "0x1812E02C0")]
		public CharacterInstance GetCharacterInstance(Item characterItem)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<CharacterInstance> list = allCharacters;
			Func<CharacterInstance, bool> func = (Func<CharacterInstance, bool>)(object)(Func<T, TResult>)delegate(CharacterInstance x)
			{
				int iD = x.Data.ID;
				throw new NullReferenceException();
			};
			return Enumerable.FirstOrDefault<CharacterInstance>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60026E3")]
		[Cpp2IlInjected.Address(RVA = "0x12E03A0", Offset = "0x12DEDA0", VA = "0x1812E03A0")]
		public CharacterInstance GetCharacterInstance(Item characterItem, [System.Runtime.InteropServices.Optional] Func<CharacterInstance, bool> predicate)
		{
			CharacterInstance characterInstance = default(CharacterInstance);
			if (characterInstance != null && (predicate == null || predicate((T)characterInstance) != null))
			{
				return characterInstance;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E4")]
		[Cpp2IlInjected.Address(RVA = "0x12E1F50", Offset = "0x12E0950", VA = "0x1812E1F50")]
		public bool IsCharacterUnlocked(Item characterItem)
		{
			if ((object)typeof(Item).TypeHandle != null)
			{
				return true;
			}
			CharacterInstance characterInstance = default(CharacterInstance);
			if (characterInstance != null)
			{
				Meta.Character metaCharacter = characterInstance.MetaCharacter;
				if (metaCharacter != null)
				{
					bool isUnlocked = metaCharacter.IsUnlocked;
					return 0 == 1;
				}
				return 0 == 1;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E5")]
		[Cpp2IlInjected.Address(RVA = "0x12E20A0", Offset = "0x12E0AA0", VA = "0x1812E20A0")]
		public static bool IsCharacterUnlocked(CharacterInstance characterInstance)
		{
			if (characterInstance != null)
			{
				Meta.Character metaCharacter = characterInstance.MetaCharacter;
				if (metaCharacter != null)
				{
					bool isUnlocked = metaCharacter.IsUnlocked;
					return 0 == 1;
				}
				return 0 == 1;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E6")]
		[Cpp2IlInjected.Address(RVA = "0x12E1DF0", Offset = "0x12E07F0", VA = "0x1812E1DF0")]
		public bool IsCharacterSleeping(Item characterItem)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			if (characterInstance != null && !characterInstance.Active)
			{
				CharacterItemData data = characterInstance.Data;
				Client client = default(Client);
				Profile profile = client.profile;
				Client client2 = default(Client);
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
				if (data.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField) == ScheduleType.Sleep)
				{
					bool flag = ((List<T>)(object)characterPerScheduleType[2]).Contains((T)characterInstance);
				}
			}
			int num = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E7")]
		[Cpp2IlInjected.Address(RVA = "0x12E1CA0", Offset = "0x12E06A0", VA = "0x1812E1CA0")]
		public bool IsCharacterSleeping(CharacterInstance characterInstance)
		{
			if (characterInstance != null && !characterInstance.Active)
			{
				CharacterItemData data = characterInstance.Data;
				Client client = default(Client);
				Profile profile = client.profile;
				Client client2 = default(Client);
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
				if (data.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField) == ScheduleType.Sleep)
				{
					bool flag = ((List<T>)(object)characterPerScheduleType[2]).Contains((T)characterInstance);
				}
			}
			int num = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E8")]
		[Cpp2IlInjected.Address(RVA = "0x12E19E0", Offset = "0x12E03E0", VA = "0x1812E19E0")]
		public bool IsCharacterInHouse(Item characterItem, bool checkNextUpdateSchedule = false)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			return IsCharacterInHouse(characterInstance, checkNextUpdateSchedule);
		}

		[Cpp2IlInjected.Token(Token = "0x60026E9")]
		[Cpp2IlInjected.Address(RVA = "0x12E1A20", Offset = "0x12E0420", VA = "0x1812E1A20")]
		public bool IsCharacterInHouse(CharacterInstance characterInstance, bool checkNextUpdateSchedule = false)
		{
			if (characterInstance != null)
			{
				CharacterItemData data = characterInstance.Data;
				if (data != null)
				{
					Profile profile = SystemRoot.Instance.MetaClient.profile;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
					ScheduleType currentSchedule = data.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField);
					int num = (int)currentSchedule;
					if (currentSchedule != ScheduleType.Indoor || ((List<T>)(object)characterPerScheduleType[1]).Contains((T)characterInstance))
					{
					}
					if (checkNextUpdateSchedule)
					{
						List<CharacterInstance>[] array = characterPerScheduleType;
						if (num == 3)
						{
							bool flag = ((List<T>)(object)array[2]).Contains((T)characterInstance);
						}
						bool flag2 = ((List<T>)(object)array[2]).Contains((T)characterInstance);
					}
				}
			}
			int num2 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026EA")]
		[Cpp2IlInjected.Address(RVA = "0x12E2590", Offset = "0x12E0F90", VA = "0x1812E2590")]
		[AsyncStateMachine(typeof(_003CMakeCharacterGoToAvatar_003Ed__109))]
		private Task MakeCharacterGoToAvatar(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026EB")]
		[Cpp2IlInjected.Address(RVA = "0x12E26B0", Offset = "0x12E10B0", VA = "0x1812E26B0")]
		[AsyncStateMachine(typeof(_003CMakeCharacterHaveAConversation_003Ed__110))]
		private Task MakeCharacterHaveAConversation(TimeSpan timeToWait, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026EC")]
		[Cpp2IlInjected.Address(RVA = "0x12E6910", Offset = "0x12E5310", VA = "0x1812E6910")]
		[AsyncStateMachine(typeof(_003CStartConversationWithReload_003Ed__114))]
		public Task<bool> StartConversationWithReload(NpcDiscussionItemData conversationItemData, CancellationToken ct, [System.Runtime.InteropServices.Optional] LocationSource conversationLocation, bool runToPartner = false, bool canInterruptConversation = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026ED")]
		[Cpp2IlInjected.Address(RVA = "0x12E6A90", Offset = "0x12E5490", VA = "0x1812E6A90")]
		[AsyncStateMachine(typeof(_003CStartConversation_003Ed__115))]
		private Task<bool> StartConversation(NpcDiscussionItemData conversationItemData, CancellationToken ct, float avatarMinDistance = -1f, [System.Runtime.InteropServices.Optional] LocationSource conversationLocation, bool runToPartner = false, bool canInterruptConversation = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026EE")]
		[Cpp2IlInjected.Address(RVA = "0x12DDBC0", Offset = "0x12DC5C0", VA = "0x1812DDBC0")]
		private Vector3 FindValidConversationPosition(Vector3 conversationPosition, Character character1, Character character2, int maxFindValidPositionTries = 1)
		{
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag == flag2)
			{
				if (!flag)
				{
				}
				int num2 = 0;
				bool flag3 = default(bool);
				if (flag3)
				{
				}
			}
			if (!flag)
			{
			}
			bool flag4 = default(bool);
			if (!flag4)
			{
				Debug.LogError("Failed to find valid conversation position");
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026EF")]
		[Cpp2IlInjected.Address(RVA = "0x12DDE00", Offset = "0x12DC800", VA = "0x1812DDE00")]
		private unsafe bool FindValidConversationPosition(ref Vector3 conversationPosition, Vector3 validPosition, Character validCharacter, Character otherCharacter)
		{
			//IL_0013: Expected O, but got Ref
			//IL_0023: Expected O, but got Ref
			//IL_0032: Expected F4, but got I4
			int num = 0;
			bool flag = default(bool);
			bool flag4 = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				if (flag2 && validCharacter.FindValidPosition((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref conversationPosition), out *(Vector3*)validPosition, 2))
				{
					goto IL_002a;
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					flag4 = validCharacter.FindValidPosition((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref conversationPosition), out *(Vector3*)validPosition, 2);
					if (flag4)
					{
						goto IL_002a;
					}
				}
			}
			throw new NullReferenceException();
			IL_002a:
			conversationPosition.z = (flag4 ? 1 : 0);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60026F0")]
		[Cpp2IlInjected.Address(RVA = "0x12E6540", Offset = "0x12E4F40", VA = "0x1812E6540")]
		public Task SetCharacterReadyForConversation(Character character, bool ready)
		{
			//Discarded unreachable code: IL_0022
			bool flag = default(bool);
			if (readyForConversation != null && flag)
			{
				Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)conversationTCS).m_task;
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60026F1")]
		[Cpp2IlInjected.Address(RVA = "0x12DCC60", Offset = "0x12DB660", VA = "0x1812DCC60")]
		public void CancelConversation(Character character)
		{
			//Discarded unreachable code: IL_0025
			//IL_0010: Expected O, but got I4
			GameObject _003CConversationPartner_003Ek__BackingField = character.ConversationPartner;
			int num = 0;
			if (_003CConversationPartner_003Ek__BackingField != (UnityEngine.Object)num)
			{
				conversationCTS?.Cancel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026F2")]
		[Cpp2IlInjected.Address(RVA = "0x12E1310", Offset = "0x12DFD10", VA = "0x1812E1310")]
		public DialogueItemData GetValidDialogue(Item characterItem, DialogueItemType dialogueType)
		{
			DialogueItemData[] array = default(DialogueItemData[]);
			if (array != null && array.Length != 0)
			{
				Func<DialogueItemData, bool> _003C_003E9__120_ = _003C_003Ec._003C_003E9__120_0;
				if (_003C_003E9__120_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DialogueItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID2 = x.PreviousDiscussionID;
						bool result2 = default(bool);
						return result2;
					};
				}
				if (!((IEnumerable<>)(object)array).Any<DialogueItemData>((Func<, >)(object)_003C_003E9__120_))
				{
					int length = array.Length;
					int num = UnityEngine.Random.Range(0, length);
					return array[num];
				}
				Func<DialogueItemData, bool> func = default(Func<DialogueItemData, bool>);
				if (_003C_003Ec._003C_003E9__120_1 == null)
				{
					func = (Func<DialogueItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DialogueItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID = x.PreviousDiscussionID;
						bool result = default(bool);
						return result;
					});
				}
				DialogueItemData[] array2 = Enumerable.Where<DialogueItemData>((IEnumerable<>)(object)array, (Func<, >)(object)func).ToArray<DialogueItemData>();
				int num2 = 0;
				return array2[(object)array2];
			}
			int num3 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026F3")]
		[Cpp2IlInjected.Address(RVA = "0x12DF2D0", Offset = "0x12DDCD0", VA = "0x1812DF2D0")]
		public DialogueItemData[] GetAllValidDialogues(Item characterItem, DialogueItemType dialogueType)
		{
			//IL_0016: Expected O, but got I4
			//IL_00d4: Expected I4, but got I8
			Item characterItem2;
			Profile profile;
			Season season;
			DateTime localTime;
			ScheduleType schedule;
			ulong num = default(ulong);
			CharacterLocation characterLocation;
			uint num2 = default(uint);
			string weather;
			Func<DiscussionRecord, bool> func = default(Func<DiscussionRecord, bool>);
			Func<DiscussionRecord, int> func2 = default(Func<DiscussionRecord, int>);
			HashSet<int> lastDiscussions;
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			do
			{
				int itemID = characterItem.ItemID;
				characterItem2 = (Item)itemID;
				profile = SystemRoot.Instance.MetaClient.profile;
				ProfileWorld world_ = profile.world_;
				Item item = characterItem2;
				Meta.Character character = world_.GetCharacter(item);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				season = SystemRoot.Instance.MetaClient.LocalTime.GetSeason();
				localTime = SystemRoot.Instance.MetaClient.LocalTime;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Item item2 = characterItem2;
				CharacterItemData itemData = _003CInstance_003Ek__BackingField2.GetItemData<CharacterItemData>(item2);
				Profile profile2 = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				schedule = itemData.GetCurrentSchedule(profile2, _003CTransactionContext_003Ek__BackingField, (byte)num != 0);
				if (character == null || character.InVillage || character.InEvent)
				{
				}
				characterLocation = (CharacterLocation)num2;
				weather = profile.world_.currentWeather_;
				RepeatedField<DiscussionRecord> lastDiscussions_ = profile.world_.lastDiscussions_;
				if (_003C_003Ec._003C_003E9__121_0 == null)
				{
					func = (Func<DiscussionRecord, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DiscussionRecord x)
					{
						//Discarded unreachable code: IL_002a
						DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
						DateTime dateTime = x.timestamp_.ToDateTime();
						DateTime dateTime2 = default(DateTime);
						TimeSpan timeSpan = default(TimeSpan);
						return dateTime2 - dateTime < timeSpan;
					});
				}
				IEnumerable<DiscussionRecord> enumerable = (IEnumerable<DiscussionRecord>)Enumerable.Where<DiscussionRecord>((IEnumerable<>)(object)lastDiscussions_, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__121_1 == null)
				{
					func2 = (Func<DiscussionRecord, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DiscussionRecord x) => x.discussionItemID_));
				}
				lastDiscussions = (HashSet<int>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<DiscussionRecord, int>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
				if (enumerable2 != null)
				{
					Func<DialogueItemData, bool> func3 = (Func<DialogueItemData, bool>)(object)(Func<T, TResult>)delegate(DialogueItemData x)
					{
						int allowRepetition2 = 0;
						return ApplyFilter(x, (byte)allowRepetition2 != 0);
					};
					DialogueItemData[] array = Enumerable.Where<DialogueItemData>(enumerable2, (Func<, >)(object)func3).ToArray<DialogueItemData>();
				}
				int num3 = 0;
				[Cpp2IlInjected.Token(Token = "0x60027C7")]
				[Cpp2IlInjected.Address(RVA = "0x13F61A0", Offset = "0x13F4BA0", VA = "0x1813F61A0")]
				bool ApplyFilter(DialogueItemData x, bool allowRepetition)
				{
					//IL_008f: Expected O, but got I4
					//IL_00df: Expected O, but got I4
					string dialogueAssetAddress_ = x.dialogueAssetAddress_;
					if (x.CharacterItemID != 0)
					{
						Season season_ = x.season_;
						if (season_ == Season.Any || season_ == season)
						{
							string timeOfDay_ = x.timeOfDay_;
							if (season_ == Season.Any)
							{
								string timeOfDay_2 = x.timeOfDay_;
								DateTime time = localTime;
								TimeOfDay timeOfDay = default(TimeOfDay);
								if (!timeOfDay.IsTimeWithinInterval(time))
								{
									goto IL_012a;
								}
							}
							ScheduleType schedule_ = x.schedule_;
							if (schedule_ == ScheduleType.Any || schedule_ == schedule)
							{
								if (x.PreviousDiscussionID == 0)
								{
									HashSet<int> hashSet = lastDiscussions;
									int previousDiscussionID_ = x.previousDiscussionID_;
									if (!((HashSet<T>)(object)hashSet).Contains((T)previousDiscussionID_))
									{
										goto IL_012a;
									}
								}
								CharacterLocation location_ = x.location_;
								if (location_ == CharacterLocation.Any || location_ == characterLocation)
								{
									string weather2 = weather;
									if (x.IsValidInWeather(weather2))
									{
										if (!allowRepetition)
										{
											HashSet<int> hashSet2 = lastDiscussions;
											int iD_ = x.iD_;
											if (((HashSet<T>)(object)hashSet2).Contains((T)iD_))
											{
												goto IL_012a;
											}
										}
										RepeatedField<int> necessaryCharactersInVillage_ = x.necessaryCharactersInVillage_;
										Func<int, bool> func5 = (Func<int, bool>)(object)(Func<T, TResult>)delegate
										{
											//Discarded unreachable code: IL_001b
											ProfileWorld world_2 = profile.world_;
											bool flag = default(bool);
											if (!flag)
											{
												return flag;
											}
											bool flag2 = default(bool);
											bool flag3 = default(bool);
											return flag2 || flag3;
										};
										if (((IEnumerable<>)(object)necessaryCharactersInVillage_).All<int>((Func<, >)(object)func5))
										{
											ConditionsList conditions_ = x.conditions_;
											Client client = default(Client);
											Profile profile3 = client.profile;
											Client client2 = default(Client);
											Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField2 = client2.TransactionContext;
											return conditions_.Evaluate(profile3, _003CTransactionContext_003Ek__BackingField2);
										}
									}
								}
							}
						}
					}
					goto IL_012a;
					IL_012a:
					throw new NullReferenceException();
				}
			}
			while (dialogueType != DialogueItemType.Discussion);
			MissionManager missionManager = MissionManager;
			Item character2 = characterItem2;
			missionManager.ResetCharacterDiscussions(character2).FireAndForgetTask();
			if (enumerable2 != null)
			{
				Func<DialogueItemData, bool> func4 = (Func<DialogueItemData, bool>)(object)(Func<T, TResult>)((DialogueItemData x) => ApplyFilter(x, allowRepetition: true));
				return Enumerable.Where<DialogueItemData>(enumerable2, (Func<, >)(object)func4).ToArray<DialogueItemData>();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026F4")]
		[Cpp2IlInjected.Address(RVA = "0x12E15D0", Offset = "0x12DFFD0", VA = "0x1812E15D0")]
		public HangoutDialogueItemData GetValidHangoutDialogue(Item characterItem, HangoutDialogueItemData.Types.HangoutDialogueType hangoutDialogueType)
		{
			HangoutDialogueItemData[] array = default(HangoutDialogueItemData[]);
			if (array != null && array.Length != 0)
			{
				Func<HangoutDialogueItemData, bool> _003C_003E9__122_ = _003C_003Ec._003C_003E9__122_0;
				if (_003C_003E9__122_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(HangoutDialogueItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID2 = x.PreviousDiscussionID;
						bool result2 = default(bool);
						return result2;
					};
				}
				if (!((IEnumerable<>)(object)array).Any<HangoutDialogueItemData>((Func<, >)(object)_003C_003E9__122_))
				{
					int length = array.Length;
					int num = UnityEngine.Random.Range(0, length);
					return array[num];
				}
				Func<HangoutDialogueItemData, bool> func = default(Func<HangoutDialogueItemData, bool>);
				if (_003C_003Ec._003C_003E9__122_1 == null)
				{
					func = (Func<HangoutDialogueItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(HangoutDialogueItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID = x.PreviousDiscussionID;
						bool result = default(bool);
						return result;
					});
				}
				HangoutDialogueItemData[] array2 = Enumerable.Where<HangoutDialogueItemData>((IEnumerable<>)(object)array, (Func<, >)(object)func).ToArray<HangoutDialogueItemData>();
				int num2 = 0;
				return array2[(object)array2];
			}
			int num3 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026F5")]
		[Cpp2IlInjected.Address(RVA = "0x12DFB90", Offset = "0x12DE590", VA = "0x1812DFB90")]
		public HangoutDialogueItemData[] GetAllValidHangoutDialogues(Item characterItem, HangoutDialogueItemData.Types.HangoutDialogueType hangoutDialogueType)
		{
			//IL_0016: Expected O, but got I4
			//IL_00db: Expected I4, but got I8
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			ProfileWorld world_ = profile.world_;
			Item item = characterItem2;
			Meta.Character character = world_.GetCharacter(item);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Season season = SystemRoot.Instance.MetaClient.LocalTime.GetSeason();
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Item item2 = characterItem2;
			CharacterItemData itemData = _003CInstance_003Ek__BackingField2.GetItemData<CharacterItemData>(item2);
			Profile profile2 = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			ulong num = default(ulong);
			ScheduleType schedule = itemData.GetCurrentSchedule(profile2, _003CTransactionContext_003Ek__BackingField, (byte)num != 0);
			if (character == null || character.InVillage || character.InEvent)
			{
			}
			uint num2 = default(uint);
			CharacterLocation characterLocation = (CharacterLocation)num2;
			string weather = profile.world_.currentWeather_;
			RepeatedField<DiscussionRecord> lastDiscussions_ = profile.world_.lastDiscussions_;
			Func<DiscussionRecord, int> func = default(Func<DiscussionRecord, int>);
			if (_003C_003Ec._003C_003E9__123_0 == null)
			{
				func = (Func<DiscussionRecord, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DiscussionRecord x) => x.discussionItemID_));
			}
			HashSet<int> lastDiscussions = (HashSet<int>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<DiscussionRecord, int>((IEnumerable<>)(object)lastDiscussions_, (Func<, >)(object)func));
			IEnumerable<> enumerable = default(IEnumerable<>);
			if (enumerable != null)
			{
				Func<HangoutDialogueItemData, bool> func2 = (Func<HangoutDialogueItemData, bool>)(object)(Func<T, TResult>)((HangoutDialogueItemData x) => ApplyFilter(x));
				return Enumerable.Where<HangoutDialogueItemData>(enumerable, (Func<, >)(object)func2).ToArray<HangoutDialogueItemData>();
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60027CC")]
			[Cpp2IlInjected.Address(RVA = "0x13F65C0", Offset = "0x13F4FC0", VA = "0x1813F65C0")]
			bool ApplyFilter(HangoutDialogueItemData x)
			{
				//IL_0091: Expected O, but got I4
				string dialogueAssetAddress_ = x.dialogueAssetAddress_;
				if (x.CharacterItemID != 0)
				{
					Season season_ = x.season_;
					if (season_ == Season.Any || season_ == season)
					{
						if (!string.IsNullOrEmpty(x.timeOfDay_))
						{
							string timeOfDay_ = x.timeOfDay_;
							DateTime time = localTime;
							TimeOfDay timeOfDay = default(TimeOfDay);
							if (!timeOfDay.IsTimeWithinInterval(time))
							{
								goto IL_011e;
							}
						}
						ScheduleType schedule_ = x.schedule_;
						if (schedule_ == ScheduleType.Any || schedule_ == schedule)
						{
							if (x.PreviousDiscussionID == 0)
							{
								HashSet<int> hashSet = lastDiscussions;
								int previousDiscussionID_ = x.previousDiscussionID_;
								if (!((HashSet<T>)(object)hashSet).Contains((T)previousDiscussionID_))
								{
									goto IL_011e;
								}
							}
							CharacterLocation location_ = x.location_;
							if (location_ == CharacterLocation.Any || location_ == characterLocation)
							{
								string weather2 = weather;
								if (x.IsValidInWeather(weather2))
								{
									RepeatedField<int> necessaryCharactersInVillage_ = x.necessaryCharactersInVillage_;
									Func<int, bool> func3 = (Func<int, bool>)(object)(Func<T, TResult>)delegate
									{
										//Discarded unreachable code: IL_001b
										ProfileWorld world_2 = profile.world_;
										bool flag = default(bool);
										if (!flag)
										{
											return flag;
										}
										bool flag2 = default(bool);
										bool flag3 = default(bool);
										return flag2 || flag3;
									};
									if (((IEnumerable<>)(object)necessaryCharactersInVillage_).All<int>((Func<, >)(object)func3))
									{
										ConditionsList conditions_ = x.conditions_;
										Client client = default(Client);
										Profile profile3 = client.profile;
										Client client2 = default(Client);
										Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField2 = client2.TransactionContext;
										if (conditions_.Evaluate(profile3, _003CTransactionContext_003Ek__BackingField2))
										{
											HangoutDialogueItemData.Types.HangoutDialogueType hangoutDialogueType2 = hangoutDialogueType;
											return x.dialogueType_ == hangoutDialogueType2;
										}
									}
								}
							}
						}
					}
				}
				goto IL_011e;
				IL_011e:
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026F6")]
		[Cpp2IlInjected.Address(RVA = "0x12E1060", Offset = "0x12DFA60", VA = "0x1812E1060")]
		public NpcDiscussionItemData GetValidConversation()
		{
			NpcDiscussionItemData[] allValidConversations = GetAllValidConversations();
			if (allValidConversations != null && allValidConversations.Length != 0)
			{
				Func<NpcDiscussionItemData, bool> _003C_003E9__124_ = _003C_003Ec._003C_003E9__124_0;
				if (_003C_003E9__124_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(NpcDiscussionItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID2 = x.PreviousDiscussionID;
						bool result2 = default(bool);
						return result2;
					};
				}
				if (!((IEnumerable<>)(object)allValidConversations).Any<NpcDiscussionItemData>((Func<, >)(object)_003C_003E9__124_))
				{
					int length = allValidConversations.Length;
					int num = UnityEngine.Random.Range(0, length);
					return allValidConversations[num];
				}
				Func<NpcDiscussionItemData, bool> func = default(Func<NpcDiscussionItemData, bool>);
				if (_003C_003Ec._003C_003E9__124_1 == null)
				{
					func = (Func<NpcDiscussionItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(NpcDiscussionItemData x)
					{
						//Discarded unreachable code: IL_0009
						int previousDiscussionID = x.PreviousDiscussionID;
						bool result = default(bool);
						return result;
					});
				}
				NpcDiscussionItemData[] array = Enumerable.Where<NpcDiscussionItemData>((IEnumerable<>)(object)allValidConversations, (Func<, >)(object)func).ToArray<NpcDiscussionItemData>();
				int num2 = 0;
				return array[(object)array];
			}
			int num3 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026F7")]
		[Cpp2IlInjected.Address(RVA = "0x12DEB80", Offset = "0x12DD580", VA = "0x1812DEB80")]
		public NpcDiscussionItemData[] GetAllValidConversations()
		{
			//IL_0079: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Season season = SystemRoot.Instance.MetaClient.LocalTime.GetSeason();
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			string weather = SystemRoot.Instance.MetaClient.profile.world_.currentWeather_;
			HashSet<CharacterInstance> hashSet = charactersInTheVillage;
			Func<CharacterInstance, bool> func = (Func<CharacterInstance, bool>)(object)new Func<T, TResult>(IsValidCharacterForConversation);
			int num = 0;
			IEnumerable<CharacterInstance> enumerable = (IEnumerable<CharacterInstance>)Enumerable.Where<CharacterInstance>((IEnumerable<>)hashSet, (Func<, >)(object)func);
			Func<CharacterInstance, Item> _003C_003E9__125_ = _003C_003Ec._003C_003E9__125_0;
			if (_003C_003E9__125_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CharacterInstance x)
				{
					int iD = x.Data.ID;
					throw new NullReferenceException();
				};
			}
			HashSet<Item> outsideCharacters = (HashSet<Item>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<CharacterInstance, Item>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__125_));
			RepeatedField<DiscussionRecord> lastDiscussions_ = SystemRoot.Instance.MetaClient.profile.world_.lastDiscussions_;
			Func<DiscussionRecord, int> func2 = default(Func<DiscussionRecord, int>);
			if (_003C_003Ec._003C_003E9__125_1 == null)
			{
				func2 = (Func<DiscussionRecord, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DiscussionRecord x) => x.discussionItemID_));
			}
			HashSet<int> lastDiscussions = (HashSet<int>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<DiscussionRecord, int>((IEnumerable<>)(object)lastDiscussions_, (Func<, >)(object)func2));
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			if (enumerable2 != null)
			{
				Func<NpcDiscussionItemData, bool> func3 = (Func<NpcDiscussionItemData, bool>)(object)new Func<T, TResult>(IsValidConversation);
				return Enumerable.Where<NpcDiscussionItemData>(enumerable2, (Func<, >)(object)func3).ToArray<NpcDiscussionItemData>();
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002718")]
			[Cpp2IlInjected.Address(RVA = "0x12E6EC0", Offset = "0x12E58C0", VA = "0x1812E6EC0")]
			static bool IsValidCharacterForConversation(CharacterInstance instance)
			{
				//IL_0020: Expected O, but got I4
				if (instance.Active)
				{
					Character _003CCharacter_003Ek__BackingField = instance.Character;
					GameObject characterToFollow = _003CCharacter_003Ek__BackingField.characterToFollow;
					int num3 = 0;
					if (characterToFollow == (UnityEngine.Object)num3 && !_003CCharacter_003Ek__BackingField.WorkingAtAShop && !_003CCharacter_003Ek__BackingField._isHangingOutWithAvatar && !_003CCharacter_003Ek__BackingField.IsMovingToTargetObject)
					{
						return !_003CCharacter_003Ek__BackingField.IsMovingToTargetPosition;
					}
				}
				int num4 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60027D0")]
			[Cpp2IlInjected.Address(RVA = "0x13F68E0", Offset = "0x13F52E0", VA = "0x1813F68E0")]
			bool IsValidConversation(NpcDiscussionItemData data)
			{
				//IL_0094: Expected O, but got I4
				HashSet<Item> hashSet2 = outsideCharacters;
				int character1ItemID = data.Character1ItemID;
				bool flag = default(bool);
				if (flag)
				{
					HashSet<Item> hashSet3 = outsideCharacters;
					int character2ItemID = data.Character2ItemID;
					bool flag2 = default(bool);
					if (flag2)
					{
						Season season_ = data.season_;
						if (season_ == Season.Any || season_ == season)
						{
							string timeOfDay_ = data.timeOfDay_;
							if (season_ == Season.Any)
							{
								string timeOfDay_2 = data.timeOfDay_;
								DateTime time = localTime;
								TimeOfDay timeOfDay = default(TimeOfDay);
								if (!timeOfDay.IsTimeWithinInterval(time))
								{
									goto IL_011e;
								}
							}
							if (data.PreviousDiscussionID == 0)
							{
								HashSet<int> hashSet4 = lastDiscussions;
								int previousDiscussionID_ = data.previousDiscussionID_;
								if (!((HashSet<T>)(object)hashSet4).Contains((T)previousDiscussionID_))
								{
									goto IL_011e;
								}
							}
							if (data.location_ == (CharacterLocation)(-3))
							{
								string weather2 = weather;
								if (data.IsValidInWeather(weather2))
								{
									RepeatedField<int> necessaryCharactersInVillage_ = data.necessaryCharactersInVillage_;
									Func<int, bool> func4 = default(Func<int, bool>);
									if (_003C_003Ec._003C_003E9__125_4 == null)
									{
										func4 = (Func<int, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
										{
											//Discarded unreachable code: IL_0024
											ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
											bool flag3 = default(bool);
											if (!flag3)
											{
												return flag3;
											}
											bool flag4 = default(bool);
											bool flag5 = default(bool);
											return flag4 || flag5;
										});
									}
									if (((IEnumerable<>)(object)necessaryCharactersInVillage_).All<int>((Func<, >)(object)func4) && !data.onlyFromMission_)
									{
										ConditionsList conditions_ = data.conditions_;
										Client client = default(Client);
										Profile profile = client.profile;
										Client client2 = default(Client);
										Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
										return conditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField);
									}
								}
							}
						}
					}
				}
				goto IL_011e;
				IL_011e:
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026F8")]
		[Cpp2IlInjected.Address(RVA = "0x12DCA50", Offset = "0x12DB450", VA = "0x1812DCA50")]
		public bool CanCharacterBark(Character character)
		{
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			DateTime dateTime = nextBark;
			if (!(localTime < dateTime) && !character.RelaxingBehaviour.Relaxing)
			{
				Meta.Character metaCharacter = character.MetaCharacter;
				int num = 0;
				if (!metaCharacter.InRealm)
				{
					Item _003CItem_003Ek__BackingField = character.Item;
					if (GetAllValidDialogues(_003CItem_003Ek__BackingField, DialogueItemType.Callout) == null)
					{
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026F9")]
		[Cpp2IlInjected.Address(RVA = "0x12E6420", Offset = "0x12E4E20", VA = "0x1812E6420")]
		public void ScheduleNextBark()
		{
			//Discarded unreachable code: IL_0029
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			System.Random rand = Rand;
			int num = 0;
			float num2 = rand.NextFloat();
			DateTime dateTime = default(DateTime);
			nextBark = dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x60026FA")]
		[Cpp2IlInjected.Address(RVA = "0x12E2DD0", Offset = "0x12E17D0", VA = "0x1812E2DD0")]
		public void NotifyOverrideCharacterSchedule(Character character)
		{
			//Discarded unreachable code: IL_0038
			List<CharacterInstance> list = allCharacters;
			Predicate<CharacterInstance> predicate = (Predicate<CharacterInstance>)(object)(Predicate<T>)delegate(CharacterInstance x)
			{
				//Discarded unreachable code: IL_0016
				Character _003CCharacter_003Ek__BackingField = x.Character;
				Character character2 = character;
				return _003CCharacter_003Ek__BackingField == character2;
			};
			CharacterInstance item = (CharacterInstance)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			bool flag = ((HashSet<T>)(object)overriddenCharacters).Add((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x60026FB")]
		[Cpp2IlInjected.Address(RVA = "0x12E2D70", Offset = "0x12E1770", VA = "0x1812E2D70")]
		public void NotifyOverrideCharacterSchedule(CharacterInstance instance)
		{
			//Discarded unreachable code: IL_000e
			bool flag = ((HashSet<T>)(object)overriddenCharacters).Add((T)instance);
		}

		[Cpp2IlInjected.Token(Token = "0x60026FC")]
		[Cpp2IlInjected.Address(RVA = "0x12E0950", Offset = "0x12DF350", VA = "0x1812E0950")]
		public ScheduleType GetCurrentCharacterSchedule(Item characterItem)
		{
			CharacterInstance characterInstance = GetCharacterInstance(characterItem);
			return GetCurrentCharacterSchedule(characterInstance);
		}

		[Cpp2IlInjected.Token(Token = "0x60026FD")]
		[Cpp2IlInjected.Address(RVA = "0x12E0840", Offset = "0x12DF240", VA = "0x1812E0840")]
		public ScheduleType GetCurrentCharacterSchedule(Character character)
		{
			//Discarded unreachable code: IL_0031
			List<CharacterInstance> list = allCharacters;
			Predicate<CharacterInstance> predicate = (Predicate<CharacterInstance>)(object)(Predicate<T>)delegate(CharacterInstance x)
			{
				//Discarded unreachable code: IL_0016
				Character _003CCharacter_003Ek__BackingField = x.Character;
				Character character2 = character;
				return _003CCharacter_003Ek__BackingField == character2;
			};
			CharacterInstance characterInstance = (CharacterInstance)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			return GetCurrentCharacterSchedule(characterInstance);
		}

		[Cpp2IlInjected.Token(Token = "0x60026FE")]
		[Cpp2IlInjected.Address(RVA = "0x12E0980", Offset = "0x12DF380", VA = "0x1812E0980")]
		public ScheduleType GetCurrentCharacterSchedule(CharacterInstance characterInstance)
		{
			//IL_0043: Expected O, but got I4
			if (characterInstance != null)
			{
				if (CurseSystem.isActive)
				{
					CurseSystem curseSystem = CurseSystem;
					int iD = characterInstance.Data.ID;
					bool flag = default(bool);
					if (flag)
					{
						goto IL_0114;
					}
				}
				Character _003CCharacter_003Ek__BackingField = characterInstance.Character;
				int num = 0;
				if (_003CCharacter_003Ek__BackingField != (UnityEngine.Object)num)
				{
					Character _003CCharacter_003Ek__BackingField2 = characterInstance.Character;
					if (_003CCharacter_003Ek__BackingField2.MetaCharacter == null || _003CCharacter_003Ek__BackingField2.MetaCharacter.InEvent)
					{
					}
					GameObject characterToFollow = characterInstance.Character.characterToFollow;
					GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
					if (characterToFollow == _003CgameObject_003Ek__BackingField)
					{
						goto IL_0164;
					}
				}
				List<CharacterInstance>[] array = characterPerScheduleType;
				int num2 = 0;
				uint num3 = default(uint);
				if (0 < array.Length)
				{
					if (!((List<T>)(object)array[num2]).Contains((T)characterInstance))
					{
						List<CharacterInstance>[] array2 = characterPerScheduleType;
					}
					if (1 == num3)
					{
						bool flag2 = ((HashSet<T>)(object)charactersInTheVillage).Contains((T)characterInstance);
					}
				}
				if (!characterInstance.Active)
				{
					CharacterItemData data = characterInstance.Data;
					Client client = default(Client);
					Profile profile = client.profile;
					Client client2 = default(Client);
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
					bool flag3 = default(bool);
					if (data.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField, (byte)num3 != 0) <= ScheduleType.Event && flag3 && !IsInScene(SceneType.House))
					{
						goto IL_0114;
					}
				}
			}
			goto IL_0164;
			IL_0114:
			if (!IsInScene(SceneType.Restaurant))
			{
				Client client3 = default(Client);
				ProfileWorld world_ = client3.profile.world_;
				Item restaurantItem = RestaurantItem;
				bool flag4 = default(bool);
				if (flag4)
				{
					bool flag5 = IsInScene(SceneType.PlayerHouse);
					if (!IsInScene(SceneType.Store))
					{
						Client client4 = default(Client);
						ProfileWorld world_2 = client4.profile.world_;
						Item storeItem = StoreItem;
						bool flag6 = default(bool);
						if (!flag6)
						{
						}
					}
				}
			}
			goto IL_0164;
			IL_0164:
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002719")]
			[Cpp2IlInjected.Address(RVA = "0x12E7090", Offset = "0x12E5A90", VA = "0x1812E7090")]
			static unsafe bool IsInScene(SceneType scene)
			{
				//Discarded unreachable code: IL_0016
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				return (IntPtr)"{il2cpp field on {'constant23' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == (IntPtr)(void*)(int)scene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026FF")]
		[Cpp2IlInjected.Address(RVA = "0x12DD030", Offset = "0x12DBA30", VA = "0x1812DD030")]
		private void ClearInternalCurrentCharacterSchedule()
		{
			//Discarded unreachable code: IL_002a
			List<CharacterInstance>[] array = characterPerScheduleType;
			int num = 0;
			if (num < array.Length)
			{
				((List<T>)(object)array[num]).Clear();
				List<CharacterInstance>[] array2 = characterPerScheduleType;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002700")]
		[Cpp2IlInjected.Address(RVA = "0x12E0F10", Offset = "0x12DF910", VA = "0x1812E0F10")]
		private bool GetInternalCurrentCharacterSchedule(CharacterInstance character, out ScheduleType scheduleType)
		{
			if (character != null)
			{
				List<CharacterInstance>[] array = characterPerScheduleType;
				int num = 0;
				if (0 < array.Length)
				{
					scheduleType.value__ = 1;
					if (!((List<T>)(object)characterPerScheduleType[num]).Contains((T)character))
					{
						List<CharacterInstance>[] array2 = characterPerScheduleType;
					}
					if (((HashSet<T>)(object)charactersInTheVillage).Contains((T)character))
					{
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002701")]
		[Cpp2IlInjected.Address(RVA = "0x12E6380", Offset = "0x12E4D80", VA = "0x1812E6380")]
		private void RemoveCharacterSchedule(CharacterInstance character)
		{
			//Discarded unreachable code: IL_0027
			List<CharacterInstance>[] array = characterPerScheduleType;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				bool flag = ((List<T>)(object)array[num]).Remove((T)character);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002702")]
		[Cpp2IlInjected.Address(RVA = "0x12DCCF0", Offset = "0x12DB6F0", VA = "0x1812DCCF0")]
		private void ChangeCurrentCharacterSchedule(CharacterInstance character, ScheduleType newScheduleType)
		{
			//Discarded unreachable code: IL_0046
			List<CharacterInstance>[] array = characterPerScheduleType;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				bool flag = ((List<T>)(object)array[num]).Remove((T)character);
				num++;
			}
			List<CharacterInstance>[] array2 = characterPerScheduleType;
			int num2 = (int)(newScheduleType - 1);
			((List<T>)(object)array2[num2]).Add((T)character);
		}

		[Cpp2IlInjected.Token(Token = "0x6002703")]
		[Cpp2IlInjected.Address(RVA = "0x12DCE00", Offset = "0x12DB800", VA = "0x1812DCE00")]
		private void ChangeCurrentCharacterSchedule(CharacterInstance character, ScheduleType oldScheduleType, ScheduleType newScheduleType)
		{
			//Discarded unreachable code: IL_003f
			if (oldScheduleType != newScheduleType)
			{
				List<CharacterInstance>[] array = characterPerScheduleType;
				int num = (int)(oldScheduleType - 1);
				bool flag = ((List<T>)(object)array[num]).Remove((T)character);
				List<CharacterInstance>[] array2 = characterPerScheduleType;
				int num2 = (int)(newScheduleType - 1);
				((List<T>)(object)array2[num2]).Add((T)character);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002704")]
		[Cpp2IlInjected.Address(RVA = "0x12E0510", Offset = "0x12DEF10", VA = "0x1812E0510")]
		public MissionSlotState GetCharacterMarkerState(Item characterItem)
		{
			//Discarded unreachable code: IL_008d
			//IL_0014: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			Item item = characterItem2;
			List<MissionSlot> cpp2il__autoParamName__idx_ = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(system.GetSlotsWithTargetCharacter(item));
			Func<MissionSlot, bool> cpp2il__autoParamName__idx_2 = (Func<MissionSlot, bool>)(object)new Func<T, TResult>(IsCompletedMarker);
			int num = 0;
			if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_2))
			{
				Func<MissionSlot, bool> cpp2il__autoParamName__idx_3 = (Func<MissionSlot, bool>)(object)new Func<T, TResult>(IsOnGoingMarker);
				if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_3))
				{
					Func<MissionSlot, bool> cpp2il__autoParamName__idx_4 = (Func<MissionSlot, bool>)(object)new Func<T, TResult>(IsAvailableMarker);
					int num2 = 0;
					bool flag = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_4);
				}
				return MissionSlotState.OnGoing;
			}
			return MissionSlotState.Completed;
			[Cpp2IlInjected.Token(Token = "0x60027D7")]
			[Cpp2IlInjected.Address(RVA = "0x13F6ED0", Offset = "0x13F58D0", VA = "0x1813F6ED0")]
			bool HasObjectiveMarker(MissionObjective obj)
			{
				//Discarded unreachable code: IL_0016
				if ((object)obj.TargetCharacterItem == null)
				{
				}
				if (HasTalkToCharacterMarker(obj))
				{
					return true;
				}
				bool result = default(bool);
				return result;
			}
			[Cpp2IlInjected.Token(Token = "0x600271C")]
			[Cpp2IlInjected.Address(RVA = "0x12E6FF0", Offset = "0x12E59F0", VA = "0x1812E6FF0")]
			static bool HasTalkToCharacterMarker(MissionObjective obj)
			{
				//Discarded unreachable code: IL_002a
				switch (obj.Data.customStepCase_)
				{
				case MissionObjectiveData.CustomStepOneofCase.TalkToCharacter:
					return true;
				default:
				{
					int num4 = 0;
					break;
				}
				case MissionObjectiveData.CustomStepOneofCase.FollowCharacter:
					break;
				}
				return obj.status_ == MissionStepStatus.ReadyToBeCompleted;
			}
			[Cpp2IlInjected.Token(Token = "0x600271B")]
			[Cpp2IlInjected.Address(RVA = "0x12E7040", Offset = "0x12E5A40", VA = "0x1812E7040")]
			static bool IsAvailableMarker(MissionSlot slot)
			{
				//Discarded unreachable code: IL_0012
				if (slot.state_ != MissionSlotState.Available)
				{
					int num3 = 0;
				}
				return slot.CanStartMission();
			}
			[Cpp2IlInjected.Token(Token = "0x600271A")]
			[Cpp2IlInjected.Address(RVA = "0x12E7070", Offset = "0x12E5A70", VA = "0x1812E7070")]
			static bool IsCompletedMarker(MissionSlot slot)
			{
				//Discarded unreachable code: IL_000a
				return slot.state_ == MissionSlotState.Completed;
			}
			[Cpp2IlInjected.Token(Token = "0x60027D6")]
			[Cpp2IlInjected.Address(RVA = "0x13F6FD0", Offset = "0x13F59D0", VA = "0x1813F6FD0")]
			bool IsOnGoingMarker(MissionSlot slot)
			{
				if (slot.state_ == MissionSlotState.OnGoing && slot.CurrentStep != null)
				{
					IEnumerable<MissionObjective> activeObjectives = (IEnumerable<MissionObjective>)slot.CurrentStep.get_ActiveObjectives();
					Func<MissionObjective, bool> cpp2il__autoParamName__idx_5 = (Func<MissionObjective, bool>)(object)new Func<T, TResult>(HasObjectiveMarker);
					return ((IEnumerable<>)activeObjectives).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_5);
				}
				int num5 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002705")]
		[Cpp2IlInjected.Address(RVA = "0x12DC6A0", Offset = "0x12DB0A0", VA = "0x1812DC6A0")]
		public unsafe MoodController ApplyMood(Vector3 origin, float radius, string mood, [System.Runtime.InteropServices.Optional] Func<Character, bool> predicate)
		{
			//Discarded unreachable code: IL_0063, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081
			//IL_0016: Expected F4, but got O
			//IL_0011: Expected native int or pointer, but got O
			//IL_004d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			_003C_003Ec__DisplayClass140_0 _003C_003Ec__DisplayClass140_ = new _003C_003Ec__DisplayClass140_0();
			((Vector3*)(IntPtr)_003C_003Ec__DisplayClass140_.origin)->z = (float)_003C_003Ec__DisplayClass140_;
			List<Character> list = (List<Character>)(object)new List<T>();
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			int num3 = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				int num4 = 0;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				((List<T>)(object)list).Add((T)num);
				CancellationToken token = cancellationTokenSource.Token;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002706")]
		[Cpp2IlInjected.Address(RVA = "0x12E3660", Offset = "0x12E2060", VA = "0x1812E3660")]
		private void OnCharacterSkinChanged(Item characterItem, Item skinItem, bool automatic)
		{
			if (GetCharacterInstance(characterItem) == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002707")]
		[Cpp2IlInjected.Address(RVA = "0x12E36A0", Offset = "0x12E20A0", VA = "0x1812E36A0")]
		private void OnCharacterStateChange(Item characterItem, Meta.Character.Types.CharacterStatus status, CharacterChangeStatusReason reason)
		{
			bool flag = default(bool);
			CharacterInstance characterInstance = default(CharacterInstance);
			Client client = default(Client);
			while (true)
			{
				int num = 0;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				if (reason == CharacterChangeStatusReason.Unlocked && flag)
				{
					return;
				}
				while (reason != CharacterChangeStatusReason.PlaceHouse)
				{
				}
				if (status != Meta.Character.Types.CharacterStatus.Unlocked)
				{
					break;
				}
				while (characterInstance == null)
				{
				}
				Meta.Character metaCharacter = characterInstance.MetaCharacter;
				Profile profile = client.profile;
				if (!metaCharacter.IsInactiveAndTargetedByMission(profile))
				{
					int num2 = 0;
					break;
				}
			}
			while (status != Meta.Character.Types.CharacterStatus.InVillage)
			{
			}
			if ((object)typeof(AsyncTaskMethodBuilder).TypeHandle != null)
			{
				Client client2 = default(Client);
				Profile profile2 = client2.profile;
				Client client3 = default(Client);
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client3.TransactionContext;
				ScheduleType scheduleType = default(ScheduleType);
				if (scheduleType == ScheduleType.Indoor)
				{
					int num3 = 0;
				}
			}
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002708")]
		[Cpp2IlInjected.Address(RVA = "0x12E4180", Offset = "0x12E2B80", VA = "0x1812E4180")]
		private void OnEventStarted(List<Item> characters)
		{
			//Discarded unreachable code: IL_001a
			CancellationToken token = cancellationTokenProvider.cancellationTokenSource.Token;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002709")]
		[Cpp2IlInjected.Address(RVA = "0x12E4050", Offset = "0x12E2A50", VA = "0x1812E4050")]
		[AsyncStateMachine(typeof(_003COnEventStartedAsync_003Ed__144))]
		private Task OnEventStartedAsync(List<Item> characters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600270A")]
		[Cpp2IlInjected.Address(RVA = "0x12E3EC0", Offset = "0x12E28C0", VA = "0x1812E3EC0")]
		private void OnEventEnded(List<Item> characters)
		{
			//Discarded unreachable code: IL_001a
			CancellationToken token = cancellationTokenProvider.cancellationTokenSource.Token;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600270B")]
		[Cpp2IlInjected.Address(RVA = "0x12E3DA0", Offset = "0x12E27A0", VA = "0x1812E3DA0")]
		[AsyncStateMachine(typeof(_003COnEventEndedAsync_003Ed__146))]
		private Task OnEventEndedAsync(List<Item> characters, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600270C")]
		[Cpp2IlInjected.Address(RVA = "0x12E4400", Offset = "0x12E2E00", VA = "0x1812E4400")]
		private void OnSecretCharacterVisitStarted(Meta.Character metaCharacter)
		{
			//Discarded unreachable code: IL_0020
			PrepareCharacterAsync().FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x60027E3")]
			[Cpp2IlInjected.Address(RVA = "0x13F7A30", Offset = "0x13F6430", VA = "0x1813F7A30")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass147_0._003C_003COnSecretCharacterVisitStarted_003Eg__PrepareCharacterAsync_007C0_003Ed))]
			Task PrepareCharacterAsync()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600270D")]
		[Cpp2IlInjected.Address(RVA = "0x12E1890", Offset = "0x12E0290", VA = "0x1812E1890")]
		[AsyncStateMachine(typeof(_003CInviteToVillage_003Ed__148))]
		public Task InviteToVillage(Item characterItem, CancellationToken ct, bool skipWelcomeMessage = false, bool skipPhotoMode = false, bool fastFade = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600270E")]
		[Cpp2IlInjected.Address(RVA = "0x12DD910", Offset = "0x12DC310", VA = "0x1812DD910")]
		public void DebugForceAllBehaviour(Character.DebugForceBehaviourType behaviourType)
		{
			//Discarded unreachable code: IL_0013, IL_0019
			List<CharacterInstance> list = allCharacters;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600270F")]
		[Cpp2IlInjected.Address(RVA = "0x12DD7B0", Offset = "0x12DC1B0", VA = "0x1812DD7B0")]
		public void DebugAllResetFreetimeMotivation()
		{
			//Discarded unreachable code: IL_0010, IL_0016
			List<CharacterInstance> list = allCharacters;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002710")]
		[Cpp2IlInjected.Address(RVA = "0x12E2F10", Offset = "0x12E1910", VA = "0x1812E2F10")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c, IL_0142
			//IL_00b2: Expected O, but got I4
			int num;
			SceneData sceneData = default(SceneData);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			Client client = default(Client);
			Client client2 = default(Client);
			ScheduleType scheduleType = default(ScheduleType);
			MissionManager missionManager = default(MissionManager);
			bool flag5 = default(bool);
			MissionManager missionManager2 = default(MissionManager);
			bool flag6 = default(bool);
			Vector3 vector = default(Vector3);
			float num6 = default(float);
			do
			{
				num = 0;
				int num2 = 0;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				List<CharacterInstance> list = allCharacters;
				if (!flag)
				{
					continue;
				}
				while (!flag2)
				{
				}
				while (flag3)
				{
				}
				while (!flag4)
				{
				}
				Profile profile = client.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
				if (scheduleType != ScheduleType.SpecificLocation)
				{
					if (num == (int)scheduleType)
					{
						missionManager = MissionManager;
						int price = ((glPlayFab.Disney.BattlePassReward)(object)this).Price;
					}
					if ((long)missionManager == 1)
					{
						HashSet<CharacterInstance> hashSet = charactersInTheVillage;
						if (!flag5)
						{
							HashSet<CharacterInstance> hashSet2 = charactersInTheVillage;
						}
					}
					missionManager2 = MissionManager;
					int price2 = ((glPlayFab.Disney.BattlePassReward)(object)this).Price;
					while (flag6)
					{
					}
					while ((object)missionManager2 == null)
					{
					}
				}
				int num3 = 0;
				if (!(missionManager2 != (UnityEngine.Object)num3))
				{
				}
				int num4 = 0;
				int num5 = 0;
				float z = vector.z;
				while (num6 <= 5f)
				{
				}
			}
			while (num != 0);
			shouldUpdateSchedule = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002711")]
		[Cpp2IlInjected.Address(RVA = "0x12E3600", Offset = "0x12E2000", VA = "0x1812E3600")]
		internal void OnCharacterSkinChanged(Character character)
		{
			//Discarded unreachable code: IL_000f
			Transform _003Ctransform_003Ek__BackingField = character.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002712")]
		[Cpp2IlInjected.Address(RVA = "0x12E1030", Offset = "0x12DFA30", VA = "0x1812E1030")]
		public InOnEnvEnterCharUpdateScope GetOnEnvEnterCharUpdateScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002713")]
		[Cpp2IlInjected.Address(RVA = "0x12E7D90", Offset = "0x12E6790", VA = "0x1812E7D90")]
		public CharacterManager()
		{
			//Discarded unreachable code: IL_01ce
			//IL_002f: Expected I4, but got I8
			List<CharacterInstance>[] array;
			List<CharacterInstance> list9;
			while (true)
			{
				Rand = new System.Random();
				MinutesBetweenCharactersGoingToAvatar = 3f;
				charactersInTheVillage = (HashSet<CharacterInstance>)(object)new HashSet<T>();
				MaximumNumberOfCharactersInTheVillage = 15;
				MinimumMinutesBetweenBarks = 1f;
				MaximumMinutesBetweenBarks = 5f;
				MinimumMinutesBeforeFirstConversation = 1f;
				MaximumMinutesBeforeFirstConversation = 3f;
				MinimumMinutesBetweenConversations = 15f;
				MaximumMinutesBetweenConversations = 30f;
				allCharacters = (List<CharacterInstance>)(object)new List<T>();
				array = new List<CharacterInstance>[9];
				List<CharacterInstance> list = (List<CharacterInstance>)(object)new List<T>();
				if (list != null && list == null)
				{
					continue;
				}
				array[0] = list;
				List<CharacterInstance> list2 = (List<CharacterInstance>)(object)new List<T>();
				if (list2 != null && list2 == null)
				{
					continue;
				}
				array[1] = list2;
				List<CharacterInstance> list3 = (List<CharacterInstance>)(object)new List<T>();
				if (list3 != null && list3 == null)
				{
					continue;
				}
				array[2] = list3;
				List<CharacterInstance> list4 = (List<CharacterInstance>)(object)new List<T>();
				if (list4 != null && list4 == null)
				{
					continue;
				}
				array[3] = list4;
				List<CharacterInstance> list5 = (List<CharacterInstance>)(object)new List<T>();
				if (list5 != null && list5 == null)
				{
					continue;
				}
				array[4] = list5;
				List<CharacterInstance> list6 = (List<CharacterInstance>)(object)new List<T>();
				if (list6 != null && list6 == null)
				{
					continue;
				}
				array[5] = list6;
				List<CharacterInstance> list7 = (List<CharacterInstance>)(object)new List<T>();
				if (list7 != null && list7 == null)
				{
					continue;
				}
				array[6] = list7;
				List<CharacterInstance> list8 = (List<CharacterInstance>)(object)new List<T>();
				if (list8 == null || list8 != null)
				{
					array[7] = list8;
					list9 = (List<CharacterInstance>)(object)new List<T>();
					if (list9 == null || list9 != null)
					{
						break;
					}
				}
			}
			array[8] = list9;
			characterPerScheduleType = array;
			overriddenCharacters = (HashSet<CharacterInstance>)(object)new HashSet<T>();
			shouldUpdateSchedule = true;
			SpawnCounts = new CharacterSpawnTracker
			{
				spawnCounts = (Dictionary<object, int>)(object)new Dictionary<TKey, TValue>()
			};
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002714")]
		[Cpp2IlInjected.Address(RVA = "0x12E7BE0", Offset = "0x12E65E0", VA = "0x1812E7BE0")]
		static CharacterManager()
		{
			activeCharacters = (Func<CharacterInstance, bool>)(object)(Func<T, TResult>)delegate(CharacterInstance instance)
			{
				//Discarded unreachable code: IL_0027
				bool active = instance.Active;
				if (!active)
				{
					return active;
				}
				Meta.Character metaCharacter = instance.MetaCharacter;
				return metaCharacter == null || metaCharacter.status_ != Meta.Character.Types.CharacterStatus.Secret;
			};
			activeCharacters = (Func<CharacterInstance, bool>)(object)(Func<T, TResult>)((CharacterInstance instance) => instance.Character);
			/*Error: Unexpected end of block*/;
		}
	}
}
