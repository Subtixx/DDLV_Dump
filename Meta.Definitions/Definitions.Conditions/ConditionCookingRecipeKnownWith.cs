using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007E4")]
	public sealed class ConditionCookingRecipeKnownWith : ICondition, IMessage<ConditionCookingRecipeKnownWith>, IMessage, IEquatable<ConditionCookingRecipeKnownWith>, IDeepCloneable<ConditionCookingRecipeKnownWith>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002789")]
		private static readonly MessageParser<ConditionCookingRecipeKnownWith> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400278A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400278B")]
		public const int MinStarRatingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400278C")]
		private int minStarRating_;

		[Cpp2IlInjected.Token(Token = "0x17001612")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005720")]
			[Cpp2IlInjected.Address(RVA = "0x3216AC0", Offset = "0x32154C0", VA = "0x183216AC0", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minStarRating_;
				return $"Recipe with a minimum of {num} star in cookbook";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001613")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005721")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001614")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCookingRecipeKnownWith> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005723")]
			[Cpp2IlInjected.Address(RVA = "0x3216B30", Offset = "0x3215530", VA = "0x183216B30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001615")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005724")]
			[Cpp2IlInjected.Address(RVA = "0x32169F0", Offset = "0x32153F0", VA = "0x1832169F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001616")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005725")]
			[Cpp2IlInjected.Address(RVA = "0x3216B90", Offset = "0x3215590", VA = "0x183216B90", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001617")]
		[DebuggerNonUserCode]
		public int MinStarRating
		{
			[Cpp2IlInjected.Token(Token = "0x6005729")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minStarRating_;
			}
			[Cpp2IlInjected.Token(Token = "0x600572A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minStarRating_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600571F")]
		[Cpp2IlInjected.Address(RVA = "0x3216650", Offset = "0x3215050", VA = "0x183216650")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005722")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005726")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeKnownWith()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005727")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeKnownWith(ConditionCookingRecipeKnownWith other)
		{
			int num = (minStarRating_ = other.minStarRating_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005728")]
		[Cpp2IlInjected.Address(RVA = "0x32165D0", Offset = "0x3214FD0", VA = "0x1832165D0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeKnownWith Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionCookingRecipeKnownWith conditionCookingRecipeKnownWith = new ConditionCookingRecipeKnownWith();
			int num = (conditionCookingRecipeKnownWith.minStarRating_ = minStarRating_);
			UnknownFieldSet unknownFieldSet = (conditionCookingRecipeKnownWith._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCookingRecipeKnownWith;
		}

		[Cpp2IlInjected.Token(Token = "0x600572B")]
		[Cpp2IlInjected.Address(RVA = "0x32166C0", Offset = "0x32150C0", VA = "0x1832166C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minStarRating_ == (IntPtr)typeof(ConditionCookingRecipeKnownWith).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600572C")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCookingRecipeKnownWith other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minStarRating_;
				if (minStarRating_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600572D")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minStarRating_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600572E")]
		[Cpp2IlInjected.Address(RVA = "0x3216880", Offset = "0x3215280", VA = "0x183216880", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600572F")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (minStarRating_ != 0)
			{
				int value = minStarRating_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005730")]
		[Cpp2IlInjected.Address(RVA = "0x3216530", Offset = "0x3214F30", VA = "0x183216530", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minStarRating_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005731")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCookingRecipeKnownWith other)
		{
			if (other != null)
			{
				int num = other.minStarRating_;
				if (num != 0)
				{
					minStarRating_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005732")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minStarRating_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005733")]
		[Cpp2IlInjected.Address(RVA = "0x3216750", Offset = "0x3215150", VA = "0x183216750", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = minStarRating_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005734")]
		[Cpp2IlInjected.Address(RVA = "0x3216800", Offset = "0x3215200", VA = "0x183216800", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				minStarRating_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005735")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minStarRating_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005736")]
		[Cpp2IlInjected.Address(RVA = "0x32168E0", Offset = "0x32152E0", VA = "0x1832168E0")]
		static ConditionCookingRecipeKnownWith()
		{
			Func<ConditionCookingRecipeKnownWith> func = default(Func<ConditionCookingRecipeKnownWith>);
			_parser = (MessageParser<ConditionCookingRecipeKnownWith>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005737")]
		[Cpp2IlInjected.Address(RVA = "0x3216650", Offset = "0x3215050", VA = "0x183216650", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			throw new NullReferenceException();
		}
	}
}
