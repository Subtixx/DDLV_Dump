using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006EF")]
	public sealed class GridObjectAddress : IMessage<GridObjectAddress>, IMessage, IEquatable<GridObjectAddress>, IDeepCloneable<GridObjectAddress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400233B")]
		private static readonly MessageParser<GridObjectAddress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400233C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400233D")]
		public const int GridIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400233E")]
		private uint gridID_;

		[Cpp2IlInjected.Token(Token = "0x400233F")]
		public const int GridObjectIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002340")]
		private uint gridObjectID_;

		[Cpp2IlInjected.Token(Token = "0x170013CF")]
		[DebuggerNonUserCode]
		public static MessageParser<GridObjectAddress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2B")]
			[Cpp2IlInjected.Address(RVA = "0x2F92FB0", Offset = "0x2F919B0", VA = "0x182F92FB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2C")]
			[Cpp2IlInjected.Address(RVA = "0x2F92EE0", Offset = "0x2F918E0", VA = "0x182F92EE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2D")]
			[Cpp2IlInjected.Address(RVA = "0x2F93010", Offset = "0x2F91A10", VA = "0x182F93010", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D2")]
		[DebuggerNonUserCode]
		public uint GridID
		{
			[Cpp2IlInjected.Token(Token = "0x6004D31")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return gridID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D32")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				gridID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D3")]
		[DebuggerNonUserCode]
		public uint GridObjectID
		{
			[Cpp2IlInjected.Token(Token = "0x6004D33")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return gridObjectID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D34")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				gridObjectID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D2E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GridObjectAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D2F")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public GridObjectAddress(GridObjectAddress other)
		{
			uint num = (gridID_ = other.gridID_);
			uint num2 = (gridObjectID_ = other.gridObjectID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D30")]
		[Cpp2IlInjected.Address(RVA = "0x2F92AD0", Offset = "0x2F914D0", VA = "0x182F92AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public GridObjectAddress Clone()
		{
			//Discarded unreachable code: IL_0037
			GridObjectAddress gridObjectAddress = new GridObjectAddress();
			uint num = (gridObjectAddress.gridID_ = gridID_);
			uint num2 = (gridObjectAddress.gridObjectID_ = gridObjectID_);
			UnknownFieldSet unknownFieldSet = (gridObjectAddress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridObjectAddress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D35")]
		[Cpp2IlInjected.Address(RVA = "0x2F92B60", Offset = "0x2F91560", VA = "0x182F92B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)gridID_ == (IntPtr)typeof(GridObjectAddress).TypeHandle && (IntPtr)(int)gridObjectID_ == (IntPtr)typeof(GridObjectAddress).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D36")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridObjectAddress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.gridID_;
				if (gridID_ == num)
				{
					uint num2 = other.gridObjectID_;
					if (gridObjectID_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D37")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (gridID_ != 0)
				{
				}
				if (gridObjectID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D38")]
		[Cpp2IlInjected.Address(RVA = "0x2F92D70", Offset = "0x2F91770", VA = "0x182F92D70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D39")]
		[Cpp2IlInjected.Address(RVA = "0x108E870", Offset = "0x108D270", VA = "0x18108E870", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (gridID_ != 0)
			{
				uint value = gridID_;
				output.WriteUInt32(value);
			}
			if (gridObjectID_ != 0)
			{
				uint value2 = gridObjectID_;
				output.WriteUInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3A")]
		[Cpp2IlInjected.Address(RVA = "0x2F92A00", Offset = "0x2F91400", VA = "0x182F92A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				uint num = gridID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeUInt32Size(num);
				}
				uint num4 = gridObjectID_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeUInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3B")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridObjectAddress other)
		{
			if (other != null)
			{
				uint num = other.gridID_;
				if (num != 0)
				{
					gridID_ = num;
				}
				uint num2 = other.gridObjectID_;
				if (num2 != 0)
				{
					gridObjectID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3C")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(gridID_ = (uint)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(gridObjectID_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3D")]
		[Cpp2IlInjected.Address(RVA = "0x2F92BF0", Offset = "0x2F915F0", VA = "0x182F92BF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint num = gridID_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3E")]
		[Cpp2IlInjected.Address(RVA = "0x2F92CB0", Offset = "0x2F916B0", VA = "0x182F92CB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				gridID_ = (uint)(int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			gridObjectID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3F")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				gridID_ = 0u;
				break;
			case 2:
				gridObjectID_ = 0u;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D40")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8770", Offset = "0x1AB7170", VA = "0x181AB8770")]
		public GridObjectAddress(uint gridID, uint gridObjectID)
		{
			gridID_ = gridID;
			gridObjectID_ = gridObjectID;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D41")]
		[Cpp2IlInjected.Address(RVA = "0x2F92DD0", Offset = "0x2F917D0", VA = "0x182F92DD0")]
		static GridObjectAddress()
		{
			Func<GridObjectAddress> func = default(Func<GridObjectAddress>);
			_parser = (MessageParser<GridObjectAddress>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
