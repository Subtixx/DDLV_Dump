using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200072F")]
	public sealed class DisplaySettingsData : IMessage<DisplaySettingsData>, IMessage, IEquatable<DisplaySettingsData>, IDeepCloneable<DisplaySettingsData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000730")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000731")]
			public sealed class ItemSupportData : IMessage<ItemSupportData>, IMessage, IEquatable<ItemSupportData>, IDeepCloneable<ItemSupportData>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000732")]
				public enum TypeOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4002414")]
					None,
					[Cpp2IlInjected.Token(Token = "0x4002415")]
					ClothingType,
					[Cpp2IlInjected.Token(Token = "0x4002416")]
					FurnitureType,
					[Cpp2IlInjected.Token(Token = "0x4002417")]
					TrimmingType
				}

				[Cpp2IlInjected.Token(Token = "0x400240C")]
				private static readonly MessageParser<ItemSupportData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400240D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400240E")]
				public const int ClothingTypeFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400240F")]
				public const int FurnitureTypeFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002410")]
				public const int TrimmingTypeFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002411")]
				private object type_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002412")]
				private TypeOneofCase typeCase_;

				[Cpp2IlInjected.Token(Token = "0x17001454")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemSupportData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004FC0")]
					[Cpp2IlInjected.Address(RVA = "0x29465F0", Offset = "0x2944FF0", VA = "0x1829465F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001455")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004FC1")]
					[Cpp2IlInjected.Address(RVA = "0x2946510", Offset = "0x2944F10", VA = "0x182946510")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001456")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004FC2")]
					[Cpp2IlInjected.Address(RVA = "0x29466B0", Offset = "0x29450B0", VA = "0x1829466B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001457")]
				[DebuggerNonUserCode]
				public ClothingSupportType ClothingType
				{
					[Cpp2IlInjected.Token(Token = "0x6004FC6")]
					[Cpp2IlInjected.Address(RVA = "0x29464B0", Offset = "0x2944EB0", VA = "0x1829464B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004FC7")]
					[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001458")]
				[DebuggerNonUserCode]
				public FurnitureSupportType FurnitureType
				{
					[Cpp2IlInjected.Token(Token = "0x6004FC8")]
					[Cpp2IlInjected.Address(RVA = "0x2946590", Offset = "0x2944F90", VA = "0x182946590")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004FC9")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001459")]
				[DebuggerNonUserCode]
				public TrimmingSupportType TrimmingType
				{
					[Cpp2IlInjected.Token(Token = "0x6004FCA")]
					[Cpp2IlInjected.Address(RVA = "0x2946650", Offset = "0x2945050", VA = "0x182946650")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004FCB")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700145A")]
				[DebuggerNonUserCode]
				public TypeOneofCase TypeCase
				{
					[Cpp2IlInjected.Token(Token = "0x6004FCC")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(TypeOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004FC3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ItemSupportData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FC4")]
				[Cpp2IlInjected.Address(RVA = "0x29462C0", Offset = "0x2944CC0", VA = "0x1829462C0")]
				[DebuggerNonUserCode]
				public ItemSupportData(ItemSupportData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FC5")]
				[Cpp2IlInjected.Address(RVA = "0x2945390", Offset = "0x2943D90", VA = "0x182945390", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemSupportData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004FCD")]
				[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
				[DebuggerNonUserCode]
				public void ClearType()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FCE")]
				[Cpp2IlInjected.Address(RVA = "0x2945550", Offset = "0x2943F50", VA = "0x182945550", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004FCF")]
				[Cpp2IlInjected.Address(RVA = "0x29453F0", Offset = "0x2943DF0", VA = "0x1829453F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemSupportData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD0")]
				[Cpp2IlInjected.Address(RVA = "0x2945730", Offset = "0x2944130", VA = "0x182945730", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD1")]
				[Cpp2IlInjected.Address(RVA = "0x2945FB0", Offset = "0x29449B0", VA = "0x182945FB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD2")]
				[Cpp2IlInjected.Address(RVA = "0x2946010", Offset = "0x2944A10", VA = "0x182946010", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD3")]
				[Cpp2IlInjected.Address(RVA = "0x2945150", Offset = "0x2943B50", VA = "0x182945150", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD4")]
				[Cpp2IlInjected.Address(RVA = "0x2945C50", Offset = "0x2944650", VA = "0x182945C50", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemSupportData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD5")]
				[Cpp2IlInjected.Address(RVA = "0x2945980", Offset = "0x2944380", VA = "0x182945980", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD6")]
				[Cpp2IlInjected.Address(RVA = "0x29455B0", Offset = "0x2943FB0", VA = "0x1829455B0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD7")]
				[Cpp2IlInjected.Address(RVA = "0x2945E50", Offset = "0x2944850", VA = "0x182945E50", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF6B80", Offset = "0x1BF5580", VA = "0x181BF6B80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004FD9")]
				[Cpp2IlInjected.Address(RVA = "0x29458D0", Offset = "0x29442D0", VA = "0x1829458D0", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004FDA")]
				[Cpp2IlInjected.Address(RVA = "0x2945320", Offset = "0x2943D20", VA = "0x182945320", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002403")]
		private static readonly MessageParser<DisplaySettingsData> _parser = (MessageParser<DisplaySettingsData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new DisplaySettingsData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002404")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002405")]
		public const int BuyItemDialogueAddressFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002406")]
		private string buyItemDialogueAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002407")]
		public const int UnavailableItemPrefabAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002408")]
		private string unavailableItemPrefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002409")]
		public const int ItemSupportsFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400240A")]
		private static readonly MapField<uint, Types.ItemSupportData>.Codec _map_itemSupports_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400240B")]
		private readonly MapField<uint, Types.ItemSupportData> itemSupports_ = (MapField<uint, Types.ItemSupportData>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700144D")]
		public unsafe static DisplaySettingsData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA5")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B1A0", Offset = "0x2C49BA0", VA = "0x182C4B1A0")]
			get
			{
				int num = 0;
				bool flag = ProtoDatabase.Instance.TryGet("DisplaySettings", out *(DisplaySettingsData*)num);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144E")]
		[DebuggerNonUserCode]
		public static MessageParser<DisplaySettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA9")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B360", Offset = "0x2C49D60", VA = "0x182C4B360")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAA")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B290", Offset = "0x2C49C90", VA = "0x182C4B290")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001450")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAB")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B3C0", Offset = "0x2C49DC0", VA = "0x182C4B3C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001451")]
		[DebuggerNonUserCode]
		public string BuyItemDialogueAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return buyItemDialogueAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB0")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B4D0", Offset = "0x2C49ED0", VA = "0x182C4B4D0")]
			set
			{
				string text = (buyItemDialogueAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001452")]
		[DebuggerNonUserCode]
		public string UnavailableItemPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return unavailableItemPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB2")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B540", Offset = "0x2C49F40", VA = "0x182C4B540")]
			set
			{
				string text = (unavailableItemPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001453")]
		[DebuggerNonUserCode]
		public MapField<uint, Types.ItemSupportData> ItemSupports
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemSupports_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA6")]
		[Cpp2IlInjected.Address(RVA = "0x2C49C10", Offset = "0x2C48610", VA = "0x182C49C10")]
		public string GetClothingSupportPrefabAddress(Item item, bool useMain, [Optional] ClothingParameterLength? paramLength, bool forceLongHandMannequin = false)
		{
			//Discarded unreachable code: IL_00c0, IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Clothing)
			{
				MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
				bool flag = default(bool);
				if (flag)
				{
					ClothingSupportType clothingSupportType = default(ClothingSupportType);
					while (clothingSupportType == null)
					{
					}
					ClothingSupportType clothingSupportType2 = default(ClothingSupportType);
					RepeatedField<ClothingItemType> itemTypes_ = clothingSupportType2.itemTypes_;
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					ClothingSupportType clothingSupportType3 = default(ClothingSupportType);
					RepeatedField<ClothingSupportType.Types.ClothingParamLength> paramLengthList_ = clothingSupportType3.paramLengthList_;
					Func<ClothingSupportType.Types.ClothingParamLength, bool> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_1;
					if (_003C_003E9__2_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ClothingSupportType.Types.ClothingParamLength x) => x.length_ == ClothingParameterLength.Long);
					}
					ClothingSupportType.Types.ClothingParamLength clothingParamLength = Enumerable.FirstOrDefault<ClothingSupportType.Types.ClothingParamLength>((IEnumerable<>)(object)paramLengthList_, (Func<, >)(object)_003C_003E9__2_);
					ClothingSupportType clothingSupportType4 = default(ClothingSupportType);
					RepeatedField<ClothingSupportType.Types.ClothingParamLength> paramLengthList_2 = clothingSupportType4.paramLengthList_;
					Func<ClothingSupportType.Types.ClothingParamLength, bool> func = default(Func<ClothingSupportType.Types.ClothingParamLength, bool>);
					Func<ClothingSupportType.Types.ClothingParamLength, bool> func2 = func;
					if (func2 == null)
					{
						ClothingParameterLength clothingParameterLength = default(ClothingParameterLength);
						func = (Func<ClothingSupportType.Types.ClothingParamLength, bool>)(object)(Func<T, TResult>)((ClothingSupportType.Types.ClothingParamLength x) => x.length_ == clothingParameterLength);
					}
					ClothingSupportType.Types.ClothingParamLength clothingParamLength2 = Enumerable.FirstOrDefault<ClothingSupportType.Types.ClothingParamLength>((IEnumerable<>)(object)paramLengthList_2, (Func<, >)(object)func2);
					if (num == 0 || num == 0)
					{
						ClothingSupportType clothingSupportType5 = default(ClothingSupportType);
						ClothingSupportType.Types.VisualSetup visualSetupDefault_ = clothingSupportType5.visualSetupDefault_;
					}
				}
				if (num == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A100", Offset = "0x2C48B00", VA = "0x182C4A100")]
		public string GetFurnitureSupportPrefabAddress(Item item)
		{
			//Discarded unreachable code: IL_0126, IL_012c
			int num = 0;
			ItemType itemType = default(ItemType);
			GridArea gridArea = default(GridArea);
			Func<FurnitureSupportType.Types.AreaFilterData, bool> func3 = default(Func<FurnitureSupportType.Types.AreaFilterData, bool>);
			if (itemType == ItemType.Furniture)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					IHasTags hasTagsItem = (IHasTags)itemData;
					if ((IntPtr)hasTagsItem != (IntPtr)num)
					{
						MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
						Predicate<int> predicate = default(Predicate<int>);
						Func<KeyValuePair<uint, Types.ItemSupportData>, bool> func = (Func<KeyValuePair<uint, Types.ItemSupportData>, bool>)(object)(Func<T, TResult>)delegate
						{
							FurnitureSupportType furnitureSupportType2 = default(FurnitureSupportType);
							if (furnitureSupportType2 != null)
							{
								Predicate<int> predicate2 = predicate;
								RepeatedField<int> tags_ = furnitureSupportType2.tags_;
								if (predicate2 == null)
								{
									predicate = (Predicate<int>)(object)(Predicate<T>)delegate
									{
										//Discarded unreachable code: IL_0009
										IHasTags hasTags = hasTagsItem;
										bool result2 = default(bool);
										return result2;
									};
								}
								return ((RepeatedField<>)(object)tags_).Any<int>((Predicate<>)(object)predicate2);
							}
							throw new NullReferenceException();
						};
						int num2 = Enumerable.Count<KeyValuePair<uint, Types.ItemSupportData>>(Enumerable.Where<KeyValuePair<uint, Types.ItemSupportData>>((IEnumerable<>)(object)mapField, (Func<, >)(object)func));
						bool flag = default(bool);
						if (num2 > 0 && num2 != 0 && num2 != 0 && flag)
						{
							uint num3 = default(uint);
							if (num < (int)num3)
							{
								num += num;
								if (num == (int)num3)
								{
									goto IL_00f2;
								}
								num++;
							}
							if ((object)gridArea != null)
							{
								uint num4 = default(uint);
								if (num < (int)num4)
								{
									num += num;
									if (num == (int)num4)
									{
										goto IL_0101;
									}
									num++;
								}
								FurnitureSupportType furnitureSupportType = default(FurnitureSupportType);
								RepeatedField<FurnitureSupportType.Types.AreaFilterData> filterData_ = furnitureSupportType.filterData_;
								Func<FurnitureSupportType.Types.AreaFilterData, bool> func2 = default(Func<FurnitureSupportType.Types.AreaFilterData, bool>);
								if (func2 == null)
								{
									func3 = (func2 = (Func<FurnitureSupportType.Types.AreaFilterData, bool>)(object)(Func<T, TResult>)delegate(FurnitureSupportType.Types.AreaFilterData x)
									{
										//Discarded unreachable code: IL_0013
										AreaSize maxAreaSize_ = x.maxAreaSize_;
										AreaSize minAreaSize_ = x.minAreaSize_;
										int num6 = 0;
										bool result = default(bool);
										return result;
									});
								}
								FurnitureSupportType.Types.AreaFilterData areaFilterData = Enumerable.FirstOrDefault<FurnitureSupportType.Types.AreaFilterData>((IEnumerable<>)(object)filterData_, (Func<, >)(object)func3);
								while (areaFilterData == null)
								{
								}
								string mainPrefabAddress_ = areaFilterData.mainPrefabAddress_;
								num++;
								goto IL_00f2;
							}
							goto IL_0110;
						}
					}
				}
			}
			goto IL_011d;
			IL_00f2:
			func3 += func3;
			num += 312;
			goto IL_0101;
			IL_0110:
			num++;
			if ((object)gridArea != null)
			{
			}
			if (num == 0)
			{
			}
			goto IL_011d;
			IL_0101:
			func3 += func3;
			num += 312;
			goto IL_0110;
			IL_011d:
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A6C0", Offset = "0x2C490C0", VA = "0x182C4A6C0")]
		public string GetTrimmingSupportPrefabAddress(Item item)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData != null && itemData != null)
			{
				IHasTags hasTagsItem = (IHasTags)itemData;
				if ((long)hasTagsItem != 0)
				{
					Predicate<int> predicate = default(Predicate<int>);
					Func<KeyValuePair<uint, Types.ItemSupportData>, bool> func = (Func<KeyValuePair<uint, Types.ItemSupportData>, bool>)(object)(Func<T, TResult>)delegate
					{
						TrimmingSupportType trimmingSupportType2 = default(TrimmingSupportType);
						if (trimmingSupportType2 != null)
						{
							Predicate<int> predicate2 = predicate;
							RepeatedField<int> tags_ = trimmingSupportType2.tags_;
							if (predicate2 == null)
							{
								predicate = (Predicate<int>)(object)(Predicate<T>)delegate
								{
									//Discarded unreachable code: IL_0009
									IHasTags hasTags = hasTagsItem;
									bool result = default(bool);
									return result;
								};
							}
							return ((RepeatedField<>)(object)tags_).Any<int>((Predicate<>)(object)predicate2);
						}
						throw new NullReferenceException();
					};
					TrimmingSupportType trimmingSupportType = default(TrimmingSupportType);
					return trimmingSupportType.mainPrefabAddress_;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FAC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B0F0", Offset = "0x2C49AF0", VA = "0x182C4B0F0")]
		[DebuggerNonUserCode]
		public DisplaySettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FAD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AF90", Offset = "0x2C49990", VA = "0x182C4AF90")]
		[DebuggerNonUserCode]
		public DisplaySettingsData(DisplaySettingsData other)
		{
			string text = (buyItemDialogueAddress_ = other.buyItemDialogueAddress_);
			string text2 = (unavailableItemPrefabAddress_ = other.unavailableItemPrefabAddress_);
			MapField<uint, Types.ItemSupportData> mapField = (itemSupports_ = (MapField<uint, Types.ItemSupportData>)(object)((MapField<TKey, TValue>)(object)other.itemSupports_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FAE")]
		[Cpp2IlInjected.Address(RVA = "0x2C498D0", Offset = "0x2C482D0", VA = "0x182C498D0", Slot = "10")]
		[DebuggerNonUserCode]
		public DisplaySettingsData Clone()
		{
			//Discarded unreachable code: IL_0071
			DisplaySettingsData displaySettingsData = new DisplaySettingsData();
			displaySettingsData.buyItemDialogueAddress_ = "";
			displaySettingsData.unavailableItemPrefabAddress_ = "";
			MapField<uint, Types.ItemSupportData> mapField = (displaySettingsData.itemSupports_ = (MapField<uint, Types.ItemSupportData>)(object)new MapField<TKey, TValue>());
			string text = (displaySettingsData.buyItemDialogueAddress_ = buyItemDialogueAddress_);
			string text2 = (displaySettingsData.unavailableItemPrefabAddress_ = unavailableItemPrefabAddress_);
			MapField<uint, Types.ItemSupportData> mapField2 = (displaySettingsData.itemSupports_ = (MapField<uint, Types.ItemSupportData>)(object)((MapField<TKey, TValue>)(object)itemSupports_).Clone());
			UnknownFieldSet unknownFieldSet = (displaySettingsData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return displaySettingsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB4")]
		[Cpp2IlInjected.Address(RVA = "0x2C49B10", Offset = "0x2C48510", VA = "0x182C49B10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				string text = buyItemDialogueAddress_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = unavailableItemPrefabAddress_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB5")]
		[Cpp2IlInjected.Address(RVA = "0x2C49A50", Offset = "0x2C48450", VA = "0x182C49A50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DisplaySettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.buyItemDialogueAddress_;
				if (!(buyItemDialogueAddress_ != text))
				{
					string text2 = other.unavailableItemPrefabAddress_;
					if (!(unavailableItemPrefabAddress_ != text2))
					{
						MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
						MapField<uint, Types.ItemSupportData> mapField2 = other.itemSupports_;
						if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB6")]
		[Cpp2IlInjected.Address(RVA = "0x293E950", Offset = "0x293D350", VA = "0x18293E950", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			string text = buyItemDialogueAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = unavailableItemPrefabAddress_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)itemSupports_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ABD0", Offset = "0x2C495D0", VA = "0x182C4ABD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AC30", Offset = "0x2C49630", VA = "0x182C4AC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0063
			if (buyItemDialogueAddress_.m_stringLength != 0)
			{
				string value = buyItemDialogueAddress_;
				output.WriteString(value);
			}
			if (unavailableItemPrefabAddress_.m_stringLength != 0)
			{
				string value2 = unavailableItemPrefabAddress_;
				output.WriteString(value2);
			}
			MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
			MapField<uint, Types.ItemSupportData>.Codec map_itemSupports_codec = _map_itemSupports_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_itemSupports_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB9")]
		[Cpp2IlInjected.Address(RVA = "0x2C496E0", Offset = "0x2C480E0", VA = "0x182C496E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0078
			string text = buyItemDialogueAddress_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = unavailableItemPrefabAddress_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
			MapField<uint, Types.ItemSupportData>.Codec map_itemSupports_codec = _map_itemSupports_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_itemSupports_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A8D0", Offset = "0x2C492D0", VA = "0x182C4A8D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DisplaySettingsData other)
		{
			//Discarded unreachable code: IL_0067
			if (other != null)
			{
				string text = other.buyItemDialogueAddress_;
				if (text.m_stringLength != 0)
				{
					BuyItemDialogueAddress = text;
				}
				string text2 = other.unavailableItemPrefabAddress_;
				if (text2.m_stringLength != 0)
				{
					UnavailableItemPrefabAddress = text2;
				}
				MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
				MapField<uint, Types.ItemSupportData> mapField2 = other.itemSupports_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBB")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A980", Offset = "0x2C49380", VA = "0x182C4A980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0069
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (BuyItemDialogueAddress = input.ReadString());
				}
				string text4 = default(string);
				if (num == 18)
				{
					text4 = (UnavailableItemPrefabAddress = input.ReadString());
				}
				if ((long)text4 == 26)
				{
					MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
					MapField<uint, Types.ItemSupportData>.Codec map_itemSupports_codec = _map_itemSupports_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_itemSupports_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A060", Offset = "0x2C48A60", VA = "0x182C4A060", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
				string text = unavailableItemPrefabAddress_;
				string text2 = buyItemDialogueAddress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AAB0", Offset = "0x2C494B0", VA = "0x182C4AAB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						UnavailableItemPrefabAddress = (string)num2;
						return;
					}
				}
				else
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				throw new InvalidCastException();
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBE")]
		[Cpp2IlInjected.Address(RVA = "0x2C49820", Offset = "0x2C48220", VA = "0x182C49820", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_002f
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					MapField<uint, Types.ItemSupportData> mapField = itemSupports_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				UnavailableItemPrefabAddress = "";
			}
			else
			{
				BuyItemDialogueAddress = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FBF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AD60", Offset = "0x2C49760", VA = "0x182C4AD60")]
		static DisplaySettingsData()
		{
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<Types.ItemSupportData> parser = Types.ItemSupportData._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Types.ItemSupportData>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<DisplaySettingsData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
