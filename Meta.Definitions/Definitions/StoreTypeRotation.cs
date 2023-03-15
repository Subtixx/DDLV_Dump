using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class StoreTypeRotation : IMessage<StoreTypeRotation>, IMessage, IEquatable<StoreTypeRotation>, IDeepCloneable<StoreTypeRotation>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			public enum RotationInterval
			{
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[OriginalName("Daily")]
				Daily,
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[OriginalName("Weekly")]
				Weekly
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly MessageParser<StoreTypeRotation> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public const int IntervalFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Types.RotationInterval interval_;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public const int NumItemsPerIntervalFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private int numItemsPerInterval_;

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreTypeRotation> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x2555F80", Offset = "0x2554980", VA = "0x182555F80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x2555EB0", Offset = "0x25548B0", VA = "0x182555EB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x2555FE0", Offset = "0x25549E0", VA = "0x182555FE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		[DebuggerNonUserCode]
		public Types.RotationInterval Interval
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return interval_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				interval_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		[DebuggerNonUserCode]
		public int NumItemsPerInterval
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return numItemsPerInterval_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				numItemsPerInterval_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreTypeRotation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public StoreTypeRotation(StoreTypeRotation other)
		{
			Types.RotationInterval rotationInterval = (interval_ = other.interval_);
			int num = (numItemsPerInterval_ = other.numItemsPerInterval_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x25557A0", Offset = "0x25541A0", VA = "0x1825557A0", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreTypeRotation Clone()
		{
			//Discarded unreachable code: IL_0037
			StoreTypeRotation storeTypeRotation = new StoreTypeRotation();
			Types.RotationInterval rotationInterval = (storeTypeRotation.interval_ = interval_);
			int num = (storeTypeRotation.numItemsPerInterval_ = numItemsPerInterval_);
			UnknownFieldSet unknownFieldSet = (storeTypeRotation._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeTypeRotation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x25558A0", Offset = "0x25542A0", VA = "0x1825558A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)interval_ == (IntPtr)typeof(StoreTypeRotation).TypeHandle && (IntPtr)numItemsPerInterval_ == (IntPtr)typeof(StoreTypeRotation).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreTypeRotation other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.RotationInterval rotationInterval = other.interval_;
				if (interval_ == rotationInterval)
				{
					int num = other.numItemsPerInterval_;
					if (numItemsPerInterval_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (interval_ != 0)
				{
				}
				if (numItemsPerInterval_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2555D40", Offset = "0x2554740", VA = "0x182555D40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (interval_ != 0)
			{
			}
			if (numItemsPerInterval_ != 0)
			{
				int value = numItemsPerInterval_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x25556D0", Offset = "0x25540D0", VA = "0x1825556D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.RotationInterval rotationInterval = interval_;
				num = 0;
				if (rotationInterval != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)rotationInterval);
				}
				int num3 = numItemsPerInterval_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreTypeRotation other)
		{
			if (other != null)
			{
				Types.RotationInterval rotationInterval = other.interval_;
				if (rotationInterval != 0)
				{
					interval_ = rotationInterval;
				}
				int num = other.numItemsPerInterval_;
				if (num != 0)
				{
					numItemsPerInterval_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
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
					int num2 = (int)(interval_ = (Types.RotationInterval)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (numItemsPerInterval_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2555A60", Offset = "0x2554460", VA = "0x182555A60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.RotationInterval rotationInterval = interval_;
			}
			if (fieldNumber == 2)
			{
				int num = numItemsPerInterval_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2555B50", Offset = "0x2554550", VA = "0x182555B50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				interval_ = (Types.RotationInterval)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			numItemsPerInterval_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				interval_ = Types.RotationInterval.Daily;
				break;
			case 2:
				numItemsPerInterval_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2555830", Offset = "0x2554230", VA = "0x182555830", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0011
			context.AddInvalidMemberError("Number of items per interval cannot be 0.", "NumItemsPerInterval");
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2555C20", Offset = "0x2554620", VA = "0x182555C20")]
		public unsafe StoreRotation ToServerConfig()
		{
			//Discarded unreachable code: IL_003b
			int num = 0;
			StoreRotation storeRotation = new StoreRotation();
			Types.RotationInterval rotationInterval = interval_;
			string value = storeRotation.ToString();
			StoreRotation storeRotation2 = storeRotation;
			bool flag = Enum.TryParse<StoreRotation.RotationInterval>(value, out *(StoreRotation.RotationInterval*)num);
			storeRotation.Interval = (StoreRotation.RotationInterval)num;
			int num2 = (storeRotation.NumItemsPerInterval = numItemsPerInterval_);
			return storeRotation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2555930", Offset = "0x2554330", VA = "0x182555930")]
		public unsafe static StoreTypeRotation FromServerConfig(StoreRotation rotationConfig)
		{
			//Discarded unreachable code: IL_003b
			int num = 0;
			StoreTypeRotation storeTypeRotation = new StoreTypeRotation();
			StoreRotation.RotationInterval _003CInterval_003Ek__BackingField = rotationConfig.Interval;
			string value = storeTypeRotation.ToString();
			StoreTypeRotation storeTypeRotation2 = storeTypeRotation;
			bool flag = Enum.TryParse<Types.RotationInterval>(value, out *(Types.RotationInterval*)num);
			storeTypeRotation.interval_ = (Types.RotationInterval)num;
			int num2 = (storeTypeRotation.numItemsPerInterval_ = rotationConfig.NumItemsPerInterval);
			return storeTypeRotation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2555DA0", Offset = "0x25547A0", VA = "0x182555DA0")]
		static StoreTypeRotation()
		{
			Func<StoreTypeRotation> func = default(Func<StoreTypeRotation>);
			_parser = (MessageParser<StoreTypeRotation>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
