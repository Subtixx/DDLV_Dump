using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000494")]
	public sealed class CustomStepFillKeyhole : IMessage<CustomStepFillKeyhole>, IMessage, IEquatable<CustomStepFillKeyhole>, IDeepCloneable<CustomStepFillKeyhole>, IMessageFieldAccessor, IStringTag
	{
		[Cpp2IlInjected.Token(Token = "0x4001896")]
		private static readonly MessageParser<CustomStepFillKeyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001897")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001898")]
		public const int KeyholeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001899")]
		private string keyhole_ = "";

		[Cpp2IlInjected.Token(Token = "0x400189A")]
		public const int LevelIndexToCompleteFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400189B")]
		private int levelIndexToComplete_;

		[Cpp2IlInjected.Token(Token = "0x17000E58")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepFillKeyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600383B")]
			[Cpp2IlInjected.Address(RVA = "0x34E3DA0", Offset = "0x34E27A0", VA = "0x1834E3DA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E59")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600383C")]
			[Cpp2IlInjected.Address(RVA = "0x34E3CD0", Offset = "0x34E26D0", VA = "0x1834E3CD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600383D")]
			[Cpp2IlInjected.Address(RVA = "0x34E3FA0", Offset = "0x34E29A0", VA = "0x1834E3FA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5B")]
		[DebuggerNonUserCode]
		public string Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6003842")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return keyhole_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003843")]
			[Cpp2IlInjected.Address(RVA = "0x34E40B0", Offset = "0x34E2AB0", VA = "0x1834E40B0")]
			set
			{
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5C")]
		[DebuggerNonUserCode]
		public int LevelIndexToComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6003844")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return levelIndexToComplete_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003845")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				levelIndexToComplete_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5D")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003851")]
			[Cpp2IlInjected.Address(RVA = "0x34E3E00", Offset = "0x34E2800", VA = "0x1834E3E00", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600383E")]
		[Cpp2IlInjected.Address(RVA = "0x34E3BE0", Offset = "0x34E25E0", VA = "0x1834E3BE0")]
		[DebuggerNonUserCode]
		public CustomStepFillKeyhole()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x600383F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003840")]
		[Cpp2IlInjected.Address(RVA = "0x34E3C30", Offset = "0x34E2630", VA = "0x1834E3C30")]
		[DebuggerNonUserCode]
		public CustomStepFillKeyhole(CustomStepFillKeyhole other)
		{
			OnConstruction();
			string text = (keyhole_ = other.keyhole_);
			int num = (levelIndexToComplete_ = other.levelIndexToComplete_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003841")]
		[Cpp2IlInjected.Address(RVA = "0x34E3600", Offset = "0x34E2000", VA = "0x1834E3600", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepFillKeyhole Clone()
		{
			//Discarded unreachable code: IL_0042
			CustomStepFillKeyhole customStepFillKeyhole = default(CustomStepFillKeyhole);
			customStepFillKeyhole.keyhole_ = "";
			customStepFillKeyhole.OnConstruction();
			string text = (customStepFillKeyhole.keyhole_ = keyhole_);
			int num = (customStepFillKeyhole.levelIndexToComplete_ = levelIndexToComplete_);
			UnknownFieldSet unknownFieldSet = (customStepFillKeyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepFillKeyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6003846")]
		[Cpp2IlInjected.Address(RVA = "0x34E36D0", Offset = "0x34E20D0", VA = "0x1834E36D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = keyhole_;
				bool flag = default(bool);
				if (!flag && levelIndexToComplete_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003847")]
		[Cpp2IlInjected.Address(RVA = "0x1395A20", Offset = "0x1394420", VA = "0x181395A20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepFillKeyhole other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.keyhole_;
				if (!(keyhole_ != text))
				{
					int num = other.levelIndexToComplete_;
					if (levelIndexToComplete_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003848")]
		[Cpp2IlInjected.Address(RVA = "0x1395C10", Offset = "0x1394610", VA = "0x181395C10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			string text = keyhole_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (levelIndexToComplete_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003849")]
		[Cpp2IlInjected.Address(RVA = "0x34E3A70", Offset = "0x34E2470", VA = "0x1834E3A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600384A")]
		[Cpp2IlInjected.Address(RVA = "0x1395F20", Offset = "0x1394920", VA = "0x181395F20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (keyhole_.m_stringLength != 0)
			{
				string value = keyhole_;
				output.WriteString(value);
			}
			if (levelIndexToComplete_ != 0)
			{
				int value2 = levelIndexToComplete_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600384B")]
		[Cpp2IlInjected.Address(RVA = "0x34E3480", Offset = "0x34E1E80", VA = "0x1834E3480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			string text = keyhole_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = levelIndexToComplete_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600384C")]
		[Cpp2IlInjected.Address(RVA = "0x34E38F0", Offset = "0x34E22F0", VA = "0x1834E38F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepFillKeyhole other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.keyhole_;
				if (text.m_stringLength != 0)
				{
					Keyhole = text;
				}
				int num = other.levelIndexToComplete_;
				if (num != 0)
				{
					levelIndexToComplete_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600384D")]
		[Cpp2IlInjected.Address(RVA = "0x34E3850", Offset = "0x34E2250", VA = "0x1834E3850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Keyhole = input.ReadString());
				}
				if (num == 16)
				{
					int num2 = (levelIndexToComplete_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600384E")]
		[Cpp2IlInjected.Address(RVA = "0x34E3780", Offset = "0x34E2180", VA = "0x1834E3780", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = keyhole_;
			}
			if (fieldNumber == 2)
			{
				int num = levelIndexToComplete_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600384F")]
		[Cpp2IlInjected.Address(RVA = "0x34E3960", Offset = "0x34E2360", VA = "0x1834E3960", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				levelIndexToComplete_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003850")]
		[Cpp2IlInjected.Address(RVA = "0x34E3550", Offset = "0x34E1F50", VA = "0x1834E3550", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0028: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				levelIndexToComplete_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003852")]
		[Cpp2IlInjected.Address(RVA = "0x34E3AD0", Offset = "0x34E24D0", VA = "0x1834E3AD0")]
		static CustomStepFillKeyhole()
		{
			Func<CustomStepFillKeyhole> func = default(Func<CustomStepFillKeyhole>);
			_parser = (MessageParser<CustomStepFillKeyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
