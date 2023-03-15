using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003FC")]
	public sealed class FishingDataItemData : IMessage<FishingDataItemData>, IMessage, IEquatable<FishingDataItemData>, IDeepCloneable<FishingDataItemData>, IMessageFieldAccessor, IItemData, IDataValidation, IActivityDataItemData
	{
		[Cpp2IlInjected.Token(Token = "0x40015AD")]
		private static readonly MessageParser<FishingDataItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015AE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40015AF")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015B0")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40015B1")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015B2")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015B3")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015B4")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015B5")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015B6")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015B7")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40015B8")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015B9")]
		public const int ResultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40015BA")]
		private ItemWithState result_;

		[Cpp2IlInjected.Token(Token = "0x40015BB")]
		public const int RarityFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40015BC")]
		private FishRarity rarity_;

		[Cpp2IlInjected.Token(Token = "0x40015BD")]
		public const int WeightPercentageFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40015BE")]
		private int weightPercentage_;

		[Cpp2IlInjected.Token(Token = "0x40015BF")]
		public const int LocationsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x40015C0")]
		private static readonly FieldCodec<VillageAreaType> _repeated_locations_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40015C1")]
		private readonly RepeatedField<VillageAreaType> locations_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40015C2")]
		public const int AppearanceConditionFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40015C3")]
		private string appearanceCondition_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015C4")]
		public const int SpecificWeatherFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40015C5")]
		private bool specificWeather_;

		[Cpp2IlInjected.Token(Token = "0x40015C6")]
		public const int WeathersFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40015C7")]
		private static readonly FieldCodec<string> _repeated_weathers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40015C8")]
		private readonly RepeatedField<string> weathers_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40015C9")]
		public const int IsHiddenFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40015CA")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x17000C64")]
		[DebuggerNonUserCode]
		public static MessageParser<FishingDataItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003075")]
			[Cpp2IlInjected.Address(RVA = "0x357D630", Offset = "0x357C030", VA = "0x18357D630")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C65")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003076")]
			[Cpp2IlInjected.Address(RVA = "0x357D560", Offset = "0x357BF60", VA = "0x18357D560")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C66")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003077")]
			[Cpp2IlInjected.Address(RVA = "0x357D690", Offset = "0x357C090", VA = "0x18357D690", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C67")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600307C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600307D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C68")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600307E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600307F")]
			[Cpp2IlInjected.Address(RVA = "0x357D8F0", Offset = "0x357C2F0", VA = "0x18357D8F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C69")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003080")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003081")]
			[Cpp2IlInjected.Address(RVA = "0x357D810", Offset = "0x357C210", VA = "0x18357D810")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6003082")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003083")]
			[Cpp2IlInjected.Address(RVA = "0x357D880", Offset = "0x357C280", VA = "0x18357D880")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6003084")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003085")]
			[Cpp2IlInjected.Address(RVA = "0x357D960", Offset = "0x357C360", VA = "0x18357D960")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6C")]
		[DebuggerNonUserCode]
		public ItemWithState Result
		{
			[Cpp2IlInjected.Token(Token = "0x6003086")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003087")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				result_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6D")]
		[DebuggerNonUserCode]
		public FishRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003088")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003089")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6E")]
		[DebuggerNonUserCode]
		public int WeightPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x600308A")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return weightPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x600308B")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				weightPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6F")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> Locations
		{
			[Cpp2IlInjected.Token(Token = "0x600308C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return locations_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C70")]
		[DebuggerNonUserCode]
		public string AppearanceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x600308D")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return appearanceCondition_;
			}
			[Cpp2IlInjected.Token(Token = "0x600308E")]
			[Cpp2IlInjected.Address(RVA = "0x357D7A0", Offset = "0x357C1A0", VA = "0x18357D7A0")]
			set
			{
				string text = (appearanceCondition_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C71")]
		[DebuggerNonUserCode]
		public bool SpecificWeather
		{
			[Cpp2IlInjected.Token(Token = "0x600308F")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return specificWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003090")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				specificWeather_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C72")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Weathers
		{
			[Cpp2IlInjected.Token(Token = "0x6003091")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return weathers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C73")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6003092")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003093")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C74")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600309F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C75")]
		Item IActivityDataItemData.ResultItem
		{
			[Cpp2IlInjected.Token(Token = "0x60030A0")]
			[Cpp2IlInjected.Address(RVA = "0x1D32670", Offset = "0x1D31070", VA = "0x181D32670", Slot = "22")]
			get
			{
				//Discarded unreachable code: IL_000c
				return result_.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003078")]
		[Cpp2IlInjected.Address(RVA = "0x357D3E0", Offset = "0x357BDE0", VA = "0x18357D3E0")]
		[DebuggerNonUserCode]
		public FishingDataItemData()
		{
			//IL_0071: Expected I4, but got I8
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
		}

		[Cpp2IlInjected.Token(Token = "0x6003079")]
		[Cpp2IlInjected.Address(RVA = "0x357C680", Offset = "0x357B080", VA = "0x18357C680")]
		private void OnConstruction()
		{
			//IL_001a: Expected I4, but got I8
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
		}

		[Cpp2IlInjected.Token(Token = "0x600307A")]
		[Cpp2IlInjected.Address(RVA = "0x357D100", Offset = "0x357BB00", VA = "0x18357D100")]
		[DebuggerNonUserCode]
		public FishingDataItemData(FishingDataItemData other)
		{
			//IL_0071: Expected I4, but got I8
			//IL_00e0: Expected O, but got I4
			ItemWithState itemWithState = (result_ = new ItemWithState());
			weightPercentage_ = 1000;
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			ItemWithState itemWithState2 = other.result_;
			if (itemWithState2 != null)
			{
				ItemWithState itemWithState3 = itemWithState2.Clone();
			}
			int num2 = 0;
			result_ = (ItemWithState)num2;
			FishRarity fishRarity = (rarity_ = other.rarity_);
			int num3 = (weightPercentage_ = other.weightPercentage_);
			RepeatedField<VillageAreaType> repeatedField = (locations_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.locations_).Clone());
			string text5 = (appearanceCondition_ = other.appearanceCondition_);
			bool flag = (specificWeather_ = other.specificWeather_);
			RepeatedField<string> repeatedField2 = (weathers_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.weathers_).Clone());
			bool flag2 = (isHidden_ = other.isHidden_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600307B")]
		[Cpp2IlInjected.Address(RVA = "0x357B860", Offset = "0x357A260", VA = "0x18357B860", Slot = "10")]
		[DebuggerNonUserCode]
		public FishingDataItemData Clone()
		{
			return new FishingDataItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003094")]
		[Cpp2IlInjected.Address(RVA = "0x357BB30", Offset = "0x357A530", VA = "0x18357BB30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003095")]
		[Cpp2IlInjected.Address(RVA = "0x357BB90", Offset = "0x357A590", VA = "0x18357BB90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishingDataItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									ItemWithState objB = other.result_;
									if (object.Equals(result_, objB))
									{
										FishRarity fishRarity = other.rarity_;
										if (rarity_ == fishRarity)
										{
											int num2 = other.weightPercentage_;
											if (weightPercentage_ == num2)
											{
												RepeatedField<VillageAreaType> repeatedField = locations_;
												RepeatedField<VillageAreaType> repeatedField2 = other.locations_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													string text5 = other.appearanceCondition_;
													if (!(appearanceCondition_ != text5))
													{
														bool flag = other.specificWeather_;
														if (specificWeather_ == flag)
														{
															RepeatedField<string> repeatedField3 = weathers_;
															RepeatedField<string> repeatedField4 = other.weathers_;
															if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
															{
																bool flag2 = other.isHidden_;
																if (isHidden_ == flag2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003096")]
		[Cpp2IlInjected.Address(RVA = "0x357BF10", Offset = "0x357A910", VA = "0x18357BF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f7
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			ItemWithState itemWithState = result_;
			if (itemWithState != null)
			{
				int hashCode5 = itemWithState.GetHashCode();
			}
			if (rarity_ != 0)
			{
			}
			if (weightPercentage_ != 0)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)locations_).GetHashCode();
			string text5 = appearanceCondition_;
			if (text5.m_stringLength != 0)
			{
				int hashCode7 = text5.GetHashCode();
			}
			if (specificWeather_)
			{
			}
			int hashCode8 = ((RepeatedField<T>)(object)weathers_).GetHashCode();
			if (isHidden_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003097")]
		[Cpp2IlInjected.Address(RVA = "0x357CB30", Offset = "0x357B530", VA = "0x18357CB30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003098")]
		[Cpp2IlInjected.Address(RVA = "0x357CB90", Offset = "0x357B590", VA = "0x18357CB90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_015e
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)result_ != 0)
			{
				ItemWithState value6 = result_;
				output.WriteMessage(value6);
			}
			if (rarity_ != 0)
			{
			}
			if (weightPercentage_ != 0)
			{
				int value7 = weightPercentage_;
				output.WriteInt32(value7);
			}
			RepeatedField<VillageAreaType> repeatedField = locations_;
			FieldCodec<VillageAreaType> repeated_locations_codec = _repeated_locations_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_locations_codec);
			if (appearanceCondition_.m_stringLength != 0)
			{
				string value8 = appearanceCondition_;
				output.WriteString(value8);
			}
			if (specificWeather_)
			{
				bool value9 = specificWeather_;
				output.WriteBool(value9);
			}
			RepeatedField<string> repeatedField2 = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_weathers_codec);
			if (isHidden_)
			{
				bool value10 = isHidden_;
				output.WriteBool(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003099")]
		[Cpp2IlInjected.Address(RVA = "0x357B1E0", Offset = "0x3579BE0", VA = "0x18357B1E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			ItemWithState itemWithState = result_;
			if (itemWithState != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(itemWithState);
				num8++;
				num2 += num8;
			}
			FishRarity fishRarity = rarity_;
			if (fishRarity != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)fishRarity);
				num9++;
				num2 += num9;
			}
			int num10 = weightPercentage_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			RepeatedField<VillageAreaType> repeatedField = locations_;
			FieldCodec<VillageAreaType> repeated_locations_codec = _repeated_locations_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_locations_codec);
			string text5 = appearanceCondition_;
			num2 += num12;
			if (text5.m_stringLength != 0)
			{
				int num13 = CodedOutputStream.ComputeStringSize(text5);
				num13++;
				num2 += num13;
			}
			RepeatedField<string> repeatedField2 = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_weathers_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<string>)(repeatedField2 + num15);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600309A")]
		[Cpp2IlInjected.Address(RVA = "0x357C4A0", Offset = "0x357AEA0", VA = "0x18357C4A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingDataItemData other)
		{
			//Discarded unreachable code: IL_0174
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if ((long)other.result_ != 0)
			{
				ItemWithState itemWithState2 = default(ItemWithState);
				if (result_ == null)
				{
					ItemWithState itemWithState = (result_ = new ItemWithState());
					itemWithState2 = result_;
				}
				ItemWithState other2 = other.result_;
				itemWithState2.MergeFrom(other2);
			}
			FishRarity fishRarity = other.rarity_;
			if (fishRarity != 0)
			{
				rarity_ = fishRarity;
			}
			int num2 = other.weightPercentage_;
			if (num2 != 0)
			{
				weightPercentage_ = num2;
			}
			RepeatedField<VillageAreaType> repeatedField = locations_;
			RepeatedField<VillageAreaType> repeatedField2 = other.locations_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text5 = other.appearanceCondition_;
			if (text5.m_stringLength != 0)
			{
				AppearanceCondition = text5;
			}
			bool flag = other.specificWeather_;
			if (flag)
			{
				specificWeather_ = flag;
			}
			RepeatedField<string> repeatedField3 = weathers_;
			RepeatedField<string> repeatedField4 = other.weathers_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			bool flag2 = other.isHidden_;
			if (flag2)
			{
				isHidden_ = flag2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600309B")]
		[Cpp2IlInjected.Address(RVA = "0x357C180", Offset = "0x357AB80", VA = "0x18357C180", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01a8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 74)
				{
					if ((int)num > 88)
					{
						if (num == 98)
						{
							RepeatedField<string> repeatedField = weathers_;
							FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_weathers_codec);
						}
						if (num != 104)
						{
							goto IL_0191;
						}
						bool flag = (isHidden_ = input.ReadBool());
					}
					string text2 = default(string);
					if (num == 82)
					{
						text2 = (AppearanceCondition = input.ReadString());
					}
					if ((long)text2 != 88)
					{
						goto IL_0191;
					}
					bool flag2 = (specificWeather_ = input.ReadBool());
				}
				int num2 = default(int);
				if (num == 64)
				{
					num2 = (weightPercentage_ = input.ReadInt32());
				}
				num2 += -72;
				if (num2 != -3)
				{
					goto IL_0191;
				}
				RepeatedField<VillageAreaType> repeatedField2 = locations_;
				FieldCodec<VillageAreaType> repeated_locations_codec = _repeated_locations_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_locations_codec);
			}
			string text6 = default(string);
			if ((int)num > 26)
			{
				int num3 = default(int);
				if ((int)num > 42)
				{
					ItemWithState itemWithState = default(ItemWithState);
					if (num == 50)
					{
						ItemWithState builder = default(ItemWithState);
						if (result_ == null)
						{
							itemWithState = (result_ = new ItemWithState());
							builder = result_;
						}
						input.ReadMessage(builder);
					}
					if ((long)itemWithState != 56)
					{
						goto IL_0191;
					}
					num3 = (int)(rarity_ = (FishRarity)input.ReadInt32());
				}
				string text4 = default(string);
				if (num3 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_0191;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text6 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num4 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_0191;
			IL_0191:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600309C")]
		[Cpp2IlInjected.Address(RVA = "0x357BD20", Offset = "0x357A720", VA = "0x18357BD20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600309D")]
		[Cpp2IlInjected.Address(RVA = "0x357C6F0", Offset = "0x357B0F0", VA = "0x18357C6F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0022, IL_002a, IL_002b, IL_0038, IL_0040, IL_0048, IL_004e, IL_0054, IL_005a, IL_0060, IL_0066
			//IL_000e: Expected I4, but got O
			//IL_001a: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600309E")]
		[Cpp2IlInjected.Address(RVA = "0x357B6A0", Offset = "0x357A0A0", VA = "0x18357B6A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001c
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030A1")]
		[Cpp2IlInjected.Address(RVA = "0x357B860", Offset = "0x357A260", VA = "0x18357B860", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FishingDataItemData fishingDataItemData = new FishingDataItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030A2")]
		[Cpp2IlInjected.Address(RVA = "0x357B8C0", Offset = "0x357A2C0", VA = "0x18357B8C0", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			if ((object)result_.Item == null)
			{
				ItemWithState itemWithState = result_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemWithState.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					Item item2 = result_.Item;
					IItemData itemData2 = default(IItemData);
					if (itemData2.IsMissionItem())
					{
						if (!isHidden_)
						{
							context.AddInvalidMemberError("Must be true for MissionItem (that include RequestItem)", "IsHidden");
						}
					}
					else
					{
						RepeatedField<VillageAreaType> cpp2il__autoParamName__idx_ = locations_;
						context.RequireNotEmpty<VillageAreaType>((IEnumerable<>)(object)cpp2il__autoParamName__idx_, "Locations");
					}
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030A3")]
		[Cpp2IlInjected.Address(RVA = "0x357C0F0", Offset = "0x357AAF0", VA = "0x18357C0F0")]
		public bool IsSpawnableInLocation(VillageAreaType location)
		{
			//Discarded unreachable code: IL_0019
			if (((RepeatedField<T>)(object)locations_).Count == 0)
			{
				return true;
			}
			RepeatedField<VillageAreaType> repeatedField = locations_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60030A4")]
		[Cpp2IlInjected.Address(RVA = "0x357B520", Offset = "0x3579F20", VA = "0x18357B520")]
		public bool CanAppearAtLocalTime(DateTime localTime)
		{
			//Discarded unreachable code: IL_002c
			string text = appearanceCondition_;
			if ((object)typeof(ProtoDatabase).TypeHandle != null)
			{
				return true;
			}
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			string text2 = appearanceCondition_;
			return _003CInstance_003Ek__BackingField.Get<TimeOfDay>(text2).IsTimeWithinInterval(localTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60030A5")]
		[Cpp2IlInjected.Address(RVA = "0x357B630", Offset = "0x357A030", VA = "0x18357B630")]
		public bool CanAppearInWeather(string weather)
		{
			//Discarded unreachable code: IL_0018
			if (!specificWeather_)
			{
				return true;
			}
			return ((RepeatedField<T>)(object)weathers_).Contains((T)weather);
		}

		[Cpp2IlInjected.Token(Token = "0x60030A6")]
		[Cpp2IlInjected.Address(RVA = "0x357CEC0", Offset = "0x357B8C0", VA = "0x18357CEC0")]
		static FishingDataItemData()
		{
			Func<FishingDataItemData> func = default(Func<FishingDataItemData>);
			MessageParser<FishingDataItemData> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<FishingDataItemData>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<FishingDataItemData>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			_parser = (MessageParser<FishingDataItemData>)(object)FieldCodec.ForString(98u);
			/*Error: Unexpected end of block*/;
		}
	}
}
