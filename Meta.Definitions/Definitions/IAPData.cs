using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class IAPData : IMessage<IAPData>, IMessage, IEquatable<IAPData>, IDeepCloneable<IAPData>, IMessageFieldAccessor, IHasOnlineItemDependencies, IHasItemDependencies, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly MessageParser<IAPData> _parser = (MessageParser<IAPData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new IAPData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public const int UniqueNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private string uniqueName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public const int TitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private string title_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public const int DescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const int IapTypeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private IAPType iapType_;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public const int RewardsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private static readonly FieldCodec<ItemAmount> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly RepeatedField<ItemAmount> rewards_ = (RepeatedField<ItemAmount>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public const int NestedRewardsFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private string nestedRewards_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public const int StoreFrontProductIdsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private static readonly MapField<uint, IAPStoreFrontData>.Codec _map_storeFrontProductIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly MapField<uint, IAPStoreFrontData> storeFrontProductIds_ = (MapField<uint, IAPStoreFrontData>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public const int CustomStoreFrontProductIdsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly MapField<uint, IAPCustomStoreFrontData>.Codec _map_customStoreFrontProductIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private readonly MapField<uint, IAPCustomStoreFrontData> customStoreFrontProductIds_ = (MapField<uint, IAPCustomStoreFrontData>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		[DebuggerNonUserCode]
		public static MessageParser<IAPData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x27B03D0", Offset = "0x27AEDD0", VA = "0x1827B03D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0x27B00E0", Offset = "0x27AEAE0", VA = "0x1827B00E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x27B0430", Offset = "0x27AEE30", VA = "0x1827B0430", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		[DebuggerNonUserCode]
		public string UniqueName
		{
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return uniqueName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0x27B0690", Offset = "0x27AF090", VA = "0x1827B0690")]
			set
			{
				string text = (uniqueName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x27B0620", Offset = "0x27AF020", VA = "0x1827B0620")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x27B0540", Offset = "0x27AEF40", VA = "0x1827B0540")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		[DebuggerNonUserCode]
		public IAPType IapType
		{
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return iapType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				iapType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemAmount> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		[DebuggerNonUserCode]
		public string NestedRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return nestedRewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0x27B05B0", Offset = "0x27AEFB0", VA = "0x1827B05B0")]
			set
			{
				string text = (nestedRewards_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		[DebuggerNonUserCode]
		public MapField<uint, IAPStoreFrontData> StoreFrontProductIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return storeFrontProductIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		[DebuggerNonUserCode]
		public MapField<uint, IAPCustomStoreFrontData> CustomStoreFrontProductIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return customStoreFrontProductIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public string AnyNativeID
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x27AFFC0", Offset = "0x27AE9C0", VA = "0x1827AFFC0")]
			get
			{
				//Discarded unreachable code: IL_005e
				IAPCustomStoreFrontData iAPCustomStoreFrontData;
				do
				{
					IL_0000:
					IAPStoreFrontData iAPStoreFrontData = Enumerable.FirstOrDefault<IAPStoreFrontData>((IEnumerable<>)((MapField<TKey, TValue>)(object)storeFrontProductIds_).get_Values());
					if (iAPStoreFrontData != null)
					{
						if (string.IsNullOrEmpty(iAPStoreFrontData.catalogID_))
						{
						}
						if (iAPStoreFrontData.catalogID_ != null)
						{
							goto IL_0000;
						}
					}
					iAPCustomStoreFrontData = Enumerable.FirstOrDefault<IAPCustomStoreFrontData>((IEnumerable<>)((MapField<TKey, TValue>)(object)customStoreFrontProductIds_).get_Values());
					if (iAPCustomStoreFrontData == null)
					{
						break;
					}
					if (string.IsNullOrEmpty(iAPCustomStoreFrontData.catalogID_))
					{
					}
				}
				while (iAPCustomStoreFrontData.catalogID_ != null);
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x27B01B0", Offset = "0x27AEBB0", VA = "0x1827B01B0", Slot = "14")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "15")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0x27B0210", Offset = "0x27AEC10", VA = "0x1827B0210", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0049
				List<Item> list = itemDependencies;
				if (list == null)
				{
					List<Item> list2 = (itemDependencies = (List<Item>)(object)new List<T>());
					RepeatedField<ItemAmount> repeatedField = rewards_;
					Func<ItemAmount, Item> _003C_003E9__76_ = _003C_003Ec._003C_003E9__76_0;
					if (_003C_003E9__76_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemAmount x) => x.Item);
					}
					IEnumerable<ItemAmount> enumerable = (IEnumerable<ItemAmount>)Enumerable.Select<ItemAmount, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__76_);
				}
				return list;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x27AFE60", Offset = "0x27AE860", VA = "0x1827AFE60")]
		[DebuggerNonUserCode]
		public IAPData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x27AFBC0", Offset = "0x27AE5C0", VA = "0x1827AFBC0")]
		[DebuggerNonUserCode]
		public IAPData(IAPData other)
		{
			string text = (uniqueName_ = other.uniqueName_);
			string text2 = (title_ = other.title_);
			string text3 = (description_ = other.description_);
			IAPType iAPType = (iapType_ = other.iapType_);
			RepeatedField<ItemAmount> repeatedField = (rewards_ = (RepeatedField<ItemAmount>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			string text4 = (nestedRewards_ = other.nestedRewards_);
			MapField<uint, IAPStoreFrontData> mapField = (storeFrontProductIds_ = (MapField<uint, IAPStoreFrontData>)(object)((MapField<TKey, TValue>)(object)other.storeFrontProductIds_).Clone());
			MapField<uint, IAPCustomStoreFrontData> mapField2 = (customStoreFrontProductIds_ = (MapField<uint, IAPCustomStoreFrontData>)(object)((MapField<TKey, TValue>)(object)other.customStoreFrontProductIds_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x27AC550", Offset = "0x27AAF50", VA = "0x1827AC550", Slot = "10")]
		[DebuggerNonUserCode]
		public IAPData Clone()
		{
			return new IAPData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x27AE240", Offset = "0x27ACC40", VA = "0x1827AE240", Slot = "0")]
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
				string text = uniqueName_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = title_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = description_;
						bool flag3 = default(bool);
						if (!flag3 && iapType_ == (flag3 ? IAPType.MoonstonePack : IAPType.FoundersPack))
						{
							RepeatedField<ItemAmount> repeatedField = rewards_;
							bool flag4 = default(bool);
							if (flag4)
							{
								string text4 = nestedRewards_;
								bool flag5 = default(bool);
								if (!flag5)
								{
									MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
									bool flag6 = default(bool);
									if (flag6)
									{
										MapField<uint, IAPCustomStoreFrontData> mapField2 = customStoreFrontProductIds_;
										bool flag7 = default(bool);
										if (flag7)
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x27AE0E0", Offset = "0x27ACAE0", VA = "0x1827AE0E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IAPData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.uniqueName_;
				if (!(uniqueName_ != text))
				{
					string text2 = other.title_;
					if (!(title_ != text2))
					{
						string text3 = other.description_;
						if (!(description_ != text3))
						{
							IAPType iAPType = other.iapType_;
							if (iapType_ == iAPType)
							{
								RepeatedField<ItemAmount> repeatedField = rewards_;
								RepeatedField<ItemAmount> repeatedField2 = other.rewards_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									string text4 = other.nestedRewards_;
									if (!(nestedRewards_ != text4))
									{
										MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
										MapField<uint, IAPStoreFrontData> mapField2 = other.storeFrontProductIds_;
										if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
										{
											MapField<uint, IAPCustomStoreFrontData> mapField3 = customStoreFrontProductIds_;
											MapField<uint, IAPCustomStoreFrontData> mapField4 = other.customStoreFrontProductIds_;
											if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x27AEB50", Offset = "0x27AD550", VA = "0x1827AEB50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b2
			string text = uniqueName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (iapType_ != 0)
			{
			}
			int hashCode4 = ((RepeatedField<T>)(object)rewards_).GetHashCode();
			string text4 = nestedRewards_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			int hashCode6 = ((MapField<TKey, TValue>)(object)storeFrontProductIds_).GetHashCode();
			int hashCode7 = ((MapField<TKey, TValue>)(object)customStoreFrontProductIds_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return hashCode7;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x27AF500", Offset = "0x27ADF00", VA = "0x1827AF500", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x27AF560", Offset = "0x27ADF60", VA = "0x1827AF560", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00da
			if (uniqueName_.m_stringLength != 0)
			{
				string value = uniqueName_;
				output.WriteString(value);
			}
			if (title_.m_stringLength != 0)
			{
				string value2 = title_;
				output.WriteString(value2);
			}
			if (description_.m_stringLength != 0)
			{
				string value3 = description_;
				output.WriteString(value3);
			}
			if (iapType_ != 0)
			{
			}
			RepeatedField<ItemAmount> repeatedField = rewards_;
			FieldCodec<ItemAmount> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			if (nestedRewards_.m_stringLength != 0)
			{
				string value4 = nestedRewards_;
				output.WriteString(value4);
			}
			MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
			MapField<uint, IAPStoreFrontData>.Codec map_storeFrontProductIds_codec = _map_storeFrontProductIds_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_storeFrontProductIds_codec);
			MapField<uint, IAPCustomStoreFrontData> mapField2 = customStoreFrontProductIds_;
			MapField<uint, IAPCustomStoreFrontData>.Codec map_customStoreFrontProductIds_codec = _map_customStoreFrontProductIds_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_customStoreFrontProductIds_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x27AC170", Offset = "0x27AAB70", VA = "0x1827AC170", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0119
			string text = uniqueName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			IAPType iAPType = iapType_;
			if (iAPType != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)iAPType);
				num5++;
				num += num5;
			}
			RepeatedField<ItemAmount> repeatedField = rewards_;
			FieldCodec<ItemAmount> repeated_rewards_codec = _repeated_rewards_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			string text4 = nestedRewards_;
			num += num6;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num += num7;
			}
			MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
			MapField<uint, IAPStoreFrontData>.Codec map_storeFrontProductIds_codec = _map_storeFrontProductIds_codec;
			int num8 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_storeFrontProductIds_codec);
			MapField<uint, IAPCustomStoreFrontData> mapField2 = customStoreFrontProductIds_;
			MapField<uint, IAPCustomStoreFrontData>.Codec map_customStoreFrontProductIds_codec = _map_customStoreFrontProductIds_codec;
			int num9 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_customStoreFrontProductIds_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x27AEF40", Offset = "0x27AD940", VA = "0x1827AEF40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IAPData other)
		{
			//Discarded unreachable code: IL_00e3
			if (other != null)
			{
				string text = other.uniqueName_;
				if (text.m_stringLength != 0)
				{
					UniqueName = text;
				}
				string text2 = other.title_;
				if (text2.m_stringLength != 0)
				{
					Title = text2;
				}
				string text3 = other.description_;
				if (text3.m_stringLength != 0)
				{
					Description = text3;
				}
				IAPType iAPType = other.iapType_;
				if (iAPType != 0)
				{
					iapType_ = iAPType;
				}
				RepeatedField<ItemAmount> repeatedField = rewards_;
				RepeatedField<ItemAmount> repeatedField2 = other.rewards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text4 = other.nestedRewards_;
				if (text4.m_stringLength != 0)
				{
					NestedRewards = text4;
				}
				MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
				MapField<uint, IAPStoreFrontData> mapField2 = other.storeFrontProductIds_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<uint, IAPCustomStoreFrontData> mapField3 = customStoreFrontProductIds_;
				MapField<uint, IAPCustomStoreFrontData> mapField4 = other.customStoreFrontProductIds_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x27AECB0", Offset = "0x27AD6B0", VA = "0x1827AECB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_010a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
						MapField<uint, IAPStoreFrontData>.Codec map_storeFrontProductIds_codec = _map_storeFrontProductIds_codec;
						((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_storeFrontProductIds_codec);
					}
					if (num != 66)
					{
						goto IL_00f3;
					}
					MapField<uint, IAPCustomStoreFrontData> mapField2 = customStoreFrontProductIds_;
					MapField<uint, IAPCustomStoreFrontData>.Codec map_customStoreFrontProductIds_codec = _map_customStoreFrontProductIds_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_customStoreFrontProductIds_codec);
				}
				if (num == 42)
				{
					RepeatedField<ItemAmount> repeatedField = rewards_;
					FieldCodec<ItemAmount> repeated_rewards_codec = _repeated_rewards_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
				}
				if (num != 50)
				{
					goto IL_00f3;
				}
				string text2 = (NestedRewards = input.ReadString());
			}
			int num2 = default(int);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (Description = input.ReadString());
				}
				if ((long)text4 != 32)
				{
					goto IL_00f3;
				}
				num2 = (int)(iapType_ = (IAPType)input.ReadInt32());
			}
			string text6 = default(string);
			if (num2 == 10)
			{
				text6 = (UniqueName = input.ReadString());
			}
			if ((long)text6 == 18)
			{
				string text8 = (Title = input.ReadString());
			}
			goto IL_00f3;
			IL_00f3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x27AE9F0", Offset = "0x27AD3F0", VA = "0x1827AE9F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				string text = uniqueName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x27AF240", Offset = "0x27ADC40", VA = "0x1827AF240", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_0027, IL_002f, IL_0030, IL_0041, IL_0047, IL_004d
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				UniqueName = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x27AC3F0", Offset = "0x27AADF0", VA = "0x1827AC3F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0016, IL_0018, IL_001b
			if (fieldNumber - 1 <= 7)
			{
				UniqueName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x27AE3E0", Offset = "0x27ACDE0", VA = "0x1827AE3E0")]
		public static IAPData FindIAPDataFromOrderId(string orderID)
		{
			//Discarded unreachable code: IL_00bc, IL_00c2, IL_00c8, IL_00ce
			uint num3 = default(uint);
			Func<IAPStoreFrontData, bool> func = default(Func<IAPStoreFrontData, bool>);
			Func<IAPStoreFrontData, bool> func2 = default(Func<IAPStoreFrontData, bool>);
			ICollection<> collection = default(ICollection<>);
			Func<IAPCustomStoreFrontData, bool> func3 = default(Func<IAPCustomStoreFrontData, bool>);
			Func<IAPCustomStoreFrontData, bool> func4 = default(Func<IAPCustomStoreFrontData, bool>);
			ICollection<> collection2 = default(ICollection<>);
			int num;
			do
			{
				IL_0000:
				num = 0;
				int num2 = 0;
				IEnumerable<IAPData> all = (IEnumerable<IAPData>)IAPData.GetAll();
				if (all != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_008d;
						}
						num++;
					}
					if (func == null)
					{
						func2 = (func = (Func<IAPStoreFrontData, bool>)(object)(Func<T, TResult>)delegate(IAPStoreFrontData x)
						{
							//Discarded unreachable code: IL_0014
							string b2 = orderID;
							return string.Equals(x.productID_, b2);
						});
					}
					if (Enumerable.FirstOrDefault<IAPStoreFrontData>((IEnumerable<>)collection, (Func<, >)(object)func2) == null)
					{
						if (func3 == null)
						{
							func4 = (func3 = (Func<IAPCustomStoreFrontData, bool>)(object)(Func<T, TResult>)delegate(IAPCustomStoreFrontData x)
							{
								//Discarded unreachable code: IL_0014
								string b = orderID;
								return string.Equals(x.productID_, b);
							});
						}
						if (Enumerable.FirstOrDefault<IAPCustomStoreFrontData>((IEnumerable<>)collection2, (Func<, >)(object)func4) == null)
						{
							goto IL_0000;
						}
						num++;
						goto IL_008d;
					}
					goto IL_009c;
				}
				goto IL_00a0;
				IL_008d:
				func4 += func4;
				num += 312;
				goto IL_009c;
				IL_009c:
				num++;
				goto IL_00a0;
				IL_00a0:
				num++;
				if (all != null)
				{
				}
			}
			while (num != 0);
			if (num != 0)
			{
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x27AE810", Offset = "0x27AD210", VA = "0x1827AE810")]
		public static IEnumerable<IAPData> GetAll()
		{
			//Discarded unreachable code: IL_000b
			return (IEnumerable<IAPData>)ProtoDatabase.Instance.Enumerate<IAPData>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x27AE8D0", Offset = "0x27AD2D0", VA = "0x1827AE8D0")]
		public static IAPData GetByUniqueName(string uniqueName)
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			IEnumerable<IAPData> all = (IEnumerable<IAPData>)IAPData.GetAll();
			Func<IAPData, bool> func = (Func<IAPData, bool>)(object)(Func<T, TResult>)delegate(IAPData x)
			{
				//Discarded unreachable code: IL_0014
				string b = uniqueName;
				return string.Equals(x.uniqueName_, b);
			};
			return Enumerable.FirstOrDefault<IAPData>((IEnumerable<>)all, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x27AF090", Offset = "0x27ADA90", VA = "0x1827AF090")]
		public bool OwnsThisNativeItemID(string nativeItemID)
		{
			ICollection<IAPStoreFrontData> values = (ICollection<IAPStoreFrontData>)((MapField<TKey, TValue>)(object)storeFrontProductIds_).get_Values();
			Func<IAPStoreFrontData, bool> cpp2il__autoParamName__idx_ = (Func<IAPStoreFrontData, bool>)(object)(Func<T, TResult>)delegate(IAPStoreFrontData x)
			{
				//Discarded unreachable code: IL_0016
				string nativeItemID3 = x.NativeItemID;
				string b2 = nativeItemID;
				return string.Equals(nativeItemID3, b2);
			};
			if (((IEnumerable<>)values).Any<IAPStoreFrontData>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				return true;
			}
			ICollection<IAPCustomStoreFrontData> values2 = (ICollection<IAPCustomStoreFrontData>)((MapField<TKey, TValue>)(object)customStoreFrontProductIds_).get_Values();
			Func<IAPCustomStoreFrontData, bool> cpp2il__autoParamName__idx_2 = (Func<IAPCustomStoreFrontData, bool>)(object)(Func<T, TResult>)delegate(IAPCustomStoreFrontData x)
			{
				//Discarded unreachable code: IL_0016
				string nativeItemID2 = x.NativeItemID;
				string b = nativeItemID;
				return string.Equals(nativeItemID2, b);
			};
			bool flag = ((IEnumerable<>)values2).Any<IAPCustomStoreFrontData>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x27AC5B0", Offset = "0x27AAFB0", VA = "0x1827AC5B0", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_0208: Expected O, but got I4
			//IL_0212: Expected O, but got I4
			//IL_021b: Expected O, but got I4
			//IL_0228: Expected O, but got I4
			//IL_0235: Expected O, but got I4
			//IL_0242: Expected O, but got I4
			//IL_024f: Expected O, but got I4
			//IL_0258: Expected O, but got I4
			//IL_0280: Expected O, but got I4
			//IL_02a2: Expected O, but got I4
			//IL_02ba: Expected O, but got I4
			//IL_0402: Expected O, but got I4
			//IL_047b: Expected O, but got I4
			//IL_04aa: Expected O, but got I4
			//IL_052f: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			string text8 = default(string);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			UnsupportedMarketplaceType unsupportedMarketplaceType = default(UnsupportedMarketplaceType);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			object[] array3 = default(object[]);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			bool flag12 = default(bool);
			bool flag13 = default(bool);
			IEnumerable<KeyValuePair<uint, IAPStoreFrontData>> enumerable = default(IEnumerable<KeyValuePair<uint, IAPStoreFrontData>>);
			int num9 = default(int);
			ulong num10 = default(ulong);
			bool flag14 = default(bool);
			IEnumerable<KeyValuePair<uint, IAPCustomStoreFrontData>> enumerable2 = default(IEnumerable<KeyValuePair<uint, IAPCustomStoreFrontData>>);
			int num12 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				string text = uniqueName_;
				if (num2 == 0)
				{
					int num5 = 0;
					IEnumerable<IAPData> all = (IEnumerable<IAPData>)IAPData.GetAll();
					Func<IAPData, bool> func = (Func<IAPData, bool>)(object)(Func<T, TResult>)delegate(IAPData x)
					{
						//Discarded unreachable code: IL_0014
						string b = x.uniqueName_;
						return string.Equals(uniqueName_, b);
					};
					if (Enumerable.Count<IAPData>(Enumerable.Where<IAPData>((IEnumerable<>)all, (Func<, >)(object)func)) == 1)
					{
						goto IL_019e;
					}
					string[] array = new string[5];
					if ("IAPData:" != null && "IAPData:" == null)
					{
						continue;
					}
					array[0] = "IAPData:";
					string text2 = uniqueName_;
					if (text2 != null && "IAPData:" == null)
					{
						continue;
					}
					array[1] = text2;
					if (" UniqueName Must be Unique '" != null && " UniqueName Must be Unique '" == null)
					{
						continue;
					}
					array[2] = " UniqueName Must be Unique '";
					string text3 = uniqueName_;
					if (text3 != null && " UniqueName Must be Unique '" == null)
					{
						continue;
					}
					array[3] = text3;
					if ("' already used" != null && "' already used" == null)
					{
						continue;
					}
				}
				string[] array2 = new string[5];
				if ("IAPData:" != null && "IAPData:" == null)
				{
					continue;
				}
				array2[0] = "IAPData:";
				string text4 = uniqueName_;
				if (text4 != null && "IAPData:" == null)
				{
					continue;
				}
				array2[1] = text4;
				if (" IAPData:" != null && " IAPData:" == null)
				{
					continue;
				}
				array2[2] = " IAPData:";
				string text5 = uniqueName_;
				if (text5 != null && " IAPData:" == null)
				{
					continue;
				}
				array2[3] = text5;
				if ("UniqueName Cannot be empty" != null && "UniqueName Cannot be empty" == null)
				{
					continue;
				}
				array2[4] = "UniqueName Cannot be empty";
				string message = string.Concat(array2);
				context.AddInvalidMemberError(message, "UniqueName");
				goto IL_019e;
				IL_019e:
				string text6 = nestedRewards_;
				string value = uniqueName_;
				if (text6.Equals(value))
				{
					string text7 = uniqueName_;
					string message2 = "IAPData:" + text7 + " NestedRewards cannot be itself, infinite recursion";
					context.AddInvalidMemberError(message2, "NestedRewards");
				}
				if (uniqueName_.Equals("FoundersPackBaseGame"))
				{
					break;
				}
				List<SupportedMarketplaceType> list = (List<SupportedMarketplaceType>)(object)new List<T>();
				((List<T>)(object)list).Add((T)6);
				((List<T>)(object)list).Add((T)11);
				((List<T>)(object)list).Add((T)4);
				((List<T>)(object)list).Add((T)201);
				((List<T>)(object)list).Add((T)200);
				((List<T>)(object)list).Add((T)203);
				((List<T>)(object)list).Add((T)202);
				((List<T>)(object)list).Add((T)8);
				if (flag)
				{
					MapField<uint, IAPStoreFrontData> mapField = storeFrontProductIds_;
					while (flag2)
					{
					}
					text8 = uniqueName_;
					string message3 = $"IAPData:{text8} Mandatory SupportedMarketplaceType {flag2} not assigned.";
					context.AddInvalidMemberError(message3, "StoreFrontProductIds");
				}
				List<UnsupportedMarketplaceType> list2 = (List<UnsupportedMarketplaceType>)(object)new List<T>();
				int num6 = 0;
				((List<T>)(object)list2).Add((T)num6);
				if (flag3)
				{
					while (flag4)
					{
					}
					string text9 = $"IAPData:{text8} Mandatory UnsupportedMarketplaceType {unsupportedMarketplaceType} not assigned.";
				}
				int num7 = 0;
				List<IAPData> list3 = (List<IAPData>)(object)Enumerable.ToList<IAPData>(IAPData.GetAll());
				if (flag5 && flag6)
				{
					while (flag7)
					{
					}
					while (!flag8)
					{
					}
					while (num4 == 0)
					{
					}
					array3 = new object[4];
					if (text8 != null && array3 == null)
					{
						continue;
					}
					array3[0] = text8;
					if (text8 != null && array3 == null)
					{
						continue;
					}
					array3[1] = text8;
					if (array3 != null && array3 == null)
					{
						continue;
					}
					array3[2] = array3;
					if (array3 != null && array3 == null)
					{
						continue;
					}
					array3[3] = array3;
					string text10 = string.Format("IAPData:{0} StoreFrontProductIds Mandatory ProductID={1} for key={2} already used by {3}", array3);
				}
				if (flag9 && flag10)
				{
					while (flag11)
					{
					}
					while (!flag12)
					{
					}
					while (num4 == 0)
					{
					}
					object[] array4 = new object[4];
					if (array3 != null && array4 == null)
					{
						continue;
					}
					array4[0] = array3;
					if (array3 != null && array4 == null)
					{
						continue;
					}
					array4[1] = array3;
					if (array4 != null && array4 == null)
					{
						continue;
					}
					array4[2] = array4;
					if (array4 != null && array4 == null)
					{
						continue;
					}
					array4[3] = array4;
					string text11 = string.Format("IAPData:{0} CustomStoreFrontProductIds Mandatory ProductID={1} for key={2} already used by {3}", array4);
				}
				if (flag13)
				{
					KeyValuePair<uint, IAPStoreFrontData> sfpid = (KeyValuePair<uint, IAPStoreFrontData>)0;
					Func<KeyValuePair<uint, IAPStoreFrontData>, bool> func2 = (Func<KeyValuePair<uint, IAPStoreFrontData>, bool>)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
					int num8 = Enumerable.Count<KeyValuePair<uint, IAPStoreFrontData>>((IEnumerable<>)enumerable);
					while (num8 <= 4)
					{
					}
					object[] array5 = new object[4];
					if (func2 != null && array5 == null)
					{
						continue;
					}
					array5[0] = func2;
					if (func2 != null && array5 == null)
					{
						continue;
					}
					array5[1] = func2;
					if (array5 != null)
					{
					}
					array5[2] = array5;
					if (num9 != 0 && num9 == 0)
					{
						continue;
					}
					array5[3] = num9;
					string text12 = string.Format("IAPData:{0} Found too many ProductID={1} found={2} expected={3}", array5);
				}
				if (num10 != 0)
				{
					continue;
				}
				if (flag14)
				{
					KeyValuePair<uint, IAPCustomStoreFrontData> sfpid2 = (KeyValuePair<uint, IAPCustomStoreFrontData>)0;
					Func<KeyValuePair<uint, IAPCustomStoreFrontData>, bool> func3 = (Func<KeyValuePair<uint, IAPCustomStoreFrontData>, bool>)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
					int num11 = Enumerable.Count<KeyValuePair<uint, IAPCustomStoreFrontData>>((IEnumerable<>)enumerable2);
					int num8 = num11;
					while (num11 == 1)
					{
					}
					object[] array6 = new object[4];
					if (func3 != null && array6 == null)
					{
						continue;
					}
					array6[0] = func3;
					if (func3 != null && array6 == null)
					{
						continue;
					}
					array6[1] = func3;
					if (array6 != null && array6 == null)
					{
						continue;
					}
					array6[2] = array6;
					if (num12 != 0 && num12 == 0)
					{
						continue;
					}
					array6[3] = num12;
					string text13 = string.Format("IAPData:{0} Found too many ProductID={1} found={2} expected={3}", array6);
				}
				if (num10 == 0)
				{
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x27AF7C0", Offset = "0x27AE1C0", VA = "0x1827AF7C0")]
		static IAPData()
		{
			MessageParser<ItemAmount> parser = ItemAmount._parser;
			uint num = default(uint);
			_parser = (MessageParser<IAPData>)(object)FieldCodec.ForMessage<ItemAmount>(num, (MessageParser<>)(object)parser);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<IAPStoreFrontData> parser2 = IAPStoreFrontData._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<IAPStoreFrontData>(num2, (MessageParser<>)(object)parser2);
			uint num3 = default(uint);
			_parser = (MessageParser<IAPData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num3);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<IAPCustomStoreFrontData> parser3 = IAPCustomStoreFrontData._parser;
			uint num4 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<IAPCustomStoreFrontData>(num4, (MessageParser<>)(object)parser3);
			uint num5 = default(uint);
			_parser = (MessageParser<IAPData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num5);
			/*Error: Unexpected end of block*/;
		}
	}
}
