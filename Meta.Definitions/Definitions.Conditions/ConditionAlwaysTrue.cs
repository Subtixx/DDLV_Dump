using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007D4")]
	public sealed class ConditionAlwaysTrue : ICondition, IMessage<ConditionAlwaysTrue>, IMessage, IEquatable<ConditionAlwaysTrue>, IDeepCloneable<ConditionAlwaysTrue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002757")]
		private static readonly MessageParser<ConditionAlwaysTrue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002758")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170015D9")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600562E")]
			[Cpp2IlInjected.Address(RVA = "0x3212350", Offset = "0x3210D50", VA = "0x183212350", Slot = "5")]
			get
			{
				return "Always TRUE";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DA")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600562F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DB")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionAlwaysTrue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005631")]
			[Cpp2IlInjected.Address(RVA = "0x3212380", Offset = "0x3210D80", VA = "0x183212380")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005632")]
			[Cpp2IlInjected.Address(RVA = "0x3212280", Offset = "0x3210C80", VA = "0x183212280")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005633")]
			[Cpp2IlInjected.Address(RVA = "0x32123E0", Offset = "0x3210DE0", VA = "0x1832123E0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600562D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005630")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005634")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionAlwaysTrue()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6005635")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ConditionAlwaysTrue(ConditionAlwaysTrue other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005636")]
		[Cpp2IlInjected.Address(RVA = "0x3211FA0", Offset = "0x32109A0", VA = "0x183211FA0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionAlwaysTrue Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ConditionAlwaysTrue conditionAlwaysTrue = default(ConditionAlwaysTrue);
			conditionAlwaysTrue.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (conditionAlwaysTrue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionAlwaysTrue;
		}

		[Cpp2IlInjected.Token(Token = "0x6005637")]
		[Cpp2IlInjected.Address(RVA = "0x3212020", Offset = "0x3210A20", VA = "0x183212020", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005638")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionAlwaysTrue other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005639")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600563A")]
		[Cpp2IlInjected.Address(RVA = "0x3212110", Offset = "0x3210B10", VA = "0x183212110", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600563B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600563C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600563D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionAlwaysTrue other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600563E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600563F")]
		[Cpp2IlInjected.Address(RVA = "0x32120A0", Offset = "0x3210AA0", VA = "0x1832120A0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005640")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005641")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005642")]
		[Cpp2IlInjected.Address(RVA = "0x3212170", Offset = "0x3210B70", VA = "0x183212170")]
		static ConditionAlwaysTrue()
		{
			Func<ConditionAlwaysTrue> func = default(Func<ConditionAlwaysTrue>);
			_parser = (MessageParser<ConditionAlwaysTrue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005643")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return true;
		}
	}
}
