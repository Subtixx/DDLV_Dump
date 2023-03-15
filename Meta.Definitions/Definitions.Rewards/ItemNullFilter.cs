using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	public sealed class ItemNullFilter : BaseItemFilter, IMessage<ItemNullFilter>, IMessage, IEquatable<ItemNullFilter>, IDeepCloneable<ItemNullFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private static readonly MessageParser<ItemNullFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemNullFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600118B")]
			[Cpp2IlInjected.Address(RVA = "0x25E7200", Offset = "0x25E5C00", VA = "0x1825E7200")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600118C")]
			[Cpp2IlInjected.Address(RVA = "0x25E7130", Offset = "0x25E5B30", VA = "0x1825E7130")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600118D")]
			[Cpp2IlInjected.Address(RVA = "0x25E7260", Offset = "0x25E5C60", VA = "0x1825E7260", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F5")]
		[field: Cpp2IlInjected.Token(Token = "0x4000762")]
		public static ItemNullFilter Default
		{
			[Cpp2IlInjected.Token(Token = "0x600119C")]
			[Cpp2IlInjected.Address(RVA = "0x25E70D0", Offset = "0x25E5AD0", VA = "0x1825E70D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600118E")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		[DebuggerNonUserCode]
		public ItemNullFilter()
		{
			((DecoderFallbackBuffer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600118F")]
		[Cpp2IlInjected.Address(RVA = "0x25E2200", Offset = "0x25E0C00", VA = "0x1825E2200")]
		[DebuggerNonUserCode]
		public ItemNullFilter(ItemNullFilter other)
		{
			((DecoderFallbackBuffer)(object)this)._002Ector();
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001190")]
		[Cpp2IlInjected.Address(RVA = "0x25E6DB0", Offset = "0x25E57B0", VA = "0x1825E6DB0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemNullFilter Clone()
		{
			//Discarded unreachable code: IL_001b
			ItemNullFilter itemNullFilter = new ItemNullFilter();
			UnknownFieldSet unknownFieldSet = (itemNullFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemNullFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001191")]
		[Cpp2IlInjected.Address(RVA = "0x25E6E30", Offset = "0x25E5830", VA = "0x1825E6E30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001192")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemNullFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x6001193")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001194")]
		[Cpp2IlInjected.Address(RVA = "0x25E6F20", Offset = "0x25E5920", VA = "0x1825E6F20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001195")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001196")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001197")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemNullFilter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001198")]
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

		[Cpp2IlInjected.Token(Token = "0x6001199")]
		[Cpp2IlInjected.Address(RVA = "0x25E6EB0", Offset = "0x25E58B0", VA = "0x1825E6EB0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600119A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600119B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600119D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600119E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600119F")]
		[Cpp2IlInjected.Address(RVA = "0x25E6F80", Offset = "0x25E5980", VA = "0x1825E6F80")]
		static ItemNullFilter()
		{
			Func<ItemNullFilter> func = default(Func<ItemNullFilter>);
			_parser = (MessageParser<ItemNullFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemNullFilter>)(object)new ItemNullFilter();
			/*Error: Unexpected end of block*/;
		}
	}
}
