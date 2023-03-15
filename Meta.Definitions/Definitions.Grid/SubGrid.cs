using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006ED")]
	public sealed class SubGrid : IMessage<SubGrid>, IMessage, IEquatable<SubGrid>, IDeepCloneable<SubGrid>, IMessageFieldAccessor, IGridStateData, IGridStateNeedInitialize, IGridStateNeedDeinitialize
	{
		[Cpp2IlInjected.Token(Token = "0x4002336")]
		private static readonly MessageParser<SubGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002337")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002338")]
		public const int GridIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002339")]
		private uint gridID_;

		[Cpp2IlInjected.Token(Token = "0x170013CB")]
		[DebuggerNonUserCode]
		public static MessageParser<SubGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D10")]
			[Cpp2IlInjected.Address(RVA = "0x25584B0", Offset = "0x2556EB0", VA = "0x1825584B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013CC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D11")]
			[Cpp2IlInjected.Address(RVA = "0x25583E0", Offset = "0x2556DE0", VA = "0x1825583E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013CD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D12")]
			[Cpp2IlInjected.Address(RVA = "0x2558510", Offset = "0x2556F10", VA = "0x182558510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013CE")]
		[DebuggerNonUserCode]
		public uint GridID
		{
			[Cpp2IlInjected.Token(Token = "0x6004D16")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return gridID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D17")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				gridID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D13")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SubGrid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D14")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public SubGrid(SubGrid other)
		{
			uint num = (gridID_ = other.gridID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D15")]
		[Cpp2IlInjected.Address(RVA = "0x2557E20", Offset = "0x2556820", VA = "0x182557E20", Slot = "10")]
		[DebuggerNonUserCode]
		public SubGrid Clone()
		{
			//Discarded unreachable code: IL_0029
			SubGrid subGrid = new SubGrid();
			uint num = (subGrid.gridID_ = gridID_);
			UnknownFieldSet unknownFieldSet = (subGrid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return subGrid;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D18")]
		[Cpp2IlInjected.Address(RVA = "0x25580B0", Offset = "0x2556AB0", VA = "0x1825580B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)gridID_ == (IntPtr)typeof(SubGrid).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D19")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SubGrid other)
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
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1A")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (gridID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1B")]
		[Cpp2IlInjected.Address(RVA = "0x2558270", Offset = "0x2556C70", VA = "0x182558270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1C")]
		[Cpp2IlInjected.Address(RVA = "0x5C29E0", Offset = "0x5C13E0", VA = "0x1805C29E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002b
			if (gridID_ != 0)
			{
				uint value = gridID_;
				output.WriteUInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1D")]
		[Cpp2IlInjected.Address(RVA = "0x2557D80", Offset = "0x2556780", VA = "0x182557D80", Slot = "7")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1E")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SubGrid other)
		{
			if (other != null)
			{
				uint num = other.gridID_;
				if (num != 0)
				{
					gridID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1F")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(gridID_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D20")]
		[Cpp2IlInjected.Address(RVA = "0x2558140", Offset = "0x2556B40", VA = "0x182558140", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint num = gridID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D21")]
		[Cpp2IlInjected.Address(RVA = "0x25581F0", Offset = "0x2556BF0", VA = "0x1825581F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				gridID_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D22")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				gridID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D23")]
		[Cpp2IlInjected.Address(RVA = "0x2557F90", Offset = "0x2556990", VA = "0x182557F90")]
		public void Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_003c
			//IL_003b: Expected I4, but got O
			if (gridID_ == 0 && (object)typeof(IProfileWorld).TypeHandle != null)
			{
				if ((object)typeof(IProfileWorld).TypeHandle != null)
				{
				}
				int num = 0;
				if ((object)typeof(IProfileWorld).TypeHandle == null && worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
					gridID_ = (uint)(int)section;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D24")]
		[Cpp2IlInjected.Address(RVA = "0x2557EA0", Offset = "0x25568A0", VA = "0x182557EA0")]
		public void Deinitialize(in WorldProfile worldProfile)
		{
			//Discarded unreachable code: IL_001f
			if (worldProfile.Section != null)
			{
				uint num = gridID_;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D25")]
		[Cpp2IlInjected.Address(RVA = "0x25582D0", Offset = "0x2556CD0", VA = "0x1825582D0")]
		static SubGrid()
		{
			Func<SubGrid> func = default(Func<SubGrid>);
			_parser = (MessageParser<SubGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D26")]
		[Cpp2IlInjected.Address(RVA = "0x2557F90", Offset = "0x2556990", VA = "0x182557F90", Slot = "14")]
		void IGridStateNeedInitialize.Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_003c
			//IL_003b: Expected I4, but got O
			if (gridID_ == 0 && (object)typeof(IProfileWorld).TypeHandle != null)
			{
				if ((object)typeof(IProfileWorld).TypeHandle != null)
				{
				}
				int num = 0;
				if ((object)typeof(IProfileWorld).TypeHandle == null && worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
					gridID_ = (uint)(int)section;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D27")]
		[Cpp2IlInjected.Address(RVA = "0x2557EA0", Offset = "0x25568A0", VA = "0x182557EA0", Slot = "15")]
		void IGridStateNeedDeinitialize.Deinitialize(in WorldProfile worldProfile)
		{
			//Discarded unreachable code: IL_001f
			if (worldProfile.Section != null)
			{
				uint num = gridID_;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
		}
	}
}
