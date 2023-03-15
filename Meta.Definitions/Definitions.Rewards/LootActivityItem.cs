using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000200")]
	public sealed class LootActivityItem : IMessage<LootActivityItem>, IMessage, IEquatable<LootActivityItem>, IDeepCloneable<LootActivityItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000201")]
		public enum ActivityItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000832")]
			ActivityItemType,
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			CropType
		}

		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private static readonly MessageParser<LootActivityItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400082C")]
		public const int ActivityItemTypeFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400082D")]
		public const int CropTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		private object activityItem_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		private ActivityItemOneofCase activityItemCase_;

		[Cpp2IlInjected.Token(Token = "0x17000454")]
		[DebuggerNonUserCode]
		public static MessageParser<LootActivityItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600134B")]
			[Cpp2IlInjected.Address(RVA = "0x38F4950", Offset = "0x38F3350", VA = "0x1838F4950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000455")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600134C")]
			[Cpp2IlInjected.Address(RVA = "0x38F4880", Offset = "0x38F3280", VA = "0x1838F4880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000456")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600134D")]
			[Cpp2IlInjected.Address(RVA = "0x38F49B0", Offset = "0x38F33B0", VA = "0x1838F49B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000457")]
		[DebuggerNonUserCode]
		public ActivityItemType ActivityItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001351")]
			[Cpp2IlInjected.Address(RVA = "0x38F47A0", Offset = "0x38F31A0", VA = "0x1838F47A0")]
			get
			{
				if (activityItemCase_ == ActivityItemOneofCase.ActivityItemType)
				{
					object obj = activityItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001352")]
			[Cpp2IlInjected.Address(RVA = "0x38F4AC0", Offset = "0x38F34C0", VA = "0x1838F4AC0")]
			set
			{
				//IL_0016: Expected I4, but got I8
				activityItem_ = typeof(ActivityItemType).TypeHandle;
				activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000458")]
		[DebuggerNonUserCode]
		public CropType CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6001353")]
			[Cpp2IlInjected.Address(RVA = "0x38F4810", Offset = "0x38F3210", VA = "0x1838F4810")]
			get
			{
				if (activityItemCase_ == ActivityItemOneofCase.CropType)
				{
					object obj = activityItem_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001354")]
			[Cpp2IlInjected.Address(RVA = "0x38F4B30", Offset = "0x38F3530", VA = "0x1838F4B30")]
			set
			{
				//IL_0016: Expected I4, but got I8
				activityItem_ = typeof(CropType).TypeHandle;
				activityItemCase_ = ActivityItemOneofCase.CropType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000459")]
		[DebuggerNonUserCode]
		public ActivityItemOneofCase ActivityItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001355")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return activityItemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600134E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootActivityItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600134F")]
		[Cpp2IlInjected.Address(RVA = "0x38F46D0", Offset = "0x38F30D0", VA = "0x1838F46D0")]
		[DebuggerNonUserCode]
		public LootActivityItem(LootActivityItem other)
		{
			//IL_002c: Expected I4, but got I8
			ActivityItemOneofCase activityItemOneofCase = other.activityItemCase_;
			if (activityItemOneofCase == ActivityItemOneofCase.ActivityItemType)
			{
				int activityItemType = (int)other.ActivityItemType;
				activityItem_ = typeof(ActivityItemType).TypeHandle;
				activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
			}
			if (activityItemOneofCase == ActivityItemOneofCase.CropType)
			{
				CropType cropType = other.CropType;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001350")]
		[Cpp2IlInjected.Address(RVA = "0x38F3CA0", Offset = "0x38F26A0", VA = "0x1838F3CA0", Slot = "10")]
		[DebuggerNonUserCode]
		public LootActivityItem Clone()
		{
			//Discarded unreachable code: IL_004e
			//IL_002c: Expected I4, but got I8
			LootActivityItem lootActivityItem = new LootActivityItem();
			ActivityItemOneofCase activityItemOneofCase = activityItemCase_;
			if (activityItemOneofCase == ActivityItemOneofCase.ActivityItemType)
			{
				int activityItemType = (int)ActivityItemType;
				lootActivityItem.activityItem_ = typeof(ActivityItemType).TypeHandle;
				lootActivityItem.activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
			}
			if (activityItemOneofCase == ActivityItemOneofCase.CropType)
			{
				CropType cropType = CropType;
			}
			UnknownFieldSet unknownFieldSet = (lootActivityItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootActivityItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6001356")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearActivityItem()
		{
			//IL_0010: Expected O, but got I4
			activityItem_ = (activityItemCase_ = ActivityItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001357")]
		[Cpp2IlInjected.Address(RVA = "0x38F3DA0", Offset = "0x38F27A0", VA = "0x1838F3DA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0037: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				ActivityItemType activityItemType = default(ActivityItemType);
				if (ActivityItemType == activityItemType)
				{
					CropType cropType = CropType;
					int num = 0;
					CropType cropType2 = default(CropType);
					if (cropType == cropType2 && activityItemCase_ == (ActivityItemOneofCase)cropType2)
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001358")]
		[Cpp2IlInjected.Address(RVA = "0x38F3E80", Offset = "0x38F2880", VA = "0x1838F3E80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootActivityItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int activityItemType = (int)ActivityItemType;
				ActivityItemType activityItemType2 = other.ActivityItemType;
				if (activityItemType == (int)activityItemType2)
				{
					int cropType = (int)CropType;
					CropType cropType2 = other.CropType;
					if (cropType == (int)cropType2)
					{
						ActivityItemOneofCase activityItemOneofCase = other.activityItemCase_;
						if (activityItemCase_ == activityItemOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001359")]
		[Cpp2IlInjected.Address(RVA = "0x38F4010", Offset = "0x38F2A10", VA = "0x1838F4010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (activityItemCase_ == ActivityItemOneofCase.ActivityItemType)
			{
				if (activityItemCase_ != ActivityItemOneofCase.ActivityItemType)
				{
				}
				object obj = activityItem_;
			}
			if (activityItemCase_ == ActivityItemOneofCase.CropType && activityItemCase_ == ActivityItemOneofCase.CropType)
			{
				object obj2 = activityItem_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600135A")]
		[Cpp2IlInjected.Address(RVA = "0x38F44C0", Offset = "0x38F2EC0", VA = "0x1838F44C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600135B")]
		[Cpp2IlInjected.Address(RVA = "0x38F4520", Offset = "0x38F2F20", VA = "0x1838F4520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			ActivityItemOneofCase activityItemOneofCase = activityItemCase_;
			if (activityItemOneofCase == ActivityItemOneofCase.ActivityItemType)
			{
				int activityItemType = (int)ActivityItemType;
				output.WriteInt32(activityItemType);
			}
			if (activityItemOneofCase == ActivityItemOneofCase.CropType)
			{
				int cropType = (int)CropType;
				output.WriteInt32(cropType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600135C")]
		[Cpp2IlInjected.Address(RVA = "0x38F3A00", Offset = "0x38F2400", VA = "0x1838F3A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			if (activityItemCase_ == ActivityItemOneofCase.ActivityItemType)
			{
				if (activityItemCase_ == ActivityItemOneofCase.ActivityItemType)
				{
					object obj = activityItem_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			if (activityItemCase_ == ActivityItemOneofCase.CropType)
			{
				if (activityItemCase_ == ActivityItemOneofCase.CropType)
				{
					object obj2 = activityItem_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600135D")]
		[Cpp2IlInjected.Address(RVA = "0x38F4200", Offset = "0x38F2C00", VA = "0x1838F4200", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootActivityItem other)
		{
			if (other != null)
			{
				ActivityItemOneofCase activityItemOneofCase = other.activityItemCase_;
				if (activityItemOneofCase == ActivityItemOneofCase.ActivityItemType)
				{
					ActivityItemType activityItemType = other.ActivityItemType;
				}
				if (activityItemOneofCase == ActivityItemOneofCase.CropType)
				{
					CropType cropType = other.CropType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600135E")]
		[Cpp2IlInjected.Address(RVA = "0x38F4280", Offset = "0x38F2C80", VA = "0x1838F4280", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005a
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			//IL_003c: Expected O, but got I4
			//IL_0045: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					activityItem_ = num2;
					activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
				}
				if (num == 16)
				{
					int num3 = input.ReadInt32();
					activityItem_ = num3;
					activityItemCase_ = ActivityItemOneofCase.CropType;
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600135F")]
		[Cpp2IlInjected.Address(RVA = "0x38F3F20", Offset = "0x38F2920", VA = "0x1838F3F20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ActivityItemType activityItemType = ActivityItemType;
			}
			if (fieldNumber == 2)
			{
				CropType cropType = CropType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001360")]
		[Cpp2IlInjected.Address(RVA = "0x38F4390", Offset = "0x38F2D90", VA = "0x1838F4390", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				activityItem_ = typeof(ActivityItemType).TypeHandle;
				activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001361")]
		[Cpp2IlInjected.Address(RVA = "0x38F3B70", Offset = "0x38F2570", VA = "0x1838F3B70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0020: Expected O, but got I4
			//IL_0029: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				ActivityItemType activityItemType = default(ActivityItemType);
				activityItem_ = activityItemType;
				activityItemCase_ = ActivityItemOneofCase.ActivityItemType;
				break;
			}
			case 2:
			{
				CropType cropType = default(CropType);
				activityItem_ = cropType;
				activityItemCase_ = ActivityItemOneofCase.CropType;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001362")]
		[Cpp2IlInjected.Address(RVA = "0x38F4150", Offset = "0x38F2B50", VA = "0x1838F4150", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ActivityItem"))
			{
				ActivityItemOneofCase activityItemOneofCase = activityItemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001363")]
		[Cpp2IlInjected.Address(RVA = "0x38F3C30", Offset = "0x38F2630", VA = "0x1838F3C30", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ActivityItem"))
			{
				activityItem_ = (activityItemCase_ = ActivityItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001364")]
		[Cpp2IlInjected.Address(RVA = "0x38F45C0", Offset = "0x38F2FC0", VA = "0x1838F45C0")]
		static LootActivityItem()
		{
			Func<LootActivityItem> func = default(Func<LootActivityItem>);
			_parser = (MessageParser<LootActivityItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
