using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E04")]
	public sealed class ActionRemoveFromInventory : IMessage<ActionRemoveFromInventory>, IMessage, IEquatable<ActionRemoveFromInventory>, IDeepCloneable<ActionRemoveFromInventory>, IMessageFieldAccessor, IAction, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038DB")]
		private static readonly MessageParser<ActionRemoveFromInventory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038DC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038DD")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038DE")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40038DF")]
		public const int FromContainerFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40038E0")]
		private bool fromContainer_;

		[Cpp2IlInjected.Token(Token = "0x40038E1")]
		public const int FromListFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40038E2")]
		private bool fromList_;

		[Cpp2IlInjected.Token(Token = "0x17001479")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionRemoveFromInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60075B6")]
			[Cpp2IlInjected.Address(RVA = "0x18DAA50", Offset = "0x18D9450", VA = "0x1818DAA50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60075B7")]
			[Cpp2IlInjected.Address(RVA = "0x18DA870", Offset = "0x18D9270", VA = "0x1818DA870")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60075B8")]
			[Cpp2IlInjected.Address(RVA = "0x18DAAB0", Offset = "0x18D94B0", VA = "0x1818DAAB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147C")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60075BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60075BD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147D")]
		[DebuggerNonUserCode]
		public bool FromContainer
		{
			[Cpp2IlInjected.Token(Token = "0x60075BE")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return fromContainer_;
			}
			[Cpp2IlInjected.Token(Token = "0x60075BF")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				fromContainer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147E")]
		[DebuggerNonUserCode]
		public bool FromList
		{
			[Cpp2IlInjected.Token(Token = "0x60075C0")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0")]
			get
			{
				return fromList_;
			}
			[Cpp2IlInjected.Token(Token = "0x60075C1")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0")]
			set
			{
				fromList_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147F")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60075CD")]
			[Cpp2IlInjected.Address(RVA = "0x18DA9F0", Offset = "0x18D93F0", VA = "0x1818DA9F0")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001480")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60075CF")]
			[Cpp2IlInjected.Address(RVA = "0x18DA940", Offset = "0x18D9340", VA = "0x1818DA940", Slot = "15")]
			get
			{
				//IL_0017: Expected O, but got I8
				long num = Convert.ToInt64((uint)itemID_);
				return $"RemoveFromInventory {num}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075B9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionRemoveFromInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60075BA")]
		[Cpp2IlInjected.Address(RVA = "0x18DA810", Offset = "0x18D9210", VA = "0x1818DA810")]
		[DebuggerNonUserCode]
		public ActionRemoveFromInventory(ActionRemoveFromInventory other)
		{
			int num = (itemID_ = other.itemID_);
			bool flag = (fromContainer_ = other.fromContainer_);
			bool flag2 = (fromList_ = other.fromList_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075BB")]
		[Cpp2IlInjected.Address(RVA = "0x18D9F70", Offset = "0x18D8970", VA = "0x1818D9F70", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionRemoveFromInventory Clone()
		{
			//Discarded unreachable code: IL_0047
			ActionRemoveFromInventory actionRemoveFromInventory = new ActionRemoveFromInventory();
			int num = (actionRemoveFromInventory.itemID_ = itemID_);
			bool flag = (actionRemoveFromInventory.fromContainer_ = fromContainer_);
			bool flag2 = (actionRemoveFromInventory.fromList_ = fromList_);
			UnknownFieldSet unknownFieldSet = (actionRemoveFromInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionRemoveFromInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x60075C2")]
		[Cpp2IlInjected.Address(RVA = "0x18DA150", Offset = "0x18D8B50", VA = "0x1818DA150", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ActionRemoveFromInventory).TypeHandle && (IntPtr)(fromContainer_ ? 1 : 0) == (IntPtr)typeof(ActionRemoveFromInventory).TypeHandle && (IntPtr)(fromList_ ? 1 : 0) == (IntPtr)typeof(ActionRemoveFromInventory).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075C3")]
		[Cpp2IlInjected.Address(RVA = "0x18DA110", Offset = "0x18D8B10", VA = "0x1818DA110", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionRemoveFromInventory other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.itemID_;
				if (itemID_ == num)
				{
					bool flag = other.fromContainer_;
					if (fromContainer_ == flag)
					{
						bool flag2 = other.fromList_;
						if (fromList_ == flag2)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075C4")]
		[Cpp2IlInjected.Address(RVA = "0x18DA300", Offset = "0x18D8D00", VA = "0x1818DA300", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				if (fromContainer_)
				{
				}
				if (fromList_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60075C5")]
		[Cpp2IlInjected.Address(RVA = "0x18DA5F0", Offset = "0x18D8FF0", VA = "0x1818DA5F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60075C6")]
		[Cpp2IlInjected.Address(RVA = "0x18DA650", Offset = "0x18D9050", VA = "0x1818DA650", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			if (fromContainer_)
			{
				bool value2 = fromContainer_;
				output.WriteBool(value2);
			}
			if (fromList_)
			{
				bool value3 = fromList_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60075C7")]
		[Cpp2IlInjected.Address(RVA = "0x18D9EA0", Offset = "0x18D88A0", VA = "0x1818D9EA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = itemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
				num3++;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				return num4 + num2;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60075C8")]
		[Cpp2IlInjected.Address(RVA = "0x18DA460", Offset = "0x18D8E60", VA = "0x1818DA460", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionRemoveFromInventory other)
		{
			if (other != null)
			{
				int num = other.itemID_;
				if (num != 0)
				{
					itemID_ = num;
				}
				bool flag = other.fromContainer_;
				if (flag)
				{
					fromContainer_ = flag;
				}
				bool flag2 = other.fromList_;
				if (flag2)
				{
					fromList_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075C9")]
		[Cpp2IlInjected.Address(RVA = "0x18DA3B0", Offset = "0x18D8DB0", VA = "0x1818DA3B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (itemID_ = input.ReadInt32());
				}
				bool flag = default(bool);
				if (num == 16)
				{
					flag = (fromContainer_ = input.ReadBool());
				}
				if (flag)
				{
					bool flag2 = (fromList_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075CA")]
		[Cpp2IlInjected.Address(RVA = "0x18DA1F0", Offset = "0x18D8BF0", VA = "0x1818DA1F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					bool flag = fromList_;
				}
				bool flag2 = fromContainer_;
			}
			int num2 = itemID_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075CB")]
		[Cpp2IlInjected.Address(RVA = "0x18DA4D0", Offset = "0x18D8ED0", VA = "0x1818DA4D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					fromList_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					fromContainer_ = (byte)(int)obj != 0;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				itemID_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075CC")]
		[Cpp2IlInjected.Address(RVA = "0x18D9F40", Offset = "0x18D8940", VA = "0x1818D9F40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0014
			//IL_001d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				fromList_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075CE")]
		[Cpp2IlInjected.Address(RVA = "0x18D9E00", Offset = "0x18D8800", VA = "0x1818D9E00", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = itemID_;
			bool flag = fromList_;
			if (fromContainer_)
			{
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075D0")]
		[Cpp2IlInjected.Address(RVA = "0x18DA100", Offset = "0x18D8B00", VA = "0x1818DA100", Slot = "16")]
		void IProtobufDefaultData.SetDefaultData()
		{
			fromContainer_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60075D1")]
		[Cpp2IlInjected.Address(RVA = "0x18DA000", Offset = "0x18D8A00", VA = "0x1818DA000", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0039
			int num = itemID_;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				context.AddInvalidMemberError("Cannot remove currency from profile (yet)", "Item");
			}
			if (!fromContainer_ && !fromList_)
			{
				context.AddError("FromContainer or FromList must be enabled");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075D2")]
		[Cpp2IlInjected.Address(RVA = "0x18DA700", Offset = "0x18D9100", VA = "0x1818DA700")]
		static ActionRemoveFromInventory()
		{
			Func<ActionRemoveFromInventory> func = default(Func<ActionRemoveFromInventory>);
			_parser = (MessageParser<ActionRemoveFromInventory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
