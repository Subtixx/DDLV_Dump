using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	public sealed class NullReward : IMessage<NullReward>, IMessage, IEquatable<NullReward>, IDeepCloneable<NullReward>, IMessageFieldAccessor, IReward
	{
		[Cpp2IlInjected.Token(Token = "0x40008DC")]
		private static readonly MessageParser<NullReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008DD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		[DebuggerNonUserCode]
		public static MessageParser<NullReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60014EC")]
			[Cpp2IlInjected.Address(RVA = "0x2979410", Offset = "0x2977E10", VA = "0x182979410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014ED")]
			[Cpp2IlInjected.Address(RVA = "0x2979340", Offset = "0x2977D40", VA = "0x182979340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014EE")]
			[Cpp2IlInjected.Address(RVA = "0x2979470", Offset = "0x2977E70", VA = "0x182979470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A7")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60014FD")]
			[Cpp2IlInjected.Address(RVA = "0x29792B0", Offset = "0x2977CB0", VA = "0x1829792B0", Slot = "14")]
			get
			{
				return "null";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A8")]
		[field: Cpp2IlInjected.Token(Token = "0x40008DE")]
		public static NullReward Default
		{
			[Cpp2IlInjected.Token(Token = "0x60014FE")]
			[Cpp2IlInjected.Address(RVA = "0x29792E0", Offset = "0x2977CE0", VA = "0x1829792E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60014EF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public NullReward()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60014F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public NullReward(NullReward other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014F1")]
		[Cpp2IlInjected.Address(RVA = "0x2978F90", Offset = "0x2977990", VA = "0x182978F90", Slot = "10")]
		[DebuggerNonUserCode]
		public NullReward Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			NullReward nullReward = default(NullReward);
			nullReward.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (nullReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return nullReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60014F2")]
		[Cpp2IlInjected.Address(RVA = "0x2979010", Offset = "0x2977A10", VA = "0x182979010", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60014F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NullReward other)
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

		[Cpp2IlInjected.Token(Token = "0x60014F4")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60014F5")]
		[Cpp2IlInjected.Address(RVA = "0x2979100", Offset = "0x2977B00", VA = "0x182979100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60014F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60014F8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NullReward other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014F9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014FA")]
		[Cpp2IlInjected.Address(RVA = "0x2979090", Offset = "0x2977A90", VA = "0x182979090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014FF")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "15")]
		public bool CanGive(IRewardRecipient recipient)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001500")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001501")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "17")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001502")]
		[Cpp2IlInjected.Address(RVA = "0x2979160", Offset = "0x2977B60", VA = "0x182979160")]
		static NullReward()
		{
			//IL_0011: Expected O, but got I4
			Func<NullReward> func = default(Func<NullReward>);
			_parser = (MessageParser<NullReward>)(object)new MessageParser<T>((Func<>)(object)func);
			int num = default(int);
			NullReward parser = new NullReward((NullReward)num);
			num = 0;
			_parser = (MessageParser<NullReward>)(object)parser;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001503")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
