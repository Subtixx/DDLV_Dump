using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200020C")]
	public sealed class LootActivityDataItem : IMessage<LootActivityDataItem>, IMessage, IEquatable<LootActivityDataItem>, IDeepCloneable<LootActivityDataItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200020D")]
		public enum ActivityDataItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000856")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000857")]
			ActivityDataItemType
		}

		[Cpp2IlInjected.Token(Token = "0x4000850")]
		private static readonly MessageParser<LootActivityDataItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000851")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000852")]
		public const int ActivityDataItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private object activityDataItem_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private ActivityDataItemOneofCase activityDataItemCase_;

		[Cpp2IlInjected.Token(Token = "0x17000469")]
		[DebuggerNonUserCode]
		public static MessageParser<LootActivityDataItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60013B9")]
			[Cpp2IlInjected.Address(RVA = "0x38F3820", Offset = "0x38F2220", VA = "0x1838F3820")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013BA")]
			[Cpp2IlInjected.Address(RVA = "0x38F3750", Offset = "0x38F2150", VA = "0x1838F3750")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013BB")]
			[Cpp2IlInjected.Address(RVA = "0x38F3880", Offset = "0x38F2280", VA = "0x1838F3880", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		[DebuggerNonUserCode]
		public ActivityDataItemType ActivityDataItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60013BF")]
			[Cpp2IlInjected.Address(RVA = "0x38F36E0", Offset = "0x38F20E0", VA = "0x1838F36E0")]
			get
			{
				if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
				{
					object obj = activityDataItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013C0")]
			[Cpp2IlInjected.Address(RVA = "0x38F3990", Offset = "0x38F2390", VA = "0x1838F3990")]
			set
			{
				//IL_0016: Expected I4, but got I8
				activityDataItem_ = typeof(ActivityDataItemType).TypeHandle;
				activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		[DebuggerNonUserCode]
		public ActivityDataItemOneofCase ActivityDataItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x60013C1")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return activityDataItemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013BC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootActivityDataItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60013BD")]
		[Cpp2IlInjected.Address(RVA = "0x38F3630", Offset = "0x38F2030", VA = "0x1838F3630")]
		[DebuggerNonUserCode]
		public LootActivityDataItem(LootActivityDataItem other)
		{
			//IL_002a: Expected I4, but got I8
			if (other.activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
			{
				int activityDataItemType = (int)other.ActivityDataItemType;
				activityDataItem_ = typeof(ActivityDataItemType).TypeHandle;
				activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013BE")]
		[Cpp2IlInjected.Address(RVA = "0x38F2E00", Offset = "0x38F1800", VA = "0x1838F2E00", Slot = "10")]
		[DebuggerNonUserCode]
		public LootActivityDataItem Clone()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected I4, but got I8
			LootActivityDataItem lootActivityDataItem = new LootActivityDataItem();
			if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
			{
				int activityDataItemType = (int)ActivityDataItemType;
				lootActivityDataItem.activityDataItem_ = typeof(ActivityDataItemType).TypeHandle;
				lootActivityDataItem.activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
			}
			UnknownFieldSet unknownFieldSet = (lootActivityDataItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootActivityDataItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearActivityDataItem()
		{
			//IL_0010: Expected O, but got I4
			activityDataItem_ = (activityDataItemCase_ = ActivityDataItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C3")]
		[Cpp2IlInjected.Address(RVA = "0x38F2EE0", Offset = "0x38F18E0", VA = "0x1838F2EE0", Slot = "0")]
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
				ActivityDataItemType activityDataItemType = ActivityDataItemType;
				int num = 0;
				ActivityDataItemType activityDataItemType2 = default(ActivityDataItemType);
				if (activityDataItemType == activityDataItemType2 && activityDataItemCase_ == (ActivityDataItemOneofCase)activityDataItemType2)
				{
					return object.Equals(_unknownFields, num);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C4")]
		[Cpp2IlInjected.Address(RVA = "0x38F2FA0", Offset = "0x38F19A0", VA = "0x1838F2FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootActivityDataItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int activityDataItemType = (int)ActivityDataItemType;
				ActivityDataItemType activityDataItemType2 = other.ActivityDataItemType;
				if (activityDataItemType == (int)activityDataItemType2)
				{
					ActivityDataItemOneofCase activityDataItemOneofCase = other.activityDataItemCase_;
					if (activityDataItemCase_ == activityDataItemOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C5")]
		[Cpp2IlInjected.Address(RVA = "0x38F30E0", Offset = "0x38F1AE0", VA = "0x1838F30E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
			{
				if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
				{
					object obj = activityDataItem_;
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

		[Cpp2IlInjected.Token(Token = "0x60013C6")]
		[Cpp2IlInjected.Address(RVA = "0x38F3450", Offset = "0x38F1E50", VA = "0x1838F3450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60013C7")]
		[Cpp2IlInjected.Address(RVA = "0x38F34B0", Offset = "0x38F1EB0", VA = "0x1838F34B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
			{
				int activityDataItemType = (int)ActivityDataItemType;
				output.WriteInt32(activityDataItemType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60013C8")]
		[Cpp2IlInjected.Address(RVA = "0x38F2C60", Offset = "0x38F1660", VA = "0x1838F2C60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
			{
				if (activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
				{
					object obj = activityDataItem_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C9")]
		[Cpp2IlInjected.Address(RVA = "0x38F3320", Offset = "0x38F1D20", VA = "0x1838F3320", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootActivityDataItem other)
		{
			if (other != null)
			{
				if (other.activityDataItemCase_ == ActivityDataItemOneofCase.ActivityDataItemType)
				{
					ActivityDataItemType activityDataItemType = other.ActivityDataItemType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013CA")]
		[Cpp2IlInjected.Address(RVA = "0x38F3250", Offset = "0x38F1C50", VA = "0x1838F3250", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003d
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					activityDataItem_ = num2;
					activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013CB")]
		[Cpp2IlInjected.Address(RVA = "0x38F3020", Offset = "0x38F1A20", VA = "0x1838F3020", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ActivityDataItemType activityDataItemType = ActivityDataItemType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013CC")]
		[Cpp2IlInjected.Address(RVA = "0x38F3380", Offset = "0x38F1D80", VA = "0x1838F3380", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				activityDataItem_ = typeof(ActivityDataItemType).TypeHandle;
				activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013CD")]
		[Cpp2IlInjected.Address(RVA = "0x38F2D30", Offset = "0x38F1730", VA = "0x1838F2D30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				ActivityDataItemType activityDataItemType = default(ActivityDataItemType);
				activityDataItem_ = activityDataItemType;
				activityDataItemCase_ = ActivityDataItemOneofCase.ActivityDataItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013CE")]
		[Cpp2IlInjected.Address(RVA = "0x38F31A0", Offset = "0x38F1BA0", VA = "0x1838F31A0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ActivityDataItem"))
			{
				ActivityDataItemOneofCase activityDataItemOneofCase = activityDataItemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013CF")]
		[Cpp2IlInjected.Address(RVA = "0x38F2D90", Offset = "0x38F1790", VA = "0x1838F2D90", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ActivityDataItem"))
			{
				activityDataItem_ = (activityDataItemCase_ = ActivityDataItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013D0")]
		[Cpp2IlInjected.Address(RVA = "0x38F3520", Offset = "0x38F1F20", VA = "0x1838F3520")]
		static LootActivityDataItem()
		{
			Func<LootActivityDataItem> func = default(Func<LootActivityDataItem>);
			_parser = (MessageParser<LootActivityDataItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
