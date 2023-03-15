using System;
using System.Diagnostics;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class BattlePassReward : IMessage<BattlePassReward>, IMessage, IEquatable<BattlePassReward>, IDeepCloneable<BattlePassReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly MessageParser<BattlePassReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public const int EditorHeaderNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private string editorHeaderName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public const int ItemIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private int itemId_;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public const int AmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public const int PriceFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private int price_;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public const int IsPremiumFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private bool isPremium_;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public const int IsRecurrentFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private bool isRecurrent_;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x26F4ED0", Offset = "0x26F38D0", VA = "0x1826F4ED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x26F4E00", Offset = "0x26F3800", VA = "0x1826F4E00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x26F4F30", Offset = "0x26F3930", VA = "0x1826F4F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[DebuggerNonUserCode]
		public string EditorHeaderName
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return editorHeaderName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x26F5040", Offset = "0x26F3A40", VA = "0x1826F5040")]
			set
			{
				string text = (editorHeaderName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		[DebuggerNonUserCode]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return itemId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				itemId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[DebuggerNonUserCode]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return price_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				price_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[DebuggerNonUserCode]
		public bool IsPremium
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
			get
			{
				return isPremium_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
			set
			{
				isPremium_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[DebuggerNonUserCode]
		public bool IsRecurrent
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xDD84C0", Offset = "0xDD6EC0", VA = "0x180DD84C0")]
			get
			{
				return isRecurrent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xDD84D0", Offset = "0xDD6ED0", VA = "0x180DD84D0")]
			set
			{
				isRecurrent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x26F4DA0", Offset = "0x26F37A0", VA = "0x1826F4DA0")]
		[DebuggerNonUserCode]
		public BattlePassReward()
		{
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			amount_ = 1;
			price_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x26F4730", Offset = "0x26F3130", VA = "0x1826F4730")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			amount_ = 1;
			price_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x26F4CD0", Offset = "0x26F36D0", VA = "0x1826F4CD0")]
		[DebuggerNonUserCode]
		public BattlePassReward(BattlePassReward other)
		{
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			amount_ = 1;
			price_ = 1;
			string text = (editorHeaderName_ = other.editorHeaderName_);
			int num = (itemId_ = other.itemId_);
			int num2 = (amount_ = other.amount_);
			int num3 = (price_ = other.price_);
			bool flag = (isPremium_ = other.isPremium_);
			bool flag2 = (isRecurrent_ = other.isRecurrent_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x26F4010", Offset = "0x26F2A10", VA = "0x1826F4010", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassReward Clone()
		{
			//Discarded unreachable code: IL_0094
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			BattlePassReward battlePassReward = new BattlePassReward();
			battlePassReward.editorHeaderName_ = "";
			battlePassReward.amount_ = 1;
			battlePassReward.price_ = 1;
			string text = (battlePassReward.editorHeaderName_ = editorHeaderName_);
			int num = (battlePassReward.itemId_ = itemId_);
			int num2 = (battlePassReward.amount_ = amount_);
			int num3 = (battlePassReward.price_ = price_);
			bool flag = (battlePassReward.isPremium_ = isPremium_);
			bool flag2 = (battlePassReward.isRecurrent_ = isRecurrent_);
			UnknownFieldSet unknownFieldSet = (battlePassReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x26F4100", Offset = "0x26F2B00", VA = "0x1826F4100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = editorHeaderName_;
				bool flag = default(bool);
				if (!flag && itemId_ == (flag ? 1 : 0) && amount_ == (flag ? 1 : 0) && price_ == (flag ? 1 : 0) && isPremium_ == flag && isRecurrent_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x26F41E0", Offset = "0x26F2BE0", VA = "0x1826F41E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassReward other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.editorHeaderName_;
				if (!(editorHeaderName_ != text))
				{
					int num = other.itemId_;
					if (itemId_ == num)
					{
						int num2 = other.amount_;
						if (amount_ == num2)
						{
							int num3 = other.price_;
							if (price_ == num3)
							{
								bool flag = other.isPremium_;
								if (isPremium_ == flag)
								{
									bool flag2 = other.isRecurrent_;
									if (isRecurrent_ == flag2)
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
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x26F4490", Offset = "0x26F2E90", VA = "0x1826F4490", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005c
			string text = editorHeaderName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (itemId_ != 0)
			{
			}
			if (amount_ != 0)
			{
			}
			if (price_ != 0)
			{
			}
			if (isPremium_)
			{
			}
			if (isRecurrent_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x26F4A20", Offset = "0x26F3420", VA = "0x1826F4A20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x26F4A80", Offset = "0x26F3480", VA = "0x1826F4A80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a9
			if (editorHeaderName_.m_stringLength != 0)
			{
				string value = editorHeaderName_;
				output.WriteString(value);
			}
			if (itemId_ != 0)
			{
				int value2 = itemId_;
				output.WriteInt32(value2);
			}
			if (amount_ != 0)
			{
				int value3 = amount_;
				output.WriteInt32(value3);
			}
			if (price_ != 0)
			{
				int value4 = price_;
				output.WriteInt32(value4);
			}
			if (isPremium_)
			{
				bool value5 = isPremium_;
				output.WriteBool(value5);
			}
			if (isRecurrent_)
			{
				bool value6 = isRecurrent_;
				output.WriteBool(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x26F3E00", Offset = "0x26F2800", VA = "0x1826F3E00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0096
			string text = editorHeaderName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = itemId_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = amount_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			int num7 = price_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x26F4690", Offset = "0x26F3090", VA = "0x1826F4690", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassReward other)
		{
			//Discarded unreachable code: IL_009e
			if (other != null)
			{
				string text = other.editorHeaderName_;
				if (text.m_stringLength != 0)
				{
					EditorHeaderName = text;
				}
				int num = other.itemId_;
				if (num != 0)
				{
					itemId_ = num;
				}
				int num2 = other.amount_;
				if (num2 != 0)
				{
					amount_ = num2;
				}
				int num3 = other.price_;
				if (num3 != 0)
				{
					price_ = num3;
				}
				bool flag = other.isPremium_;
				if (flag)
				{
					isPremium_ = flag;
				}
				bool flag2 = other.isRecurrent_;
				if (flag2)
				{
					isRecurrent_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x26F4590", Offset = "0x26F2F90", VA = "0x1826F4590", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00aa
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (price_ = input.ReadInt32());
				}
				bool flag = default(bool);
				if (num == 40)
				{
					flag = (isPremium_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0093;
				}
				bool flag2 = (isRecurrent_ = input.ReadBool());
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (EditorHeaderName = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text2 == 16)
			{
				num3 = (itemId_ = input.ReadInt32());
			}
			if (num3 == 24)
			{
				int num4 = (amount_ = input.ReadInt32());
			}
			goto IL_0093;
			IL_0093:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x26F4340", Offset = "0x26F2D40", VA = "0x1826F4340", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				string text = editorHeaderName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x26F4740", Offset = "0x26F3140", VA = "0x1826F4740", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				EditorHeaderName = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x26F3F40", Offset = "0x26F2940", VA = "0x1826F3F40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014, IL_0015, IL_0017
			if (fieldNumber - 1 <= 5)
			{
				EditorHeaderName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x26F4960", Offset = "0x26F3360", VA = "0x1826F4960")]
		public glPlayFab.Disney.BattlePassReward ToServerReward()
		{
			//Discarded unreachable code: IL_0061
			glPlayFab.Disney.BattlePassReward battlePassReward = new glPlayFab.Disney.BattlePassReward();
			Content content = new Content();
			int num = (content.GameItemId = itemId_);
			int num2 = (content.Amount = amount_);
			battlePassReward.Content = content;
			int num3 = (battlePassReward.Price = price_);
			bool flag = (battlePassReward.IsPremium = isPremium_);
			bool flag2 = (battlePassReward.IsRecurrent = isRecurrent_);
			return battlePassReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x26F4270", Offset = "0x26F2C70", VA = "0x1826F4270")]
		public static BattlePassReward FromServerReward(glPlayFab.Disney.BattlePassReward serverReward)
		{
			//Discarded unreachable code: IL_0079
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			BattlePassReward battlePassReward = new BattlePassReward();
			battlePassReward.editorHeaderName_ = "";
			battlePassReward.amount_ = 1;
			battlePassReward.price_ = 1;
			int num = (battlePassReward.itemId_ = serverReward.Content.GameItemId);
			int num2 = (battlePassReward.amount_ = serverReward.Content.Amount);
			int num3 = (battlePassReward.price_ = serverReward.Price);
			bool flag = (battlePassReward.isPremium_ = serverReward.IsPremium);
			bool flag2 = (battlePassReward.isRecurrent_ = serverReward.IsRecurrent);
			return battlePassReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x26F4BC0", Offset = "0x26F35C0", VA = "0x1826F4BC0")]
		static BattlePassReward()
		{
			Func<BattlePassReward> func = default(Func<BattlePassReward>);
			_parser = (MessageParser<BattlePassReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
