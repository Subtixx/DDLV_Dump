using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000894")]
	public sealed class FlowerData : IGridStateData, IMessage<FlowerData>, IMessage, IEquatable<FlowerData>, IDeepCloneable<FlowerData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A3C")]
		private static readonly MessageParser<FlowerData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A3D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A3E")]
		public const int DryFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A3F")]
		private bool dry_;

		[Cpp2IlInjected.Token(Token = "0x17001814")]
		[DebuggerNonUserCode]
		public static MessageParser<FlowerData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005FD7")]
			[Cpp2IlInjected.Address(RVA = "0x3580780", Offset = "0x357F180", VA = "0x183580780")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001815")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FD8")]
			[Cpp2IlInjected.Address(RVA = "0x35806B0", Offset = "0x357F0B0", VA = "0x1835806B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001816")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FD9")]
			[Cpp2IlInjected.Address(RVA = "0x35807E0", Offset = "0x357F1E0", VA = "0x1835807E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001817")]
		[DebuggerNonUserCode]
		public bool Dry
		{
			[Cpp2IlInjected.Token(Token = "0x6005FDD")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return dry_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005FDE")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				dry_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FDA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FlowerData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005FDB")]
		[Cpp2IlInjected.Address(RVA = "0x13AA900", Offset = "0x13A9300", VA = "0x1813AA900")]
		[DebuggerNonUserCode]
		public FlowerData(FlowerData other)
		{
			bool flag = (dry_ = other.dry_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FDC")]
		[Cpp2IlInjected.Address(RVA = "0x3580300", Offset = "0x357ED00", VA = "0x183580300", Slot = "10")]
		[DebuggerNonUserCode]
		public FlowerData Clone()
		{
			//Discarded unreachable code: IL_0029
			FlowerData flowerData = new FlowerData();
			bool flag = (flowerData.dry_ = dry_);
			UnknownFieldSet unknownFieldSet = (flowerData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return flowerData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FDF")]
		[Cpp2IlInjected.Address(RVA = "0x3580380", Offset = "0x357ED80", VA = "0x183580380", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(dry_ ? 1 : 0) == (IntPtr)typeof(FlowerData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE0")]
		[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A8E00", VA = "0x1813AA400", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FlowerData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.dry_;
				if (dry_ == flag)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE1")]
		[Cpp2IlInjected.Address(RVA = "0x13AA570", Offset = "0x13A8F70", VA = "0x1813AA570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (dry_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE2")]
		[Cpp2IlInjected.Address(RVA = "0x3580540", Offset = "0x357EF40", VA = "0x183580540", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE3")]
		[Cpp2IlInjected.Address(RVA = "0x13AA790", Offset = "0x13A9190", VA = "0x1813AA790", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (dry_)
			{
				bool value = dry_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE4")]
		[Cpp2IlInjected.Address(RVA = "0x13AA330", Offset = "0x13A8D30", VA = "0x1813AA330", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				bool flag = dry_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE5")]
		[Cpp2IlInjected.Address(RVA = "0x13AA660", Offset = "0x13A9060", VA = "0x1813AA660", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FlowerData other)
		{
			if (other != null)
			{
				bool flag = other.dry_;
				if (flag)
				{
					dry_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE6")]
		[Cpp2IlInjected.Address(RVA = "0x13AA5E0", Offset = "0x13A8FE0", VA = "0x1813AA5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (dry_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE7")]
		[Cpp2IlInjected.Address(RVA = "0x3580410", Offset = "0x357EE10", VA = "0x183580410", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = dry_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE8")]
		[Cpp2IlInjected.Address(RVA = "0x35804C0", Offset = "0x357EEC0", VA = "0x1835804C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				dry_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FE9")]
		[Cpp2IlInjected.Address(RVA = "0x13AA370", Offset = "0x13A8D70", VA = "0x1813AA370", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				dry_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FEA")]
		[Cpp2IlInjected.Address(RVA = "0x35805A0", Offset = "0x357EFA0", VA = "0x1835805A0")]
		static FlowerData()
		{
			Func<FlowerData> func = default(Func<FlowerData>);
			_parser = (MessageParser<FlowerData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
