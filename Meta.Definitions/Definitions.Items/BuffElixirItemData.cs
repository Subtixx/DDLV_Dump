using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002B0")]
	public sealed class BuffElixirItemData : IMessage<BuffElixirItemData>, IMessage, IEquatable<BuffElixirItemData>, IDeepCloneable<BuffElixirItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IBackpackItem, ISellable, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x20002B1")]
		public enum EndConditionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000B9A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000B9B")]
			Duration = 11,
			[Cpp2IlInjected.Token(Token = "0x4000B9C")]
			NumberOfUses = 12
		}

		[Cpp2IlInjected.Token(Token = "0x4000B7D")]
		private static readonly MessageParser<BuffElixirItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B7E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000B7F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B80")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000B81")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B82")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B83")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B84")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B85")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B86")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B87")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B88")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B89")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B8A")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000B8B")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B8C")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B8D")]
		public const int BuffTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B8E")]
		private BuffType buffType_;

		[Cpp2IlInjected.Token(Token = "0x4000B8F")]
		public const int PercentageEffectFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000B90")]
		private int percentageEffect_;

		[Cpp2IlInjected.Token(Token = "0x4000B91")]
		public const int BuffPersistenceFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B92")]
		private BuffPersistence buffPersistence_;

		[Cpp2IlInjected.Token(Token = "0x4000B93")]
		public const int DurationFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000B94")]
		public const int NumberOfUsesFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000B95")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000B96")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000B97")]
		private object endCondition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000B98")]
		private EndConditionOneofCase endConditionCase_;

		[Cpp2IlInjected.Token(Token = "0x17000630")]
		[DebuggerNonUserCode]
		public static MessageParser<BuffElixirItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF4")]
			[Cpp2IlInjected.Address(RVA = "0x32EA520", Offset = "0x32E8F20", VA = "0x1832EA520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000631")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF5")]
			[Cpp2IlInjected.Address(RVA = "0x32EA380", Offset = "0x32E8D80", VA = "0x1832EA380")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000632")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF6")]
			[Cpp2IlInjected.Address(RVA = "0x32EA580", Offset = "0x32E8F80", VA = "0x1832EA580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000633")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000634")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BFE")]
			[Cpp2IlInjected.Address(RVA = "0x32EA820", Offset = "0x32E9220", VA = "0x1832EA820")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000635")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "27")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C00")]
			[Cpp2IlInjected.Address(RVA = "0x32EA700", Offset = "0x32E9100", VA = "0x1832EA700")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000636")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C02")]
			[Cpp2IlInjected.Address(RVA = "0x32EA7B0", Offset = "0x32E91B0", VA = "0x1832EA7B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000637")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C03")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C04")]
			[Cpp2IlInjected.Address(RVA = "0x32EA900", Offset = "0x32E9300", VA = "0x1832EA900")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000638")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001C05")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C06")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000639")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001C07")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "28")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C08")]
			[Cpp2IlInjected.Address(RVA = "0x32EA690", Offset = "0x32E9090", VA = "0x1832EA690")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063A")]
		[DebuggerNonUserCode]
		public BuffType BuffType
		{
			[Cpp2IlInjected.Token(Token = "0x6001C09")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return buffType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C0A")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				buffType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063B")]
		[DebuggerNonUserCode]
		public int PercentageEffect
		{
			[Cpp2IlInjected.Token(Token = "0x6001C0B")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return percentageEffect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C0C")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				percentageEffect_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063C")]
		[DebuggerNonUserCode]
		public BuffPersistence BuffPersistence
		{
			[Cpp2IlInjected.Token(Token = "0x6001C0D")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return buffPersistence_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C0E")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				buffPersistence_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063D")]
		[DebuggerNonUserCode]
		public Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001C0F")]
			[Cpp2IlInjected.Address(RVA = "0x32EA450", Offset = "0x32E8E50", VA = "0x1832EA450")]
			get
			{
				int num = 0;
				if (endConditionCase_ == EndConditionOneofCase.Duration)
				{
					object obj = endCondition_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001C10")]
			[Cpp2IlInjected.Address(RVA = "0x32EA770", Offset = "0x32E9170", VA = "0x1832EA770")]
			set
			{
				endCondition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063E")]
		[DebuggerNonUserCode]
		public int NumberOfUses
		{
			[Cpp2IlInjected.Token(Token = "0x6001C11")]
			[Cpp2IlInjected.Address(RVA = "0x32EA4B0", Offset = "0x32E8EB0", VA = "0x1832EA4B0")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUses)
				{
					object obj = endCondition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C12")]
			[Cpp2IlInjected.Address(RVA = "0x32EA890", Offset = "0x32E9290", VA = "0x1832EA890")]
			set
			{
				//IL_0015: Expected I4, but got I8
				endCondition_ = typeof(int).TypeHandle;
				endConditionCase_ = EndConditionOneofCase.NumberOfUses;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063F")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C13")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C14")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000640")]
		[DebuggerNonUserCode]
		public EndConditionOneofCase EndConditionCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001C15")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return endConditionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000641")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001C24")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "30")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000642")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001C25")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "29")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000643")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001C26")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "31")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF7")]
		[Cpp2IlInjected.Address(RVA = "0x32EA2A0", Offset = "0x32E8CA0", VA = "0x1832EA2A0")]
		[DebuggerNonUserCode]
		public BuffElixirItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF8")]
		[Cpp2IlInjected.Address(RVA = "0x32E9700", Offset = "0x32E8100", VA = "0x1832E9700")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF9")]
		[Cpp2IlInjected.Address(RVA = "0x32EA030", Offset = "0x32E8A30", VA = "0x1832EA030")]
		[DebuggerNonUserCode]
		public BuffElixirItemData(BuffElixirItemData other)
		{
			//IL_00b5: Expected O, but got I4
			//IL_0130: Expected I4, but got O
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			int num2 = 0;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			gridAreaData_ = (GridAreaData)num2;
			string text5 = (description_ = other.description_);
			BuffType buffType = (buffType_ = other.buffType_);
			int num3 = (percentageEffect_ = other.percentageEffect_);
			BuffPersistence buffPersistence = (buffPersistence_ = other.buffPersistence_);
			uint num4 = (glotID_ = other.glotID_);
			Duration duration = default(Duration);
			if (other.endConditionCase_ == EndConditionOneofCase.Duration)
			{
				EndConditionOneofCase endConditionOneofCase = other.endConditionCase_;
				if (other.endCondition_ == null)
				{
					throw new InvalidCastException();
				}
				endCondition_ = duration;
				endConditionCase_ = (EndConditionOneofCase)duration;
			}
			if ((long)duration == 12)
			{
				int num5 = (NumberOfUses = other.NumberOfUses);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BFA")]
		[Cpp2IlInjected.Address(RVA = "0x32E87F0", Offset = "0x32E71F0", VA = "0x1832E87F0", Slot = "10")]
		[DebuggerNonUserCode]
		public BuffElixirItemData Clone()
		{
			return new BuffElixirItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C16")]
		[Cpp2IlInjected.Address(RVA = "0x31F2DE0", Offset = "0x31F17E0", VA = "0x1831F2DE0")]
		[DebuggerNonUserCode]
		public void ClearEndCondition()
		{
			//IL_0010: Expected O, but got I4
			endCondition_ = (endConditionCase_ = EndConditionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C17")]
		[Cpp2IlInjected.Address(RVA = "0x32E89D0", Offset = "0x32E73D0", VA = "0x1832E89D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_00e0: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(BuffElixirItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && object.Equals(gridAreaData_, other))
								{
									string text5 = description_;
									bool flag5 = default(bool);
									Duration objB = default(Duration);
									if (!flag5 && buffType_ == (flag5 ? BuffType.FriendshipGained : BuffType.None) && percentageEffect_ == (flag5 ? 1 : 0) && buffPersistence_ == (flag5 ? BuffPersistence.Transient : BuffPersistence.Persisted) && object.Equals(Duration, objB))
									{
										int numberOfUses = NumberOfUses;
										int num = 0;
										int num2 = default(int);
										if (numberOfUses == num2 && glotID_ == (uint)num2 && endConditionCase_ == (EndConditionOneofCase)num2)
										{
											return object.Equals(_unknownFields, num);
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C18")]
		[Cpp2IlInjected.Address(RVA = "0x32E8850", Offset = "0x32E7250", VA = "0x1832E8850", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuffElixirItemData other)
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
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										string text5 = other.description_;
										if (!(description_ != text5))
										{
											BuffType buffType = other.buffType_;
											if (buffType_ == buffType)
											{
												int num2 = other.percentageEffect_;
												if (percentageEffect_ == num2)
												{
													BuffPersistence buffPersistence = other.buffPersistence_;
													if (buffPersistence_ == buffPersistence)
													{
														Duration duration = Duration;
														Duration duration2 = other.Duration;
														if (object.Equals(duration, duration2))
														{
															int numberOfUses = NumberOfUses;
															int numberOfUses2 = other.NumberOfUses;
															if (numberOfUses == numberOfUses2)
															{
																uint num3 = other.glotID_;
																if (glotID_ == num3)
																{
																	EndConditionOneofCase endConditionOneofCase = other.endConditionCase_;
																	if (endConditionCase_ == endConditionOneofCase)
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
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C19")]
		[Cpp2IlInjected.Address(RVA = "0x32E8DB0", Offset = "0x32E77B0", VA = "0x1832E8DB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0122
			do
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				GridAreaData gridAreaData = gridAreaData_;
				if (gridAreaData != null)
				{
					int hashCode5 = gridAreaData.GetHashCode();
				}
				string text5 = description_;
				if (text5.m_stringLength != num2)
				{
					int hashCode6 = text5.GetHashCode();
				}
				if (buffType_ != 0)
				{
				}
				if (percentageEffect_ != 0)
				{
				}
				if (buffPersistence_ != 0)
				{
				}
			}
			while (endConditionCase_ != EndConditionOneofCase.Duration);
			object obj = endCondition_;
			if (obj != null)
			{
				int hashCode7 = obj.GetHashCode();
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUses && endConditionCase_ == EndConditionOneofCase.NumberOfUses)
				{
					object obj2 = endCondition_;
				}
				if (glotID_ != 0)
				{
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode8 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1A")]
		[Cpp2IlInjected.Address(RVA = "0x32E9BC0", Offset = "0x32E85C0", VA = "0x1832E9BC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1B")]
		[Cpp2IlInjected.Address(RVA = "0x32E9C20", Offset = "0x32E8620", VA = "0x1832E9C20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0160
			do
			{
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
				if ((long)gridAreaData_ != 0)
				{
					GridAreaData value6 = gridAreaData_;
					output.WriteMessage(value6);
				}
				if (description_.m_stringLength != 0)
				{
					string value7 = description_;
					output.WriteString(value7);
				}
				if (buffType_ != 0)
				{
				}
				if (percentageEffect_ != 0)
				{
					int value8 = percentageEffect_;
					output.WriteInt32(value8);
				}
				if (buffPersistence_ != 0)
				{
				}
			}
			while (endConditionCase_ != EndConditionOneofCase.Duration);
			if (endConditionCase_ == EndConditionOneofCase.Duration)
			{
				object obj = endCondition_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (endConditionCase_ == EndConditionOneofCase.NumberOfUses)
			{
				int numberOfUses = NumberOfUses;
				output.WriteInt32(numberOfUses);
			}
			if (glotID_ != 0)
			{
				uint value9 = glotID_;
				output.WriteUInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1C")]
		[Cpp2IlInjected.Address(RVA = "0x32E8200", Offset = "0x32E6C00", VA = "0x1832E8200", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01e6
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			string text5 = description_;
			if (text5.m_stringLength != num2)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			BuffType buffType = buffType_;
			if (buffType != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)buffType);
				num10++;
				num2 += num10;
			}
			int num11 = percentageEffect_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			BuffPersistence buffPersistence = buffPersistence_;
			if (buffPersistence != 0)
			{
				int num13 = CodedOutputStream.ComputeEnumSize((int)buffPersistence);
				num13++;
				num2 += num13;
			}
			if (endConditionCase_ == EndConditionOneofCase.Duration)
			{
				if (endConditionCase_ != EndConditionOneofCase.Duration)
				{
				}
				object obj = endCondition_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num14 = default(int);
				num2 += num14;
			}
			if (endConditionCase_ == EndConditionOneofCase.NumberOfUses)
			{
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUses)
				{
					object obj2 = endCondition_;
				}
				num2++;
				int num15 = default(int);
				num2 += num15;
			}
			uint num16 = glotID_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeUInt32Size(num16);
				num17 += 2;
				num2 += num17;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num18 = unknownFields.CalculateSize();
				num2 += num18;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1D")]
		[Cpp2IlInjected.Address(RVA = "0x32E93F0", Offset = "0x32E7DF0", VA = "0x1832E93F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuffElixirItemData other)
		{
			//Discarded unreachable code: IL_01e8
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
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
			}
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			BuffType buffType = other.buffType_;
			if (buffType != 0)
			{
				buffType_ = buffType;
			}
			int num2 = other.percentageEffect_;
			if (num2 != 0)
			{
				percentageEffect_ = num2;
			}
			BuffPersistence buffPersistence = other.buffPersistence_;
			if (buffPersistence != 0)
			{
				buffPersistence_ = buffPersistence;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			if (other.endConditionCase_ == EndConditionOneofCase.Duration)
			{
				EndConditionOneofCase endConditionOneofCase = endConditionCase_;
				object obj = default(object);
				if (endConditionOneofCase == EndConditionOneofCase.Duration)
				{
					obj = endCondition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Duration duration = (Duration)(endCondition_ = new Duration());
					endConditionCase_ = endConditionOneofCase;
				}
				if (endConditionCase_ == EndConditionOneofCase.Duration)
				{
					object obj2 = endCondition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.endConditionCase_ == EndConditionOneofCase.Duration)
				{
					object obj3 = other.endCondition_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Duration).TypeHandle == 12)
			{
				int num4 = (NumberOfUses = other.NumberOfUses);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1E")]
		[Cpp2IlInjected.Address(RVA = "0x32E90E0", Offset = "0x32E7AE0", VA = "0x1832E90E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00bc: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 72)
				{
					if ((int)num > 90)
					{
						if (num == 96)
						{
							int num3 = (NumberOfUses = input.ReadInt32());
						}
						if (num != 7992)
						{
							goto IL_01ac;
						}
						int num4 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num5 = default(int);
					if (num == 80)
					{
						num5 = (int)(buffPersistence_ = (BuffPersistence)input.ReadInt32());
					}
					if (num5 != 90)
					{
						goto IL_01ac;
					}
					Duration builder = new Duration();
					if (endConditionCase_ == EndConditionOneofCase.Duration)
					{
						if (endConditionCase_ != EndConditionOneofCase.Duration)
						{
						}
						object obj = endCondition_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					endCondition_ = builder;
					endConditionCase_ = (EndConditionOneofCase)typeof(Duration).TypeHandle;
				}
				string text2 = default(string);
				if (num == 58)
				{
					text2 = (Description = input.ReadString());
				}
				int num6 = default(int);
				if ((long)text2 == 64)
				{
					num6 = (int)(buffType_ = (BuffType)input.ReadInt32());
				}
				if (num6 != 72)
				{
					goto IL_01ac;
				}
				int num7 = (percentageEffect_ = input.ReadInt32());
			}
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 26)
			{
				string text4 = default(string);
				if (num == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 42)
				{
					text6 = (PrefabAddress = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_01ac;
				}
				GridAreaData builder2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder2 = gridAreaData_;
				}
				input.ReadMessage(builder2);
			}
			int num8 = default(int);
			if ((long)gridAreaData == 8)
			{
				num8 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num8 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_01ac;
			IL_01ac:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1F")]
		[Cpp2IlInjected.Address(RVA = "0x32E8B90", Offset = "0x32E7590", VA = "0x1832E8B90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C20")]
		[Cpp2IlInjected.Address(RVA = "0x32E9760", Offset = "0x32E8160", VA = "0x1832E9760", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_002b, IL_0031, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061, IL_0067
			//IL_000e: Expected I4, but got O
			//IL_002a: Expected I4, but got O
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C21")]
		[Cpp2IlInjected.Address(RVA = "0x32E85D0", Offset = "0x32E6FD0", VA = "0x1832E85D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0014, IL_0020, IL_002c, IL_0038, IL_0044, IL_0059, IL_0063, IL_006d, IL_0079, IL_008d
			//IL_004d: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C22")]
		[Cpp2IlInjected.Address(RVA = "0x32E9030", Offset = "0x32E7A30", VA = "0x1832E9030", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "EndCondition"))
			{
				EndConditionOneofCase endConditionOneofCase = endConditionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C23")]
		[Cpp2IlInjected.Address(RVA = "0x32E8780", Offset = "0x32E7180", VA = "0x1832E8780", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "EndCondition"))
			{
				endCondition_ = (endConditionCase_ = EndConditionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C27")]
		[Cpp2IlInjected.Address(RVA = "0x32E87F0", Offset = "0x32E71F0", VA = "0x1832E87F0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			BuffElixirItemData buffElixirItemData = new BuffElixirItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C28")]
		[Cpp2IlInjected.Address(RVA = "0x32E9F20", Offset = "0x32E8920", VA = "0x1832E9F20")]
		static BuffElixirItemData()
		{
			Func<BuffElixirItemData> func = default(Func<BuffElixirItemData>);
			_parser = (MessageParser<BuffElixirItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
