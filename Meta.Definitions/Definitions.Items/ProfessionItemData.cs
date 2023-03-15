using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000330")]
	public sealed class ProfessionItemData : IMessage<ProfessionItemData>, IMessage, IEquatable<ProfessionItemData>, IDeepCloneable<ProfessionItemData>, IMessageFieldAccessor, IItemData, IHasGlotID
	{
		[Cpp2IlInjected.Token(Token = "0x2000331")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000332")]
			public sealed class HangoutBuffData : IMessage<HangoutBuffData>, IMessage, IEquatable<HangoutBuffData>, IDeepCloneable<HangoutBuffData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001034")]
				private static readonly MessageParser<HangoutBuffData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001035")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001036")]
				public const int BuffTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001037")]
				private BuffType buffType_;

				[Cpp2IlInjected.Token(Token = "0x4001038")]
				public const int BuffStatFormulaFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001039")]
				private int buffStatFormula_;

				[Cpp2IlInjected.Token(Token = "0x1700091D")]
				[DebuggerNonUserCode]
				public static MessageParser<HangoutBuffData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002510")]
					[Cpp2IlInjected.Address(RVA = "0x236D4E0", Offset = "0x236BEE0", VA = "0x18236D4E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700091E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002511")]
					[Cpp2IlInjected.Address(RVA = "0x236D460", Offset = "0x236BE60", VA = "0x18236D460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700091F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002512")]
					[Cpp2IlInjected.Address(RVA = "0x236D540", Offset = "0x236BF40", VA = "0x18236D540", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000920")]
				[DebuggerNonUserCode]
				public BuffType BuffType
				{
					[Cpp2IlInjected.Token(Token = "0x6002516")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(BuffType);
					}
					[Cpp2IlInjected.Token(Token = "0x6002517")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000921")]
				[DebuggerNonUserCode]
				public int BuffStatFormula
				{
					[Cpp2IlInjected.Token(Token = "0x6002518")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002519")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002513")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public HangoutBuffData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002514")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public HangoutBuffData(HangoutBuffData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002515")]
				[Cpp2IlInjected.Address(RVA = "0x236D010", Offset = "0x236BA10", VA = "0x18236D010", Slot = "10")]
				[DebuggerNonUserCode]
				public HangoutBuffData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600251A")]
				[Cpp2IlInjected.Address(RVA = "0x236D0A0", Offset = "0x236BAA0", VA = "0x18236D0A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600251B")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(HangoutBuffData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600251C")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600251D")]
				[Cpp2IlInjected.Address(RVA = "0x236D2F0", Offset = "0x236BCF0", VA = "0x18236D2F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600251E")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600251F")]
				[Cpp2IlInjected.Address(RVA = "0x236CF40", Offset = "0x236B940", VA = "0x18236CF40", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002520")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(HangoutBuffData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002521")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002522")]
				[Cpp2IlInjected.Address(RVA = "0x236D130", Offset = "0x236BB30", VA = "0x18236D130", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002523")]
				[Cpp2IlInjected.Address(RVA = "0x236D220", Offset = "0x236BC20", VA = "0x18236D220", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002524")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400101E")]
		private static readonly MessageParser<ProfessionItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400101F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001020")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001021")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001022")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001023")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001024")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001025")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001026")]
		public const int DescriptionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001027")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001028")]
		public const int IconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001029")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400102A")]
		public const int HangoutBuffsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400102B")]
		private static readonly FieldCodec<Types.HangoutBuffData> _repeated_hangoutBuffs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400102C")]
		private readonly RepeatedField<Types.HangoutBuffData> hangoutBuffs_ = (RepeatedField<Types.HangoutBuffData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400102D")]
		public const int IsUniqueFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400102E")]
		private bool isUnique_;

		[Cpp2IlInjected.Token(Token = "0x400102F")]
		public const int HangoutPreferredActivitiesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001030")]
		private static readonly FieldCodec<HangoutActivityType> _repeated_hangoutPreferredActivities_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001031")]
		private readonly RepeatedField<HangoutActivityType> hangoutPreferredActivities_ = (RepeatedField<HangoutActivityType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001032")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001033")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x1700090F")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfessionItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60024EB")]
			[Cpp2IlInjected.Address(RVA = "0x28874A0", Offset = "0x2885EA0", VA = "0x1828874A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000910")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60024EC")]
			[Cpp2IlInjected.Address(RVA = "0x28873D0", Offset = "0x2885DD0", VA = "0x1828873D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000911")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60024ED")]
			[Cpp2IlInjected.Address(RVA = "0x2887540", Offset = "0x2885F40", VA = "0x182887540", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000912")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60024F1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024F2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000913")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60024F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024F4")]
			[Cpp2IlInjected.Address(RVA = "0x28877A0", Offset = "0x28861A0", VA = "0x1828877A0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000914")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60024F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024F6")]
			[Cpp2IlInjected.Address(RVA = "0x28876C0", Offset = "0x28860C0", VA = "0x1828876C0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000915")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60024F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024F8")]
			[Cpp2IlInjected.Address(RVA = "0x2887650", Offset = "0x2886050", VA = "0x182887650")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000916")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60024F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024FA")]
			[Cpp2IlInjected.Address(RVA = "0x2887730", Offset = "0x2886130", VA = "0x182887730")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000917")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.HangoutBuffData> HangoutBuffs
		{
			[Cpp2IlInjected.Token(Token = "0x60024FB")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return hangoutBuffs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000918")]
		[DebuggerNonUserCode]
		public bool IsUnique
		{
			[Cpp2IlInjected.Token(Token = "0x60024FC")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get
			{
				return isUnique_;
			}
			[Cpp2IlInjected.Token(Token = "0x60024FD")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			set
			{
				isUnique_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000919")]
		[DebuggerNonUserCode]
		public RepeatedField<HangoutActivityType> HangoutPreferredActivities
		{
			[Cpp2IlInjected.Token(Token = "0x60024FE")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return hangoutPreferredActivities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700091A")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60024FF")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002500")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700091B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600250C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700091C")]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600250D")]
			[Cpp2IlInjected.Address(RVA = "0x2887500", Offset = "0x2885F00", VA = "0x182887500", Slot = "19")]
			get
			{
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024EE")]
		[Cpp2IlInjected.Address(RVA = "0x2887070", Offset = "0x2885A70", VA = "0x182887070")]
		[DebuggerNonUserCode]
		public ProfessionItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60024EF")]
		[Cpp2IlInjected.Address(RVA = "0x2887190", Offset = "0x2885B90", VA = "0x182887190")]
		[DebuggerNonUserCode]
		public ProfessionItemData(ProfessionItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (description_ = other.description_);
			string text4 = (iconAddress_ = other.iconAddress_);
			RepeatedField<Types.HangoutBuffData> repeatedField = (hangoutBuffs_ = (RepeatedField<Types.HangoutBuffData>)(object)((RepeatedField<T>)(object)other.hangoutBuffs_).Clone());
			bool flag = (isUnique_ = other.isUnique_);
			RepeatedField<HangoutActivityType> repeatedField2 = (hangoutPreferredActivities_ = (RepeatedField<HangoutActivityType>)(object)((RepeatedField<T>)(object)other.hangoutPreferredActivities_).Clone());
			uint num2 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024F0")]
		[Cpp2IlInjected.Address(RVA = "0x2885DC0", Offset = "0x28847C0", VA = "0x182885DC0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfessionItemData Clone()
		{
			return new ProfessionItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002501")]
		[Cpp2IlInjected.Address(RVA = "0x2885F60", Offset = "0x2884960", VA = "0x182885F60", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(ProfessionItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = description_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = iconAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									RepeatedField<Types.HangoutBuffData> repeatedField = hangoutBuffs_;
									bool flag5 = default(bool);
									if (flag5 && isUnique_ == flag5)
									{
										RepeatedField<HangoutActivityType> repeatedField2 = hangoutPreferredActivities_;
										bool flag6 = default(bool);
										if (flag6 && glotID_ == (flag6 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002502")]
		[Cpp2IlInjected.Address(RVA = "0x2885E20", Offset = "0x2884820", VA = "0x182885E20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfessionItemData other)
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
							string text3 = other.description_;
							if (!(description_ != text3))
							{
								string text4 = other.iconAddress_;
								if (!(iconAddress_ != text4))
								{
									RepeatedField<Types.HangoutBuffData> repeatedField = hangoutBuffs_;
									RepeatedField<Types.HangoutBuffData> repeatedField2 = other.hangoutBuffs_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										bool flag = other.isUnique_;
										if (isUnique_ == flag)
										{
											RepeatedField<HangoutActivityType> repeatedField3 = hangoutPreferredActivities_;
											RepeatedField<HangoutActivityType> repeatedField4 = other.hangoutPreferredActivities_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												uint num2 = other.glotID_;
												if (glotID_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002503")]
		[Cpp2IlInjected.Address(RVA = "0x28862A0", Offset = "0x2884CA0", VA = "0x1828862A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b5
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
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)hangoutBuffs_).GetHashCode();
			if (isUnique_)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)hangoutPreferredActivities_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002504")]
		[Cpp2IlInjected.Address(RVA = "0x2886AC0", Offset = "0x28854C0", VA = "0x182886AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002505")]
		[Cpp2IlInjected.Address(RVA = "0x2886B20", Offset = "0x2885520", VA = "0x182886B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0104
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
			if (description_.m_stringLength != 0)
			{
				string value4 = description_;
				output.WriteString(value4);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value5 = iconAddress_;
				output.WriteString(value5);
			}
			RepeatedField<Types.HangoutBuffData> repeatedField = hangoutBuffs_;
			FieldCodec<Types.HangoutBuffData> repeated_hangoutBuffs_codec = _repeated_hangoutBuffs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_hangoutBuffs_codec);
			if (isUnique_)
			{
				bool value6 = isUnique_;
				output.WriteBool(value6);
			}
			RepeatedField<HangoutActivityType> repeatedField2 = hangoutPreferredActivities_;
			FieldCodec<HangoutActivityType> repeated_hangoutPreferredActivities_codec = _repeated_hangoutPreferredActivities_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_hangoutPreferredActivities_codec);
			if (glotID_ != 0)
			{
				uint value7 = glotID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002506")]
		[Cpp2IlInjected.Address(RVA = "0x28859D0", Offset = "0x28843D0", VA = "0x1828859D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
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
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RepeatedField<Types.HangoutBuffData> repeatedField = hangoutBuffs_;
			FieldCodec<Types.HangoutBuffData> repeated_hangoutBuffs_codec = _repeated_hangoutBuffs_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_hangoutBuffs_codec);
			RepeatedField<HangoutActivityType> repeatedField2 = hangoutPreferredActivities_;
			FieldCodec<HangoutActivityType> repeated_hangoutPreferredActivities_codec = _repeated_hangoutPreferredActivities_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_hangoutPreferredActivities_codec);
			uint num10 = glotID_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeUInt32Size(num10);
				num11 += 2;
				repeatedField2 = (RepeatedField<HangoutActivityType>)(repeatedField2 + num11);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<HangoutActivityType>)(repeatedField2 + num12);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002507")]
		[Cpp2IlInjected.Address(RVA = "0x2886410", Offset = "0x2884E10", VA = "0x182886410", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfessionItemData other)
		{
			//Discarded unreachable code: IL_00f5
			if (other != null)
			{
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
				string text3 = other.description_;
				if (text3.m_stringLength != 0)
				{
					Description = text3;
				}
				string text4 = other.iconAddress_;
				if (text4.m_stringLength != 0)
				{
					IconAddress = text4;
				}
				RepeatedField<Types.HangoutBuffData> repeatedField = hangoutBuffs_;
				RepeatedField<Types.HangoutBuffData> repeatedField2 = other.hangoutBuffs_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.isUnique_;
				if (flag)
				{
					isUnique_ = flag;
				}
				RepeatedField<HangoutActivityType> repeatedField3 = hangoutPreferredActivities_;
				RepeatedField<HangoutActivityType> repeatedField4 = other.hangoutPreferredActivities_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				uint num2 = other.glotID_;
				if (num2 != 0)
				{
					glotID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002508")]
		[Cpp2IlInjected.Address(RVA = "0x2886550", Offset = "0x2884F50", VA = "0x182886550", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0122
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 56)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 7992)
						{
							goto IL_010b;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					RepeatedField<HangoutActivityType> repeatedField = hangoutPreferredActivities_;
					FieldCodec<HangoutActivityType> repeated_hangoutPreferredActivities_codec = _repeated_hangoutPreferredActivities_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_hangoutPreferredActivities_codec);
				}
				if (num == 50)
				{
					RepeatedField<Types.HangoutBuffData> repeatedField2 = hangoutBuffs_;
					FieldCodec<Types.HangoutBuffData> repeated_hangoutBuffs_codec = _repeated_hangoutBuffs_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_hangoutBuffs_codec);
				}
				if (num != 56)
				{
					goto IL_010b;
				}
				bool flag = (isUnique_ = input.ReadBool());
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (Description = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_010b;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text6 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_010b;
			IL_010b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002509")]
		[Cpp2IlInjected.Address(RVA = "0x28860F0", Offset = "0x2884AF0", VA = "0x1828860F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
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

		[Cpp2IlInjected.Token(Token = "0x600250A")]
		[Cpp2IlInjected.Address(RVA = "0x28867A0", Offset = "0x28851A0", VA = "0x1828867A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_0028, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_003f: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
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

		[Cpp2IlInjected.Token(Token = "0x600250B")]
		[Cpp2IlInjected.Address(RVA = "0x2885C60", Offset = "0x2884660", VA = "0x182885C60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0016, IL_0020
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 999)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600250E")]
		[Cpp2IlInjected.Address(RVA = "0x2885DC0", Offset = "0x28847C0", VA = "0x182885DC0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ProfessionItemData professionItemData = new ProfessionItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600250F")]
		[Cpp2IlInjected.Address(RVA = "0x2886DA0", Offset = "0x28857A0", VA = "0x182886DA0")]
		static ProfessionItemData()
		{
			Func<ProfessionItemData> func = default(Func<ProfessionItemData>);
			MessageParser<ProfessionItemData> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ProfessionItemData>)(object)new MessageParser<T>((Func<>)(object)func));
			MessageParser<Types.HangoutBuffData> parser = Types.HangoutBuffData._parser;
			uint num = default(uint);
			_parser = (MessageParser<ProfessionItemData>)(object)FieldCodec.ForMessage<Types.HangoutBuffData>(num, (MessageParser<>)(object)parser);
			Func<HangoutActivityType, int> func2 = (Func<HangoutActivityType, int>)(object)(Func<T, TResult>)((HangoutActivityType x) => (int)x);
			Func<int, HangoutActivityType> func3 = (Func<int, HangoutActivityType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num2 = default(uint);
			_parser = (MessageParser<ProfessionItemData>)(object)FieldCodec.ForEnum<HangoutActivityType>(num2, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
