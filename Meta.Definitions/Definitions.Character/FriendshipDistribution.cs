using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x200085D")]
	public sealed class FriendshipDistribution : IDataValidation, IMessage<FriendshipDistribution>, IMessage, IEquatable<FriendshipDistribution>, IDeepCloneable<FriendshipDistribution>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400295D")]
		private static readonly MessageParser<FriendshipDistribution> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400295E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400295F")]
		public const int XpRewardTablesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002960")]
		private static readonly FieldCodec<XpRewardTable> _repeated_xpRewardTables_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002961")]
		private readonly RepeatedField<XpRewardTable> xpRewardTables_ = (RepeatedField<XpRewardTable>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001790")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipDistribution> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D84")]
			[Cpp2IlInjected.Address(RVA = "0x34388A0", Offset = "0x34372A0", VA = "0x1834388A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001791")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D85")]
			[Cpp2IlInjected.Address(RVA = "0x34387D0", Offset = "0x34371D0", VA = "0x1834387D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001792")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D86")]
			[Cpp2IlInjected.Address(RVA = "0x3438900", Offset = "0x3437300", VA = "0x183438900", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001793")]
		[DebuggerNonUserCode]
		public RepeatedField<XpRewardTable> XpRewardTables
		{
			[Cpp2IlInjected.Token(Token = "0x6005D8A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return xpRewardTables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D82")]
		[Cpp2IlInjected.Address(RVA = "0x3437FC0", Offset = "0x34369C0", VA = "0x183437FC0")]
		public XpRewardTable GetXpRewardTable(int missionCount)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			Func<XpRewardTable, bool> func = (Func<XpRewardTable, bool>)(object)(Func<T, TResult>)((XpRewardTable x) => ((RepeatedField<T>)(object)x.weights_).Count == missionCount);
			return Enumerable.FirstOrDefault<XpRewardTable>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D83")]
		[Cpp2IlInjected.Address(RVA = "0x3437CB0", Offset = "0x34366B0", VA = "0x183437CB0", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			Predicate<XpRewardTable> predicate = (Predicate<XpRewardTable>)(object)(Predicate<T>)delegate(XpRewardTable x)
			{
				//Discarded unreachable code: IL_002c
				RepeatedField<XpRewardTable> repeatedField2 = xpRewardTables_;
				Func<XpRewardTable, bool> func = (Func<XpRewardTable, bool>)(object)(Func<T, TResult>)delegate(XpRewardTable d)
				{
					//Discarded unreachable code: IL_0022
					int count = ((RepeatedField<T>)(object)d.weights_).Count;
					int count2 = ((RepeatedField<T>)(object)x.weights_).Count;
					return count == count2;
				};
				return Enumerable.Count<XpRewardTable>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func) > 1;
			};
			if (((RepeatedField<>)(object)repeatedField).Any<XpRewardTable>((Predicate<>)(object)predicate))
			{
				context.AddInvalidMemberError("The number of elements inside each Weights must be unique", "XpRewardTables");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D87")]
		[Cpp2IlInjected.Address(RVA = "0x3438650", Offset = "0x3437050", VA = "0x183438650")]
		[DebuggerNonUserCode]
		public FriendshipDistribution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005D88")]
		[Cpp2IlInjected.Address(RVA = "0x34386D0", Offset = "0x34370D0", VA = "0x1834386D0")]
		[DebuggerNonUserCode]
		public FriendshipDistribution(FriendshipDistribution other)
		{
			RepeatedField<XpRewardTable> repeatedField = (xpRewardTables_ = (RepeatedField<XpRewardTable>)(object)((RepeatedField<T>)(object)other.xpRewardTables_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D89")]
		[Cpp2IlInjected.Address(RVA = "0x3437B80", Offset = "0x3436580", VA = "0x183437B80", Slot = "11")]
		[DebuggerNonUserCode]
		public FriendshipDistribution Clone()
		{
			//Discarded unreachable code: IL_003b
			FriendshipDistribution friendshipDistribution = new FriendshipDistribution();
			RepeatedField<XpRewardTable> repeatedField = (friendshipDistribution.xpRewardTables_ = (RepeatedField<XpRewardTable>)(object)new RepeatedField<T>());
			RepeatedField<XpRewardTable> repeatedField2 = (friendshipDistribution.xpRewardTables_ = (RepeatedField<XpRewardTable>)(object)((RepeatedField<T>)(object)xpRewardTables_).Clone());
			UnknownFieldSet unknownFieldSet = (friendshipDistribution._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return friendshipDistribution;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8B")]
		[Cpp2IlInjected.Address(RVA = "0x3437E60", Offset = "0x3436860", VA = "0x183437E60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8C")]
		[Cpp2IlInjected.Address(RVA = "0x3437DD0", Offset = "0x34367D0", VA = "0x183437DD0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipDistribution other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
				RepeatedField<XpRewardTable> repeatedField2 = other.xpRewardTables_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)xpRewardTables_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8E")]
		[Cpp2IlInjected.Address(RVA = "0x3438270", Offset = "0x3436C70", VA = "0x183438270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8F")]
		[Cpp2IlInjected.Address(RVA = "0x34383C0", Offset = "0x3436DC0", VA = "0x1834383C0", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			FieldCodec<XpRewardTable> repeated_xpRewardTables_codec = _repeated_xpRewardTables_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_xpRewardTables_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D90")]
		[Cpp2IlInjected.Address(RVA = "0x3437A70", Offset = "0x3436470", VA = "0x183437A70", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			FieldCodec<XpRewardTable> repeated_xpRewardTables_codec = _repeated_xpRewardTables_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_xpRewardTables_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D91")]
		[Cpp2IlInjected.Address(RVA = "0x3438190", Offset = "0x3436B90", VA = "0x183438190", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipDistribution other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
				RepeatedField<XpRewardTable> repeatedField2 = other.xpRewardTables_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D92")]
		[Cpp2IlInjected.Address(RVA = "0x34380A0", Offset = "0x3436AA0", VA = "0x1834380A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
					FieldCodec<XpRewardTable> repeated_xpRewardTables_codec = _repeated_xpRewardTables_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_xpRewardTables_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D93")]
		[Cpp2IlInjected.Address(RVA = "0x3437F40", Offset = "0x3436940", VA = "0x183437F40", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D94")]
		[Cpp2IlInjected.Address(RVA = "0x3438210", Offset = "0x3436C10", VA = "0x183438210", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D95")]
		[Cpp2IlInjected.Address(RVA = "0x3437B20", Offset = "0x3436520", VA = "0x183437B20", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<XpRewardTable> repeatedField = xpRewardTables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D96")]
		[Cpp2IlInjected.Address(RVA = "0x3438480", Offset = "0x3436E80", VA = "0x183438480")]
		static FriendshipDistribution()
		{
			Func<FriendshipDistribution> func = default(Func<FriendshipDistribution>);
			_parser = (MessageParser<FriendshipDistribution>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<XpRewardTable> parser = XpRewardTable._parser;
			uint num = default(uint);
			_parser = (MessageParser<FriendshipDistribution>)(object)FieldCodec.ForMessage<XpRewardTable>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
