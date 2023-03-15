using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B2A")]
	public class SpawnHelper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002B5E")]
		private readonly Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B5F")]
		private readonly ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B60")]
		private readonly ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B61")]
		private readonly ISpawnHelper spawnData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B62")]
		private readonly ItemFilter itemFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B63")]
		private readonly string debugName;

		[Cpp2IlInjected.Token(Token = "0x17001047")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4002B64")]
		public float TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6005E51")]
			[Cpp2IlInjected.Address(RVA = "0x823CC0", Offset = "0x8226C0", VA = "0x180823CC0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005E52")]
			[Cpp2IlInjected.Address(RVA = "0x824250", Offset = "0x822C50", VA = "0x180824250")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E53")]
		[Cpp2IlInjected.Address(RVA = "0xC02130", Offset = "0xC00B30", VA = "0x180C02130")]
		public SpawnHelper(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context, ISpawnHelper spawnData, ItemFilter itemFilter, string debugName = "")
		{
			//IL_0022: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			this.profile = profile;
			this.dispatcher = dispatcher;
			this.context = context;
			this.spawnData = (ISpawnHelper)0;
			this.itemFilter = (ItemFilter)0;
			this.debugName = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E54")]
		[Cpp2IlInjected.Address(RVA = "0xC01D30", Offset = "0xC00730", VA = "0x180C01D30")]
		private string LogFormat(string msg)
		{
			string text = debugName;
			if ("\nFrom: " == null)
			{
				string text2 = debugName;
				string text3 = msg + "\nFrom: " + text2;
			}
			return msg + "\n\n\n";
		}

		[Cpp2IlInjected.Token(Token = "0x6005E55")]
		[Cpp2IlInjected.Address(RVA = "0xC01DB0", Offset = "0xC007B0", VA = "0x180C01DB0")]
		private void LogSpawnError(string error)
		{
			//Discarded unreachable code: IL_0018
			ITransactionContext transactionContext = context;
			if ((object)typeof(MetaLogger).TypeHandle != null)
			{
				string text = LogFormat(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E56")]
		[Cpp2IlInjected.Address(RVA = "0xC01EE0", Offset = "0xC008E0", VA = "0x180C01EE0")]
		private void LogSpawnInfo(string info)
		{
			//Discarded unreachable code: IL_0018
			ITransactionContext transactionContext = context;
			if ((object)typeof(MetaLogger).TypeHandle != null)
			{
				string text = LogFormat(info);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E57")]
		[Cpp2IlInjected.Address(RVA = "0xBFCE70", Offset = "0xBFB870", VA = "0x180BFCE70")]
		private HashSet<(IGrid, string)> GetAvailableGrids()
		{
			ISpawnHelper spawnHelper = spawnData;
			return (HashSet<(IGrid, string)>)(object)SpawnHelper.GetAvailableGrids(profile, spawnHelper);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E58")]
		[Cpp2IlInjected.Address(RVA = "0xBFCE80", Offset = "0xBFB880", VA = "0x180BFCE80")]
		private static HashSet<(IGrid, string)> GetAvailableGrids(Profile profile, ISpawnHelper spawnData)
		{
			//Discarded unreachable code: IL_0051
			//IL_0037: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			HashSet<(IGrid grid, string customLocationPath)> availableGridsSet;
			HashSet<(IGrid, string)> hashSet = (availableGridsSet = (HashSet<(IGrid grid, string customLocationPath)>)(object)new HashSet<T>());
			if (spawnData != null)
			{
				if (hashSet != null)
				{
					bool flag = default(bool);
					if (flag)
					{
						AddGridsFromLocationSource((LocationSource)num2);
					}
					if (num3 + 1 == 0)
					{
					}
				}
				if (hashSet == null)
				{
				}
			}
			AddVillageGrids();
			return availableGridsSet;
			[Cpp2IlInjected.Token(Token = "0x6005E67")]
			[Cpp2IlInjected.Address(RVA = "0x5A4700", Offset = "0x5A3100", VA = "0x1805A4700")]
			unsafe void AddGridsFromLocationSource(LocationSource locationSource)
			{
				//Discarded unreachable code: IL_0233, IL_0239, IL_023f, IL_0245, IL_024b, IL_0251, IL_0257, IL_025d, IL_0263, IL_0269, IL_026f, IL_0275, IL_027b, IL_0281, IL_0287, IL_028d, IL_0293, IL_0299, IL_029f, IL_02a5, IL_02ab, IL_02b1, IL_02b7, IL_02bd, IL_02c3, IL_02c9, IL_02cf
				//IL_0096: Expected O, but got I4
				//IL_011f: Expected O, but got I4
				bool flag5 = default(bool);
				uint num9 = default(uint);
				bool flag7 = default(bool);
				int num12 = default(int);
				ICollection<> collection = default(ICollection<>);
				ICollection<> collection2 = default(ICollection<>);
				uint num16 = default(uint);
				bool flag9 = default(bool);
				bool flag10 = default(bool);
				int num18 = default(int);
				uint num20 = default(uint);
				IEnumerable<uint> enumerable = default(IEnumerable<uint>);
				bool flag11 = default(bool);
				int num13 = default(int);
				int num15 = default(int);
				while (true)
				{
					int num6 = 0;
					int num7 = 0;
					int gridID = 0;
					LocationSource.LocationOneofCase locationCase_ = locationSource.locationCase_;
					if (locationCase_ == LocationSource.LocationOneofCase.AvatarFront || locationCase_ == LocationSource.LocationOneofCase.NearAvatar)
					{
						break;
					}
					if (locationCase_ == LocationSource.LocationOneofCase.AnywhereInScene)
					{
						Item sceneItem = locationSource.AnywhereInScene.SceneItem;
						break;
					}
					ICollection<Realm> values;
					if (locationCase_ != LocationSource.LocationOneofCase.NearUniqueItem)
					{
						if (locationCase_ == LocationSource.LocationOneofCase.Realm)
						{
							MapField<string, Realm> realms_ = profile.world_.realms_;
							string realm_ = locationSource.Realm.realm_;
							if (!((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)realm_, out *(TValue*)num6))
							{
								return;
							}
							if (flag5)
							{
								if (!profile.world_.gridCollection_.TryGetGrid((uint)gridID, out *(IGrid*)num6))
								{
									continue;
								}
								HashSet<(IGrid, string)> hashSet3 = availableGridsSet;
								int num8 = 0;
								bool flag6 = ((HashSet<T>)(object)hashSet3).Add((T)num8);
							}
							num6++;
							if (num6 == 0)
							{
							}
						}
						if (locationSource.locationCase_ == LocationSource.LocationOneofCase.Custom)
						{
							AddVillageGrids();
							values = (ICollection<Realm>)((MapField<TKey, TValue>)(object)profile.world_.realms_).get_Values();
							if (values != null)
							{
								if (num6 < (int)num9)
								{
									num6 += num6;
									if (num6 == (int)num9)
									{
										goto IL_0121;
									}
									num6++;
								}
								int num10 = 0;
								while (values != null)
								{
								}
								if (flag7)
								{
									if (!profile.world_.gridCollection_.TryGetGrid((uint)gridID, out *(IGrid*)num6))
									{
										continue;
									}
									HashSet<(IGrid, string)> hashSet4 = availableGridsSet;
									int num11 = 0;
									bool flag8 = ((HashSet<T>)(object)hashSet4).Add((T)num11);
								}
								goto IL_0121;
							}
							goto IL_0129;
						}
					}
					goto IL_0205;
					IL_01f5:
					num12++;
					if (collection != null)
					{
					}
					if (num12 == 0)
					{
					}
					goto IL_0205;
					IL_0193:
					num13++;
					int num14 = 0;
					if (collection2 != null)
					{
					}
					if (num13 != 0)
					{
						num15 = num13 - 1;
					}
					if (collection != null)
					{
						if (num14 < (int)num16)
						{
							num14 += num14;
							if (num14 == (int)num16)
							{
								goto IL_01dc;
							}
							num14++;
						}
						if (flag9)
						{
							while (flag9)
							{
							}
							while (!flag10)
							{
							}
							int num17 = 0;
						}
						goto IL_01dc;
					}
					goto IL_01f5;
					IL_0129:
					num18++;
					int num19 = 0;
					if (values != null)
					{
					}
					if (num18 != 0)
					{
						num15 = num18 - 1;
					}
					if (collection2 != null)
					{
						if (num19 < (int)num20)
						{
							num19 += num19;
							if (num19 == (int)num20)
							{
								goto IL_0175;
							}
							num19++;
						}
						if (enumerable != null)
						{
							int num21 = 0;
							while (enumerable != null)
							{
							}
							while (!flag11)
							{
							}
							int num22 = 0;
						}
						goto IL_0175;
					}
					goto IL_0193;
					IL_0121:
					num6++;
					while (num6 == 0)
					{
					}
					goto IL_0129;
					IL_0205:
					Item sceneItem2 = locationSource.NearUniqueItem.SceneItem;
					return;
					IL_01dc:
					num13++;
					while (num13 == 0)
					{
					}
					num12 = num13 - 1;
					num13 = num12;
					num13 = num12;
					goto IL_01f5;
					IL_0175:
					num15++;
					if (enumerable != null)
					{
					}
					while (num15 == 0)
					{
					}
					num13 = num15 - 1;
					num15 = num13;
					num15 = num13;
					goto IL_0193;
				}
				ProfilePlayer player_ = profile.player_;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005E64")]
			[Cpp2IlInjected.Address(RVA = "0x5A55A0", Offset = "0x5A3FA0", VA = "0x1805A55A0")]
			void AddVillageGrids()
			{
				//Discarded unreachable code: IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
				//IL_005e: Expected O, but got I4
				int num4 = 0;
				MapField<int, Village.Types.VillageArea> areas_ = profile.Village.areas_;
				bool flag2 = default(bool);
				if (flag2)
				{
					while ((long)"{il2cpp array field local9->}" == 0)
					{
					}
					GridCollection gridCollection_ = profile.world_.gridCollection_;
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					HashSet<(IGrid, string)> hashSet2 = availableGridsSet;
					string customLocationPositionsPath_ = profile.Village.customLocationPositionsPath_;
					int num5 = 0;
					bool flag4 = ((HashSet<T>)(object)hashSet2).Add((T)num5);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E59")]
		[Cpp2IlInjected.Address(RVA = "0xBFB460", Offset = "0xBF9E60", VA = "0x180BFB460")]
		public List<PlaceOnGrid.Types.Response> AddMissingItemsToGrid(Random rand, bool forceSpawn, int amountToSpawn, int radius, [Optional] GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_00ca
			//IL_006b: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0097: Expected O, but got F4
			if (amountToSpawn > 0)
			{
				ISpawnHelper spawnHelper = spawnData;
				List<(IGrid, string)> list = (List<(IGrid, string)>)(object)Enumerable.ToList<(IGrid, string)>((IEnumerable<>)SpawnHelper.GetAvailableGrids(profile, spawnHelper));
				int num = 0;
				DateTime now = DateTime.Now;
				ISpawnHelper spawnHelper2 = spawnData;
				int num2 = 0;
				if (spawnHelper2 != null)
				{
				}
				if (num2 != 0)
				{
				}
				if (list != null)
				{
					ISpawnHelper spawnHelper3 = spawnData;
				}
				List<PlaceOnGrid.Types.Response> list2 = default(List<PlaceOnGrid.Types.Response>);
				int size = ((List<>)(object)list2)._size;
				if (context != null)
				{
				}
				string info = $"Spawn: {size}/{size} (server: {num2}).";
				LogSpawnInfo(info);
				int size2 = ((List<>)(object)list2)._size;
				if (amountToSpawn < size2)
				{
					float num3 = TargetAmount;
					float num4 = default(float);
					string info2 = $"TargetAmount = {num4} (TO FIX SPAWN ISSUE)";
					LogSpawnInfo(info2);
				}
				int num5 = 0;
				TimeSpan arg = DateTime.Now - now;
				string error = $"SpawnHelper: Too slow {arg:F2} sec";
				LogSpawnError(error);
				return list2;
			}
			string error2 = string.Format("SpawnHelper: AmountToSpawn={0}, DataValidation have failed?? code error?? ", "SpawnHelper: Too slow {0:F2} sec");
			LogSpawnError(error2);
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5A")]
		[Cpp2IlInjected.Address(RVA = "0xBFC920", Offset = "0xBFB320", VA = "0x180BFC920")]
		private List<PlaceOnGrid.Types.Response> AddMissingItemsToGrid(Random rand, List<(IGrid grid, string customLocationPath)> availableGrids, List<LocationSource> locSourceList, bool forceSpawn, int amountToSpawn, int radius, GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_00f5
			//IL_0036: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			Func<LocationSource, int> func2 = default(Func<LocationSource, int>);
			Func<LocationSource, int> func3 = default(Func<LocationSource, int>);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				bool forceSpawn2 = false;
				int radius2 = 0;
				GridAddObjectOptions addObjectOptions2 = (GridAddObjectOptions)0;
				List<PlaceOnGrid.Types.Response> spawnedItems = (List<PlaceOnGrid.Types.Response>)(object)new List<T>();
				if (locSourceList != null)
				{
					Func<LocationSource, bool> func = (Func<LocationSource, bool>)(object)(Func<T, TResult>)delegate(LocationSource x)
					{
						//Discarded unreachable code: IL_0017
						SpawnHelper spawnHelper2 = this;
						List<(IGrid, string)> list6 = availableGrids;
						return spawnHelper2.IsValidSource(x, (List<>)(object)list6);
					};
					List<LocationSource> list = (List<LocationSource>)(object)Enumerable.ToList<LocationSource>(Enumerable.Where<LocationSource>((IEnumerable<>)locSourceList, (Func<, >)(object)func));
				}
				if (num3 != 0)
				{
					int num4 = 0;
					int num5 = 0;
					availableGrids = (List<(IGrid grid, string customLocationPath)>)(object)Enumerable.ToList<(IGrid, string)>((IEnumerable<>)SpawnHelper.GetAvailableGrids((Profile)num3, (ISpawnHelper)num5));
					int size = ((List<>)(object)locSourceList)._size;
					string text = $"Spawn failure validation: All sources ({size}) are invalid, Fallback to spawn InVillage (look previous errors for details)";
				}
				if (locSourceList == null)
				{
					break;
				}
				if (func2 == null)
				{
					func3 = (func2 = (Func<LocationSource, int>)(object)(Func<T, TResult>)delegate
					{
						Random random2 = rand;
						throw new NullReferenceException();
					});
				}
				List<LocationSource> list2 = (List<LocationSource>)(object)Enumerable.ToList<LocationSource>((IEnumerable<>)Enumerable.OrderBy<LocationSource, int>((IEnumerable<>)num3, (Func<, >)(object)func3));
				if (flag)
				{
					Spawn((LocationSource)num2, 1);
					num3++;
				}
				num3++;
				if (num3 == 0)
				{
					if (num3 == 0)
					{
					}
					break;
				}
				continue;
				SpawnHelper spawnHelper;
				List<PlaceOnGrid.Types.Response> list3;
				int num6;
				GridAddObjectOptions gridAddObjectOptions;
				bool flag2;
				List<(IGrid, string)> list4;
				Random random;
				List<PlaceOnGrid.Types.Response> list5;
				ulong num7 = default(ulong);
				[Cpp2IlInjected.Token(Token = "0x6005E69")]
				[Cpp2IlInjected.Address(RVA = "0x5A5840", Offset = "0x5A4240", VA = "0x1805A5840")]
				void Spawn(LocationSource _source, int _amount)
				{
					//Discarded unreachable code: IL_0051
					//IL_0046: Expected I4, but got I8
					spawnHelper = this;
					list3 = spawnedItems;
					num6 = radius2;
					gridAddObjectOptions = addObjectOptions2;
					flag2 = forceSpawn2;
					list4 = availableGrids;
					random = rand;
					list5 = (List<PlaceOnGrid.Types.Response>)(object)spawnHelper.AddMissingItemsToGrid(random, (List<>)(object)list4, _source, flag2, _amount, num6, (byte)num7 != 0, gridAddObjectOptions);
					((List<T>)(object)list3).AddRange((IEnumerable<>)list5);
				}
				[Cpp2IlInjected.Token(Token = "0x6005E69")]
				[Cpp2IlInjected.Address(RVA = "0x5A5840", Offset = "0x5A4240", VA = "0x1805A5840")]
				void Spawn(LocationSource _source, int _amount)
				{
					//Discarded unreachable code: IL_0051
					//IL_0046: Expected I4, but got I8
					spawnHelper = this;
					list3 = spawnedItems;
					num6 = radius2;
					gridAddObjectOptions = addObjectOptions2;
					flag2 = forceSpawn2;
					list4 = availableGrids;
					random = rand;
					list5 = (List<PlaceOnGrid.Types.Response>)(object)spawnHelper.AddMissingItemsToGrid(random, (List<>)(object)list4, _source, flag2, _amount, num6, (byte)num7 != 0, gridAddObjectOptions);
					((List<T>)(object)list3).AddRange((IEnumerable<>)list5);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5B")]
		[Cpp2IlInjected.Address(RVA = "0xBFB910", Offset = "0xBFA310", VA = "0x180BFB910")]
		private List<PlaceOnGrid.Types.Response> AddMissingItemsToGrid(Random rand, List<(IGrid grid, string customLocationPath)> availableGrids, LocationSource locSource, bool forceSpawn, int amountToSpawn, int radius, bool useMultipleSources, GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_00da, IL_00df, IL_00fd, IL_0102, IL_011a, IL_011d, IL_0122, IL_0128, IL_0137, IL_013c, IL_0149, IL_0156, IL_016f, IL_0187, IL_019a, IL_01a3, IL_01a8, IL_0229, IL_022e, IL_0237, IL_023c, IL_0246, IL_024d, IL_0253, IL_0259, IL_025f, IL_026d, IL_0272, IL_0277, IL_027d, IL_0283, IL_0289, IL_028f, IL_0296, IL_02a7, IL_02ad, IL_02b3, IL_02b9, IL_02bf, IL_02c5
			//IL_0165: Expected O, but got I4
			//IL_01bf: Expected I4, but got O
			//IL_01d1: Expected I4, but got O
			//IL_01da: Expected I4, but got O
			//IL_01e3: Expected I4, but got O
			//IL_01ed: Expected I4, but got I8
			//IL_0217: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			List<PlaceOnGrid.Types.Response> result = (List<PlaceOnGrid.Types.Response>)(object)new List<T>();
			int item_ = itemFilter.data_.item_;
			int num3 = 0;
			Func<(IGrid, string), IEnumerable<GridObject>> func = default(Func<(IGrid, string), IEnumerable<GridObject>>);
			if (_003C_003Ec._003C_003E9__18_1 == null)
			{
				func = (Func<(IGrid, string), IEnumerable<GridObject>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			IEnumerable<(IGrid, string)> enumerable = (IEnumerable<(IGrid, string)>)Enumerable.SelectMany<(IGrid, string), GridObject>((IEnumerable<>)availableGrids, (Func<, >)(object)func);
			Func<GridObject, bool> func2 = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				//Discarded unreachable code: IL_0032
				int itemID2 = x.ItemID;
				ItemType itemType = default(ItemType);
				if (itemType != ItemType.ActivityItem)
				{
					int num5 = 0;
				}
				int itemID3 = x.ItemID;
				ItemFilterData data_2 = itemFilter.data_;
				ActivityItemType activityItemType = default(ActivityItemType);
				return activityItemType == data_2.activityItemType_;
			};
			IEnumerable<GridObject> enumerable2 = (IEnumerable<GridObject>)Enumerable.Where<GridObject>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			Func<GridObject, Item> func3 = default(Func<GridObject, Item>);
			if (_003C_003Ec._003C_003E9__18_3 == null)
			{
				func3 = (Func<GridObject, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject y)
				{
					int itemID = y.ItemID;
					throw new NullReferenceException();
				});
			}
			IEnumerable<GridObject> enumerable3 = (IEnumerable<GridObject>)Enumerable.Select<GridObject, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func3);
			bool flag = default(bool);
			if (flag)
			{
				Func<Item, bool> func4 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate(Item x)
				{
					//Discarded unreachable code: IL_001b
					ItemFilterData data_ = itemFilter.data_;
					return (IntPtr)x == (IntPtr)data_.item_;
				};
				IEnumerable<Item> enumerable4 = (IEnumerable<Item>)Enumerable.Where<Item>((IEnumerable<>)enumerable3, (Func<, >)(object)func4);
			}
			List<Item> list = (List<Item>)(object)itemFilter.ApplyFilter((IEnumerable<>)enumerable3);
			IEnumerable<Item> enumerable5 = default(IEnumerable<Item>);
			int num4 = Enumerable.Count<Item>((IEnumerable<>)enumerable5);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5C")]
		[Cpp2IlInjected.Address(RVA = "0xC009A0", Offset = "0xBFF3A0", VA = "0x180C009A0")]
		private bool IsGridAreaValid(IGrid grid, in GridPosition gridPosition, in GridArea area, Item itemToSpawn, bool useClearing = false)
		{
			//Discarded unreachable code: IL_0004, IL_000b, IL_0013
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5D")]
		[Cpp2IlInjected.Address(RVA = "0xC00AC0", Offset = "0xBFF4C0", VA = "0x180C00AC0")]
		private bool IsValidSource(LocationSource locSource, List<(IGrid grid, string customLocationPath)> grids)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5E")]
		[Cpp2IlInjected.Address(RVA = "0xBFD0F0", Offset = "0xBFBAF0", VA = "0x180BFD0F0")]
		private (bool, bool, IGrid, GridPosition) GetPosFromLocSource(LocationSource locSource, Random gridPosRandom, List<(IGrid grid, string customLocationPath)> grids, int radius, Item itemToSpawn, GridArea area, bool useClearing)
		{
			//IL_0027: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_01f1: Expected O, but got I4
			//IL_0245: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			uint num5 = default(uint);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			List<GridPosition> list = default(List<GridPosition>);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			Func<IGrid, uint> func = default(Func<IGrid, uint>);
			List<IGrid> list3 = default(List<IGrid>);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				LocationSource locSource2 = (LocationSource)(object)gridPosRandom;
				SpawnHelper spawnHelper = (SpawnHelper)(object)locSource;
				Item itemToSpawn2 = (Item)0;
				bool useClearing2 = false;
				Random gridPosRandom2 = (Random)(object)grids;
				GridArea area2 = (GridArea)num2;
				Dictionary<IGrid, List<GridPosition>> dictionary = (Dictionary<IGrid, List<GridPosition>>)(object)new Dictionary<TKey, TValue>();
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemToSpawn2;
				IGridPlaceableItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<IGridPlaceableItemData>(item);
				LocationSource locationSource = locSource2;
				if (locationSource != null)
				{
					LocationSource.LocationOneofCase locationCase_ = locationSource.locationCase_;
				}
				if (num == 0 || num > 18)
				{
					continue;
				}
				if (flag)
				{
					while (!flag2)
					{
					}
					while (!flag3)
					{
					}
					list = (List<GridPosition>)(object)new List<T>();
					if ((int)num5 > 0)
					{
						Random random = gridPosRandom2;
						Random random2 = gridPosRandom2;
						LocationAnywhereFloorType anywhereFloorType = locSource2.AnywhereFloorType;
						GridFloorType type_ = anywhereFloorType.type_;
						while (anywhereFloorType == null)
						{
						}
						while (!flag4)
						{
						}
						((List<T>)(object)list).Add((T)num);
					}
					LocationAnywhereFloorType anywhereFloorType2 = locSource2.AnywhereFloorType;
					GridFloorType type_2 = anywhereFloorType2.type_;
					if (anywhereFloorType2 != null && flag5)
					{
						((List<T>)(object)list).Add((T)num);
						num++;
					}
					num++;
					num++;
					throw new NullReferenceException();
				}
				int num6 = 0;
				if (list != null || ((Dictionary<TKey, TValue>)(object)dictionary).Count != 0)
				{
					continue;
				}
				LocationSource.LocationOneofCase locationCase_2 = locSource2.locationCase_;
				LocationAnywhereFloorType anywhereFloorType3 = locSource2.AnywhereFloorType;
				GridFloorType type_3 = anywhereFloorType3.type_;
				Item item2 = itemToSpawn2;
				string text = $"Spawn failure: No grid found for {locationCase_2} {anywhereFloorType3}\nCheck if any Biome of that FloorType is unlocked\nFallback to spawn InVillage\nSpawnItem: {anywhereFloorType3}";
				if (flag6)
				{
					LocationAnywhereVillageArea anywhereVillageArea = locSource2.AnywhereVillageArea;
					while (!flag7)
					{
					}
					while (!flag8)
					{
					}
					List<GridPosition> list2 = (List<GridPosition>)(object)new List<T>();
					throw new NullReferenceException();
				}
				int num7 = 0;
				if (list != null || ((Dictionary<TKey, TValue>)(object)dictionary).Count != 0)
				{
					continue;
				}
				LocationSource.LocationOneofCase locationCase_3 = locSource2.locationCase_;
				LocationAnywhereVillageArea anywhereVillageArea2 = locSource2.AnywhereVillageArea;
				VillageAreaType location_ = anywhereVillageArea2.location_;
				Item item3 = itemToSpawn2;
				string text2 = $"Spawn failure: No grid found for {locationCase_3} {anywhereVillageArea2}\nCheck if that biome is unlocked\nFallback to spawn InVillage\nSpawnItem: {anywhereVillageArea2}";
				int scene_ = locSource2.AnywhereInScene.scene_;
				if (_003C_003Ec._003C_003E9__21_3 == null)
				{
					func = (Func<IGrid, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					});
				}
				List<uint> list4 = (List<uint>)(object)Enumerable.ToList<uint>(Enumerable.Select<IGrid, uint>((IEnumerable<>)list3, (Func<, >)(object)func));
				if (flag9)
				{
					if (((List<T>)(object)list4).Contains((T)flag9))
					{
						while (!flag10)
						{
						}
						List<GridPosition> list5 = (List<GridPosition>)(object)new List<T>();
						throw new NullReferenceException();
					}
				}
				else if (list == null && ((Dictionary<TKey, TValue>)(object)dictionary).Count == 0)
				{
					LocationSource.LocationOneofCase locationCase_4 = locSource2.locationCase_;
					Item item4 = itemToSpawn2;
					int building_ = locSource2.Building.building_;
					if (flag11)
					{
						break;
					}
				}
			}
			bool flag12 = default(bool);
			while (true)
			{
				if (flag12)
				{
					/*Error: Could not find block for branch target IL_02a9*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E5F")]
		[Cpp2IlInjected.Address(RVA = "0xC00830", Offset = "0xBFF230", VA = "0x180C00830")]
		private List<GridPosition> GetPositionsInRadius(IGrid grid, GridPosition gridPos, int radius, List<GridPosition> exclutions)
		{
			//Discarded unreachable code: IL_0030
			List<GridPosition> result = (List<GridPosition>)(object)new List<T>();
			if (radius > 0)
			{
				int x = gridPos.X;
				x -= radius;
				int x2 = gridPos.X;
				x2 -= radius;
				int num = 0;
				if (x2 < radius)
				{
					x2++;
				}
				x++;
				return result;
			}
			return result;
		}
	}
}
