using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class OnlineSegmentData : IMessage<OnlineSegmentData>, IMessage, IEquatable<OnlineSegmentData>, IDeepCloneable<OnlineSegmentData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private static readonly MessageParser<OnlineSegmentData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public const int ConditionsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineSegmentData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x369B710", Offset = "0x369A110", VA = "0x18369B710")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x369B640", Offset = "0x369A040", VA = "0x18369B640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x369B770", Offset = "0x369A170", VA = "0x18369B770", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public OnlineSegmentData()
		{
			((Array)this).Initialize();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x369B5D0", Offset = "0x3699FD0", VA = "0x18369B5D0")]
		[DebuggerNonUserCode]
		public OnlineSegmentData(OnlineSegmentData other)
		{
			//IL_0021: Expected O, but got I4
			((Array)this).Initialize();
			ConditionsList conditionsList = other.conditions_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			int num = 0;
			conditions_ = (ConditionsList)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x369B060", Offset = "0x3699A60", VA = "0x18369B060", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineSegmentData Clone()
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			OnlineSegmentData onlineSegmentData = default(OnlineSegmentData);
			((Array)(object)onlineSegmentData).Initialize();
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			int num = 0;
			onlineSegmentData.conditions_ = (ConditionsList)num;
			UnknownFieldSet unknownFieldSet = (onlineSegmentData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineSegmentData;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x369B100", Offset = "0x3699B00", VA = "0x18369B100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(conditions_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineSegmentData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ConditionsList objB = other.conditions_;
				if (object.Equals(conditions_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode = conditionsList.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x369B460", Offset = "0x3699E60", VA = "0x18369B460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)conditions_ != 0)
			{
				ConditionsList value = conditions_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x369AFC0", Offset = "0x36999C0", VA = "0x18369AFC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = conditions_;
				num = 0;
				if (conditionsList != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x369B310", Offset = "0x3699D10", VA = "0x18369B310", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineSegmentData other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				ConditionsList other2 = other.conditions_;
				conditionsList.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x369B230", Offset = "0x3699C30", VA = "0x18369B230", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				input.ReadMessage(conditionsList);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x369B1B0", Offset = "0x3699BB0", VA = "0x18369B1B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ConditionsList conditionsList = conditions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x369B3E0", Offset = "0x3699DE0", VA = "0x18369B3E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				conditions_ = (ConditionsList)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x369B4C0", Offset = "0x3699EC0", VA = "0x18369B4C0")]
		static OnlineSegmentData()
		{
			Func<OnlineSegmentData> func = default(Func<OnlineSegmentData>);
			_parser = (MessageParser<OnlineSegmentData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
