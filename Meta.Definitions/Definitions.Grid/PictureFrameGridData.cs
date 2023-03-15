using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006FE")]
	public sealed class PictureFrameGridData : IMessage<PictureFrameGridData>, IMessage, IEquatable<PictureFrameGridData>, IDeepCloneable<PictureFrameGridData>, IMessageFieldAccessor, IMessageOneofAccessor, IGridStateData
	{
		[Cpp2IlInjected.Token(Token = "0x20006FF")]
		public enum DataOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400237E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400237F")]
			MemoryShardItemID
		}

		[Cpp2IlInjected.Token(Token = "0x4002378")]
		private static readonly MessageParser<PictureFrameGridData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002379")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400237A")]
		public const int MemoryShardItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400237B")]
		private object data_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400237C")]
		private DataOneofCase dataCase_;

		[Cpp2IlInjected.Token(Token = "0x170013F8")]
		[DebuggerNonUserCode]
		public static MessageParser<PictureFrameGridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004DE7")]
			[Cpp2IlInjected.Address(RVA = "0x36B0140", Offset = "0x36AEB40", VA = "0x1836B0140")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DE8")]
			[Cpp2IlInjected.Address(RVA = "0x36AFF50", Offset = "0x36AE950", VA = "0x1836AFF50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DE9")]
			[Cpp2IlInjected.Address(RVA = "0x36B01A0", Offset = "0x36AEBA0", VA = "0x1836B01A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FB")]
		[DebuggerNonUserCode]
		public int MemoryShardItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004DED")]
			[Cpp2IlInjected.Address(RVA = "0x36B0020", Offset = "0x36AEA20", VA = "0x1836B0020")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (dataCase_ == DataOneofCase.MemoryShardItemID)
				{
					object obj = data_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6004DEE")]
			[Cpp2IlInjected.Address(RVA = "0x36B02B0", Offset = "0x36AECB0", VA = "0x1836B02B0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				data_ = typeof(int).TypeHandle;
				dataCase_ = DataOneofCase.MemoryShardItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FC")]
		[DebuggerNonUserCode]
		public DataOneofCase DataCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004DEF")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return dataCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FD")]
		public Item MemoryShardItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004DFE")]
			[Cpp2IlInjected.Address(RVA = "0x36B0090", Offset = "0x36AEA90", VA = "0x1836B0090")]
			get
			{
				if (dataCase_ == DataOneofCase.MemoryShardItemID)
				{
					object obj = data_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004DFF")]
			[Cpp2IlInjected.Address(RVA = "0x36B0320", Offset = "0x36AED20", VA = "0x1836B0320")]
			set
			{
				//IL_001b: Expected I4, but got I8
				int itemID = value.ItemID;
				data_ = typeof(int).TypeHandle;
				dataCase_ = DataOneofCase.MemoryShardItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PictureFrameGridData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEB")]
		[Cpp2IlInjected.Address(RVA = "0x36AFEA0", Offset = "0x36AE8A0", VA = "0x1836AFEA0")]
		[DebuggerNonUserCode]
		public PictureFrameGridData(PictureFrameGridData other)
		{
			//IL_002a: Expected I4, but got I8
			if (other.dataCase_ == DataOneofCase.MemoryShardItemID)
			{
				int memoryShardItemID = other.MemoryShardItemID;
				data_ = typeof(int).TypeHandle;
				dataCase_ = DataOneofCase.MemoryShardItemID;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEC")]
		[Cpp2IlInjected.Address(RVA = "0x36AF6B0", Offset = "0x36AE0B0", VA = "0x1836AF6B0", Slot = "10")]
		[DebuggerNonUserCode]
		public PictureFrameGridData Clone()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected I4, but got I8
			PictureFrameGridData pictureFrameGridData = new PictureFrameGridData();
			if (dataCase_ == DataOneofCase.MemoryShardItemID)
			{
				int memoryShardItemID = MemoryShardItemID;
				pictureFrameGridData.data_ = typeof(int).TypeHandle;
				pictureFrameGridData.dataCase_ = DataOneofCase.MemoryShardItemID;
			}
			UnknownFieldSet unknownFieldSet = (pictureFrameGridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pictureFrameGridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF0")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearData()
		{
			//IL_0010: Expected O, but got I4
			data_ = (dataCase_ = DataOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF1")]
		[Cpp2IlInjected.Address(RVA = "0x36AF790", Offset = "0x36AE190", VA = "0x1836AF790", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_002e: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int memoryShardItemID = MemoryShardItemID;
				int num = 0;
				int num2 = default(int);
				if (memoryShardItemID == num2 && dataCase_ == (DataOneofCase)num2)
				{
					return object.Equals(_unknownFields, num);
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF2")]
		[Cpp2IlInjected.Address(RVA = "0x36AF850", Offset = "0x36AE250", VA = "0x1836AF850", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PictureFrameGridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int memoryShardItemID = MemoryShardItemID;
				int memoryShardItemID2 = other.MemoryShardItemID;
				if (memoryShardItemID == memoryShardItemID2)
				{
					DataOneofCase dataOneofCase = other.dataCase_;
					if (dataCase_ == dataOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF3")]
		[Cpp2IlInjected.Address(RVA = "0x36AF990", Offset = "0x36AE390", VA = "0x1836AF990", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (dataCase_ == DataOneofCase.MemoryShardItemID)
			{
				if (dataCase_ == DataOneofCase.MemoryShardItemID)
				{
					object obj = data_;
				}
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF4")]
		[Cpp2IlInjected.Address(RVA = "0x36AFCC0", Offset = "0x36AE6C0", VA = "0x1836AFCC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF5")]
		[Cpp2IlInjected.Address(RVA = "0x36AFD20", Offset = "0x36AE720", VA = "0x1836AFD20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (dataCase_ == DataOneofCase.MemoryShardItemID)
			{
				int memoryShardItemID = MemoryShardItemID;
				output.WriteInt32(memoryShardItemID);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF6")]
		[Cpp2IlInjected.Address(RVA = "0x36AF510", Offset = "0x36ADF10", VA = "0x1836AF510", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (dataCase_ == DataOneofCase.MemoryShardItemID)
			{
				if (dataCase_ == DataOneofCase.MemoryShardItemID)
				{
					object obj = data_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF7")]
		[Cpp2IlInjected.Address(RVA = "0x36AFB90", Offset = "0x36AE590", VA = "0x1836AFB90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PictureFrameGridData other)
		{
			if (other != null)
			{
				if (other.dataCase_ == DataOneofCase.MemoryShardItemID)
				{
					int num = (MemoryShardItemID = other.MemoryShardItemID);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF8")]
		[Cpp2IlInjected.Address(RVA = "0x36AFB00", Offset = "0x36AE500", VA = "0x1836AFB00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num3 = (MemoryShardItemID = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF9")]
		[Cpp2IlInjected.Address(RVA = "0x36AF8D0", Offset = "0x36AE2D0", VA = "0x1836AF8D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int memoryShardItemID = MemoryShardItemID;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFA")]
		[Cpp2IlInjected.Address(RVA = "0x36AFBF0", Offset = "0x36AE5F0", VA = "0x1836AFBF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				data_ = typeof(int).TypeHandle;
				dataCase_ = DataOneofCase.MemoryShardItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFB")]
		[Cpp2IlInjected.Address(RVA = "0x36AF5E0", Offset = "0x36ADFE0", VA = "0x1836AF5E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				int num = default(int);
				data_ = num;
				dataCase_ = DataOneofCase.MemoryShardItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFC")]
		[Cpp2IlInjected.Address(RVA = "0x36AFA50", Offset = "0x36AE450", VA = "0x1836AFA50", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Data"))
			{
				DataOneofCase dataOneofCase = dataCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFD")]
		[Cpp2IlInjected.Address(RVA = "0x36AF640", Offset = "0x36AE040", VA = "0x1836AF640", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Data"))
			{
				data_ = (dataCase_ = DataOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E00")]
		[Cpp2IlInjected.Address(RVA = "0x36AFD90", Offset = "0x36AE790", VA = "0x1836AFD90")]
		static PictureFrameGridData()
		{
			Func<PictureFrameGridData> func = default(Func<PictureFrameGridData>);
			_parser = (MessageParser<PictureFrameGridData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
