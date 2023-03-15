using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008A0")]
	public sealed class HouseData : IGridStateData, IGridUpgradeStateData, IMessage<HouseData>, IMessage, IEquatable<HouseData>, IDeepCloneable<HouseData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A65")]
		private static readonly MessageParser<HouseData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A66")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A67")]
		public const int BuiltFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A68")]
		private bool built_;

		[Cpp2IlInjected.Token(Token = "0x4002A69")]
		public const int UpgradeStateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A6A")]
		private UpgradeState upgradeState_;

		[Cpp2IlInjected.Token(Token = "0x17001830")]
		[DebuggerNonUserCode]
		public static MessageParser<HouseData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600605D")]
			[Cpp2IlInjected.Address(RVA = "0x27AB290", Offset = "0x27A9C90", VA = "0x1827AB290")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001831")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600605E")]
			[Cpp2IlInjected.Address(RVA = "0x27AB1C0", Offset = "0x27A9BC0", VA = "0x1827AB1C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001832")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600605F")]
			[Cpp2IlInjected.Address(RVA = "0x27AB2F0", Offset = "0x27A9CF0", VA = "0x1827AB2F0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001833")]
		[DebuggerNonUserCode]
		public bool Built
		{
			[Cpp2IlInjected.Token(Token = "0x6006063")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return built_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006064")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				built_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001834")]
		[DebuggerNonUserCode]
		public UpgradeState UpgradeState
		{
			[Cpp2IlInjected.Token(Token = "0x6006065")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
			get
			{
				return upgradeState_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006066")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "5")]
			set
			{
				upgradeState_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006060")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public HouseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006061")]
		[Cpp2IlInjected.Address(RVA = "0x27AB150", Offset = "0x27A9B50", VA = "0x1827AB150")]
		[DebuggerNonUserCode]
		public HouseData(HouseData other)
		{
			//IL_002f: Expected O, but got I4
			bool flag = (built_ = other.built_);
			UpgradeState upgradeState = other.upgradeState_;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			int num = 0;
			upgradeState_ = (UpgradeState)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006062")]
		[Cpp2IlInjected.Address(RVA = "0x27AA990", Offset = "0x27A9390", VA = "0x1827AA990", Slot = "12")]
		[DebuggerNonUserCode]
		public HouseData Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			HouseData houseData = new HouseData();
			bool flag = (houseData.built_ = built_);
			UpgradeState upgradeState = upgradeState_;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			int num = 0;
			houseData.upgradeState_ = (UpgradeState)num;
			UnknownFieldSet unknownFieldSet = (houseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return houseData;
		}

		[Cpp2IlInjected.Token(Token = "0x6006067")]
		[Cpp2IlInjected.Address(RVA = "0x27AAA30", Offset = "0x27A9430", VA = "0x1827AAA30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(built_ ? 1 : 0) == (IntPtr)typeof(HouseData).TypeHandle && object.Equals(upgradeState_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006068")]
		[Cpp2IlInjected.Address(RVA = "0x27AAAE0", Offset = "0x27A94E0", VA = "0x1827AAAE0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(HouseData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.built_;
				if (built_ == flag)
				{
					UpgradeState objB = other.upgradeState_;
					if (object.Equals(upgradeState_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006069")]
		[Cpp2IlInjected.Address(RVA = "0x27AAC20", Offset = "0x27A9620", VA = "0x1827AAC20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (built_)
				{
				}
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState != null)
				{
					int hashCode = upgradeState.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600606A")]
		[Cpp2IlInjected.Address(RVA = "0x27AAF50", Offset = "0x27A9950", VA = "0x1827AAF50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600606B")]
		[Cpp2IlInjected.Address(RVA = "0x27AAFB0", Offset = "0x27A99B0", VA = "0x1827AAFB0", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (built_)
			{
				bool value = built_;
				output.WriteBool(value);
			}
			if ((long)upgradeState_ != 0)
			{
				UpgradeState value2 = upgradeState_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600606C")]
		[Cpp2IlInjected.Address(RVA = "0x27AA8B0", Offset = "0x27A92B0", VA = "0x1827AA8B0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState != null)
				{
					int num = CodedOutputStream.ComputeMessageSize(upgradeState);
					num++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x600606D")]
		[Cpp2IlInjected.Address(RVA = "0x27AADA0", Offset = "0x27A97A0", VA = "0x1827AADA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(HouseData other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			bool flag = other.built_;
			if (flag)
			{
				built_ = flag;
			}
			if ((long)other.upgradeState_ != 0)
			{
				UpgradeState upgradeState2 = default(UpgradeState);
				if (upgradeState_ == null)
				{
					UpgradeState upgradeState = (upgradeState_ = new UpgradeState());
					upgradeState2 = upgradeState_;
				}
				UpgradeState other2 = other.upgradeState_;
				upgradeState2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600606E")]
		[Cpp2IlInjected.Address(RVA = "0x27AACB0", Offset = "0x27A96B0", VA = "0x1827AACB0", Slot = "7")]
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
				bool flag = (built_ = input.ReadBool());
			}
			if (num == 18)
			{
				UpgradeState builder = default(UpgradeState);
				if (upgradeState_ == null)
				{
					UpgradeState upgradeState = (upgradeState_ = new UpgradeState());
					builder = upgradeState_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600606F")]
		[Cpp2IlInjected.Address(RVA = "0x27AAB50", Offset = "0x27A9550", VA = "0x1827AAB50", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = built_;
			}
			if (fieldNumber == 2)
			{
				UpgradeState upgradeState = upgradeState_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006070")]
		[Cpp2IlInjected.Address(RVA = "0x27AAE80", Offset = "0x27A9880", VA = "0x1827AAE80", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				built_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				upgradeState_ = (UpgradeState)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006071")]
		[Cpp2IlInjected.Address(RVA = "0x27AA960", Offset = "0x27A9360", VA = "0x1827AA960", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			switch (fieldNumber)
			{
			case 1:
				built_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006072")]
		[Cpp2IlInjected.Address(RVA = "0x27AB040", Offset = "0x27A9A40", VA = "0x1827AB040")]
		static HouseData()
		{
			Func<HouseData> func = default(Func<HouseData>);
			_parser = (MessageParser<HouseData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
