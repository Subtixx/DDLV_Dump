using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000703")]
	public sealed class KeyholeGridData : IMessage<KeyholeGridData>, IMessage, IEquatable<KeyholeGridData>, IDeepCloneable<KeyholeGridData>, IMessageFieldAccessor, IGridStateData, IGridStateNeedInitialize, IGridStateNeedDeinitialize
	{
		[Cpp2IlInjected.Token(Token = "0x400238C")]
		private static readonly MessageParser<KeyholeGridData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400238D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400238E")]
		public const int KeyholeIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400238F")]
		private uint keyholeID_;

		[Cpp2IlInjected.Token(Token = "0x4002390")]
		public const int KeyholeConfigDataGUIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002391")]
		private string keyholeConfigDataGUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001406")]
		[DebuggerNonUserCode]
		public static MessageParser<KeyholeGridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E27")]
			[Cpp2IlInjected.Address(RVA = "0x273E130", Offset = "0x273CB30", VA = "0x18273E130")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001407")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E28")]
			[Cpp2IlInjected.Address(RVA = "0x273E060", Offset = "0x273CA60", VA = "0x18273E060")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001408")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E29")]
			[Cpp2IlInjected.Address(RVA = "0x273E190", Offset = "0x273CB90", VA = "0x18273E190", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001409")]
		[DebuggerNonUserCode]
		public uint KeyholeID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E2D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return keyholeID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E2E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				keyholeID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140A")]
		[DebuggerNonUserCode]
		public string KeyholeConfigDataGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E2F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return keyholeConfigDataGUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E30")]
			[Cpp2IlInjected.Address(RVA = "0x273E2A0", Offset = "0x273CCA0", VA = "0x18273E2A0")]
			set
			{
				string text = (keyholeConfigDataGUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2A")]
		[Cpp2IlInjected.Address(RVA = "0x273E010", Offset = "0x273CA10", VA = "0x18273E010")]
		[DebuggerNonUserCode]
		public unsafe KeyholeGridData()
		{
			int num = 0;
			Deinitialize(in *(WorldProfile*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2B")]
		[Cpp2IlInjected.Address(RVA = "0x273DF70", Offset = "0x273C970", VA = "0x18273DF70")]
		[DebuggerNonUserCode]
		public unsafe KeyholeGridData(KeyholeGridData other)
		{
			int num = 0;
			Deinitialize(in *(WorldProfile*)num);
			uint num2 = (keyholeID_ = other.keyholeID_);
			string text = (keyholeConfigDataGUID_ = other.keyholeConfigDataGUID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2C")]
		[Cpp2IlInjected.Address(RVA = "0x273D880", Offset = "0x273C280", VA = "0x18273D880", Slot = "10")]
		[DebuggerNonUserCode]
		public unsafe KeyholeGridData Clone()
		{
			//Discarded unreachable code: IL_0047
			KeyholeGridData keyholeGridData = default(KeyholeGridData);
			keyholeGridData.keyholeConfigDataGUID_ = "";
			int num = 0;
			keyholeGridData.Deinitialize(in *(WorldProfile*)num);
			uint num2 = (keyholeGridData.keyholeID_ = keyholeID_);
			string text = (keyholeGridData.keyholeConfigDataGUID_ = keyholeConfigDataGUID_);
			UnknownFieldSet unknownFieldSet = (keyholeGridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return keyholeGridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E31")]
		[Cpp2IlInjected.Address(RVA = "0x273DA10", Offset = "0x273C410", VA = "0x18273DA10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)keyholeID_ == (IntPtr)typeof(KeyholeGridData).TypeHandle)
				{
					string text = keyholeConfigDataGUID_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E32")]
		[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(KeyholeGridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.keyholeID_;
				if (keyholeID_ == num)
				{
					string text = other.keyholeConfigDataGUID_;
					if (!(keyholeConfigDataGUID_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E33")]
		[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0036
			if (keyholeID_ != 0)
			{
			}
			string text = keyholeConfigDataGUID_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E34")]
		[Cpp2IlInjected.Address(RVA = "0x273DD70", Offset = "0x273C770", VA = "0x18273DD70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E35")]
		[Cpp2IlInjected.Address(RVA = "0x273DDD0", Offset = "0x273C7D0", VA = "0x18273DDD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0047
			if (keyholeID_ != 0)
			{
				uint value = keyholeID_;
				output.WriteUInt32(value);
			}
			if (keyholeConfigDataGUID_.m_stringLength != 0)
			{
				string value2 = keyholeConfigDataGUID_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E36")]
		[Cpp2IlInjected.Address(RVA = "0x273D740", Offset = "0x273C140", VA = "0x18273D740", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0055
			uint num = keyholeID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			string text = keyholeConfigDataGUID_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E37")]
		[Cpp2IlInjected.Address(RVA = "0x273DC30", Offset = "0x273C630", VA = "0x18273DC30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(KeyholeGridData other)
		{
			//Discarded unreachable code: IL_004a
			if (other != null)
			{
				uint num = other.keyholeID_;
				if (num != 0)
				{
					keyholeID_ = num;
				}
				string text = other.keyholeConfigDataGUID_;
				if (text.m_stringLength != 0)
				{
					KeyholeConfigDataGUID = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E38")]
		[Cpp2IlInjected.Address(RVA = "0x273DB90", Offset = "0x273C590", VA = "0x18273DB90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(keyholeID_ = (uint)input.ReadInt32());
				}
				if (num == 18)
				{
					string text2 = (KeyholeConfigDataGUID = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E39")]
		[Cpp2IlInjected.Address(RVA = "0x273DAC0", Offset = "0x273C4C0", VA = "0x18273DAC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint num = keyholeID_;
			}
			if (fieldNumber == 2)
			{
				string text = keyholeConfigDataGUID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3A")]
		[Cpp2IlInjected.Address(RVA = "0x273DCA0", Offset = "0x273C6A0", VA = "0x18273DCA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				keyholeID_ = (uint)(int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3B")]
		[Cpp2IlInjected.Address(RVA = "0x273D810", Offset = "0x273C210", VA = "0x18273D810", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				keyholeID_ = 0u;
				break;
			case 2:
				KeyholeConfigDataGUID = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3C")]
		[Cpp2IlInjected.Address(RVA = "0x273D950", Offset = "0x273C350", VA = "0x18273D950")]
		public void Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001e
			IProfileWorld section = worldProfile.Section;
			if (section != null)
			{
				string text = keyholeConfigDataGUID_;
				if (section == null)
				{
					IProfileWorld section2 = worldProfile.Section;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Deinitialize(in WorldProfile worldProfile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3E")]
		[Cpp2IlInjected.Address(RVA = "0x273DE60", Offset = "0x273C860", VA = "0x18273DE60")]
		static KeyholeGridData()
		{
			Func<KeyholeGridData> func = default(Func<KeyholeGridData>);
			_parser = (MessageParser<KeyholeGridData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3F")]
		[Cpp2IlInjected.Address(RVA = "0x273D950", Offset = "0x273C350", VA = "0x18273D950", Slot = "14")]
		void IGridStateNeedInitialize.Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001e
			IProfileWorld section = worldProfile.Section;
			if (section != null)
			{
				string text = keyholeConfigDataGUID_;
				if (section == null)
				{
					IProfileWorld section2 = worldProfile.Section;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E40")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
		void IGridStateNeedDeinitialize.Deinitialize(in WorldProfile worldProfile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
