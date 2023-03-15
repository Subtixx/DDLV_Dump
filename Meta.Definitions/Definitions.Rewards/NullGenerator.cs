using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	public sealed class NullGenerator : IMessage<NullGenerator>, IMessage, IEquatable<NullGenerator>, IDeepCloneable<NullGenerator>, IMessageFieldAccessor, IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private static readonly MessageParser<NullGenerator> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		[DebuggerNonUserCode]
		public static MessageParser<NullGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60012E6")]
			[Cpp2IlInjected.Address(RVA = "0x2978E20", Offset = "0x2977820", VA = "0x182978E20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000441")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012E7")]
			[Cpp2IlInjected.Address(RVA = "0x2978D50", Offset = "0x2977750", VA = "0x182978D50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012E8")]
			[Cpp2IlInjected.Address(RVA = "0x2978E80", Offset = "0x2977880", VA = "0x182978E80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000443")]
		[field: Cpp2IlInjected.Token(Token = "0x4000810")]
		public static NullGenerator Default
		{
			[Cpp2IlInjected.Token(Token = "0x60012F7")]
			[Cpp2IlInjected.Address(RVA = "0x2978CF0", Offset = "0x29776F0", VA = "0x182978CF0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60012E9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public NullGenerator()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60012EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public NullGenerator(NullGenerator other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012EB")]
		[Cpp2IlInjected.Address(RVA = "0x2978930", Offset = "0x2977330", VA = "0x182978930", Slot = "10")]
		[DebuggerNonUserCode]
		public NullGenerator Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			NullGenerator nullGenerator = default(NullGenerator);
			nullGenerator.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (nullGenerator._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return nullGenerator;
		}

		[Cpp2IlInjected.Token(Token = "0x60012EC")]
		[Cpp2IlInjected.Address(RVA = "0x2978A50", Offset = "0x2977450", VA = "0x182978A50", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60012ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NullGenerator other)
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

		[Cpp2IlInjected.Token(Token = "0x60012EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60012EF")]
		[Cpp2IlInjected.Address(RVA = "0x2978B40", Offset = "0x2977540", VA = "0x182978B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60012F1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60012F2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NullGenerator other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012F3")]
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

		[Cpp2IlInjected.Token(Token = "0x60012F4")]
		[Cpp2IlInjected.Address(RVA = "0x2978AD0", Offset = "0x29774D0", VA = "0x182978AD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012F5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60012F9")]
		[Cpp2IlInjected.Address(RVA = "0x29789B0", Offset = "0x29773B0", VA = "0x1829789B0")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			NullReward nullReward = NullReward.Default;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FA")]
		[Cpp2IlInjected.Address(RVA = "0x2978BA0", Offset = "0x29775A0", VA = "0x182978BA0")]
		static NullGenerator()
		{
			//IL_0011: Expected O, but got I4
			Func<NullGenerator> func = default(Func<NullGenerator>);
			_parser = (MessageParser<NullGenerator>)(object)new MessageParser<T>((Func<>)(object)func);
			int num = default(int);
			NullGenerator parser = new NullGenerator((NullGenerator)num);
			num = 0;
			_parser = (MessageParser<NullGenerator>)(object)parser;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FC")]
		[Cpp2IlInjected.Address(RVA = "0x29789B0", Offset = "0x29773B0", VA = "0x1829789B0", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			NullReward nullReward = NullReward.Default;
			/*Error: Unexpected end of block*/;
		}
	}
}
