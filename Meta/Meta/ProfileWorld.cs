using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Keyholes;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Mdl.Utils;
using Meta.Grids;
using Meta.Missions;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000946")]
	public sealed class ProfileWorld : IMessage<ProfileWorld>, IMessage, IEquatable<ProfileWorld>, IDeepCloneable<ProfileWorld>, IMessageFieldAccessor, IProfileWorld, IKeyholesProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000947")]
		internal struct SubGridItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400268D")]
			public Item Item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400268E")]
			public int Amount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400268F")]
			public ItemState ItemState;
		}

		[Cpp2IlInjected.Token(Token = "0x2000948")]
		public class NoFriendshipEvent : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002690")]
			private readonly Player Player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002691")]
			private readonly World World;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002692")]
			private readonly ITransactionContext Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4002693")]
			private readonly Dictionary<Item, Dictionary<FriendshipSource, int>> FriendshipEvents;

			[Cpp2IlInjected.Token(Token = "0x600520B")]
			[Cpp2IlInjected.Address(RVA = "0xEA3C10", Offset = "0xEA2610", VA = "0x180EA3C10")]
			internal static IDisposable Scope(in Player player, in World world, ITransactionContext context)
			{
				NoFriendshipEvent noFriendshipEvent = default(NoFriendshipEvent);
				noFriendshipEvent.Context = context;
				Dictionary<Item, Dictionary<FriendshipSource, int>> dictionary = (noFriendshipEvent.FriendshipEvents = (Dictionary<Item, Dictionary<FriendshipSource, int>>)(object)new Dictionary<TKey, TValue>());
				ProfileWorld profileWorld = default(ProfileWorld);
				profileWorld._noFriendshipEvent = noFriendshipEvent;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600520C")]
			[Cpp2IlInjected.Address(RVA = "0xEA3D30", Offset = "0xEA2730", VA = "0x180EA3D30")]
			internal NoFriendshipEvent(in Player player, in World world, ITransactionContext context)
			{
				Context = context;
				Dictionary<Item, Dictionary<FriendshipSource, int>> dictionary = (FriendshipEvents = (Dictionary<Item, Dictionary<FriendshipSource, int>>)(object)new Dictionary<TKey, TValue>());
				ProfileWorld profileWorld = default(ProfileWorld);
				profileWorld._noFriendshipEvent = this;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600520D")]
			[Cpp2IlInjected.Address(RVA = "0xEA35F0", Offset = "0xEA1FF0", VA = "0x180EA35F0")]
			public void AddCharacterFriendship(Item characterItem, int amount, FriendshipSource source)
			{
				//Discarded unreachable code: IL_000d, IL_0018, IL_0024, IL_002a, IL_0030, IL_003d, IL_0043, IL_0044
				Dictionary<Item, Dictionary<FriendshipSource, int>> friendshipEvents = FriendshipEvents;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600520E")]
			[Cpp2IlInjected.Address(RVA = "0xEA37E0", Offset = "0xEA21E0", VA = "0x180EA37E0", Slot = "4")]
			public unsafe void Dispose()
			{
				//Discarded unreachable code: IL_0083, IL_008f, IL_0095, IL_009b, IL_00a1, IL_00a7
				//IL_000b: Expected O, but got I4
				//IL_0020: Expected O, but got I4
				//IL_0032: Expected O, but got I4
				ProfileWorld profileWorld = default(ProfileWorld);
				bool flag = default(bool);
				ProfileWorld profileWorld2 = default(ProfileWorld);
				ProfilePlayer profilePlayer = default(ProfilePlayer);
				bool flag2 = default(bool);
				AddedFriendshipSummary other = default(AddedFriendshipSummary);
				while (true)
				{
					int num = 0;
					int num2 = 0;
					profileWorld._noFriendshipEvent = (NoFriendshipEvent)num;
					Dictionary<Item, Dictionary<FriendshipSource, int>> friendshipEvents = FriendshipEvents;
					if (flag)
					{
						if (!profileWorld2.TryGetCharacter((Item)num, out *(Character*)num))
						{
							continue;
						}
						AddedFriendshipSummary addedFriendshipSummary = new AddedFriendshipSummary();
						addedFriendshipSummary.CharacterItem = (Item)num;
						addedFriendshipSummary.PreviousCharacterFriendship = num;
						int num3 = (addedFriendshipSummary.PreviousPlayerXP = profilePlayer.xp_);
						addedFriendshipSummary.FriendshipGained = num;
						if (flag2)
						{
							ITransactionContext context = Context;
							addedFriendshipSummary.MergeWith(other);
						}
						if (num != 0)
						{
							break;
						}
						IWorldEventDispatcher dispatcher = World.dispatcher;
					}
					if (num == 0)
					{
						return;
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000949")]
		public class FilterInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002695")]
			private ItemFilterData ItemFilterCache;

			[Cpp2IlInjected.Token(Token = "0x17000E2F")]
			public MissionSlot MissionSlot
			{
				[Cpp2IlInjected.Token(Token = "0x600520F")]
				[Cpp2IlInjected.Address(RVA = "0xE9C470", Offset = "0xE9AE70", VA = "0x180E9C470")]
				get
				{
					List<MissionObjective> list = Objectives;
					if (list != null)
					{
						MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)list);
						if (missionObjective != null)
						{
							return missionObjective.MissionSlot;
						}
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E30")]
			public List<MissionObjective> Objectives
			{
				[Cpp2IlInjected.Token(Token = "0x6005210")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CObjectives_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6005211")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CObjectives_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E31")]
			private bool IsSingleFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6005212")]
				[Cpp2IlInjected.Address(RVA = "0xE9BEC0", Offset = "0xE9A8C0", VA = "0x180E9BEC0")]
				get
				{
					//Discarded unreachable code: IL_002e
					List<MissionObjective> list = Objectives;
					Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
					if (_003C_003Ec._003C_003E9__7_0 == null)
					{
						func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => default(bool)));
					}
					return ((IEnumerable<>)list).All<MissionObjective>((Func<, >)(object)func);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E32")]
			public ItemFilterData ItemFilterData
			{
				[Cpp2IlInjected.Token(Token = "0x6005213")]
				[Cpp2IlInjected.Address(RVA = "0xE9C010", Offset = "0xE9AA10", VA = "0x180E9C010")]
				get
				{
					if ((long)ItemFilterCache == 0)
					{
						List<MissionObjective> list = Objectives;
						List<MissionObjective> list2 = Objectives;
						Func<MissionObjective, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
						if (_003C_003E9__7_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
						}
						if (!((IEnumerable<>)list2).All<MissionObjective>((Func<, >)(object)_003C_003E9__7_))
						{
							int num = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							throw new NullReferenceException();
						}
						List<MissionObjective> list3 = Objectives;
						Func<MissionObjective, IEnumerable<Item>> func = default(Func<MissionObjective, IEnumerable<Item>>);
						if (_003C_003Ec._003C_003E9__10_0 == null)
						{
							func = (Func<MissionObjective, IEnumerable<Item>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => null));
						}
						IEnumerable<Item> enumerable = (IEnumerable<Item>)Enumerable.Distinct<Item>(Enumerable.SelectMany<MissionObjective, Item>((IEnumerable<>)list3, (Func<, >)(object)func));
						Func<Item, int> func2 = default(Func<Item, int>);
						if (_003C_003Ec._003C_003E9__10_1 == null)
						{
							func2 = (Func<Item, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => default(int)));
						}
						IEnumerable<Item> enumerable2 = (IEnumerable<Item>)Enumerable.Select<Item, int>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
						ItemFilterData itemFilterData = (ItemFilterCache = new ItemFilterData());
					}
					return (ItemFilterData)typeof(_003C_003Ec).TypeHandle;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005214")]
			[Cpp2IlInjected.Address(RVA = "0xE9B430", Offset = "0xE99E30", VA = "0x180E9B430")]
			[IteratorStateMachine(typeof(_003CEnumSingleFilter_003Ed__11))]
			public static IEnumerable<FilterInfo> EnumSingleFilter(IEnumerable<FilterInfo> filters)
			{
				new _003CEnumSingleFilter_003Ed__11(-2)._003C_003E3__filters = filters;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005215")]
			[Cpp2IlInjected.Address(RVA = "0xE9B5B0", Offset = "0xE99FB0", VA = "0x180E9B5B0")]
			[IteratorStateMachine(typeof(_003CGetMissionsByFilter_003Ed__12))]
			private static IEnumerable<FilterInfo> GetMissionsByFilter(ProfileWorld world, Func<MissionObjective, bool> predicate, MissionObjectiveData.CustomStepOneofCase customStep = MissionObjectiveData.CustomStepOneofCase.None, MissionObjectiveData.CustomStepOneofCase excludedStep = MissionObjectiveData.CustomStepOneofCase.None, bool onlyActiveMissions = true, bool onlyActiveObjectives = true)
			{
				_003CGetMissionsByFilter_003Ed__12 _003CGetMissionsByFilter_003Ed__ = new _003CGetMissionsByFilter_003Ed__12(-2);
				_003CGetMissionsByFilter_003Ed__._003C_003E3__world = world;
				_003CGetMissionsByFilter_003Ed__._003C_003E3__predicate = predicate;
				_003CGetMissionsByFilter_003Ed__._003C_003E3__onlyActiveMissions = false;
				_003CGetMissionsByFilter_003Ed__._003C_003E3__onlyActiveObjectives = false;
				_003CGetMissionsByFilter_003Ed__._003C_003E3__excludedStep = excludedStep;
				_003CGetMissionsByFilter_003Ed__._003C_003E3__customStep = customStep;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005216")]
			[Cpp2IlInjected.Address(RVA = "0xE9BB20", Offset = "0xE9A520", VA = "0x180E9BB20")]
			public static IEnumerable<FilterInfo> GetMissionsByStepType(ProfileWorld world, MissionObjectiveData.CustomStepOneofCase customStep)
			{
				if (_003C_003Ec._003C_003E9__13_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				}
				IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6005217")]
			[Cpp2IlInjected.Address(RVA = "0xE9B4A0", Offset = "0xE99EA0", VA = "0x180E9B4A0")]
			public static IEnumerable<FilterInfo> GetMissionsByFilter(ProfileWorld world, List<ItemType> itemTypes, GoBehavior mask, MissionObjectiveData.CustomStepOneofCase customStep = MissionObjectiveData.CustomStepOneofCase.None, MissionObjectiveData.CustomStepOneofCase excludedStep = MissionObjectiveData.CustomStepOneofCase.None)
			{
				//Discarded unreachable code: IL_0026
				_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
				CS_0024_003C_003E8__locals0.itemTypes = itemTypes;
				CS_0024_003C_003E8__locals0.mask = mask;
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6005218")]
			[Cpp2IlInjected.Address(RVA = "0xE9B770", Offset = "0xE9A170", VA = "0x180E9B770")]
			public static IEnumerable<FilterInfo> GetMissionsByFilter(ProfileWorld world, ItemType itemType, GoBehavior mask, MissionObjectiveData.CustomStepOneofCase customStep = MissionObjectiveData.CustomStepOneofCase.None)
			{
				//Discarded unreachable code: IL_0028
				_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
				CS_0024_003C_003E8__locals0.itemType = itemType;
				CS_0024_003C_003E8__locals0.mask = mask;
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6005219")]
			[Cpp2IlInjected.Address(RVA = "0xE9B670", Offset = "0xE9A070", VA = "0x180E9B670")]
			public static IEnumerable<FilterInfo> GetMissionsByFilter(ProfileWorld world, ActivityItemType activityItemType, GoBehavior mask, MissionObjectiveData.CustomStepOneofCase customStep = MissionObjectiveData.CustomStepOneofCase.None)
			{
				//Discarded unreachable code: IL_0028
				_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
				CS_0024_003C_003E8__locals0.activityItemType = activityItemType;
				CS_0024_003C_003E8__locals0.mask = mask;
				Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600521A")]
			[Cpp2IlInjected.Address(RVA = "0xE9B870", Offset = "0xE9A270", VA = "0x180E9B870")]
			public static IEnumerable<FilterInfo> GetMissionsByGardeningFilter(ProfileWorld world)
			{
				//IL_0031: Expected I4, but got I8
				//IL_0031: Expected I4, but got I8
				Func<MissionObjective, bool> _003C_003E9__17_ = _003C_003Ec._003C_003E9__17_0;
				if (_003C_003E9__17_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				}
				int num = 0;
				int num2 = 0;
				ulong num3 = default(ulong);
				ulong num4 = default(ulong);
				return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByFilter(world, (Func<, >)(object)_003C_003E9__17_, (MissionObjectiveData.CustomStepOneofCase)num2, (MissionObjectiveData.CustomStepOneofCase)num, (byte)num3 != 0, (byte)num4 != 0);
			}

			[Cpp2IlInjected.Token(Token = "0x600521B")]
			[Cpp2IlInjected.Address(RVA = "0xE9B9A0", Offset = "0xE9A3A0", VA = "0x180E9B9A0")]
			public static IEnumerable<FilterInfo> GetMissionsByItem(ProfileWorld world, IItemData itemData, ItemState state)
			{
				//Discarded unreachable code: IL_0056
				_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
				CS_0024_003C_003E8__locals0.itemData = itemData;
				CS_0024_003C_003E8__locals0.state = state;
				CS_0024_003C_003E8__locals0.world = world;
				bool flag = CS_0024_003C_003E8__locals0.itemData.IsMissionItem();
				ProfileWorld world2 = CS_0024_003C_003E8__locals0.world;
				if (flag)
				{
					Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				}
				Func<MissionObjective, bool> func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => default(bool));
				int num = 0;
				int num2 = 0;
				IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600521C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FilterInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002637")]
		private static readonly MessageParser<ProfileWorld> _parser = (MessageParser<ProfileWorld>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ProfileWorld()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002638")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002639")]
		public const int VillageFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400263A")]
		private Village village_;

		[Cpp2IlInjected.Token(Token = "0x400263B")]
		public const int PlayerHouseFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400263C")]
		private House playerHouse_;

		[Cpp2IlInjected.Token(Token = "0x400263D")]
		public const int CharactersFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400263E")]
		private static readonly FieldCodec<Character> _repeated_characters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400263F")]
		private readonly RepeatedField<Character> characters_;

		[Cpp2IlInjected.Token(Token = "0x4002640")]
		public const int GridCollectionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002641")]
		private GridCollection gridCollection_;

		[Cpp2IlInjected.Token(Token = "0x4002642")]
		public const int RealmsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002643")]
		private static readonly MapField<string, Realm>.Codec _map_realms_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002644")]
		private readonly MapField<string, Realm> realms_;

		[Cpp2IlInjected.Token(Token = "0x4002645")]
		public const int PendingFishesFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002646")]
		private static readonly MapField<uint, PendingFish>.Codec _map_pendingFishes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002647")]
		private readonly MapField<uint, PendingFish> pendingFishes_;

		[Cpp2IlInjected.Token(Token = "0x4002648")]
		public const int NextPendingFishIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002649")]
		private uint nextPendingFishID_;

		[Cpp2IlInjected.Token(Token = "0x400264A")]
		public const int ShopsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x400264B")]
		private static readonly FieldCodec<Shop> _repeated_shops_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400264C")]
		private readonly RepeatedField<Shop> shops_;

		[Cpp2IlInjected.Token(Token = "0x400264D")]
		public const int UnlockedBuildingsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x400264E")]
		private static readonly FieldCodec<int> _repeated_unlockedBuildings_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400264F")]
		private readonly RepeatedField<int> unlockedBuildings_;

		[Cpp2IlInjected.Token(Token = "0x4002650")]
		public const int BuildingInfosFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4002651")]
		private static readonly MapField<int, BuildingInfo>.Codec _map_buildingInfos_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002652")]
		private readonly MapField<int, BuildingInfo> buildingInfos_;

		[Cpp2IlInjected.Token(Token = "0x4002653")]
		public const int OffGridBuildingsFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4002654")]
		private static readonly MapField<int, OffGridBuilding>.Codec _map_offGridBuildings_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002655")]
		private readonly MapField<int, OffGridBuilding> offGridBuildings_;

		[Cpp2IlInjected.Token(Token = "0x4002656")]
		public const int CharacterRestaurantOrdersFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4002657")]
		private static readonly FieldCodec<CharacterRestaurantOrder> _repeated_characterRestaurantOrders_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002658")]
		private readonly RepeatedField<CharacterRestaurantOrder> characterRestaurantOrders_;

		[Cpp2IlInjected.Token(Token = "0x4002659")]
		public const int CrittersFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x400265A")]
		private static readonly FieldCodec<Critter> _repeated_critters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400265B")]
		private readonly RepeatedField<Critter> critters_;

		[Cpp2IlInjected.Token(Token = "0x400265C")]
		public const int BurningStateFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400265D")]
		private BurningState burningState_;

		[Cpp2IlInjected.Token(Token = "0x400265E")]
		public const int StoresFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x400265F")]
		private static readonly FieldCodec<StoreInfo> _repeated_stores_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002660")]
		private readonly RepeatedField<StoreInfo> stores_;

		[Cpp2IlInjected.Token(Token = "0x4002661")]
		public const int KeyholesFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4002662")]
		private static readonly MapField<string, Keyhole>.Codec _map_keyholes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002663")]
		private readonly MapField<string, Keyhole> keyholes_;

		[Cpp2IlInjected.Token(Token = "0x4002664")]
		public const int MissionSlotsFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4002665")]
		private static readonly MapField<int, MissionQueue>.Codec _map_missionSlots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002666")]
		private readonly MapField<int, MissionQueue> missionSlots_;

		[Cpp2IlInjected.Token(Token = "0x4002667")]
		public const int QuestInfoFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002668")]
		private QuestInformation questInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002669")]
		public const int LastDiscussionsFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x400266A")]
		private static readonly FieldCodec<DiscussionRecord> _repeated_lastDiscussions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400266B")]
		private readonly RepeatedField<DiscussionRecord> lastDiscussions_;

		[Cpp2IlInjected.Token(Token = "0x400266C")]
		public const int FriendshipChoicesFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x400266D")]
		private static readonly MapField<int, ListId>.Codec _map_friendshipChoices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400266E")]
		private readonly MapField<int, ListId> friendshipChoices_;

		[Cpp2IlInjected.Token(Token = "0x400266F")]
		public const int DialogueFlagsFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4002670")]
		private static readonly FieldCodec<int> _repeated_dialogueFlags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002671")]
		private readonly RepeatedField<int> dialogueFlags_;

		[Cpp2IlInjected.Token(Token = "0x4002672")]
		public const int CastleLevelFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002673")]
		private int castleLevel_;

		[Cpp2IlInjected.Token(Token = "0x4002674")]
		public const int WishingWellLevelFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4002675")]
		private int wishingWellLevel_;

		[Cpp2IlInjected.Token(Token = "0x4002676")]
		public const int KitchenStallLevelFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002677")]
		private int kitchenStallLevel_;

		[Cpp2IlInjected.Token(Token = "0x4002678")]
		public const int CurrentWeatherFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002679")]
		private string currentWeather_;

		[Cpp2IlInjected.Token(Token = "0x400267A")]
		public const int NextWeatherCheckFieldNumber = 26;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400267B")]
		private Timestamp nextWeatherCheck_;

		[Cpp2IlInjected.Token(Token = "0x400267C")]
		public const int TimeZoneOffsetFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400267D")]
		private Duration timeZoneOffset_;

		[Cpp2IlInjected.Token(Token = "0x400267E")]
		public const int TimeZoneOffsetIsDSTFieldNumber = 28;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400267F")]
		private bool timeZoneOffsetIsDST_;

		[Cpp2IlInjected.Token(Token = "0x4002680")]
		public const int RecurringEventsFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x4002681")]
		private static readonly MapField<uint, RecurringEvent>.Codec _map_recurringEvents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002682")]
		private readonly MapField<uint, RecurringEvent> recurringEvents_;

		[Cpp2IlInjected.Token(Token = "0x4002683")]
		public const int NextRecurringEventIDFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002684")]
		private uint nextRecurringEventID_;

		[Cpp2IlInjected.Token(Token = "0x4002685")]
		public const int FishedVillageAreasFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4002686")]
		private static readonly FieldCodec<FishingPerVillageArea> _repeated_fishedVillageAreas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002687")]
		private readonly RepeatedField<FishingPerVillageArea> fishedVillageAreas_;

		[Cpp2IlInjected.Token(Token = "0x4002688")]
		public const int UncursedLightLockedTimerFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002689")]
		private int uncursedLightLockedTimer_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400268A")]
		private NoFriendshipEvent _noFriendshipEvent;

		[Cpp2IlInjected.Token(Token = "0x400268B")]
		private static readonly MissionSlotClass[] EnumMissionSlotClass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400268C")]
		private Dictionary<Item, bool> DialogueFlagsOverride;

		[Cpp2IlInjected.Token(Token = "0x17000E08")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfileWorld> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600515E")]
			[Cpp2IlInjected.Address(RVA = "0x148A290", Offset = "0x1488C90", VA = "0x18148A290")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E09")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600515F")]
			[Cpp2IlInjected.Address(RVA = "0x148A160", Offset = "0x1488B60", VA = "0x18148A160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005160")]
			[Cpp2IlInjected.Address(RVA = "0x148A300", Offset = "0x1488D00", VA = "0x18148A300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0B")]
		[DebuggerNonUserCode]
		public Village Village
		{
			[Cpp2IlInjected.Token(Token = "0x6005165")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return village_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005166")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				village_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0C")]
		[DebuggerNonUserCode]
		public House PlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6005167")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playerHouse_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005168")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				playerHouse_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0D")]
		[DebuggerNonUserCode]
		public RepeatedField<Character> Characters
		{
			[Cpp2IlInjected.Token(Token = "0x6005169")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return characters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0E")]
		[DebuggerNonUserCode]
		public GridCollection GridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x600516A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return gridCollection_;
			}
			[Cpp2IlInjected.Token(Token = "0x600516B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				gridCollection_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0F")]
		[DebuggerNonUserCode]
		public MapField<string, Realm> Realms
		{
			[Cpp2IlInjected.Token(Token = "0x600516C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return realms_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E10")]
		[DebuggerNonUserCode]
		public MapField<uint, PendingFish> PendingFishes
		{
			[Cpp2IlInjected.Token(Token = "0x600516D")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return pendingFishes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E11")]
		[DebuggerNonUserCode]
		public uint NextPendingFishID
		{
			[Cpp2IlInjected.Token(Token = "0x600516E")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return nextPendingFishID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600516F")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				nextPendingFishID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E12")]
		[DebuggerNonUserCode]
		public RepeatedField<Shop> Shops
		{
			[Cpp2IlInjected.Token(Token = "0x6005170")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return shops_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E13")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UnlockedBuildings
		{
			[Cpp2IlInjected.Token(Token = "0x6005171")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return unlockedBuildings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E14")]
		[DebuggerNonUserCode]
		public MapField<int, BuildingInfo> BuildingInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6005172")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return buildingInfos_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E15")]
		[DebuggerNonUserCode]
		public MapField<int, OffGridBuilding> OffGridBuildings
		{
			[Cpp2IlInjected.Token(Token = "0x6005173")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return offGridBuildings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E16")]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterRestaurantOrder> CharacterRestaurantOrders
		{
			[Cpp2IlInjected.Token(Token = "0x6005174")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return characterRestaurantOrders_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E17")]
		[DebuggerNonUserCode]
		public RepeatedField<Critter> Critters
		{
			[Cpp2IlInjected.Token(Token = "0x6005175")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return critters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E18")]
		[DebuggerNonUserCode]
		public BurningState BurningState
		{
			[Cpp2IlInjected.Token(Token = "0x6005176")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return burningState_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005177")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E19")]
		[DebuggerNonUserCode]
		public RepeatedField<StoreInfo> Stores
		{
			[Cpp2IlInjected.Token(Token = "0x6005178")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return stores_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1A")]
		[DebuggerNonUserCode]
		public MapField<string, Keyhole> Keyholes
		{
			[Cpp2IlInjected.Token(Token = "0x6005179")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return keyholes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1B")]
		[DebuggerNonUserCode]
		public MapField<int, MissionQueue> MissionSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600517A")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return missionSlots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1C")]
		[DebuggerNonUserCode]
		public QuestInformation QuestInfo
		{
			[Cpp2IlInjected.Token(Token = "0x600517B")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return questInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x600517C")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			set
			{
				questInfo_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1D")]
		[DebuggerNonUserCode]
		public RepeatedField<DiscussionRecord> LastDiscussions
		{
			[Cpp2IlInjected.Token(Token = "0x600517D")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return lastDiscussions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1E")]
		[DebuggerNonUserCode]
		public MapField<int, ListId> FriendshipChoices
		{
			[Cpp2IlInjected.Token(Token = "0x600517E")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return friendshipChoices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1F")]
		[DebuggerNonUserCode]
		public RepeatedField<int> DialogueFlags
		{
			[Cpp2IlInjected.Token(Token = "0x600517F")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return dialogueFlags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E20")]
		[DebuggerNonUserCode]
		public int CastleLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005180")]
			[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150")]
			get
			{
				return castleLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005181")]
			[Cpp2IlInjected.Address(RVA = "0x148A410", Offset = "0x1488E10", VA = "0x18148A410")]
			set
			{
				castleLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E21")]
		[DebuggerNonUserCode]
		public int WishingWellLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005182")]
			[Cpp2IlInjected.Address(RVA = "0x148A2F0", Offset = "0x1488CF0", VA = "0x18148A2F0")]
			get
			{
				return wishingWellLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005183")]
			[Cpp2IlInjected.Address(RVA = "0x148A4B0", Offset = "0x1488EB0", VA = "0x18148A4B0")]
			set
			{
				wishingWellLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E22")]
		[DebuggerNonUserCode]
		public int KitchenStallLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005184")]
			[Cpp2IlInjected.Address(RVA = "0x148A270", Offset = "0x1488C70", VA = "0x18148A270")]
			get
			{
				return kitchenStallLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005185")]
			[Cpp2IlInjected.Address(RVA = "0x148A490", Offset = "0x1488E90", VA = "0x18148A490")]
			set
			{
				kitchenStallLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E23")]
		[DebuggerNonUserCode]
		public string CurrentWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6005186")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0", Slot = "17")]
			get
			{
				return currentWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005187")]
			[Cpp2IlInjected.Address(RVA = "0x148A420", Offset = "0x1488E20", VA = "0x18148A420")]
			set
			{
				string text = (currentWeather_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E24")]
		[DebuggerNonUserCode]
		public Timestamp NextWeatherCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6005188")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80", Slot = "18")]
			get
			{
				return nextWeatherCheck_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005189")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			set
			{
				nextWeatherCheck_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E25")]
		[DebuggerNonUserCode]
		public Duration TimeZoneOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600518A")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return timeZoneOffset_;
			}
			[Cpp2IlInjected.Token(Token = "0x600518B")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			set
			{
				timeZoneOffset_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E26")]
		[DebuggerNonUserCode]
		public bool TimeZoneOffsetIsDST
		{
			[Cpp2IlInjected.Token(Token = "0x600518C")]
			[Cpp2IlInjected.Address(RVA = "0x13389E0", Offset = "0x13373E0", VA = "0x1813389E0")]
			get
			{
				return timeZoneOffsetIsDST_;
			}
			[Cpp2IlInjected.Token(Token = "0x600518D")]
			[Cpp2IlInjected.Address(RVA = "0x1339840", Offset = "0x1338240", VA = "0x181339840")]
			set
			{
				timeZoneOffsetIsDST_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E27")]
		[DebuggerNonUserCode]
		public MapField<uint, RecurringEvent> RecurringEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600518E")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return recurringEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E28")]
		[DebuggerNonUserCode]
		public uint NextRecurringEventID
		{
			[Cpp2IlInjected.Token(Token = "0x600518F")]
			[Cpp2IlInjected.Address(RVA = "0x148A280", Offset = "0x1488C80", VA = "0x18148A280")]
			get
			{
				return nextRecurringEventID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005190")]
			[Cpp2IlInjected.Address(RVA = "0x148A4A0", Offset = "0x1488EA0", VA = "0x18148A4A0")]
			set
			{
				nextRecurringEventID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E29")]
		[DebuggerNonUserCode]
		public RepeatedField<FishingPerVillageArea> FishedVillageAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6005191")]
			[Cpp2IlInjected.Address(RVA = "0x7389E0", Offset = "0x7373E0", VA = "0x1807389E0")]
			get
			{
				return fishedVillageAreas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2A")]
		[DebuggerNonUserCode]
		public int UncursedLightLockedTimer
		{
			[Cpp2IlInjected.Token(Token = "0x6005192")]
			[Cpp2IlInjected.Address(RVA = "0xE58430", Offset = "0xE56E30", VA = "0x180E58430")]
			get
			{
				return uncursedLightLockedTimer_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005193")]
			[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE56E80", VA = "0x180E58480")]
			set
			{
				uncursedLightLockedTimer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2B")]
		Item IProfileWorld.PlayerHouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x60051C5")]
			[Cpp2IlInjected.Address(RVA = "0x147D370", Offset = "0x147BD70", VA = "0x18147D370", Slot = "47")]
			get
			{
				//Discarded unreachable code: IL_000c
				return playerHouse_.HouseItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2C")]
		IEnumerable<Item> IProfileWorld.MissionsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60051EB")]
			[Cpp2IlInjected.Address(RVA = "0x147D230", Offset = "0x147BC30", VA = "0x18147D230", Slot = "32")]
			get
			{
				//Discarded unreachable code: IL_0033
				RepeatedField<int> missionsCompleted_ = questInfo_.missionsCompleted_;
				Func<int, Item> _003C_003E9__266_ = _003C_003Ec._003C_003E9__266_0;
				if (_003C_003E9__266_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
				}
				return (IEnumerable<Item>)Enumerable.Select<int, Item>((IEnumerable<>)(object)missionsCompleted_, (Func<, >)(object)_003C_003E9__266_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2D")]
		IEnumerable<Item> IProfileWorld.MissionsActive
		{
			[Cpp2IlInjected.Token(Token = "0x60051EC")]
			[Cpp2IlInjected.Address(RVA = "0x147D020", Offset = "0x147BA20", VA = "0x18147D020", Slot = "33")]
			get
			{
				//Discarded unreachable code: IL_004e
				Func<MissionSlot, bool> _003C_003E9__268_ = _003C_003Ec._003C_003E9__268_0;
				if (_003C_003E9__268_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot x)
					{
						if (x == null)
						{
							int num = 0;
							/*Error: Unexpected end of block*/;
						}
						return x.IsValid;
					};
				}
				IEnumerable<MissionSlot> allMissionSlot = (IEnumerable<MissionSlot>)this.GetAllMissionSlot((Func<, >)(object)_003C_003E9__268_);
				Func<MissionSlot, Item> func = default(Func<MissionSlot, Item>);
				if (_003C_003Ec._003C_003E9__268_1 == null)
				{
					func = (Func<MissionSlot, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot x)
					{
						int iD = x.Data.ID;
						throw new NullReferenceException();
					});
				}
				return (IEnumerable<Item>)Enumerable.Select<MissionSlot, Item>((IEnumerable<>)allMissionSlot, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2E")]
		public bool HasDialogueFlagsOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60051FA")]
			[Cpp2IlInjected.Address(RVA = "0x148A230", Offset = "0x1488C30", VA = "0x18148A230")]
			get
			{
				return Enumerable.Any<KeyValuePair<Item, bool>>((IEnumerable<>)DialogueFlagsOverride);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005161")]
		[Cpp2IlInjected.Address(RVA = "0x1489530", Offset = "0x1487F30", VA = "0x181489530")]
		[DebuggerNonUserCode]
		public ProfileWorld()
		{
			characters_ = (RepeatedField<Character>)(object)new RepeatedField<T>();
			realms_ = (MapField<string, Realm>)(object)new MapField<TKey, TValue>();
			pendingFishes_ = (MapField<uint, PendingFish>)(object)new MapField<TKey, TValue>();
			shops_ = (RepeatedField<Shop>)(object)new RepeatedField<T>();
			unlockedBuildings_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			buildingInfos_ = (MapField<int, BuildingInfo>)(object)new MapField<TKey, TValue>();
			offGridBuildings_ = (MapField<int, OffGridBuilding>)(object)new MapField<TKey, TValue>();
			characterRestaurantOrders_ = (RepeatedField<CharacterRestaurantOrder>)(object)new RepeatedField<T>();
			critters_ = (RepeatedField<Critter>)(object)new RepeatedField<T>();
			stores_ = (RepeatedField<StoreInfo>)(object)new RepeatedField<T>();
			keyholes_ = (MapField<string, Keyhole>)(object)new MapField<TKey, TValue>();
			missionSlots_ = (MapField<int, MissionQueue>)(object)new MapField<TKey, TValue>();
			lastDiscussions_ = (RepeatedField<DiscussionRecord>)(object)new RepeatedField<T>();
			friendshipChoices_ = (MapField<int, ListId>)(object)new MapField<TKey, TValue>();
			dialogueFlags_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			currentWeather_ = "";
			recurringEvents_ = (MapField<uint, RecurringEvent>)(object)new MapField<TKey, TValue>();
			fishedVillageAreas_ = (RepeatedField<FishingPerVillageArea>)(object)new RepeatedField<T>();
			DialogueFlagsOverride = (Dictionary<Item, bool>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			Village village = (village_ = new Village());
			House house = (playerHouse_ = new House());
			GridCollection gridCollection = (gridCollection_ = new GridCollection());
			BurningState burningState = (burningState_ = new BurningState());
			QuestInformation questInformation = (questInfo_ = new QuestInformation());
			Timestamp timestamp = (nextWeatherCheck_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005162")]
		[Cpp2IlInjected.Address(RVA = "0x1484D50", Offset = "0x1483750", VA = "0x181484D50")]
		private void OnConstruction()
		{
			Village village = (village_ = new Village());
			House house = (playerHouse_ = new House());
			GridCollection gridCollection = (gridCollection_ = new GridCollection());
			BurningState burningState = (burningState_ = new BurningState());
			QuestInformation questInformation = (questInfo_ = new QuestInformation());
			Timestamp timestamp = (nextWeatherCheck_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005163")]
		[Cpp2IlInjected.Address(RVA = "0x1489BC0", Offset = "0x14885C0", VA = "0x181489BC0")]
		[DebuggerNonUserCode]
		public ProfileWorld(ProfileWorld other)
		{
			//IL_001b: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			//IL_0198: Expected O, but got I4
			//IL_0234: Expected O, but got I4
			Village village = other.village_;
			int num = 0;
			if (village != null)
			{
				Village village2 = village.Clone();
			}
			village_ = (Village)num;
			House house = other.playerHouse_;
			if (house != null)
			{
				House house2 = house.Clone();
			}
			playerHouse_ = (House)num;
			RepeatedField<Character> repeatedField = (characters_ = (RepeatedField<Character>)(object)((RepeatedField<T>)(object)other.characters_).Clone());
			GridCollection gridCollection = other.gridCollection_;
			if (gridCollection != null)
			{
				GridCollection gridCollection2 = gridCollection.Clone();
			}
			gridCollection_ = (GridCollection)num;
			MapField<string, Realm> mapField = (realms_ = (MapField<string, Realm>)(object)((MapField<TKey, TValue>)(object)other.realms_).Clone());
			MapField<uint, PendingFish> mapField2 = (pendingFishes_ = (MapField<uint, PendingFish>)(object)((MapField<TKey, TValue>)(object)other.pendingFishes_).Clone());
			uint num2 = (nextPendingFishID_ = other.nextPendingFishID_);
			RepeatedField<Shop> repeatedField2 = (shops_ = (RepeatedField<Shop>)(object)((RepeatedField<T>)(object)other.shops_).Clone());
			RepeatedField<int> repeatedField3 = (unlockedBuildings_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.unlockedBuildings_).Clone());
			MapField<int, BuildingInfo> mapField3 = (buildingInfos_ = (MapField<int, BuildingInfo>)(object)((MapField<TKey, TValue>)(object)other.buildingInfos_).Clone());
			MapField<int, OffGridBuilding> mapField4 = (offGridBuildings_ = (MapField<int, OffGridBuilding>)(object)((MapField<TKey, TValue>)(object)other.offGridBuildings_).Clone());
			RepeatedField<CharacterRestaurantOrder> repeatedField4 = (characterRestaurantOrders_ = (RepeatedField<CharacterRestaurantOrder>)(object)((RepeatedField<T>)(object)other.characterRestaurantOrders_).Clone());
			RepeatedField<Critter> repeatedField5 = (critters_ = (RepeatedField<Critter>)(object)((RepeatedField<T>)(object)other.critters_).Clone());
			BurningState burningState = other.burningState_;
			if (burningState != null)
			{
				BurningState burningState2 = burningState.Clone();
			}
			burningState_ = (BurningState)num;
			RepeatedField<StoreInfo> repeatedField6 = (stores_ = (RepeatedField<StoreInfo>)(object)((RepeatedField<T>)(object)other.stores_).Clone());
			MapField<string, Keyhole> mapField5 = (keyholes_ = (MapField<string, Keyhole>)(object)((MapField<TKey, TValue>)(object)other.keyholes_).Clone());
			MapField<int, MissionQueue> mapField6 = (missionSlots_ = (MapField<int, MissionQueue>)(object)((MapField<TKey, TValue>)(object)other.missionSlots_).Clone());
			QuestInformation questInformation = other.questInfo_;
			if (questInformation != null)
			{
				QuestInformation questInformation2 = questInformation.Clone();
			}
			questInfo_ = (QuestInformation)num;
			RepeatedField<DiscussionRecord> repeatedField7 = (lastDiscussions_ = (RepeatedField<DiscussionRecord>)(object)((RepeatedField<T>)(object)other.lastDiscussions_).Clone());
			MapField<int, ListId> mapField7 = (friendshipChoices_ = (MapField<int, ListId>)(object)((MapField<TKey, TValue>)(object)other.friendshipChoices_).Clone());
			RepeatedField<int> repeatedField8 = (dialogueFlags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.dialogueFlags_).Clone());
			int num3 = (castleLevel_ = other.castleLevel_);
			int num4 = (wishingWellLevel_ = other.wishingWellLevel_);
			int num5 = (kitchenStallLevel_ = other.kitchenStallLevel_);
			string text = (currentWeather_ = other.currentWeather_);
			Timestamp timestamp = other.nextWeatherCheck_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			nextWeatherCheck_ = (Timestamp)num;
			Duration duration = other.timeZoneOffset_;
			Duration duration2 = default(Duration);
			if (duration != null)
			{
				duration2 = duration.Clone();
			}
			timeZoneOffset_ = duration2;
			bool flag = (timeZoneOffsetIsDST_ = other.timeZoneOffsetIsDST_);
			MapField<uint, RecurringEvent> mapField8 = (recurringEvents_ = (MapField<uint, RecurringEvent>)(object)((MapField<TKey, TValue>)(object)other.recurringEvents_).Clone());
			uint num6 = (nextRecurringEventID_ = other.nextRecurringEventID_);
			RepeatedField<FishingPerVillageArea> repeatedField9 = (fishedVillageAreas_ = (RepeatedField<FishingPerVillageArea>)(object)((RepeatedField<T>)(object)other.fishedVillageAreas_).Clone());
			int num7 = (uncursedLightLockedTimer_ = other.uncursedLightLockedTimer_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005164")]
		[Cpp2IlInjected.Address(RVA = "0x147C780", Offset = "0x147B180", VA = "0x18147C780", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfileWorld Clone()
		{
			return new ProfileWorld(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005194")]
		[Cpp2IlInjected.Address(RVA = "0x147D8B0", Offset = "0x147C2B0", VA = "0x18147D8B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ProfileWorld)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005195")]
		[Cpp2IlInjected.Address(RVA = "0x147D390", Offset = "0x147BD90", VA = "0x18147D390", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfileWorld other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Village objB = other.village_;
				if (object.Equals(village_, objB))
				{
					House objB2 = other.playerHouse_;
					if (object.Equals(playerHouse_, objB2))
					{
						RepeatedField<Character> repeatedField = characters_;
						RepeatedField<Character> repeatedField2 = other.characters_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							GridCollection objB3 = other.gridCollection_;
							if (object.Equals(gridCollection_, objB3))
							{
								MapField<string, Realm> mapField = realms_;
								MapField<string, Realm> mapField2 = other.realms_;
								if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
								{
									MapField<uint, PendingFish> mapField3 = pendingFishes_;
									MapField<uint, PendingFish> mapField4 = other.pendingFishes_;
									if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
									{
										uint num = other.nextPendingFishID_;
										if (nextPendingFishID_ == num)
										{
											RepeatedField<Shop> repeatedField3 = shops_;
											RepeatedField<Shop> repeatedField4 = other.shops_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												RepeatedField<int> repeatedField5 = unlockedBuildings_;
												RepeatedField<int> repeatedField6 = other.unlockedBuildings_;
												if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
												{
													MapField<int, BuildingInfo> mapField5 = buildingInfos_;
													MapField<int, BuildingInfo> mapField6 = other.buildingInfos_;
													if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
													{
														MapField<int, OffGridBuilding> mapField7 = offGridBuildings_;
														MapField<int, OffGridBuilding> mapField8 = other.offGridBuildings_;
														if (((MapField<TKey, TValue>)(object)mapField7).Equals((MapField<, >)(object)mapField8))
														{
															RepeatedField<CharacterRestaurantOrder> repeatedField7 = characterRestaurantOrders_;
															RepeatedField<CharacterRestaurantOrder> repeatedField8 = other.characterRestaurantOrders_;
															if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
															{
																RepeatedField<Critter> repeatedField9 = critters_;
																RepeatedField<Critter> repeatedField10 = other.critters_;
																if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
																{
																	BurningState objB4 = other.burningState_;
																	if (object.Equals(burningState_, objB4))
																	{
																		RepeatedField<StoreInfo> repeatedField11 = stores_;
																		RepeatedField<StoreInfo> repeatedField12 = other.stores_;
																		if (((RepeatedField<T>)(object)repeatedField11).Equals((RepeatedField<>)(object)repeatedField12))
																		{
																			MapField<string, Keyhole> mapField9 = keyholes_;
																			MapField<string, Keyhole> mapField10 = other.keyholes_;
																			if (((MapField<TKey, TValue>)(object)mapField9).Equals((MapField<, >)(object)mapField10))
																			{
																				MapField<int, MissionQueue> mapField11 = missionSlots_;
																				MapField<int, MissionQueue> mapField12 = other.missionSlots_;
																				if (((MapField<TKey, TValue>)(object)mapField11).Equals((MapField<, >)(object)mapField12))
																				{
																					QuestInformation objB5 = other.questInfo_;
																					if (object.Equals(questInfo_, objB5))
																					{
																						RepeatedField<DiscussionRecord> repeatedField13 = lastDiscussions_;
																						RepeatedField<DiscussionRecord> repeatedField14 = other.lastDiscussions_;
																						if (((RepeatedField<T>)(object)repeatedField13).Equals((RepeatedField<>)(object)repeatedField14))
																						{
																							MapField<int, ListId> mapField13 = friendshipChoices_;
																							MapField<int, ListId> mapField14 = other.friendshipChoices_;
																							if (((MapField<TKey, TValue>)(object)mapField13).Equals((MapField<, >)(object)mapField14))
																							{
																								RepeatedField<int> repeatedField15 = dialogueFlags_;
																								RepeatedField<int> repeatedField16 = other.dialogueFlags_;
																								if (((RepeatedField<T>)(object)repeatedField15).Equals((RepeatedField<>)(object)repeatedField16))
																								{
																									int num2 = other.castleLevel_;
																									if (castleLevel_ == num2)
																									{
																										int num3 = other.wishingWellLevel_;
																										if (wishingWellLevel_ == num3)
																										{
																											int num4 = other.kitchenStallLevel_;
																											if (kitchenStallLevel_ == num4)
																											{
																												string text = other.currentWeather_;
																												if (!(currentWeather_ != text))
																												{
																													Timestamp objB6 = other.nextWeatherCheck_;
																													if (object.Equals(nextWeatherCheck_, objB6))
																													{
																														Duration objB7 = other.timeZoneOffset_;
																														if (object.Equals(timeZoneOffset_, objB7))
																														{
																															bool flag = other.timeZoneOffsetIsDST_;
																															if (timeZoneOffsetIsDST_ == flag)
																															{
																																MapField<uint, RecurringEvent> mapField15 = recurringEvents_;
																																MapField<uint, RecurringEvent> mapField16 = other.recurringEvents_;
																																if (((MapField<TKey, TValue>)(object)mapField15).Equals((MapField<, >)(object)mapField16))
																																{
																																	uint num5 = other.nextRecurringEventID_;
																																	if (nextRecurringEventID_ == num5)
																																	{
																																		RepeatedField<FishingPerVillageArea> repeatedField17 = fishedVillageAreas_;
																																		RepeatedField<FishingPerVillageArea> repeatedField18 = other.fishedVillageAreas_;
																																		if (((RepeatedField<T>)(object)repeatedField17).Equals((RepeatedField<>)(object)repeatedField18))
																																		{
																																			int num6 = other.uncursedLightLockedTimer_;
																																			if (uncursedLightLockedTimer_ == num6)
																																			{
																																				UnknownFieldSet unknownFields = other._unknownFields;
																																				return object.Equals(_unknownFields, unknownFields);
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005196")]
		[Cpp2IlInjected.Address(RVA = "0x147F1A0", Offset = "0x147DBA0", VA = "0x18147F1A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0233
			int num = 0;
			Village village = village_;
			if (village != null)
			{
				int hashCode = village.GetHashCode();
			}
			House house = playerHouse_;
			if (house != null)
			{
				int hashCode2 = house.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)characters_).GetHashCode();
			GridCollection gridCollection = gridCollection_;
			if (gridCollection != null)
			{
				int hashCode4 = gridCollection.GetHashCode();
			}
			int hashCode5 = ((MapField<TKey, TValue>)(object)realms_).GetHashCode();
			int hashCode6 = ((MapField<TKey, TValue>)(object)pendingFishes_).GetHashCode();
			if (nextPendingFishID_ != 0)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)shops_).GetHashCode();
			RepeatedField<int> repeatedField = unlockedBuildings_;
			hashCode5 = hashCode7;
			int hashCode8 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			MapField<int, BuildingInfo> mapField = buildingInfos_;
			hashCode6 = hashCode8;
			int hashCode9 = ((MapField<TKey, TValue>)(object)mapField).GetHashCode();
			MapField<int, OffGridBuilding> mapField2 = offGridBuildings_;
			hashCode5 = hashCode9;
			int hashCode10 = ((MapField<TKey, TValue>)(object)mapField2).GetHashCode();
			RepeatedField<CharacterRestaurantOrder> repeatedField2 = characterRestaurantOrders_;
			hashCode6 = hashCode10;
			int hashCode11 = ((RepeatedField<T>)(object)repeatedField2).GetHashCode();
			RepeatedField<Critter> repeatedField3 = critters_;
			hashCode5 = hashCode11;
			int hashCode12 = ((RepeatedField<T>)(object)repeatedField3).GetHashCode();
			BurningState burningState = burningState_;
			hashCode6 = hashCode12;
			if (burningState != null)
			{
				int hashCode13 = burningState.GetHashCode();
			}
			int hashCode14 = ((RepeatedField<T>)(object)stores_).GetHashCode();
			MapField<string, Keyhole> mapField3 = keyholes_;
			hashCode5 = hashCode14;
			int hashCode15 = ((MapField<TKey, TValue>)(object)mapField3).GetHashCode();
			int hashCode16 = ((MapField<TKey, TValue>)(object)missionSlots_).GetHashCode();
			QuestInformation questInformation = questInfo_;
			hashCode6 = hashCode16;
			if (questInformation != null)
			{
				int hashCode17 = questInformation.GetHashCode();
			}
			int hashCode18 = ((RepeatedField<T>)(object)lastDiscussions_).GetHashCode();
			MapField<int, ListId> mapField4 = friendshipChoices_;
			hashCode5 = hashCode18;
			int hashCode19 = ((MapField<TKey, TValue>)(object)mapField4).GetHashCode();
			RepeatedField<int> repeatedField4 = dialogueFlags_;
			hashCode15 = hashCode19;
			hashCode6 = ((RepeatedField<T>)(object)repeatedField4).GetHashCode();
			if (castleLevel_ != 0)
			{
			}
			if (wishingWellLevel_ != 0)
			{
			}
			if (kitchenStallLevel_ != 0)
			{
			}
			string text = currentWeather_;
			if (text.m_stringLength != 0)
			{
				int hashCode20 = text.GetHashCode();
			}
			Timestamp timestamp = nextWeatherCheck_;
			if (timestamp != null)
			{
				int hashCode21 = timestamp.GetHashCode();
			}
			Duration duration = timeZoneOffset_;
			if (duration != null)
			{
				int hashCode22 = duration.GetHashCode();
			}
			if (timeZoneOffsetIsDST_)
			{
			}
			int hashCode23 = ((MapField<TKey, TValue>)(object)recurringEvents_).GetHashCode();
			if (nextRecurringEventID_ != 0)
			{
			}
			int hashCode24 = ((RepeatedField<T>)(object)fishedVillageAreas_).GetHashCode();
			if (uncursedLightLockedTimer_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode25 = unknownFields.GetHashCode();
			}
			return hashCode6;
		}

		[Cpp2IlInjected.Token(Token = "0x6005197")]
		[Cpp2IlInjected.Address(RVA = "0x1486D80", Offset = "0x1485780", VA = "0x181486D80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005198")]
		[Cpp2IlInjected.Address(RVA = "0x1487CE0", Offset = "0x14866E0", VA = "0x181487CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0343
			if ((long)_map_pendingFishes_codec != 0)
			{
				Village value = village_;
				output.WriteMessage(value);
			}
			if ((long)playerHouse_ != 0)
			{
				House value2 = playerHouse_;
				output.WriteMessage(value2);
			}
			RepeatedField<Character> repeatedField = characters_;
			FieldCodec<Character> repeated_characters_codec = _repeated_characters_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_characters_codec);
			if ((long)gridCollection_ != 0)
			{
				GridCollection value3 = gridCollection_;
				output.WriteMessage(value3);
			}
			MapField<string, Realm> mapField = realms_;
			MapField<string, Realm>.Codec map_realms_codec = _map_realms_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_realms_codec);
			MapField<uint, PendingFish> mapField2 = pendingFishes_;
			MapField<uint, PendingFish>.Codec map_pendingFishes_codec = _map_pendingFishes_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_pendingFishes_codec);
			if (nextPendingFishID_ != 0)
			{
				uint value4 = nextPendingFishID_;
				output.WriteUInt32(value4);
			}
			RepeatedField<Shop> repeatedField2 = shops_;
			FieldCodec<Shop> repeated_shops_codec = _repeated_shops_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_shops_codec);
			RepeatedField<int> repeatedField3 = unlockedBuildings_;
			FieldCodec<int> repeated_unlockedBuildings_codec = _repeated_unlockedBuildings_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_unlockedBuildings_codec);
			MapField<int, BuildingInfo> mapField3 = buildingInfos_;
			MapField<int, BuildingInfo>.Codec map_buildingInfos_codec = _map_buildingInfos_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_buildingInfos_codec);
			MapField<int, OffGridBuilding> mapField4 = offGridBuildings_;
			MapField<int, OffGridBuilding>.Codec map_offGridBuildings_codec = _map_offGridBuildings_codec;
			((MapField<TKey, TValue>)(object)mapField4).WriteTo(output, (MapField<, >.Codec)(object)map_offGridBuildings_codec);
			RepeatedField<CharacterRestaurantOrder> repeatedField4 = characterRestaurantOrders_;
			FieldCodec<CharacterRestaurantOrder> repeated_characterRestaurantOrders_codec = _repeated_characterRestaurantOrders_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_characterRestaurantOrders_codec);
			RepeatedField<Critter> repeatedField5 = critters_;
			FieldCodec<Critter> repeated_critters_codec = _repeated_critters_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_critters_codec);
			if ((long)_map_recurringEvents_codec != 0)
			{
				BurningState value5 = burningState_;
				output.WriteMessage(value5);
			}
			RepeatedField<StoreInfo> repeatedField6 = stores_;
			FieldCodec<StoreInfo> repeated_stores_codec = _repeated_stores_codec;
			((RepeatedField<T>)(object)repeatedField6).WriteTo(output, (FieldCodec<>)(object)repeated_stores_codec);
			MapField<string, Keyhole> mapField5 = keyholes_;
			MapField<string, Keyhole>.Codec map_keyholes_codec = _map_keyholes_codec;
			((MapField<TKey, TValue>)(object)mapField5).WriteTo(output, (MapField<, >.Codec)(object)map_keyholes_codec);
			MapField<int, MissionQueue> mapField6 = missionSlots_;
			MapField<int, MissionQueue>.Codec map_missionSlots_codec = _map_missionSlots_codec;
			((MapField<TKey, TValue>)(object)mapField6).WriteTo(output, (MapField<, >.Codec)(object)map_missionSlots_codec);
			if ((long)questInfo_ != 0)
			{
				QuestInformation value6 = questInfo_;
				output.WriteMessage(value6);
			}
			RepeatedField<DiscussionRecord> repeatedField7 = lastDiscussions_;
			FieldCodec<DiscussionRecord> repeated_lastDiscussions_codec = _repeated_lastDiscussions_codec;
			((RepeatedField<T>)(object)repeatedField7).WriteTo(output, (FieldCodec<>)(object)repeated_lastDiscussions_codec);
			MapField<int, ListId> mapField7 = friendshipChoices_;
			MapField<int, ListId>.Codec map_friendshipChoices_codec = _map_friendshipChoices_codec;
			((MapField<TKey, TValue>)(object)mapField7).WriteTo(output, (MapField<, >.Codec)(object)map_friendshipChoices_codec);
			RepeatedField<int> repeatedField8 = dialogueFlags_;
			FieldCodec<int> repeated_dialogueFlags_codec = _repeated_dialogueFlags_codec;
			((RepeatedField<T>)(object)repeatedField8).WriteTo(output, (FieldCodec<>)(object)repeated_dialogueFlags_codec);
			if (castleLevel_ != 0)
			{
				int value7 = castleLevel_;
				output.WriteInt32(value7);
			}
			if (wishingWellLevel_ != 0)
			{
				int value8 = wishingWellLevel_;
				output.WriteInt32(value8);
			}
			if (kitchenStallLevel_ != 0)
			{
				int value9 = kitchenStallLevel_;
				output.WriteInt32(value9);
			}
			if (currentWeather_.m_stringLength != 0)
			{
				string value10 = currentWeather_;
				output.WriteString(value10);
			}
			if ((long)nextWeatherCheck_ != 0)
			{
				Timestamp value11 = nextWeatherCheck_;
				output.WriteMessage(value11);
			}
			if ((long)timeZoneOffset_ != 0)
			{
				Duration value12 = timeZoneOffset_;
				output.WriteMessage(value12);
			}
			if (timeZoneOffsetIsDST_)
			{
				bool value13 = timeZoneOffsetIsDST_;
				output.WriteBool(value13);
			}
			MapField<uint, RecurringEvent> mapField8 = recurringEvents_;
			MapField<uint, RecurringEvent>.Codec map_recurringEvents_codec = _map_recurringEvents_codec;
			((MapField<TKey, TValue>)(object)mapField8).WriteTo(output, (MapField<, >.Codec)(object)map_recurringEvents_codec);
			if (nextRecurringEventID_ != 0)
			{
				uint value14 = nextRecurringEventID_;
				output.WriteUInt32(value14);
			}
			RepeatedField<FishingPerVillageArea> repeatedField9 = fishedVillageAreas_;
			FieldCodec<FishingPerVillageArea> repeated_fishedVillageAreas_codec = _repeated_fishedVillageAreas_codec;
			((RepeatedField<T>)(object)repeatedField9).WriteTo(output, (FieldCodec<>)(object)repeated_fishedVillageAreas_codec);
			if (uncursedLightLockedTimer_ != 0)
			{
				int value15 = uncursedLightLockedTimer_;
				output.WriteInt32(value15);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005199")]
		[Cpp2IlInjected.Address(RVA = "0x147BB70", Offset = "0x147A570", VA = "0x18147BB70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0392
			Village village = village_;
			int num = 0;
			if (village != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(village);
			}
			House house = playerHouse_;
			if (house != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(house);
				num3++;
				num += num3;
			}
			RepeatedField<Character> repeatedField = characters_;
			FieldCodec<Character> repeated_characters_codec = _repeated_characters_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_characters_codec);
			GridCollection gridCollection = gridCollection_;
			num += num4;
			if (gridCollection != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(gridCollection);
				num5++;
				num += num5;
			}
			MapField<string, Realm> mapField = realms_;
			MapField<string, Realm>.Codec map_realms_codec = _map_realms_codec;
			int num6 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_realms_codec);
			MapField<uint, PendingFish> mapField2 = pendingFishes_;
			MapField<uint, PendingFish>.Codec map_pendingFishes_codec = _map_pendingFishes_codec;
			int num7 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_pendingFishes_codec);
			uint num8 = nextPendingFishID_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeUInt32Size(num8);
				num9++;
				num += num9;
			}
			RepeatedField<Shop> repeatedField2 = shops_;
			FieldCodec<Shop> repeated_shops_codec = _repeated_shops_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_shops_codec);
			RepeatedField<int> repeatedField3 = unlockedBuildings_;
			FieldCodec<int> repeated_unlockedBuildings_codec = _repeated_unlockedBuildings_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_unlockedBuildings_codec);
			MapField<int, BuildingInfo> mapField3 = buildingInfos_;
			MapField<int, BuildingInfo>.Codec map_buildingInfos_codec = _map_buildingInfos_codec;
			int num12 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_buildingInfos_codec);
			MapField<int, OffGridBuilding> mapField4 = offGridBuildings_;
			MapField<int, OffGridBuilding>.Codec map_offGridBuildings_codec = _map_offGridBuildings_codec;
			int num13 = ((MapField<TKey, TValue>)(object)mapField4).CalculateSize((MapField<, >.Codec)(object)map_offGridBuildings_codec);
			RepeatedField<CharacterRestaurantOrder> repeatedField4 = characterRestaurantOrders_;
			FieldCodec<CharacterRestaurantOrder> repeated_characterRestaurantOrders_codec = _repeated_characterRestaurantOrders_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_characterRestaurantOrders_codec);
			RepeatedField<Critter> repeatedField5 = critters_;
			FieldCodec<Critter> repeated_critters_codec = _repeated_critters_codec;
			int num15 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_critters_codec);
			BurningState burningState = burningState_;
			if (burningState != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(burningState);
				num16++;
				num += num16;
			}
			RepeatedField<StoreInfo> repeatedField6 = stores_;
			FieldCodec<StoreInfo> repeated_stores_codec = _repeated_stores_codec;
			int num17 = ((RepeatedField<T>)(object)repeatedField6).CalculateSize((FieldCodec<>)(object)repeated_stores_codec);
			MapField<string, Keyhole> mapField5 = keyholes_;
			MapField<string, Keyhole>.Codec map_keyholes_codec = _map_keyholes_codec;
			int num18 = ((MapField<TKey, TValue>)(object)mapField5).CalculateSize((MapField<, >.Codec)(object)map_keyholes_codec);
			MapField<int, MissionQueue> mapField6 = missionSlots_;
			MapField<int, MissionQueue>.Codec map_missionSlots_codec = _map_missionSlots_codec;
			int num19 = ((MapField<TKey, TValue>)(object)mapField6).CalculateSize((MapField<, >.Codec)(object)map_missionSlots_codec);
			QuestInformation questInformation = questInfo_;
			if (questInformation != null)
			{
				int num20 = CodedOutputStream.ComputeMessageSize(questInformation);
				num20 += 2;
				num += num20;
			}
			RepeatedField<DiscussionRecord> repeatedField7 = lastDiscussions_;
			FieldCodec<DiscussionRecord> repeated_lastDiscussions_codec = _repeated_lastDiscussions_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField7).CalculateSize((FieldCodec<>)(object)repeated_lastDiscussions_codec);
			MapField<int, ListId> mapField7 = friendshipChoices_;
			MapField<int, ListId>.Codec map_friendshipChoices_codec = _map_friendshipChoices_codec;
			int num22 = ((MapField<TKey, TValue>)(object)mapField7).CalculateSize((MapField<, >.Codec)(object)map_friendshipChoices_codec);
			RepeatedField<int> repeatedField8 = dialogueFlags_;
			FieldCodec<int> repeated_dialogueFlags_codec = _repeated_dialogueFlags_codec;
			int num23 = ((RepeatedField<T>)(object)repeatedField8).CalculateSize((FieldCodec<>)(object)repeated_dialogueFlags_codec);
			int num24 = castleLevel_;
			if (num24 != 0)
			{
				int num25 = CodedOutputStream.ComputeInt32Size(num24);
				num25 += 2;
				num += num25;
			}
			int num26 = wishingWellLevel_;
			if (num26 != 0)
			{
				int num27 = CodedOutputStream.ComputeInt32Size(num26);
				num27 += 2;
				num += num27;
			}
			int num28 = kitchenStallLevel_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
				num += num29;
			}
			string text = currentWeather_;
			if (text.m_stringLength != 0)
			{
				int num30 = CodedOutputStream.ComputeStringSize(text);
				num30 += 2;
				num += num30;
			}
			Timestamp timestamp = nextWeatherCheck_;
			if (timestamp != null)
			{
				int num31 = CodedOutputStream.ComputeMessageSize(timestamp);
				num31 += 2;
				num += num31;
			}
			Duration duration = timeZoneOffset_;
			if (duration != null)
			{
				int num32 = CodedOutputStream.ComputeMessageSize(duration);
				num32 += 2;
				num += num32;
			}
			MapField<uint, RecurringEvent> mapField8 = recurringEvents_;
			MapField<uint, RecurringEvent>.Codec map_recurringEvents_codec = _map_recurringEvents_codec;
			int num33 = ((MapField<TKey, TValue>)(object)mapField8).CalculateSize((MapField<, >.Codec)(object)map_recurringEvents_codec);
			uint num34 = nextRecurringEventID_;
			if (num34 != 0)
			{
				int num35 = CodedOutputStream.ComputeUInt32Size(num34);
				num35 += 2;
			}
			RepeatedField<FishingPerVillageArea> repeatedField9 = fishedVillageAreas_;
			FieldCodec<FishingPerVillageArea> repeated_fishedVillageAreas_codec = _repeated_fishedVillageAreas_codec;
			int num36 = ((RepeatedField<T>)(object)repeatedField9).CalculateSize((FieldCodec<>)(object)repeated_fishedVillageAreas_codec);
			int num37 = uncursedLightLockedTimer_;
			if (num37 != 0)
			{
				int num38 = CodedOutputStream.ComputeInt32Size(num37);
				num38 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num39 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600519A")]
		[Cpp2IlInjected.Address(RVA = "0x1484690", Offset = "0x1483090", VA = "0x181484690", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfileWorld other)
		{
			//Discarded unreachable code: IL_041f
			if (other == null)
			{
				return;
			}
			if ((long)_map_pendingFishes_codec != 0)
			{
				Village village = village_;
				if (village == null)
				{
					Village village2 = (village_ = new Village());
					Village village3 = village_;
				}
				Village other2 = other.village_;
				village.MergeFrom(other2);
			}
			if ((long)other.playerHouse_ != 0)
			{
				House house2 = default(House);
				if (playerHouse_ == null)
				{
					House house = (playerHouse_ = new House());
					house2 = playerHouse_;
				}
				House other3 = other.playerHouse_;
				house2.MergeFrom(other3);
			}
			RepeatedField<Character> repeatedField = characters_;
			RepeatedField<Character> repeatedField2 = other.characters_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.gridCollection_ != 0)
			{
				GridCollection gridCollection2 = default(GridCollection);
				if (gridCollection_ == null)
				{
					GridCollection gridCollection = (gridCollection_ = new GridCollection());
					gridCollection2 = gridCollection_;
				}
				GridCollection other4 = other.gridCollection_;
				gridCollection2.MergeFrom(other4);
			}
			MapField<string, Realm> mapField = realms_;
			MapField<string, Realm> mapField2 = other.realms_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			MapField<uint, PendingFish> mapField3 = pendingFishes_;
			MapField<uint, PendingFish> mapField4 = other.pendingFishes_;
			((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
			uint num = other.nextPendingFishID_;
			if (num != 0)
			{
				nextPendingFishID_ = num;
			}
			RepeatedField<Shop> repeatedField3 = shops_;
			RepeatedField<Shop> repeatedField4 = other.shops_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<int> repeatedField5 = unlockedBuildings_;
			RepeatedField<int> repeatedField6 = other.unlockedBuildings_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			MapField<int, BuildingInfo> mapField5 = buildingInfos_;
			MapField<int, BuildingInfo> mapField6 = other.buildingInfos_;
			((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
			MapField<int, OffGridBuilding> mapField7 = offGridBuildings_;
			MapField<int, OffGridBuilding> mapField8 = other.offGridBuildings_;
			((MapField<TKey, TValue>)(object)mapField7).Add((IDictionary<, >)(object)mapField8);
			RepeatedField<CharacterRestaurantOrder> repeatedField7 = characterRestaurantOrders_;
			RepeatedField<CharacterRestaurantOrder> repeatedField8 = other.characterRestaurantOrders_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			RepeatedField<Critter> repeatedField9 = critters_;
			RepeatedField<Critter> repeatedField10 = other.critters_;
			((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
			if ((long)_map_recurringEvents_codec != 0)
			{
				BurningState burningState2 = default(BurningState);
				if (burningState_ == null)
				{
					BurningState burningState = (burningState_ = new BurningState());
					burningState2 = burningState_;
				}
				BurningState other5 = other.burningState_;
				burningState2.MergeFrom(other5);
			}
			RepeatedField<StoreInfo> repeatedField11 = stores_;
			RepeatedField<StoreInfo> repeatedField12 = other.stores_;
			((RepeatedField<T>)(object)repeatedField11).Add((IEnumerable<>)(object)repeatedField12);
			MapField<string, Keyhole> mapField9 = keyholes_;
			MapField<string, Keyhole> mapField10 = other.keyholes_;
			((MapField<TKey, TValue>)(object)mapField9).Add((IDictionary<, >)(object)mapField10);
			MapField<int, MissionQueue> mapField11 = missionSlots_;
			MapField<int, MissionQueue> mapField12 = other.missionSlots_;
			((MapField<TKey, TValue>)(object)mapField11).Add((IDictionary<, >)(object)mapField12);
			if ((long)other.questInfo_ != 0)
			{
				QuestInformation questInformation2 = default(QuestInformation);
				if (questInfo_ == null)
				{
					QuestInformation questInformation = (questInfo_ = new QuestInformation());
					questInformation2 = questInfo_;
				}
				QuestInformation other6 = other.questInfo_;
				questInformation2.MergeFrom(other6);
			}
			RepeatedField<DiscussionRecord> repeatedField13 = lastDiscussions_;
			RepeatedField<DiscussionRecord> repeatedField14 = other.lastDiscussions_;
			((RepeatedField<T>)(object)repeatedField13).Add((IEnumerable<>)(object)repeatedField14);
			MapField<int, ListId> mapField13 = friendshipChoices_;
			MapField<int, ListId> mapField14 = other.friendshipChoices_;
			((MapField<TKey, TValue>)(object)mapField13).Add((IDictionary<, >)(object)mapField14);
			RepeatedField<int> repeatedField15 = dialogueFlags_;
			RepeatedField<int> repeatedField16 = other.dialogueFlags_;
			((RepeatedField<T>)(object)repeatedField15).Add((IEnumerable<>)(object)repeatedField16);
			int num2 = other.castleLevel_;
			if (num2 != 0)
			{
				castleLevel_ = num2;
			}
			int num3 = other.wishingWellLevel_;
			if (num3 != 0)
			{
				wishingWellLevel_ = num3;
			}
			int num4 = other.kitchenStallLevel_;
			if (num4 != 0)
			{
				kitchenStallLevel_ = num4;
			}
			string text = other.currentWeather_;
			if (text.m_stringLength != 0)
			{
				CurrentWeather = text;
			}
			if ((long)other.nextWeatherCheck_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (nextWeatherCheck_ == null)
				{
					Timestamp timestamp = (nextWeatherCheck_ = new Timestamp());
					timestamp2 = nextWeatherCheck_;
				}
				Timestamp other7 = other.nextWeatherCheck_;
				timestamp2.MergeFrom(other7);
			}
			if ((long)other.timeZoneOffset_ != 0)
			{
				Duration duration2 = default(Duration);
				if (timeZoneOffset_ == null)
				{
					Duration duration = (timeZoneOffset_ = new Duration());
					duration2 = timeZoneOffset_;
				}
				Duration other8 = other.timeZoneOffset_;
				duration2.MergeFrom(other8);
			}
			bool flag = other.timeZoneOffsetIsDST_;
			if (flag)
			{
				timeZoneOffsetIsDST_ = flag;
			}
			MapField<uint, RecurringEvent> mapField15 = recurringEvents_;
			MapField<uint, RecurringEvent> mapField16 = other.recurringEvents_;
			((MapField<TKey, TValue>)(object)mapField15).Add((IDictionary<, >)(object)mapField16);
			uint num5 = other.nextRecurringEventID_;
			if (num5 != 0)
			{
				nextRecurringEventID_ = num5;
			}
			RepeatedField<FishingPerVillageArea> repeatedField17 = fishedVillageAreas_;
			RepeatedField<FishingPerVillageArea> repeatedField18 = other.fishedVillageAreas_;
			((RepeatedField<T>)(object)repeatedField17).Add((IEnumerable<>)(object)repeatedField18);
			int num6 = other.uncursedLightLockedTimer_;
			if (num6 != 0)
			{
				uncursedLightLockedTimer_ = num6;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600519B")]
		[Cpp2IlInjected.Address(RVA = "0x1483A70", Offset = "0x1482470", VA = "0x181483A70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_052c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 130)
			{
				if ((int)num > 184)
				{
					if ((int)num > 218)
					{
						if ((int)num > 234)
						{
							if (num == 240)
							{
								int num2 = (int)(nextRecurringEventID_ = (uint)input.ReadInt32());
							}
							if (num == 250)
							{
								RepeatedField<FishingPerVillageArea> repeatedField = fishedVillageAreas_;
								FieldCodec<FishingPerVillageArea> repeated_fishedVillageAreas_codec = _repeated_fishedVillageAreas_codec;
								((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_fishedVillageAreas_codec);
							}
							if (num != 256)
							{
								goto IL_0515;
							}
							int num3 = (uncursedLightLockedTimer_ = input.ReadInt32());
						}
						bool flag = default(bool);
						if (num == 224)
						{
							flag = (timeZoneOffsetIsDST_ = input.ReadBool());
						}
						if (!flag)
						{
							goto IL_0515;
						}
						MapField<uint, RecurringEvent> mapField = recurringEvents_;
						MapField<uint, RecurringEvent>.Codec map_recurringEvents_codec = _map_recurringEvents_codec;
						((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_recurringEvents_codec);
					}
					Duration duration = default(Duration);
					if ((int)num > 202)
					{
						Timestamp timestamp = default(Timestamp);
						if (num == 210)
						{
							Timestamp builder = default(Timestamp);
							if (nextWeatherCheck_ == null)
							{
								timestamp = (nextWeatherCheck_ = new Timestamp());
								builder = nextWeatherCheck_;
							}
							input.ReadMessage(builder);
						}
						if ((long)timestamp != 218)
						{
							goto IL_0515;
						}
						Duration builder2 = default(Duration);
						if (timeZoneOffset_ == null)
						{
							duration = (timeZoneOffset_ = new Duration());
							builder2 = timeZoneOffset_;
						}
						input.ReadMessage(builder2);
					}
					int num4 = default(int);
					if ((long)duration == 192)
					{
						num4 = (kitchenStallLevel_ = input.ReadInt32());
					}
					if (num4 != 202)
					{
						goto IL_0515;
					}
					string text2 = (CurrentWeather = input.ReadString());
				}
				int num6 = default(int);
				if ((int)num > 162)
				{
					if ((int)num > 170)
					{
						int num5 = default(int);
						if (num == 176)
						{
							num5 = (castleLevel_ = input.ReadInt32());
						}
						if (num5 != 184)
						{
							goto IL_0515;
						}
						num6 = (wishingWellLevel_ = input.ReadInt32());
					}
					num6 += -168;
					if (num6 != -3)
					{
						goto IL_0515;
					}
					RepeatedField<int> repeatedField2 = dialogueFlags_;
					FieldCodec<int> repeated_dialogueFlags_codec = _repeated_dialogueFlags_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_dialogueFlags_codec);
				}
				if (num6 > 146)
				{
					if (num6 == 154)
					{
						RepeatedField<DiscussionRecord> repeatedField3 = lastDiscussions_;
						FieldCodec<DiscussionRecord> repeated_lastDiscussions_codec = _repeated_lastDiscussions_codec;
						((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_lastDiscussions_codec);
					}
					if (num6 != 162)
					{
						goto IL_0515;
					}
					MapField<int, ListId> mapField2 = friendshipChoices_;
					MapField<int, ListId>.Codec map_friendshipChoices_codec = _map_friendshipChoices_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_friendshipChoices_codec);
				}
				if (num6 == 138)
				{
					MapField<int, MissionQueue> mapField3 = missionSlots_;
					MapField<int, MissionQueue>.Codec map_missionSlots_codec = _map_missionSlots_codec;
					((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_missionSlots_codec);
				}
				if (num6 != 146)
				{
					goto IL_0515;
				}
				QuestInformation builder3 = default(QuestInformation);
				if (questInfo_ == null)
				{
					QuestInformation questInformation = (questInfo_ = new QuestInformation());
					builder3 = questInfo_;
				}
				input.ReadMessage(builder3);
			}
			BurningState burningState = default(BurningState);
			if ((int)num > 66)
			{
				if ((int)num > 90)
				{
					if ((int)num > 106)
					{
						if (num == 114)
						{
							BurningState builder4 = default(BurningState);
							if (burningState_ == null)
							{
								burningState = (burningState_ = new BurningState());
								builder4 = burningState_;
							}
							input.ReadMessage(builder4);
						}
						if ((long)burningState == 122)
						{
							RepeatedField<StoreInfo> repeatedField4 = stores_;
							FieldCodec<StoreInfo> repeated_stores_codec = _repeated_stores_codec;
							((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_stores_codec);
						}
						if ((long)burningState != 130)
						{
							goto IL_0515;
						}
						MapField<string, Keyhole> mapField4 = keyholes_;
						MapField<string, Keyhole>.Codec map_keyholes_codec = _map_keyholes_codec;
						((MapField<TKey, TValue>)(object)mapField4).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_keyholes_codec);
					}
					if ((long)burningState == 98)
					{
						RepeatedField<CharacterRestaurantOrder> repeatedField5 = characterRestaurantOrders_;
						FieldCodec<CharacterRestaurantOrder> repeated_characterRestaurantOrders_codec = _repeated_characterRestaurantOrders_codec;
						((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_characterRestaurantOrders_codec);
					}
					if ((long)burningState != 106)
					{
						goto IL_0515;
					}
					RepeatedField<Critter> repeatedField6 = critters_;
					FieldCodec<Critter> repeated_critters_codec = _repeated_critters_codec;
					((RepeatedField<T>)(object)repeatedField6).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_critters_codec);
				}
				if ((long)burningState > 74)
				{
					if ((long)burningState == 82)
					{
						MapField<int, BuildingInfo> mapField5 = buildingInfos_;
						MapField<int, BuildingInfo>.Codec map_buildingInfos_codec = _map_buildingInfos_codec;
						((MapField<TKey, TValue>)(object)mapField5).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_buildingInfos_codec);
					}
					if ((long)burningState != 90)
					{
						goto IL_0515;
					}
					MapField<int, OffGridBuilding> mapField6 = offGridBuildings_;
					MapField<int, OffGridBuilding>.Codec map_offGridBuildings_codec = _map_offGridBuildings_codec;
					((MapField<TKey, TValue>)(object)mapField6).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_offGridBuildings_codec);
				}
				if ((long)burningState != 4294967293L)
				{
					goto IL_0515;
				}
				RepeatedField<int> repeatedField7 = unlockedBuildings_;
				FieldCodec<int> repeated_unlockedBuildings_codec = _repeated_unlockedBuildings_codec;
				((RepeatedField<T>)(object)repeatedField7).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlockedBuildings_codec);
			}
			int num7 = default(int);
			if ((long)burningState > 34)
			{
				if ((long)burningState > 50)
				{
					if ((long)burningState == 56)
					{
						num7 = (int)(nextPendingFishID_ = (uint)input.ReadInt32());
					}
					if (num7 != 66)
					{
						goto IL_0515;
					}
					RepeatedField<Shop> repeatedField8 = shops_;
					FieldCodec<Shop> repeated_shops_codec = _repeated_shops_codec;
					((RepeatedField<T>)(object)repeatedField8).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_shops_codec);
				}
				if (num7 == 42)
				{
					MapField<string, Realm> mapField7 = realms_;
					MapField<string, Realm>.Codec map_realms_codec = _map_realms_codec;
					((MapField<TKey, TValue>)(object)mapField7).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_realms_codec);
				}
				if (num7 != 50)
				{
					goto IL_0515;
				}
				MapField<uint, PendingFish> mapField8 = pendingFishes_;
				MapField<uint, PendingFish>.Codec map_pendingFishes_codec = _map_pendingFishes_codec;
				((MapField<TKey, TValue>)(object)mapField8).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_pendingFishes_codec);
			}
			GridCollection gridCollection = default(GridCollection);
			if (num7 > 18)
			{
				if (num7 == 26)
				{
					RepeatedField<Character> repeatedField9 = characters_;
					FieldCodec<Character> repeated_characters_codec = _repeated_characters_codec;
					((RepeatedField<T>)(object)repeatedField9).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_characters_codec);
				}
				if (num7 != 34)
				{
					goto IL_0515;
				}
				GridCollection builder5 = default(GridCollection);
				if (gridCollection_ == null)
				{
					gridCollection = (gridCollection_ = new GridCollection());
					builder5 = gridCollection_;
				}
				input.ReadMessage(builder5);
			}
			Village village = default(Village);
			if ((long)gridCollection == 10)
			{
				Village builder6 = default(Village);
				if (village_ == null)
				{
					village = (village_ = new Village());
					builder6 = village_;
				}
				input.ReadMessage(builder6);
			}
			if ((long)village == 18)
			{
				House builder7 = default(House);
				if (playerHouse_ == null)
				{
					House house = (playerHouse_ = new House());
					builder7 = playerHouse_;
				}
				input.ReadMessage(builder7);
			}
			goto IL_0515;
			IL_0515:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600519C")]
		[Cpp2IlInjected.Address(RVA = "0x147E050", Offset = "0x147CA50", VA = "0x18147E050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 31)
			{
				Village village = village_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600519D")]
		[Cpp2IlInjected.Address(RVA = "0x14863A0", Offset = "0x1484DA0", VA = "0x1814863A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_0021, IL_0029, IL_0031, IL_0039, IL_003a, IL_0042, IL_004a, IL_0052, IL_005e
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 31)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				village_ = (Village)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600519E")]
		[Cpp2IlInjected.Address(RVA = "0x147C410", Offset = "0x147AE10", VA = "0x18147C410", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d, IL_000f
			if (fieldNumber - 1 > 31)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600519F")]
		[Cpp2IlInjected.Address(RVA = "0x147CB20", Offset = "0x147B520", VA = "0x18147CB20")]
		internal void DebugStartEvent(List<Item> characters, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_004a, IL_0050, IL_0056, IL_005c
			//IL_0028: Expected I4, but got I8
			int friendshipLevel_ = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				Character character = new Character();
				character.base_.id_ = 0;
				character.status_ = Character.Types.CharacterStatus.InEvent;
				character.friendshipLevel_ = friendshipLevel_;
				if (world.dispatcher == null)
				{
				}
				int num = 0;
				((RepeatedField<T>)(object)characters_).Add((T)character);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051A0")]
		[Cpp2IlInjected.Address(RVA = "0x147C7E0", Offset = "0x147B1E0", VA = "0x18147C7E0")]
		internal void DebugEndEvent(IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0053, IL_0059, IL_005f, IL_0065, IL_006b
			int num = 0;
			List<Item> list = (List<Item>)(object)new List<T>();
			List<Character> list2 = (List<Character>)(object)Enumerable.ToList<Character>((IEnumerable<>)(object)characters_);
			Predicate<Character> _003C_003E9__184_ = _003C_003Ec._003C_003E9__184_0;
			if (_003C_003E9__184_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(Character x)
				{
					//Discarded unreachable code: IL_0017
					bool inEvent = x.InEvent;
					return (!inEvent) ? inEvent : (x.friendshipLevel_ == 0);
				};
			}
			List<Character> list3 = (List<Character>)(object)((List<T>)(object)list2).FindAll((Predicate<>)(object)_003C_003E9__184_);
			bool flag = default(bool);
			if (flag)
			{
				CharacterItemData characterItemData = default(CharacterItemData);
				int iD_ = characterItemData.iD_;
				RepeatedField<Character> repeatedField = characters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051A1")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "15")]
		public IGridProvider GetGridProvider()
		{
			GridCollection gridCollection = gridCollection_;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051A2")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "16")]
		public IKeyholesProvider GetKeyholesProvider()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60051A3")]
		[Cpp2IlInjected.Address(RVA = "0x1482FE0", Offset = "0x14819E0", VA = "0x181482FE0", Slot = "29")]
		public bool IsItemInVillage(Item item)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051A4")]
		[Cpp2IlInjected.Address(RVA = "0x1483020", Offset = "0x1481A20", VA = "0x181483020")]
		public bool IsItemInVillage(Item item, out GridObject gridObject)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051A5")]
		[Cpp2IlInjected.Address(RVA = "0x1482FB0", Offset = "0x14819B0", VA = "0x181482FB0")]
		public bool IsItemInVillage(Item item, out IGrid grid, out GridObject gridObject)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051A6")]
		[Cpp2IlInjected.Address(RVA = "0x1482BE0", Offset = "0x14815E0", VA = "0x181482BE0")]
		public bool IsItemInVillage(Item item, out IGrid grid, out GridObject gridObject, out VillageAreaType areaType)
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064
			//IL_0018: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			Item item2 = (Item)itemID;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					Func<GridObject, bool> func = default(Func<GridObject, bool>);
					if (func == null)
					{
						func = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
						{
							int itemID2 = x.ItemID;
							throw new NullReferenceException();
						};
					}
					num++;
				}
				if (num + 1 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051A7")]
		[Cpp2IlInjected.Address(RVA = "0x1481F50", Offset = "0x1480950", VA = "0x181481F50")]
		public bool IsAnyItemInVillage(List<Item> items)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051A8")]
		[Cpp2IlInjected.Address(RVA = "0x1481AB0", Offset = "0x14804B0", VA = "0x181481AB0")]
		public unsafe bool IsAnyItemInVillage(List<Item> items, out IGrid grid, out GridObject gridObject, out VillageAreaType areaType)
		{
			//Discarded unreachable code: IL_0090, IL_0096, IL_00a2, IL_00a8, IL_00ae
			bool flag = default(bool);
			int num2 = default(int);
			while (true)
			{
				int num = 0;
				MapField<int, Village.Types.VillageArea> areas_ = village_.areas_;
				if (flag)
				{
					bool flag2 = gridCollection_.TryGetGrid((uint)num, out *(IGrid*)num);
					while (!flag2)
					{
					}
					if (flag2)
					{
						_003C_003Ec__DisplayClass192_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass192_0();
						CS_0024_003C_003E8__locals0.villageObj = (GridObject)(object)CS_0024_003C_003E8__locals0;
						Func<Item, bool> cpp2il__autoParamName__idx_ = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
						{
							bool flag3 = default(bool);
							if (!flag3)
							{
								return flag3;
							}
							int itemID = CS_0024_003C_003E8__locals0.villageObj.ItemID;
							throw new NullReferenceException();
						};
						if (!((IEnumerable<>)items).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_))
						{
							continue;
						}
						num++;
					}
					num++;
					if (flag2)
					{
						num2 = 0;
					}
					if (num != 0)
					{
						break;
					}
					while (num == 0)
					{
					}
					if (num2 == 207)
					{
					}
					while (num2 != 177)
					{
					}
				}
				if (num + 1 != 0)
				{
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051A9")]
		[Cpp2IlInjected.Address(RVA = "0x14823B0", Offset = "0x1480DB0", VA = "0x1814823B0")]
		public bool IsAnyItemOnGrid(Item item)
		{
			//Discarded unreachable code: IL_000e
			List<Item> list = (List<Item>)(object)new List<T>();
			return this.IsAnyItemOnGrid((List<>)(object)list);
		}

		[Cpp2IlInjected.Token(Token = "0x60051AA")]
		[Cpp2IlInjected.Address(RVA = "0x1481F90", Offset = "0x1480990", VA = "0x181481F90")]
		public bool IsAnyItemOnGrid(List<Item> items)
		{
			//Discarded unreachable code: IL_00a3, IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1
			ICollection<Grid> values;
			uint num2 = default(uint);
			ICollection<> collection = default(ICollection<>);
			int num3 = default(int);
			Func<Item, bool> func = default(Func<Item, bool>);
			while (true)
			{
				int num = 0;
				values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)gridCollection_.grids_).get_Values();
				if (values == null)
				{
					break;
				}
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_005d;
					}
					num++;
				}
				if (collection != null)
				{
					_003C_003Ec__DisplayClass194_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass194_0();
					CS_0024_003C_003E8__locals0.gridObj = (GridObject)(object)CS_0024_003C_003E8__locals0;
					func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
					{
						bool flag = default(bool);
						if (!flag)
						{
							return flag;
						}
						int itemID = CS_0024_003C_003E8__locals0.gridObj.ItemID;
						throw new NullReferenceException();
					};
					if (!((IEnumerable<>)items).Any<Item>((Func<, >)(object)func))
					{
						continue;
					}
					num++;
					goto IL_005d;
				}
				goto IL_006c;
				IL_006c:
				num++;
				if (collection != null)
				{
					num3 = 0;
				}
				while (num == 0)
				{
				}
				if (num3 == 132)
				{
				}
				while (num3 != 110)
				{
				}
				break;
				IL_005d:
				func += func;
				num += 312;
				goto IL_006c;
			}
			int num4 = num4 + 1;
			if (values != null)
			{
			}
			if (num4 != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051AB")]
		[Cpp2IlInjected.Address(RVA = "0x14836E0", Offset = "0x14820E0", VA = "0x1814836E0", Slot = "45")]
		public bool IsVillageAreaUnlocked(VillageAreaType villageArea)
		{
			MapField<int, Village.Types.VillageArea> areas_ = village_.areas_;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051AC")]
		[Cpp2IlInjected.Address(RVA = "0x147E670", Offset = "0x147D070", VA = "0x18147E670")]
		[IteratorStateMachine(typeof(_003CGetFruitTreeAreas_003Ed__196))]
		public IEnumerable<VillageAreaType> GetFruitTreeAreas(CropItemData fruitItemData)
		{
			_003CGetFruitTreeAreas_003Ed__196 _003CGetFruitTreeAreas_003Ed__ = new _003CGetFruitTreeAreas_003Ed__196(-2);
			_003CGetFruitTreeAreas_003Ed__._003C_003E4__this = this;
			_003CGetFruitTreeAreas_003Ed__._003C_003E3__fruitItemData = fruitItemData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051AD")]
		[Cpp2IlInjected.Address(RVA = "0x147E700", Offset = "0x147D100", VA = "0x18147E700")]
		public unsafe List<IGrid> GetGridsFromScene(Item sceneItem)
		{
			//Discarded unreachable code: IL_01a4, IL_01aa, IL_01b0, IL_01b6
			//IL_001c: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_016e: Expected O, but got I4
			int itemID = sceneItem.ItemID;
			int num = 0;
			int num2 = 0;
			int gridID2 = 0;
			Item sceneItem2 = (Item)itemID;
			List<IGrid> result = (List<IGrid>)(object)new List<T>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = sceneItem2;
			SceneItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<SceneItemData>(item);
			if (itemData != null)
			{
				SceneType sceneType_ = itemData.sceneType_;
			}
			if (num != 0 && -1L <= 7L)
			{
				MapField<int, Village.Types.VillageArea> areas_ = village_.areas_;
				Func<KeyValuePair<int, Village.Types.VillageArea>, bool> func = default(Func<KeyValuePair<int, Village.Types.VillageArea>, bool>);
				if (_003C_003Ec._003C_003E9__197_3 == null)
				{
					func = (Func<KeyValuePair<int, Village.Types.VillageArea>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					});
				}
				IEnumerable<KeyValuePair<int, Village.Types.VillageArea>> enumerable = (IEnumerable<KeyValuePair<int, Village.Types.VillageArea>>)Enumerable.Where<KeyValuePair<int, Village.Types.VillageArea>>((IEnumerable<>)(object)areas_, (Func<, >)(object)func);
				if (enumerable != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num != (int)num3)
						{
							num++;
						}
					}
					enumerable = (IEnumerable<KeyValuePair<int, Village.Types.VillageArea>>)(object)((object)enumerable + (object)enumerable);
					num += 312;
				}
				num++;
				if (enumerable != null)
				{
				}
				if (num != 0)
				{
				}
				Func<BuildingItemData, bool> func2 = (Func<BuildingItemData, bool>)(object)(Func<T, TResult>)delegate(BuildingItemData x)
				{
					Item sceneItem3 = x.SceneItem;
					throw new NullReferenceException();
				};
				IEnumerable<> enumerable2 = default(IEnumerable<>);
				BuildingItemData buildingItemData = Enumerable.FirstOrDefault<BuildingItemData>(enumerable2, (Func<, >)(object)func2);
				if (buildingItemData != null)
				{
					int iD = buildingItemData.ID;
					bool flag = default(bool);
					if (flag)
					{
						Func<WorldData.Types.World, bool> func3 = (Func<WorldData.Types.World, bool>)(object)(Func<T, TResult>)delegate(WorldData.Types.World x)
						{
							//Discarded unreachable code: IL_0011
							Item item2 = sceneItem2;
							return (IntPtr)x.sceneId_ == (IntPtr)item2;
						};
						WorldData.Types.World world = Enumerable.FirstOrDefault<WorldData.Types.World>((IEnumerable<>)num, (Func<, >)(object)func3);
						if (world != null)
						{
							string worldName_ = world.worldName_;
							bool flag2 = default(bool);
							if (flag2)
							{
								bool flag3 = default(bool);
								if (flag3)
								{
									AddGridId((uint)gridID2);
								}
								num++;
								if (num != 0)
								{
								}
								int num4 = default(int);
								if (num4 > 0)
								{
									int num5 = 0;
									House.Types.Floor floor = default(House.Types.Floor);
									MapField<int, House.Types.Room> rooms_ = floor.rooms_;
									int num6 = 0;
									if (((MapField<TKey, TValue>)(object)rooms_).TryGetValue((TKey)num6, out *(TValue*)num))
									{
										AddGridId((uint)num6);
										ICollection<> collection = default(ICollection<>);
										if (collection != null)
										{
										}
										num++;
										if (collection != null)
										{
										}
										if (num != 0)
										{
										}
										Item scroogeGeneralStore = BuildingItem.ScroogeGeneralStore;
										AddBuildingGrid(scroogeGeneralStore);
									}
								}
							}
						}
					}
				}
			}
			return result;
			[Cpp2IlInjected.Token(Token = "0x6005281")]
			[Cpp2IlInjected.Address(RVA = "0xEBB430", Offset = "0xEB9E30", VA = "0x180EBB430")]
			unsafe void AddBuildingGrid(Item buildingItem)
			{
				//Discarded unreachable code: IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0
				//IL_001b: Expected O, but got I4
				//IL_0050: Expected O, but got I4
				//IL_0076: Expected O, but got I4
				int itemID2;
				int num7;
				IEnumerable<uint> enumerable3 = default(IEnumerable<uint>);
				uint num8 = default(uint);
				bool flag4 = default(bool);
				while (true)
				{
					itemID2 = buildingItem.ItemID;
					num7 = 0;
					if (!((MapField<TKey, TValue>)(object)buildingInfos_).TryGetValue((TKey)itemID2, out *(TValue*)num7))
					{
						break;
					}
					if (enumerable3 != null)
					{
						if (num7 < (int)num8)
						{
							num7 += num7;
							if (num7 == (int)num8)
							{
								goto IL_0050;
							}
							num7++;
						}
						GridCollection gridCollection = gridCollection_;
						while (!flag4)
						{
						}
						((List<T>)(object)result).Add((T)num7);
						goto IL_0050;
					}
					goto IL_0054;
					IL_0050:
					num7 += num7;
					goto IL_0054;
					IL_0054:
					num7++;
					if (enumerable3 != null)
					{
					}
					if (num7 == 0)
					{
						if (num7 == 0)
						{
						}
						break;
					}
				}
				if (((MapField<TKey, TValue>)(object)offGridBuildings_).TryGetValue((TKey)itemID2, out *(TValue*)num7))
				{
					Action<uint> action = (Action<uint>)(object)(Action<T>)delegate(uint x)
					{
						AddGridId(x);
					};
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6005280")]
			[Cpp2IlInjected.Address(RVA = "0xEBB7C0", Offset = "0xEBA1C0", VA = "0x180EBB7C0")]
			void AddGridId(uint gridID)
			{
				//Discarded unreachable code: IL_0018
				GridCollection gridCollection2 = gridCollection_;
				bool flag5 = default(bool);
				if (flag5)
				{
					List<IGrid> list = result;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051AE")]
		[Cpp2IlInjected.Address(RVA = "0x1482B90", Offset = "0x1481590", VA = "0x181482B90")]
		public unsafe bool IsGridUnlocked(uint gridID)
		{
			Village village = village_;
			int num = 0;
			if (!village.TryGetVillageArea(gridID, out *(VillageAreaType*)num, out *(Village.Types.VillageArea*)num))
			{
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051AF")]
		[Cpp2IlInjected.Address(RVA = "0x1487860", Offset = "0x1486260", VA = "0x181487860")]
		public bool TryGetVillageBuildingUpgradeLevel(Item buildingItem, out int level)
		{
			int value = 0;
			bool flag = default(bool);
			bool result = default(bool);
			if (flag && this != null)
			{
				return result;
			}
			level.m_value = value;
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B0")]
		[Cpp2IlInjected.Address(RVA = "0x14855E0", Offset = "0x1483FE0", VA = "0x1814855E0")]
		internal unsafe AddRemoveItemResult RemoveFurnitureItem(Item item, in World world, out List<SubGridItem> subgridItems)
		{
			//Discarded unreachable code: IL_00b2
			//IL_0014: Expected O, but got I4
			//IL_0021: Expected O, but got Ref
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			List<SubGridItem> list = (List<SubGridItem>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref subgridItems))._items = (T[])(object)new List<T>());
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				int num = 0;
				int num2 = 0;
				MapField<uint, Grid> grids_ = gridCollection_.grids_;
				bool flag = default(bool);
				Func<KeyValuePair<uint, GridObject>, bool> func = default(Func<KeyValuePair<uint, GridObject>, bool>);
				if (flag && func == null)
				{
					func = (Func<KeyValuePair<uint, GridObject>, bool>)(object)(Func<T, TResult>)((KeyValuePair<uint, GridObject> obj) => (byte)(int)typeof(Item).TypeHandle != 0);
				}
				SubGrid subGrid = default(SubGrid);
				if (num != 0 && num2 != 0 && subGrid != null)
				{
					uint gridID_ = subGrid.gridID_;
					bool flag2 = default(bool);
					if (flag2)
					{
						Func<GridObject, SubGridItem> func2 = default(Func<GridObject, SubGridItem>);
						if (_003C_003Ec._003C_003E9__201_1 == null)
						{
							func2 = (Func<GridObject, SubGridItem>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								//IL_0020: Expected I4, but got O
								int num4 = 0;
								int num5 = 0;
								AmountWithState amountWithState = default(AmountWithState);
								if (amountWithState != null)
								{
								}
								AmountWithState amountWithState2 = default(AmountWithState);
								ItemState state_ = default(ItemState);
								if (num5 != 0 && amountWithState2 != null)
								{
									state_ = amountWithState2.state_;
								}
								((int*)num5)->m_value = (int)state_;
								throw new NullReferenceException();
							});
						}
						ICollection<> collection = default(ICollection<>);
						IEnumerable<GridObject> enumerable = (IEnumerable<GridObject>)Enumerable.Select<GridObject, SubGridItem>((IEnumerable<>)collection, (Func<, >)(object)func2);
					}
				}
				int num3 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051B1")]
		[Cpp2IlInjected.Address(RVA = "0x1485BF0", Offset = "0x14845F0", VA = "0x181485BF0")]
		internal AddRemoveItemResult RemoveTrimmingItem(Item item)
		{
			//Discarded unreachable code: IL_0033, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Trimming)
			{
				RepeatedField<House.Types.Floor> floors_ = playerHouse_.floors_;
				bool flag = default(bool);
				if (flag)
				{
					ICollection<> collection = default(ICollection<>);
					if (collection != null)
					{
						int num2 = 0;
						Item dEFAULT_FLOOR = House.Types.Room.DEFAULT_FLOOR;
						bool flag2 = default(bool);
						if (!flag2)
						{
						}
					}
					if (collection == null)
					{
					}
				}
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B2")]
		[Cpp2IlInjected.Address(RVA = "0x14854E0", Offset = "0x1483EE0", VA = "0x1814854E0")]
		public bool OwnsCharacter(Item item)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<Character> repeatedField = characters_;
			Predicate<Character> predicate = (Predicate<Character>)(object)(Predicate<T>)delegate(Character x)
			{
				Item item3 = x.base_.Item;
				throw new NullReferenceException();
			};
			return ProtoExtensions.Exists<Character>((RepeatedField<>)(object)repeatedField, (Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60051B3")]
		[Cpp2IlInjected.Address(RVA = "0x147DDB0", Offset = "0x147C7B0", VA = "0x18147DDB0")]
		public Character GetCharacter(Item item)
		{
			//Discarded unreachable code: IL_0027, IL_002d
			int num = 0;
			RepeatedField<Character> repeatedField = characters_;
			bool flag = default(bool);
			if (flag)
			{
				Item item2 = default(Item);
				while ((object)item2 == null)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051B4")]
		[Cpp2IlInjected.Address(RVA = "0x14872B0", Offset = "0x1485CB0", VA = "0x1814872B0")]
		public bool TryGetCharacter(Item item, out Character character)
		{
			Character character2 = GetCharacter(item);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B5")]
		[Cpp2IlInjected.Address(RVA = "0x147FFC0", Offset = "0x147E9C0", VA = "0x18147FFC0")]
		internal Character GetOrAddCharacter(Item item, in World world, ITransactionContext context)
		{
			if ((object)typeof(ProfileEventDispatcher).TypeHandle == null)
			{
				bool flag = default(bool);
				if (!flag)
				{
					Character character = new Character();
					BaseItem base_ = character.base_;
					if (world.dispatcher == null)
					{
					}
					int num = 0;
					((RepeatedField<T>)(object)characters_).Add((T)character);
				}
				Character result = default(Character);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051B6")]
		[Cpp2IlInjected.Address(RVA = "0x1487BB0", Offset = "0x14865B0", VA = "0x181487BB0")]
		public int UnlockCharacterCount()
		{
			RepeatedField<Character> repeatedField = characters_;
			Func<Character, bool> func = default(Func<Character, bool>);
			if (_003C_003Ec._003C_003E9__207_0 == null)
			{
				func = (Func<Character, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Character character) => character.IsUnlocked));
			}
			return Enumerable.Count<Character>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60051B7")]
		[Cpp2IlInjected.Address(RVA = "0x14829F0", Offset = "0x14813F0", VA = "0x1814829F0", Slot = "30")]
		public bool IsCharacterUnlocked(Item characterItem)
		{
			Character character = GetCharacter(characterItem);
			if (character == null)
			{
				int num = 0;
			}
			return character.IsUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B8")]
		[Cpp2IlInjected.Address(RVA = "0x147DCE0", Offset = "0x147C6E0", VA = "0x18147DCE0", Slot = "31")]
		public Item GetCharacterProfession(Item characterItem)
		{
			Character character = default(Character);
			if (character != null)
			{
				long num = Convert.ToInt64((uint)character.professionID_);
			}
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B9")]
		[Cpp2IlInjected.Address(RVA = "0x147CFC0", Offset = "0x147B9C0", VA = "0x18147CFC0", Slot = "26")]
		bool IProfileWorld.IsCharacterLockedInVillage(Item characterItem)
		{
			Character character = GetCharacter(characterItem);
			if (character == null)
			{
				int num = 0;
			}
			return character.IsLockedInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x60051BA")]
		[Cpp2IlInjected.Address(RVA = "0x1483770", Offset = "0x1482170", VA = "0x181483770")]
		internal void LockedCharacterInVillage(Item item, in World world, IWorldEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0087
			//IL_0070: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Character character = new Character();
				character.base_.Id = itemID;
				IWorldEventDispatcher dispatcher2 = world.dispatcher;
				int num2 = 0;
				((RepeatedField<T>)(object)characters_).Add((T)character);
			}
			Character character2 = default(Character);
			if (character2.IsUnlocked || character2.status_ == Character.Types.CharacterStatus.LockedInVillage)
			{
				return;
			}
			SecretCharacterRecurringConditionData secretCharacterData_ = character2.secretCharacterData_;
			uint status_ = default(uint);
			character2.status_ = (Character.Types.CharacterStatus)status_;
			if (secretCharacterData_ != null)
			{
				if (dispatcher == null)
				{
				}
				int num3 = 0;
				character2.secretCharacterData_ = (SecretCharacterRecurringConditionData)num;
				Character.Types.CharacterStatus status_2 = character2.status_;
			}
			uint num4 = default(uint);
			if (num < (int)num4)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051BB")]
		[Cpp2IlInjected.Address(RVA = "0x1483480", Offset = "0x1481E80", VA = "0x181483480")]
		public bool IsPreferredItem(Item characterItem, Item item)
		{
			if (GetCharacter(characterItem) == null)
			{
				int num = 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051BC")]
		[Cpp2IlInjected.Address(RVA = "0x1483410", Offset = "0x1481E10", VA = "0x181483410")]
		public bool IsPreferredItemNotGivenToday(Item characterItem, Item item)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (GetCharacter(characterItem) != null && flag)
			{
				return !flag2;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051BD")]
		[Cpp2IlInjected.Address(RVA = "0x1484EC0", Offset = "0x14838C0", VA = "0x181484EC0")]
		public ScheduleType OverrideCharacterSchedule(CharacterItemData characterItemData, ScheduleType? scheduleType, DateTime localTime, bool canOverride, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_004e: Expected O, but got I4
			bool flag = default(bool);
			Character character = default(Character);
			bool flag2 = default(bool);
			Predicate<MissionSlot> predicate2 = default(Predicate<MissionSlot>);
			Predicate<MissionSlot> predicate3 = default(Predicate<MissionSlot>);
			uint num4 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (flag)
				{
					break;
				}
				int num3 = 0;
				if ((DebugSettings.Settings.forceCharactersOutside_ ? 1 : 0) != num)
				{
					break;
				}
				int iD = characterItemData.ID;
				if (character != null && character.status_ == Character.Types.CharacterStatus.LockedInVillage)
				{
					break;
				}
				int iD2 = characterItemData.ID;
				Item characterItem = (Item)iD2;
				if (character != null && character.status_ == Character.Types.CharacterStatus.InEvent)
				{
					break;
				}
				MapField<int, MissionQueue> mapField = missionSlots_;
				if (mapField != null)
				{
					Predicate<MissionSlot> predicate = default(Predicate<MissionSlot>);
					Func<KeyValuePair<int, MissionQueue>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<int, MissionQueue>, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_002e
						if ((object)typeof(_003C_003Ec__DisplayClass214_0).TypeHandle != null)
						{
							if (predicate == null)
							{
								predicate = (Predicate<MissionSlot>)(object)(Predicate<T>)delegate(MissionSlot x)
								{
									//Discarded unreachable code: IL_000f
									Item characterItem2 = characterItem;
									return x.OverrideScheduleOutdoor(characterItem2);
								};
							}
							int num8 = 0;
						}
						return 0 == 1;
					};
					if (((IEnumerable<>)(object)mapField).Any<KeyValuePair<int, MissionQueue>>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						break;
					}
				}
				if (missionSlots_ != null)
				{
					if (flag2)
					{
						if (flag2)
						{
							if (mapField != null && predicate2 == null)
							{
								predicate2 = (Predicate<MissionSlot>)(object)(Predicate<T>)delegate(MissionSlot x)
								{
									//Discarded unreachable code: IL_0010
									if ((object)x.CharacterItem == null)
									{
									}
									return x.IsMissionStarted;
								};
							}
							if (num != 1)
							{
								num++;
							}
						}
						if (mapField != null && predicate3 == null)
						{
							Func<MissionObjectiveData, bool> func = default(Func<MissionObjectiveData, bool>);
							predicate3 = (Predicate<MissionSlot>)(object)(Predicate<T>)delegate(MissionSlot x)
							{
								//Discarded unreachable code: IL_003f
								bool isMissionStarted = x.IsMissionStarted;
								if (!isMissionStarted)
								{
									return isMissionStarted;
								}
								MissionItemData missionItemData = default(MissionItemData);
								IEnumerable<MissionObjectiveData> allStepsObjectives = (IEnumerable<MissionObjectiveData>)missionItemData.get_AllStepsObjectives();
								Func<MissionObjectiveData, bool> func2 = default(Func<MissionObjectiveData, bool>);
								if (func == null)
								{
									func2 = (func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData obj)
									{
										uint num6 = default(uint);
										while (obj != null)
										{
											ITargetCharacterOverride getITargetCharacterOverride = obj.GetITargetCharacterOverride;
											int num5 = 0;
											if (getITargetCharacterOverride != null)
											{
												if (num5 < (int)num6)
												{
													num5 += num5;
													num5++;
												}
												getITargetCharacterOverride = (ITargetCharacterOverride)(object)((object)getITargetCharacterOverride + (object)getITargetCharacterOverride);
												break;
											}
										}
										bool flag3 = default(bool);
										if (0 == 0 || flag3)
										{
										}
										int num7 = 0;
										/*Error: Unexpected end of block*/;
									});
								}
								return Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func2) != null;
							};
						}
						while (num == 1)
						{
						}
						num++;
					}
					num++;
					if (num != 0)
					{
						continue;
					}
					if (num != 0)
					{
						if (num == 491)
						{
						}
						if (num4 == 467)
						{
							break;
						}
					}
				}
				if (character != null && character.status_ == Character.Types.CharacterStatus.Unlocked)
				{
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051BE")]
		[Cpp2IlInjected.Address(RVA = "0x147E630", Offset = "0x147D030", VA = "0x18147E630", Slot = "19")]
		public int GetFriendshipLevel(Item characterItem)
		{
			Character character;
			do
			{
				character = GetCharacter(characterItem);
			}
			while (character == null);
			return character.friendshipLevel_;
		}

		[Cpp2IlInjected.Token(Token = "0x60051BF")]
		[Cpp2IlInjected.Address(RVA = "0x147C3E0", Offset = "0x147ADE0", VA = "0x18147C3E0")]
		private bool CheckNoFriendshipEvent(Item characterItem, int amount, FriendshipSource source)
		{
			NoFriendshipEvent noFriendshipEvent = _noFriendshipEvent;
			if (noFriendshipEvent == null)
			{
				int num = 0;
			}
			noFriendshipEvent.AddCharacterFriendship(characterItem, amount, source);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60051C0")]
		[Cpp2IlInjected.Address(RVA = "0x147B170", Offset = "0x1479B70", VA = "0x18147B170")]
		internal AddedFriendshipSummary AddCharacterFriendship(Item characterItem, int amount, FriendshipSource source, in Player player, in World world, ITransactionContext context, bool mustRaiseFriendshipAdded = true)
		{
			//IL_0026: Expected O, but got I4
			//IL_0075: Expected I4, but got I8
			//IL_0085: Expected I4, but got I8
			int itemID = characterItem.ItemID;
			if (_noFriendshipEvent == null)
			{
				int num = 0;
				AddedFriendshipSummary addedFriendshipSummary = new AddedFriendshipSummary();
				addedFriendshipSummary.CharacterItem = (Item)itemID;
				Character character = default(Character);
				int num2 = (addedFriendshipSummary.PreviousCharacterFriendship = character.friendship_);
				ProfilePlayer profilePlayer = default(ProfilePlayer);
				int num3 = (addedFriendshipSummary.PreviousPlayerXP = profilePlayer.xp_);
				addedFriendshipSummary.FriendshipGained = 0;
				addedFriendshipSummary.FriendshipSource = source;
				if (character.friendshipLevel_ != num)
				{
				}
				if (character.status_ == Character.Types.CharacterStatus.InRealm)
				{
					addedFriendshipSummary.FriendshipGained = 1;
				}
				if ((long)character == 5)
				{
					addedFriendshipSummary.FriendshipGained = 1;
				}
				num += num;
				num++;
			}
			int num4 = 0;
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051C1")]
		[Cpp2IlInjected.Address(RVA = "0x1482890", Offset = "0x1481290", VA = "0x181482890", Slot = "42")]
		public bool IsBuildingUnlocked(Item buildingItem)
		{
			//Discarded unreachable code: IL_002c
			//IL_002b: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBuildingUnlockable buildingUnlockable = default(IBuildingUnlockable);
			if (buildingUnlockable == null)
			{
				int num = 0;
			}
			if (!buildingUnlockable.NeedUnlock())
			{
				return false;
			}
			return ((RepeatedField<T>)(object)unlockedBuildings_).Contains((T)16777216);
		}

		[Cpp2IlInjected.Token(Token = "0x60051C2")]
		[Cpp2IlInjected.Address(RVA = "0x14827F0", Offset = "0x14811F0", VA = "0x1814827F0", Slot = "43")]
		public bool IsBuildingUnlocked(IBuildingUnlockable buildingUnlockable)
		{
			//Discarded unreachable code: IL_0026
			//IL_0025: Expected O, but got I4
			if (buildingUnlockable == null)
			{
				int num = 0;
			}
			if (!buildingUnlockable.NeedUnlock())
			{
				return false;
			}
			return ((RepeatedField<T>)(object)unlockedBuildings_).Contains((T)16777216);
		}

		[Cpp2IlInjected.Token(Token = "0x60051C3")]
		[Cpp2IlInjected.Address(RVA = "0x1482450", Offset = "0x1480E50", VA = "0x181482450")]
		public bool IsBuildingBuilt(int buildingId)
		{
			//Discarded unreachable code: IL_002b
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBuildingConstructable buildingConstructable = default(IBuildingConstructable);
			if (buildingConstructable != null && buildingConstructable != null)
			{
				GridCollection gridCollection = gridCollection_;
				HouseData houseData = default(HouseData);
				if (houseData != null)
				{
					bool built_ = houseData.built_;
					int num = 0;
				}
				int num2 = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60051C4")]
		[Cpp2IlInjected.Address(RVA = "0x1482640", Offset = "0x1481040", VA = "0x181482640")]
		public bool IsBuildingBuilt(Item buildingItem)
		{
			//Discarded unreachable code: IL_002b
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBuildingConstructable buildingConstructable = default(IBuildingConstructable);
			if (buildingConstructable != null && buildingConstructable != null)
			{
				GridCollection gridCollection = gridCollection_;
				HouseData houseData = default(HouseData);
				if (houseData != null)
				{
					bool built_ = houseData.built_;
					int num = 0;
				}
				int num2 = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60051C6")]
		[Cpp2IlInjected.Address(RVA = "0x14834D0", Offset = "0x1481ED0", VA = "0x1814834D0", Slot = "27")]
		public unsafe bool IsRealmUnlocked(Item universeTagItem)
		{
			//IL_0016: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			int itemID = universeTagItem.ItemID;
			int num = 0;
			Item universeTagItem2 = (Item)itemID;
			bool flag = default(bool);
			TagItemType tagItemType = default(TagItemType);
			bool flag2 = default(bool);
			if (flag && tagItemType == TagItemType.Universe && flag2)
			{
				Func<WorldData.Types.World, bool> func = (Func<WorldData.Types.World, bool>)(object)(Func<T, TResult>)delegate(WorldData.Types.World y)
				{
					Item universeTagItem3 = y.UniverseTagItem;
					throw new NullReferenceException();
				};
				WorldData.Types.World world = Enumerable.FirstOrDefault<WorldData.Types.World>((IEnumerable<>)num, (Func<, >)(object)func);
				if (world == null)
				{
					return true;
				}
				MapField<string, Realm> mapField = realms_;
				string worldName_ = world.worldName_;
				if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)worldName_, out *(TValue*)num))
				{
					goto IL_0064;
				}
			}
			int num2 = 0;
			goto IL_0064;
			IL_0064:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051C7")]
		[Cpp2IlInjected.Address(RVA = "0x147B880", Offset = "0x147A280", VA = "0x18147B880", Slot = "28")]
		public bool AnyRealmUnlocked()
		{
			MapField<string, Realm> cpp2il__autoParamName__idx_ = realms_;
			Func<KeyValuePair<string, Realm>, bool> _003C_003E9__227_ = _003C_003Ec._003C_003E9__227_0;
			if (_003C_003E9__227_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			return ((IEnumerable<>)(object)cpp2il__autoParamName__idx_).Any<KeyValuePair<string, Realm>>((Func<, >)(object)_003C_003E9__227_);
		}

		[Cpp2IlInjected.Token(Token = "0x60051C8")]
		[Cpp2IlInjected.Address(RVA = "0x147CD60", Offset = "0x147B760", VA = "0x18147CD60", Slot = "48")]
		string IKeyholesProvider.AddKeyhole(string KeyholeConfigDataGUID)
		{
			//Discarded unreachable code: IL_004c
			//IL_0038: Expected I4, but got I8
			KeyholeConfig keyholeConfig = KeyholeConfig.GetKeyholeConfig(KeyholeConfigDataGUID);
			if (keyholeConfig != null)
			{
				MapField<string, Keyhole> mapField = keyholes_;
				bool flag = default(bool);
				if (!flag)
				{
					Keyhole keyhole = new Keyhole();
					string text = (keyhole.GUID = keyholeConfig.gUID_);
					keyhole.currentLevel_ = 0;
					((MapField<TKey, TValue>)(object)keyholes_).Add((TKey)KeyholeConfigDataGUID, (TValue)keyhole);
				}
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x60051C9")]
		[Cpp2IlInjected.Address(RVA = "0x147CED0", Offset = "0x147B8D0", VA = "0x18147CED0", Slot = "49")]
		void IKeyholesProvider.RemoveKeyhole(string KeyholeConfigDataGUID)
		{
			//Discarded unreachable code: IL_000e
			bool flag = ((MapField<TKey, TValue>)(object)keyholes_).Remove((TKey)KeyholeConfigDataGUID);
		}

		[Cpp2IlInjected.Token(Token = "0x60051CA")]
		[Cpp2IlInjected.Address(RVA = "0x147CF30", Offset = "0x147B930", VA = "0x18147CF30", Slot = "46")]
		int IProfileWorld.GetKeyholeCurrentLevel(string KeyholeConfigDataGUID)
		{
			//Discarded unreachable code: IL_000d
			MapField<string, Keyhole> mapField = keyholes_;
			bool flag = default(bool);
			if (flag)
			{
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60051CB")]
		[Cpp2IlInjected.Address(RVA = "0x147A1E0", Offset = "0x1478BE0", VA = "0x18147A1E0")]
		internal unsafe void AddBuildingInfos(IBuildingUnlockable unlockableBuilding, in World world, ITransactionContext context)
		{
			//IL_0024: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag || flag)
			{
				return;
			}
			bool flag2 = ((MapField<TKey, TValue>)(object)buildingInfos_).ContainsKey((TKey)flag);
			if (flag2 || ((MapField<TKey, TValue>)(object)offGridBuildings_).ContainsKey((TKey)flag2))
			{
				return;
			}
			IFileSystem binaryLocalizationFs = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
			object obj = default(object);
			if (obj == null)
			{
			}
			BuildingInfo buildingInfo;
			Dictionary<uint, int> invertedWallGridIDs;
			if (obj != null)
			{
				if (obj == null)
				{
					return;
				}
				if (obj == null)
				{
					BuildingInfo buildingInfo2 = new BuildingInfo();
					IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
					string empty = default(string);
					if ((object)typeof(FileSystem).TypeHandle == null)
					{
						empty = string.Empty;
					}
					buildingInfo2.CustomLocationPositionsPath = empty;
					buildingInfo = buildingInfo2;
					IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
					List<IGrid> newGrids = (List<IGrid>)(object)new List<T>();
					if (obj == null)
					{
						BuildingInfo buildingInfo3 = buildingInfo;
						BuildingInfo.Types.GridIDList gridIDList2 = (buildingInfo3.GridIDs = new BuildingInfo.Types.GridIDList());
						if (obj == null)
						{
							goto IL_030a;
						}
						string assemblyQualifiedName = typeof(GridCollection).AssemblyQualifiedName;
						List<IGrid> list = newGrids;
					}
					BuildingInfo buildingInfo4 = buildingInfo;
					House.Types.Room room2 = (buildingInfo4.Room = new House.Types.Room());
					MapField<int, uint> wallGridIDs_ = room2.wallGridIDs_;
					Func<KeyValuePair<int, uint>, uint> func = default(Func<KeyValuePair<int, uint>, uint>);
					if (_003C_003Ec._003C_003E9__231_1 == null)
					{
						func = (Func<KeyValuePair<int, uint>, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					Func<KeyValuePair<int, uint>, int> func2 = default(Func<KeyValuePair<int, uint>, int>);
					if (_003C_003Ec._003C_003E9__231_2 == null)
					{
						func2 = (Func<KeyValuePair<int, uint>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, uint> x) => (int)((KeyValuePair<, >*)(&x))->key));
					}
					invertedWallGridIDs = (Dictionary<uint, int>)(object)Enumerable.ToDictionary<KeyValuePair<int, uint>, uint, int>((IEnumerable<>)(object)wallGridIDs_, (Func<, >)(object)func, (Func<, >)(object)func2);
					House.Types.Room room3 = buildingInfo.Room;
					List<IGrid> list2 = newGrids;
					Action<uint, uint> action = (Action<uint, uint>)(object)new Action<T1, T2>(ReattributeWallGridIDs);
					uint floorGridID_ = default(uint);
					room3.floorGridID_ = floorGridID_;
					int i = num;
					List<IGrid> list3 = newGrids;
					if (buildingInfo.GridIDs != null)
					{
						List<IGrid> cpp2il__autoParamName__idx_ = newGrids;
						Func<IGrid, bool> cpp2il__autoParamName__idx_2 = (Func<IGrid, bool>)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						};
						if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<IGrid>((Func<, >)(object)cpp2il__autoParamName__idx_2))
						{
							RepeatedField<uint> list_ = buildingInfo.GridIDs.list_;
							List<IGrid> list4 = newGrids;
						}
					}
					List<IGrid> list5 = newGrids;
					List<IGrid> list6 = newGrids;
					BuildingInfo buildingInfo5 = buildingInfo;
					WorldProfile worldProfile = default(WorldProfile);
					IProfile profile = worldProfile.profile;
					return;
				}
				List<IGrid> newGrids2 = (List<IGrid>)(object)new List<T>();
				GridCollection gridCollection = gridCollection_;
				List<IGrid> list7 = newGrids2;
				int j = num;
				List<IGrid> cpp2il__autoParamName__idx_3 = newGrids2;
				Func<IGrid, bool> func3 = default(Func<IGrid, bool>);
				Func<IGrid, bool> cpp2il__autoParamName__idx_4 = default(Func<IGrid, bool>);
				if (func3 == null)
				{
					cpp2il__autoParamName__idx_4 = (func3 = (Func<IGrid, bool>)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				if (!((IEnumerable<>)cpp2il__autoParamName__idx_3).Any<IGrid>((Func<, >)(object)cpp2il__autoParamName__idx_4))
				{
					List<IGrid> list8 = newGrids2;
				}
				List<IGrid> list9 = newGrids2;
				List<IGrid> list10 = newGrids2;
				throw new NullReferenceException();
			}
			goto IL_030a;
			IL_030a:
			throw new InvalidCastException();
			[Cpp2IlInjected.Token(Token = "0x6005293")]
			[Cpp2IlInjected.Address(RVA = "0xEBC1E0", Offset = "0xEBABE0", VA = "0x180EBC1E0")]
			void ReattributeWallGridIDs(uint oldID, uint newID)
			{
				//Discarded unreachable code: IL_0028
				//IL_0027: Expected O, but got I4
				//IL_0027: Expected O, but got I8
				Dictionary<uint, int> dictionary = invertedWallGridIDs;
				bool flag3 = default(bool);
				if (flag3)
				{
					ulong num3 = default(ulong);
					((MapField<TKey, TValue>)(object)buildingInfo.Room.wallGridIDs_).Add((TKey)num3, (TValue)newID);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051CC")]
		[Cpp2IlInjected.Address(RVA = "0x1486DE0", Offset = "0x14857E0", VA = "0x181486DE0")]
		private unsafe bool TryGetBodiesOfWater(PendingFishSelector.Types.BodyOfWaterData bodyOfWaterData, out RepeatedField<BodyOfWater> bodiesOfWater)
		{
			//IL_0042: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got Ref
			//IL_007b: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			//IL_00c1: Expected O, but got Ref
			int num = 0;
			PendingFishSelector.Types.BodyOfWaterData bodyOfWaterData2 = bodyOfWaterData;
			ActivityDataLocationFilter activityDataLocationFilter = default(ActivityDataLocationFilter);
			switch (activityDataLocationFilter.locationTypeCase_)
			{
			case ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea:
			{
				MapField<int, Village.Types.VillageArea> areas_ = village_.areas_;
				int villageArea = (int)activityDataLocationFilter.VillageArea;
				if (((MapField<TKey, TValue>)(object)areas_).TryGetValue((TKey)villageArea, out *(TValue*)num))
				{
					((RepeatedField<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bodiesOfWater)).list = (List<T>)num;
					return true;
				}
				break;
			}
			case ActivityDataLocationFilter.LocationTypeOneofCase.Scene:
			{
				bool flag = default(bool);
				if (flag)
				{
					Predicate<WorldData.Types.World> predicate = (Predicate<WorldData.Types.World>)(object)(Predicate<T>)delegate(WorldData.Types.World x)
					{
						//Discarded unreachable code: IL_001f
						PendingFishSelector.Types.BodyOfWaterData bodyOfWaterData4 = bodyOfWaterData;
						int sceneId_ = x.sceneId_;
						int scene2 = bodyOfWaterData4.location_.Scene;
						return sceneId_ == scene2;
					};
					bool flag2 = default(bool);
					if (flag2 && !((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)num, out *(TValue*)num))
					{
					}
				}
				Func<OffGridBuildingItemData, bool> func = (Func<OffGridBuildingItemData, bool>)(object)(Func<T, TResult>)delegate(OffGridBuildingItemData x)
				{
					//Discarded unreachable code: IL_001f
					PendingFishSelector.Types.BodyOfWaterData bodyOfWaterData3 = bodyOfWaterData;
					int scene_ = x.scene_;
					int scene = bodyOfWaterData3.location_.Scene;
					return scene_ == scene;
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				OffGridBuildingItemData offGridBuildingItemData = Enumerable.FirstOrDefault<OffGridBuildingItemData>(enumerable, (Func<, >)(object)func);
				if (offGridBuildingItemData != null)
				{
					MapField<int, OffGridBuilding> mapField = offGridBuildings_;
					int iD_ = offGridBuildingItemData.iD_;
					if (!((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)iD_, out *(TValue*)num))
					{
					}
				}
				break;
			}
			}
			((RepeatedField<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bodiesOfWater)).list = (List<T>)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051CD")]
		[Cpp2IlInjected.Address(RVA = "0x14871C0", Offset = "0x1485BC0", VA = "0x1814871C0")]
		public unsafe bool TryGetBodyOfWater(PendingFishSelector.Types.BodyOfWaterData bodyOfWaterData, out BodyOfWater bodyOfWater)
		{
			int num = 0;
			int num2 = default(int);
			if (TryGetBodiesOfWater(bodyOfWaterData, out *(RepeatedField<BodyOfWater>*)num) && bodyOfWaterData.index_ < num2)
			{
				int index_ = bodyOfWaterData.index_;
				return true;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051CE")]
		[Cpp2IlInjected.Address(RVA = "0x1480430", Offset = "0x147EE30", VA = "0x181480430")]
		public Shop GetShop(string shopName)
		{
			Shop result = default(Shop);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051CF")]
		[Cpp2IlInjected.Address(RVA = "0x1480170", Offset = "0x147EB70", VA = "0x181480170")]
		internal Shop GetOrCreateShop(string shopName, out bool shouldBeAdded)
		{
			//Discarded unreachable code: IL_0056
			RepeatedField<Shop> repeatedField = shops_;
			Func<Shop, bool> func = (Func<Shop, bool>)(object)(Func<T, TResult>)delegate(Shop x)
			{
				//Discarded unreachable code: IL_0014
				string b = shopName;
				return string.Equals(x.shopName_, b);
			};
			Shop shop = Enumerable.FirstOrDefault<Shop>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (shop == null)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
					Shop shop2 = new Shop();
					string text2 = (shop2.ShopName = shopName);
				}
			}
			return shop;
		}

		[Cpp2IlInjected.Token(Token = "0x60051D0")]
		[Cpp2IlInjected.Address(RVA = "0x1480450", Offset = "0x147EE50", VA = "0x181480450")]
		public StoreInfo GetStore(Item item)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<StoreInfo> repeatedField = stores_;
			Func<StoreInfo, bool> func = (Func<StoreInfo, bool>)(object)(Func<T, TResult>)delegate(StoreInfo x)
			{
				//Discarded unreachable code: IL_0011
				Item item3 = item2;
				return (IntPtr)x.buildingItemID_ == (IntPtr)item3;
			};
			return Enumerable.FirstOrDefault<StoreInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D1")]
		[Cpp2IlInjected.Address(RVA = "0x147F6B0", Offset = "0x147E0B0", VA = "0x18147F6B0")]
		public MissionQueue GetMissionQueue(MissionSlotClass slotClass)
		{
			//Discarded unreachable code: IL_0033
			//IL_000e: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			if (!((MapField<TKey, TValue>)(object)missionSlots_).ContainsKey((TKey)slotClass))
			{
				MapField<int, MissionQueue> mapField = missionSlots_;
				MissionQueue value = new MissionQueue();
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)slotClass, (TValue)value);
			}
			return (MissionQueue)((MapField<TKey, TValue>)(object)missionSlots_)[(TKey)slotClass];
		}

		[Cpp2IlInjected.Token(Token = "0x60051D2")]
		[Cpp2IlInjected.Address(RVA = "0x1480530", Offset = "0x147EF30", VA = "0x181480530")]
		[IteratorStateMachine(typeof(_003CGetValidMissionSlot_003Ed__240))]
		public IEnumerable<MissionSlot> GetValidMissionSlot(MissionSlotClass slotClass, [System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			_003CGetValidMissionSlot_003Ed__240 _003CGetValidMissionSlot_003Ed__ = new _003CGetValidMissionSlot_003Ed__240(-2);
			_003CGetValidMissionSlot_003Ed__._003C_003E4__this = this;
			_003CGetValidMissionSlot_003Ed__._003C_003E3__predicate = predicate;
			_003CGetValidMissionSlot_003Ed__._003C_003E3__slotClass = slotClass;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051D3")]
		[Cpp2IlInjected.Address(RVA = "0x14805D0", Offset = "0x147EFD0", VA = "0x1814805D0")]
		[IteratorStateMachine(typeof(_003CGetValidMissionSlot_003Ed__241))]
		public IEnumerable<MissionSlot> GetValidMissionSlot([System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			_003CGetValidMissionSlot_003Ed__241 _003CGetValidMissionSlot_003Ed__ = new _003CGetValidMissionSlot_003Ed__241(-2);
			_003CGetValidMissionSlot_003Ed__._003C_003E4__this = this;
			_003CGetValidMissionSlot_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051D4")]
		[Cpp2IlInjected.Address(RVA = "0x147DB70", Offset = "0x147C570", VA = "0x18147DB70")]
		[IteratorStateMachine(typeof(_003CGetAllMissionSlot_003Ed__242))]
		public IEnumerable<MissionSlot> GetAllMissionSlot([System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			_003CGetAllMissionSlot_003Ed__242 _003CGetAllMissionSlot_003Ed__ = new _003CGetAllMissionSlot_003Ed__242(-2);
			_003CGetAllMissionSlot_003Ed__._003C_003E4__this = this;
			_003CGetAllMissionSlot_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051D5")]
		[Cpp2IlInjected.Address(RVA = "0x147DC00", Offset = "0x147C600", VA = "0x18147DC00")]
		public IEnumerable<MissionSlot> GetCharacterMissions(Item characterItem, [System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			//Discarded unreachable code: IL_0030
			//IL_001b: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_001e
				//IL_001c: Expected I4, but got O
				if ((object)x.CharacterItem == null)
				{
				}
				Func<MissionSlot, bool> func2 = predicate;
				return (func2 == null) ? true : ((byte)(int)func2((T)x) != 0);
			};
			return (IEnumerable<MissionSlot>)this.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D6")]
		[Cpp2IlInjected.Address(RVA = "0x147FA70", Offset = "0x147E470", VA = "0x18147FA70")]
		public MissionSlot GetMissionSlot(MissionSlotClass slotClass, int slotId)
		{
			//IL_000e: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int num = (int)slotClass;
			if (!((MapField<TKey, TValue>)(object)missionSlots_).ContainsKey((TKey)num))
			{
				MapField<int, MissionQueue> mapField = missionSlots_;
				MissionQueue value = new MissionQueue();
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)num, (TValue)value);
			}
			MissionQueue missionQueue = (MissionQueue)((MapField<TKey, TValue>)(object)missionSlots_)[(TKey)num];
			if (missionQueue != null)
			{
				RepeatedField<MissionSlot> slots_ = missionQueue.slots_;
				if (slots_ != null)
				{
					num = slotId;
					return Enumerable.ElementAtOrDefault<MissionSlot>((IEnumerable<>)(object)slots_, num);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051D7")]
		[Cpp2IlInjected.Address(RVA = "0x14874B0", Offset = "0x1485EB0", VA = "0x1814874B0")]
		public bool TryGetMissionSlot(MissionSlotClass slotClass, int slotId, out MissionSlot slot)
		{
			//Discarded unreachable code: IL_0056
			//IL_000e: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int num = (int)slotClass;
			if (!((MapField<TKey, TValue>)(object)missionSlots_).ContainsKey((TKey)num))
			{
				MapField<int, MissionQueue> mapField = missionSlots_;
				MissionQueue value = new MissionQueue();
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)num, (TValue)value);
			}
			MissionQueue missionQueue = (MissionQueue)((MapField<TKey, TValue>)(object)missionSlots_)[(TKey)num];
			if (missionQueue != null)
			{
				RepeatedField<MissionSlot> slots_ = missionQueue.slots_;
				if (slots_ != null)
				{
					num = slotId;
					MissionSlot missionSlot = Enumerable.ElementAtOrDefault<MissionSlot>((IEnumerable<>)(object)slots_, num);
				}
			}
			int num2 = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051D8")]
		[Cpp2IlInjected.Address(RVA = "0x147F7A0", Offset = "0x147E1A0", VA = "0x18147F7A0")]
		public MissionSlot GetMissionSlot(Item missionItem, [System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			//Discarded unreachable code: IL_0056
			//IL_000f: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			IEnumerable<MissionSlot> enumerable;
			if (flag)
			{
				int num2 = 0;
				enumerable = (IEnumerable<MissionSlot>)this.GetAllMissionSlot((Func<, >)num2);
				if (enumerable != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_003d;
						}
						num++;
					}
					Item item = default(Item);
					while ((object)item == null)
					{
					}
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					if (!flag2 || predicate == null || flag3)
					{
					}
					num++;
					goto IL_003d;
				}
				goto IL_0041;
			}
			goto IL_004d;
			IL_004d:
			int num4 = 0;
			throw new NullReferenceException();
			IL_003d:
			enumerable = (IEnumerable<MissionSlot>)(object)((object)enumerable + (object)enumerable);
			goto IL_0041;
			IL_0041:
			num++;
			if (enumerable != null)
			{
			}
			if (num == 0)
			{
			}
			goto IL_004d;
		}

		[Cpp2IlInjected.Token(Token = "0x60051D9")]
		[Cpp2IlInjected.Address(RVA = "0x1487610", Offset = "0x1486010", VA = "0x181487610")]
		public bool TryGetMissionSlot(Item missionItem, out MissionSlot slot, [System.Runtime.InteropServices.Optional] Func<MissionSlot, bool> predicate)
		{
			MissionSlot missionSlot = this.GetMissionSlot(missionItem, (Func<, >)(object)predicate);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051DA")]
		[Cpp2IlInjected.Address(RVA = "0x1487650", Offset = "0x1486050", VA = "0x181487650")]
		public bool TryGetOngoingMissionSlot(Item missionItem, string activeStepName, out MissionSlot missionSlot, [System.Runtime.InteropServices.Optional] Func<MissionItemData, bool> predicate)
		{
			bool flag = default(bool);
			if (flag)
			{
				Func<MissionStepData, bool> func = (Func<MissionStepData, bool>)(object)(Func<T, TResult>)delegate(MissionStepData x)
				{
					//Discarded unreachable code: IL_0014
					string b = activeStepName;
					return string.Equals(x.stepName_, b);
				};
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051DB")]
		[Cpp2IlInjected.Address(RVA = "0x147FD90", Offset = "0x147E790", VA = "0x18147FD90")]
		[IteratorStateMachine(typeof(_003CGetOnGoingMissionObjectives_003Ed__249))]
		public IEnumerable<MissionObjective> GetOnGoingMissionObjectives(MissionSlot slot, [System.Runtime.InteropServices.Optional] Func<MissionObjective, bool> predicate)
		{
			_003CGetOnGoingMissionObjectives_003Ed__249 _003CGetOnGoingMissionObjectives_003Ed__ = new _003CGetOnGoingMissionObjectives_003Ed__249(-2);
			_003CGetOnGoingMissionObjectives_003Ed__._003C_003E3__slot = slot;
			_003CGetOnGoingMissionObjectives_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051DC")]
		[Cpp2IlInjected.Address(RVA = "0x147FE20", Offset = "0x147E820", VA = "0x18147FE20")]
		public IEnumerable<MissionObjective> GetOnGoingMissionObjectives(Item missionItem, [System.Runtime.InteropServices.Optional] Func<MissionObjective, bool> predicate)
		{
			if (_003C_003Ec._003C_003E9__250_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					//Discarded unreachable code: IL_0015
					if (x.state_ != MissionSlotState.OnGoing)
					{
						int num = 0;
					}
					return !x.OwnerInactive;
				};
			}
			MissionSlot _003C_003E3__slot = default(MissionSlot);
			new _003CGetOnGoingMissionObjectives_003Ed__249(-2)._003C_003E3__slot = _003C_003E3__slot;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051DD")]
		[Cpp2IlInjected.Address(RVA = "0x147FD00", Offset = "0x147E700", VA = "0x18147FD00")]
		[IteratorStateMachine(typeof(_003CGetOnGoingMissionObjectives_003Ed__251))]
		public IEnumerable<MissionObjective> GetOnGoingMissionObjectives([System.Runtime.InteropServices.Optional] Func<MissionObjective, bool> predicate)
		{
			_003CGetOnGoingMissionObjectives_003Ed__251 _003CGetOnGoingMissionObjectives_003Ed__ = new _003CGetOnGoingMissionObjectives_003Ed__251(-2);
			_003CGetOnGoingMissionObjectives_003Ed__._003C_003E4__this = this;
			_003CGetOnGoingMissionObjectives_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051DE")]
		[Cpp2IlInjected.Address(RVA = "0x147E4E0", Offset = "0x147CEE0", VA = "0x18147E4E0")]
		public IEnumerable<FilterInfo> GetFiltersItemInfo(Item item, ItemState state)
		{
			//Discarded unreachable code: IL_000f
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByItem(this, itemData, state);
		}

		[Cpp2IlInjected.Token(Token = "0x60051DF")]
		[Cpp2IlInjected.Address(RVA = "0x147E4D0", Offset = "0x147CED0", VA = "0x18147E4D0")]
		public IEnumerable<FilterInfo> GetFiltersItemInfo(IItemData itemData, ItemState state)
		{
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByItem(this, itemData, state);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E0")]
		[Cpp2IlInjected.Address(RVA = "0x147E3F0", Offset = "0x147CDF0", VA = "0x18147E3F0")]
		public IEnumerable<FilterInfo> GetFiltersCatalogInfo()
		{
			//Discarded unreachable code: IL_0018
			//IL_000e: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			List<ItemType> list = (List<ItemType>)(object)new List<T>();
			((List<T>)(object)list).Add((T)4);
			((List<T>)(object)list).Add((T)2);
			IEnumerable<FilterInfo> result = default(IEnumerable<FilterInfo>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051E1")]
		[Cpp2IlInjected.Address(RVA = "0x147E600", Offset = "0x147D000", VA = "0x18147E600")]
		public IEnumerable<FilterInfo> GetFiltersWardrobeInfo()
		{
			int num = 0;
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByFilter(this, ItemType.Clothing, GoBehavior.Item, (MissionObjectiveData.CustomStepOneofCase)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E2")]
		[Cpp2IlInjected.Address(RVA = "0x147E3C0", Offset = "0x147CDC0", VA = "0x18147E3C0")]
		public IEnumerable<FilterInfo> GetFiltersBackpackInfo()
		{
			int num = 0;
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByFilter(this, ItemType.ActivityItem, GoBehavior.Item, (MissionObjectiveData.CustomStepOneofCase)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E3")]
		[Cpp2IlInjected.Address(RVA = "0x147E5C0", Offset = "0x147CFC0", VA = "0x18147E5C0")]
		public IEnumerable<FilterInfo> GetFiltersMealInfo()
		{
			int num = 0;
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByFilter(this, ActivityItemType.Meal, GoBehavior.Item, (MissionObjectiveData.CustomStepOneofCase)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E4")]
		[Cpp2IlInjected.Address(RVA = "0x147E4C0", Offset = "0x147CEC0", VA = "0x18147E4C0")]
		public IEnumerable<FilterInfo> GetFiltersCropInfo()
		{
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByGardeningFilter(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E5")]
		[Cpp2IlInjected.Address(RVA = "0x147E4B0", Offset = "0x147CEB0", VA = "0x18147E4B0")]
		public IEnumerable<FilterInfo> GetFiltersCraftInfo()
		{
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByStepType(this, MissionObjectiveData.CustomStepOneofCase.CraftItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E6")]
		[Cpp2IlInjected.Address(RVA = "0x147E5F0", Offset = "0x147CFF0", VA = "0x18147E5F0")]
		public IEnumerable<FilterInfo> GetFiltersPurchaseInfo()
		{
			return (IEnumerable<FilterInfo>)FilterInfo.GetMissionsByStepType(this, MissionObjectiveData.CustomStepOneofCase.PurchaseItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E7")]
		[Cpp2IlInjected.Address(RVA = "0x1485FE0", Offset = "0x14849E0", VA = "0x181485FE0")]
		public IEnumerable<MissionSlot> SearchQuestSlots(QuestTree quest)
		{
			//Discarded unreachable code: IL_0029
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_0026
				QuestInformation questInformation = questInfo_;
				Item missionItem = x.MissionItem;
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				QuestTree questTree = quest;
				bool result = default(bool);
				return result;
			};
			return (IEnumerable<MissionSlot>)this.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E8")]
		[Cpp2IlInjected.Address(RVA = "0x14860C0", Offset = "0x1484AC0", VA = "0x1814860C0")]
		public IEnumerable<MissionSlot> SearchUnquestSlots()
		{
			Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_0023
				Item missionItem = x.MissionItem;
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				QuestInformation questInformation = questInfo_;
				Item missionItem2 = x.MissionItem;
				bool flag2 = default(bool);
				return !flag2;
			};
			return (IEnumerable<MissionSlot>)this.GetAllMissionSlot((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E9")]
		[Cpp2IlInjected.Address(RVA = "0x1483280", Offset = "0x1481C80", VA = "0x181483280", Slot = "35")]
		public bool IsMissionStarted(Item item)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			MissionSlot missionSlot = this.GetMissionSlot(item, (Func<, >)num);
			if (missionSlot == null)
			{
				int num2 = 0;
			}
			return missionSlot.IsMissionStarted;
		}

		[Cpp2IlInjected.Token(Token = "0x60051EA")]
		[Cpp2IlInjected.Address(RVA = "0x14831A0", Offset = "0x1481BA0", VA = "0x1814831A0", Slot = "34")]
		public bool IsMissionCompleted(Item item)
		{
			//Discarded unreachable code: IL_000d
			return questInfo_.IsMissionCompleted(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60051ED")]
		[Cpp2IlInjected.Address(RVA = "0x147DB30", Offset = "0x147C530", VA = "0x18147DB30", Slot = "38")]
		public MissionSlotState GetActiveMissionState(Item item)
		{
			//IL_000a: Expected O, but got I4
			MissionSlot missionSlot;
			do
			{
				int num = 0;
				missionSlot = this.GetMissionSlot(item, (Func<, >)num);
			}
			while (missionSlot == null);
			return missionSlot.state_;
		}

		[Cpp2IlInjected.Token(Token = "0x60051EE")]
		[Cpp2IlInjected.Address(RVA = "0x14832C0", Offset = "0x1481CC0", VA = "0x1814832C0", Slot = "37")]
		public bool IsMissionStepCompleted(Item item, int stepID)
		{
			//Discarded unreachable code: IL_0056
			QuestInformation questInformation = questInfo_;
			bool flag = default(bool);
			MissionSlot missionSlot = default(MissionSlot);
			if (!flag && missionSlot != null)
			{
				RepeatedField<MissionStep> missionSteps_ = missionSlot.missionSteps_;
				Func<MissionStep, bool> func = (Func<MissionStep, bool>)(object)(Func<T, TResult>)delegate(MissionStep x)
				{
					//Discarded unreachable code: IL_0018
					MissionStepData _003CData_003Ek__BackingField = x.Data;
					int num = stepID;
					return _003CData_003Ek__BackingField.stepID_ == num;
				};
				MissionStep missionStep = Enumerable.FirstOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, (Func<, >)(object)func);
				if (missionStep != null)
				{
					MissionStepStatus status = missionStep.Status;
				}
			}
			return 3L >= 3L;
		}

		[Cpp2IlInjected.Token(Token = "0x60051EF")]
		[Cpp2IlInjected.Address(RVA = "0x147FBB0", Offset = "0x147E5B0", VA = "0x18147FBB0", Slot = "39")]
		public MissionStepStatus GetMissionStepStatus(Item item, int stepID)
		{
			QuestInformation questInformation = questInfo_;
			bool flag = default(bool);
			MissionSlot missionSlot = default(MissionSlot);
			if (!flag && missionSlot != null)
			{
				RepeatedField<MissionStep> missionSteps_ = missionSlot.missionSteps_;
				Func<MissionStep, bool> func = (Func<MissionStep, bool>)(object)(Func<T, TResult>)delegate(MissionStep x)
				{
					//Discarded unreachable code: IL_0018
					MissionStepData _003CData_003Ek__BackingField = x.Data;
					int num = stepID;
					return _003CData_003Ek__BackingField.stepID_ == num;
				};
				MissionStep missionStep = Enumerable.FirstOrDefault<MissionStep>((IEnumerable<>)(object)missionSteps_, (Func<, >)(object)func);
				if (missionStep != null)
				{
					return missionStep.Status;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F0")]
		[Cpp2IlInjected.Address(RVA = "0x14831D0", Offset = "0x1481BD0", VA = "0x1814831D0", Slot = "40")]
		public bool IsMissionObjectiveCompleted(Item item, int stepID, int subStepID, int objectiveID)
		{
			//Discarded unreachable code: IL_0024
			if (!questInfo_.IsMissionCompleted(item))
			{
				int num = 0;
				MissionSlot missionSlot = default(MissionSlot);
				MissionObjective missionObjective = default(MissionObjective);
				if (missionSlot != null && missionObjective == null)
				{
				}
			}
			return 3L >= 3L;
		}

		[Cpp2IlInjected.Token(Token = "0x60051F1")]
		[Cpp2IlInjected.Address(RVA = "0x147F600", Offset = "0x147E000", VA = "0x18147F600", Slot = "41")]
		public MissionStepStatus GetMissionObjectiveStatus(Item item, int stepID, int subStepID, int objectiveID)
		{
			MissionSlot missionSlot = default(MissionSlot);
			MissionObjective missionObjective = default(MissionObjective);
			if (!questInfo_.IsMissionCompleted(item) && missionSlot != null && missionObjective != null)
			{
				return missionObjective.status_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F2")]
		[Cpp2IlInjected.Address(RVA = "0x1483160", Offset = "0x1481B60", VA = "0x181483160", Slot = "36")]
		public bool IsMissionAvailable(Item item)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			MissionSlot missionSlot = this.GetMissionSlot(item, (Func<, >)num);
			if (missionSlot == null)
			{
				int num2 = 0;
			}
			return missionSlot.CanStartMission();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F3")]
		[Cpp2IlInjected.Address(RVA = "0x1483110", Offset = "0x1481B10", VA = "0x181483110")]
		public unsafe bool IsKnownFriendshipChoice(string id)
		{
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			int num = 0;
			bool flag = TryGetFriendshipChoiceInfo(id, out *(Item*)num, out *(string*)num);
			if (!flag)
			{
				return flag;
			}
			return IsKnownFriendshipChoice((Item)num, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60051F4")]
		[Cpp2IlInjected.Address(RVA = "0x1483050", Offset = "0x1481A50", VA = "0x181483050")]
		private bool IsKnownFriendshipChoice(Item item, string dialogId)
		{
			//Discarded unreachable code: IL_000f
			MapField<int, ListId> mapField = friendshipChoices_;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60051F5")]
		[Cpp2IlInjected.Address(RVA = "0x147B600", Offset = "0x147A000", VA = "0x18147B600")]
		public unsafe void AddFriendshipChoice(string id)
		{
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			int num = 0;
			if (TryGetFriendshipChoiceInfo(id, out *(Item*)num, out *(string*)num) && !IsKnownFriendshipChoice((Item)num, (string)num))
			{
				if (((MapField<TKey, TValue>)(object)friendshipChoices_).ContainsKey((TKey)num))
				{
					MapField<int, ListId> mapField = friendshipChoices_;
					ListId listId = default(ListId);
					((RepeatedField<T>)(object)listId.ids_).Add((T)id);
					throw new NullReferenceException();
				}
				ListId listId2 = new ListId();
				((RepeatedField<T>)(object)listId2.ids_).Add((T)num);
				((MapField<TKey, TValue>)(object)friendshipChoices_)[(TKey)num] = (TValue)listId2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051F6")]
		[Cpp2IlInjected.Address(RVA = "0x147B4B0", Offset = "0x1479EB0", VA = "0x18147B4B0")]
		private void AddFriendshipChoice(Item item, string dialogId)
		{
			//IL_0017: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			int itemID = item.ItemID;
			bool flag = default(bool);
			if (!flag)
			{
				if (((MapField<TKey, TValue>)(object)friendshipChoices_).ContainsKey((TKey)itemID))
				{
					MapField<int, ListId> mapField = friendshipChoices_;
					ListId listId = default(ListId);
					RepeatedField<string> ids_ = listId.ids_;
					throw new NullReferenceException();
				}
				ListId listId2 = new ListId();
				((RepeatedField<T>)(object)listId2.ids_).Add((T)dialogId);
				((MapField<TKey, TValue>)(object)friendshipChoices_)[(TKey)itemID] = (TValue)listId2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051F7")]
		[Cpp2IlInjected.Address(RVA = "0x14872E0", Offset = "0x1485CE0", VA = "0x1814872E0")]
		private bool TryGetFriendshipChoiceInfo(string id, out Item item, out string dialogId)
		{
			//IL_006b: Expected I4, but got O
			if (id != null)
			{
				char[] array = new char[1];
				array[0] = '.';
				string[] array2 = id.Split(array);
				if (array2 != null && array2.Length == 3)
				{
					string text = array2[0];
					bool flag = default(bool);
					ulong num = default(ulong);
					if (flag && num != 0)
					{
						item.ItemID = (flag ? 1 : 0);
						IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)(object)array2, 1);
						string text2 = string.Join(".", (IEnumerable<>)enumerable);
					}
				}
			}
			Item invalid = Item.Invalid;
			item.ItemID = (int)invalid;
			string empty = string.Empty;
			int num2 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F8")]
		[Cpp2IlInjected.Address(RVA = "0x1482A30", Offset = "0x1481430", VA = "0x181482A30")]
		public bool IsDialogueFlagOn(Item item, out bool wasOverride)
		{
			//IL_0025: Expected O, but got I4
			int itemID = item.ItemID;
			Dictionary<Item, bool> dialogueFlagsOverride = DialogueFlagsOverride;
			bool flag = default(bool);
			if (!flag)
			{
				wasOverride.m_value = flag;
				return ((RepeatedField<T>)(object)dialogueFlags_).Contains((T)itemID);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F9")]
		[Cpp2IlInjected.Address(RVA = "0x1482AF0", Offset = "0x14814F0", VA = "0x181482AF0", Slot = "44")]
		public bool IsDialogueFlagOn(Item item)
		{
			//IL_001e: Expected O, but got I4
			int itemID = item.ItemID;
			Dictionary<Item, bool> dialogueFlagsOverride = DialogueFlagsOverride;
			bool flag = default(bool);
			if (!flag)
			{
				return ((RepeatedField<T>)(object)dialogueFlags_).Contains((T)itemID);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051FB")]
		[Cpp2IlInjected.Address(RVA = "0x1486150", Offset = "0x1484B50", VA = "0x181486150")]
		internal bool SetDialogueFlag(Item item, bool active, IWorldEventDispatcher dispatcher, bool isOverride = false)
		{
			int num = 0;
			bool flag = default(bool);
			DialogueItemType dialogueItemType = default(DialogueItemType);
			if (flag && dialogueItemType == DialogueItemType.Flag)
			{
				bool flag2 = default(bool);
				bool flag3 = active != flag2;
				if (active == flag2)
				{
				}
				Dictionary<Item, bool> dialogueFlagsOverride = DialogueFlagsOverride;
				RepeatedField<int> repeatedField = dialogueFlags_;
				bool flag4 = default(bool);
				if (active && !flag4)
				{
					RepeatedField<int> repeatedField2 = dialogueFlags_;
				}
				if (active)
				{
					RepeatedField<int> repeatedField3 = dialogueFlags_;
					throw new NullReferenceException();
				}
				uint num2 = default(uint);
				if (flag3 && dispatcher != null && num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051FC")]
		[Cpp2IlInjected.Address(RVA = "0x147B9B0", Offset = "0x147A3B0", VA = "0x18147B9B0")]
		internal bool ApplyDialogueFlagOverride(IWorldEventDispatcher dispatcher)
		{
			//IL_002b: Expected I4, but got I8
			//IL_002b: Expected O, but got I4
			int num = 0;
			if (Enumerable.Any<KeyValuePair<Item, bool>>((IEnumerable<>)DialogueFlagsOverride))
			{
				List<KeyValuePair<Item, bool>> list = (List<KeyValuePair<Item, bool>>)(object)Enumerable.ToList<KeyValuePair<Item, bool>>((IEnumerable<>)DialogueFlagsOverride);
				bool flag = default(bool);
				if (flag)
				{
					ulong num2 = default(ulong);
					bool flag2 = SetDialogueFlag((Item)num, (byte)num != 0, dispatcher, (byte)num2 != 0);
				}
				return true;
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051FD")]
		[Cpp2IlInjected.Address(RVA = "0x147B780", Offset = "0x147A180", VA = "0x18147B780")]
		internal uint AddPendingFish(PendingFish pendingFish, IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			uint num = nextPendingFishID_;
			MapField<uint, PendingFish> mapField = pendingFishes_;
			uint num2 = (nextPendingFishID_ = num + 1);
			((MapField<TKey, TValue>)(object)mapField).Add((TKey)num, (TValue)pendingFish);
			if (dispatcher != null)
			{
				int num3 = 0;
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60051FE")]
		[Cpp2IlInjected.Address(RVA = "0x1485B10", Offset = "0x1484510", VA = "0x181485B10")]
		internal void RemovePendingFish(uint pendingFishID, IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0020
			//IL_000c: Expected O, but got I4
			bool flag = ((MapField<TKey, TValue>)(object)pendingFishes_).Remove((TKey)pendingFishID);
			if (dispatcher != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051FF")]
		[Cpp2IlInjected.Address(RVA = "0x1480660", Offset = "0x147F060", VA = "0x181480660", Slot = "21")]
		public bool HasEnoughCharactersToDiscuss(int minAmount)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			int num2 = 0;
			RepeatedField<Character> repeatedField = characters_;
			bool flag = default(bool);
			if (flag)
			{
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005200")]
		[Cpp2IlInjected.Address(RVA = "0x14807F0", Offset = "0x147F1F0", VA = "0x1814807F0", Slot = "22")]
		public bool HasEnoughCrittersToFeed(int minAmount, ITransactionContext context)
		{
			//Discarded unreachable code: IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num3 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Critter critter = default(Critter);
			bool flag3 = default(bool);
			int num2;
			do
			{
				IL_0000:
				int num = 0;
				num2 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (enumerable != null)
				{
					_003C_003Ec__DisplayClass290_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass290_0();
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0074;
						}
						num2++;
					}
					CS_0024_003C_003E8__locals0.critterItemData = (CritterItemData)(object)CS_0024_003C_003E8__locals0;
					int location_ = (int)CS_0024_003C_003E8__locals0.critterItemData.location_;
					while (!flag)
					{
					}
					CritterItemData critterItemData = CS_0024_003C_003E8__locals0.critterItemData;
					while (!flag2)
					{
					}
					Func<Critter, bool> func = (Func<Critter, bool>)(object)(Func<T, TResult>)delegate(Critter x)
					{
						Item critterItem = x.CritterItem;
						int iD = CS_0024_003C_003E8__locals0.critterItemData.ID;
						throw new NullReferenceException();
					};
					if (critter != null && flag3)
					{
						goto IL_0000;
					}
					num2++;
					goto IL_0074;
				}
				goto IL_0083;
				IL_0074:
				critter = (Critter)(object)((object)critter + (object)critter);
				num2 += 312;
				goto IL_0083;
				IL_0083:
				num2++;
				if (enumerable != null)
				{
				}
			}
			while (num2 != 0);
			if (num2 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005201")]
		[Cpp2IlInjected.Address(RVA = "0x1480C60", Offset = "0x147F660", VA = "0x181480C60", Slot = "23")]
		public bool HasEnoughDriedFlowers(int minAmount)
		{
			//Discarded unreachable code: IL_00af, IL_00b5, IL_00c1, IL_00c7, IL_00cd, IL_00d3
			bool flag = default(bool);
			FlowerData flowerData = default(FlowerData);
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				ICollection<Village.Types.VillageArea> values = (ICollection<Village.Types.VillageArea>)((MapField<TKey, TValue>)(object)village_.areas_).get_Values();
				Func<Village.Types.VillageArea, bool> _003C_003E9__291_ = _003C_003Ec._003C_003E9__291_0;
				if (_003C_003E9__291_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Village.Types.VillageArea x) => x.unlocked_);
				}
				IEnumerable<Village.Types.VillageArea> enumerable = (IEnumerable<Village.Types.VillageArea>)Enumerable.Where<Village.Types.VillageArea>((IEnumerable<>)values, (Func<, >)(object)_003C_003E9__291_);
				if (enumerable != null)
				{
					GridCollection gridCollection = gridCollection_;
					while (!flag)
					{
					}
					if (flag)
					{
						if (0 == 0)
						{
							continue;
						}
						if (flowerData != null)
						{
							bool dry_ = flowerData.dry_;
						}
						while (num == 1)
						{
						}
						num++;
					}
					num++;
					if (flag)
					{
						num2 = 0;
					}
					if (num != 0)
					{
						break;
					}
					while (num == 0)
					{
					}
					if (num2 == 239)
					{
					}
					while (num2 != 214)
					{
					}
				}
				num3++;
				if (enumerable != null)
				{
				}
				if (num == 0)
				{
					if (num3 != 0)
					{
					}
					int num4 = 0;
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005202")]
		[Cpp2IlInjected.Address(RVA = "0x1481140", Offset = "0x147FB40", VA = "0x181481140", Slot = "24")]
		public bool HasEnoughNightThorns(int minAmount)
		{
			//Discarded unreachable code: IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<EphemeralItemData, bool> _003C_003E9__292_ = _003C_003Ec._003C_003E9__292_0;
			if (_003C_003E9__292_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EphemeralItemData x) => x.ephemeralType_ == EphemeralType.NightThorn);
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<EphemeralItemData> enumerable2 = (IEnumerable<EphemeralItemData>)Enumerable.Where<EphemeralItemData>(enumerable, (Func<, >)(object)_003C_003E9__292_);
			Func<EphemeralItemData, Item> func = default(Func<EphemeralItemData, Item>);
			if (_003C_003Ec._003C_003E9__292_1 == null)
			{
				func = (Func<EphemeralItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(EphemeralItemData x)
				{
					int iD = x.ID;
					throw new NullReferenceException();
				});
			}
			HashSet<>.Slot[] slots = (HashSet<>.Slot[])(object)((HashSet<>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<EphemeralItemData, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func)))._slots;
			Func<Village.Types.VillageArea, bool> func2 = default(Func<Village.Types.VillageArea, bool>);
			if (_003C_003Ec._003C_003E9__292_2 == null)
			{
				func2 = (Func<Village.Types.VillageArea, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Village.Types.VillageArea x) => x.unlocked_));
			}
			ICollection<> collection = default(ICollection<>);
			IEnumerable<Village.Types.VillageArea> enumerable3 = (IEnumerable<Village.Types.VillageArea>)Enumerable.Where<Village.Types.VillageArea>((IEnumerable<>)collection, (Func<, >)(object)func2);
			if (enumerable3 != null)
			{
				int num2 = 0;
				bool flag = default(bool);
				while (!flag)
				{
				}
				if (flag)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					num++;
				}
				num++;
				int num3 = default(int);
				if (flag)
				{
					num3 = 0;
				}
				while (num == 0)
				{
				}
				if (num3 == 275)
				{
				}
				while (num3 != 253)
				{
				}
			}
			int num4 = num4 + 1;
			if (enumerable3 != null)
			{
			}
			if (num4 != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005203")]
		[Cpp2IlInjected.Address(RVA = "0x1481890", Offset = "0x1480290", VA = "0x181481890", Slot = "25")]
		public bool HasEnoughRestaurantOrders(int minAmount, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002e, IL_0034, IL_003a
			int num2;
			bool flag = default(bool);
			DateTime dateTime = default(DateTime);
			while (true)
			{
				int num = 0;
				num2 = 0;
				RepeatedField<CharacterRestaurantOrder> repeatedField = characterRestaurantOrders_;
				if (!flag)
				{
					break;
				}
				if (dateTime < dateTime)
				{
					num2++;
					break;
				}
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005204")]
		[Cpp2IlInjected.Address(RVA = "0x147DF90", Offset = "0x147C990", VA = "0x18147DF90", Slot = "14")]
		public DateTime GetClientLocalTime(DateTime serverTime)
		{
			Duration duration = timeZoneOffset_;
			if (duration != null)
			{
				TimeSpan timeSpan = duration.ToTimeSpan();
			}
			TimeSpan zero = TimeSpan.Zero;
			return serverTime + zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6005205")]
		[Cpp2IlInjected.Address(RVA = "0x1480370", Offset = "0x147ED70", VA = "0x181480370")]
		public DateTime GetServerTime(DateTime localTime)
		{
			Duration duration = timeZoneOffset_;
			if (duration != null)
			{
				TimeSpan timeSpan = duration.ToTimeSpan();
			}
			TimeSpan zero = TimeSpan.Zero;
			return localTime - zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6005206")]
		[Cpp2IlInjected.Address(RVA = "0x147D910", Offset = "0x147C310", VA = "0x18147D910")]
		internal void FixDisappearingBuildings(ListInventory buildingInventory)
		{
			//Discarded unreachable code: IL_002f, IL_0035, IL_003b, IL_0041
			int num = 0;
			RepeatedField<Character> repeatedField = characters_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				CharacterItemData characterItemData = default(CharacterItemData);
				int house = characterItemData.House;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				BuildingItemType buildingItemType = default(BuildingItemType);
				while (buildingItemType == BuildingItemType.OffGridBuilding)
				{
				}
				CharacterItemData characterItemData2 = default(CharacterItemData);
				int house2 = characterItemData2.House;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005207")]
		[Cpp2IlInjected.Address(RVA = "0x1488520", Offset = "0x1486F20", VA = "0x181488520")]
		static ProfileWorld()
		{
			MessageParser<Character> parser = Character._parser;
			uint num = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<Character>(num, (MessageParser<>)(object)parser);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<Realm> parser2 = Realm._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Realm>(num2, (MessageParser<>)(object)parser2);
			uint num3 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num3);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<PendingFish> parser3 = PendingFish._parser;
			uint num4 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<PendingFish>(num4, (MessageParser<>)(object)parser3);
			uint num5 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num5);
			MessageParser<Shop> parser4 = Shop._parser;
			uint num6 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<Shop>(num6, (MessageParser<>)(object)parser4);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForInt32(74u);
			FieldCodec<int> fieldCodec5 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<BuildingInfo> parser5 = BuildingInfo._parser;
			uint num7 = default(uint);
			FieldCodec<> fieldCodec6 = FieldCodec.ForMessage<BuildingInfo>(num7, (MessageParser<>)(object)parser5);
			uint num8 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, fieldCodec6, num8);
			FieldCodec<int> fieldCodec7 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<OffGridBuilding> parser6 = OffGridBuilding._parser;
			uint num9 = default(uint);
			FieldCodec<> fieldCodec8 = FieldCodec.ForMessage<OffGridBuilding>(num9, (MessageParser<>)(object)parser6);
			uint num10 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec7, fieldCodec8, num10);
			MessageParser<CharacterRestaurantOrder> parser7 = CharacterRestaurantOrder._parser;
			uint num11 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<CharacterRestaurantOrder>(num11, (MessageParser<>)(object)parser7);
			MessageParser<Critter> parser8 = Critter._parser;
			uint num12 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<Critter>(num12, (MessageParser<>)(object)parser8);
			MessageParser<StoreInfo> parser9 = StoreInfo._parser;
			uint num13 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<StoreInfo>(num13, (MessageParser<>)(object)parser9);
			FieldCodec<string> fieldCodec9 = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<Keyhole> parser10 = Keyhole._parser;
			uint num14 = default(uint);
			FieldCodec<> fieldCodec10 = FieldCodec.ForMessage<Keyhole>(num14, (MessageParser<>)(object)parser10);
			uint num15 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec9, fieldCodec10, num15);
			FieldCodec<int> fieldCodec11 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<MissionQueue> parser11 = MissionQueue._parser;
			uint num16 = default(uint);
			FieldCodec<> fieldCodec12 = FieldCodec.ForMessage<MissionQueue>(num16, (MessageParser<>)(object)parser11);
			uint num17 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec11, fieldCodec12, num17);
			MessageParser<DiscussionRecord> parser12 = DiscussionRecord._parser;
			uint num18 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<DiscussionRecord>(num18, (MessageParser<>)(object)parser12);
			FieldCodec<int> fieldCodec13 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<ListId> parser13 = ListId._parser;
			uint num19 = default(uint);
			FieldCodec<> fieldCodec14 = FieldCodec.ForMessage<ListId>(num19, (MessageParser<>)(object)parser13);
			uint num20 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec13, fieldCodec14, num20);
			uint num21 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForInt32(num21);
			FieldCodec<uint> fieldCodec15 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<RecurringEvent> parser14 = RecurringEvent._parser;
			uint num22 = default(uint);
			FieldCodec<> fieldCodec16 = FieldCodec.ForMessage<RecurringEvent>(num22, (MessageParser<>)(object)parser14);
			uint num23 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec15, fieldCodec16, num23);
			MessageParser<FishingPerVillageArea> parser15 = FishingPerVillageArea._parser;
			uint num24 = default(uint);
			_parser = (MessageParser<ProfileWorld>)(object)FieldCodec.ForMessage<FishingPerVillageArea>(num24, (MessageParser<>)(object)parser15);
			Array values = System.Enum.GetValues(typeof(MissionSlotClass));
			if (values == null)
			{
			}
			if (values != null)
			{
				_parser = (MessageParser<ProfileWorld>)(object)values;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005208")]
		[Cpp2IlInjected.Address(RVA = "0x147D000", Offset = "0x147BA00", VA = "0x18147D000", Slot = "20")]
		ScheduleType IProfileWorld.OverrideCharacterSchedule(CharacterItemData characterItemData, ScheduleType? scheduleType, DateTime localTime, bool canOverride, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			ScheduleType result = default(ScheduleType);
			return result;
		}
	}
}
