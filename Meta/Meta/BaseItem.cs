using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007E3")]
	public sealed class BaseItem : IMessage<BaseItem>, IMessage, IEquatable<BaseItem>, IDeepCloneable<BaseItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F6B")]
		private static readonly MessageParser<BaseItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F6C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F6D")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F6E")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x4001F6F")]
		public const int ObtainedTimeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F70")]
		private Timestamp obtainedTime_;

		[Cpp2IlInjected.Token(Token = "0x17000A8D")]
		[DebuggerNonUserCode]
		public static MessageParser<BaseItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004164")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9660", Offset = "0x1AB8060", VA = "0x181AB9660")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004165")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9530", Offset = "0x1AB7F30", VA = "0x181AB9530")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004166")]
			[Cpp2IlInjected.Address(RVA = "0x1AB96C0", Offset = "0x1AB80C0", VA = "0x181AB96C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A90")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600416A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600416B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A91")]
		[DebuggerNonUserCode]
		public Timestamp ObtainedTime
		{
			[Cpp2IlInjected.Token(Token = "0x600416C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return obtainedTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x600416D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				obtainedTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A92")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004179")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9600", Offset = "0x1AB8000", VA = "0x181AB9600")]
			get
			{
				long num = Convert.ToInt64((uint)id_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600417A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				id_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004167")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BaseItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004168")]
		[Cpp2IlInjected.Address(RVA = "0x17397E0", Offset = "0x17381E0", VA = "0x1817397E0")]
		[DebuggerNonUserCode]
		public BaseItem(BaseItem other)
		{
			//IL_002f: Expected O, but got I4
			int num = (id_ = other.id_);
			Timestamp timestamp = other.obtainedTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			obtainedTime_ = (Timestamp)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004169")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8F00", Offset = "0x1AB7900", VA = "0x181AB8F00", Slot = "10")]
		[DebuggerNonUserCode]
		public BaseItem Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			BaseItem baseItem = new BaseItem();
			int num = (baseItem.id_ = id_);
			Timestamp timestamp = obtainedTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			baseItem.obtainedTime_ = (Timestamp)num2;
			UnknownFieldSet unknownFieldSet = (baseItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return baseItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600416E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8FA0", Offset = "0x1AB79A0", VA = "0x181AB8FA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(BaseItem).TypeHandle && object.Equals(obtainedTime_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600416F")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BaseItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
				{
					Timestamp objB = other.obtainedTime_;
					if (object.Equals(obtainedTime_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004170")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (id_ != 0)
				{
				}
				Timestamp timestamp = obtainedTime_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004171")]
		[Cpp2IlInjected.Address(RVA = "0x1AB93C0", Offset = "0x1AB7DC0", VA = "0x181AB93C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004172")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			if ((long)obtainedTime_ != 0)
			{
				Timestamp value2 = obtainedTime_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004173")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8E30", Offset = "0x1AB7830", VA = "0x181AB8E30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = id_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Timestamp timestamp = obtainedTime_;
				if (timestamp != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004174")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9120", Offset = "0x1AB7B20", VA = "0x181AB9120", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BaseItem other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			int num = other.id_;
			if (num != 0)
			{
				id_ = num;
			}
			if ((long)other.obtainedTime_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (obtainedTime_ == null)
				{
					Timestamp timestamp = (obtainedTime_ = new Timestamp());
					timestamp2 = obtainedTime_;
				}
				Timestamp other2 = other.obtainedTime_;
				timestamp2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004175")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9200", Offset = "0x1AB7C00", VA = "0x181AB9200", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (id_ = input.ReadInt32());
			}
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (obtainedTime_ == null)
				{
					Timestamp timestamp = (obtainedTime_ = new Timestamp());
					builder = obtainedTime_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004176")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9050", Offset = "0x1AB7A50", VA = "0x181AB9050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = id_;
			}
			if (fieldNumber == 2)
			{
				Timestamp timestamp = obtainedTime_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004177")]
		[Cpp2IlInjected.Address(RVA = "0x1AB92F0", Offset = "0x1AB7CF0", VA = "0x181AB92F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				id_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				obtainedTime_ = (Timestamp)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004178")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				id_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600417B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9420", Offset = "0x1AB7E20", VA = "0x181AB9420")]
		static BaseItem()
		{
			Func<BaseItem> func = default(Func<BaseItem>);
			_parser = (MessageParser<BaseItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
