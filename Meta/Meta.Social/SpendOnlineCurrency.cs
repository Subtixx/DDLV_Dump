using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C77")]
	public sealed class SpendOnlineCurrency : IMessage<SpendOnlineCurrency>, IMessage, IEquatable<SpendOnlineCurrency>, IDeepCloneable<SpendOnlineCurrency>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C78")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C79")]
			public sealed class CurrencyInfo : IMessage<CurrencyInfo>, IMessage, IEquatable<CurrencyInfo>, IDeepCloneable<CurrencyInfo>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400304F")]
				private static readonly MessageParser<CurrencyInfo> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003050")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003051")]
				public const int CurrencyIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003052")]
				private int currencyID_;

				[Cpp2IlInjected.Token(Token = "0x4003053")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4003054")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17001284")]
				[DebuggerNonUserCode]
				public static MessageParser<CurrencyInfo> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006A61")]
					[Cpp2IlInjected.Address(RVA = "0x15B8EB0", Offset = "0x15B78B0", VA = "0x1815B8EB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001285")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A62")]
					[Cpp2IlInjected.Address(RVA = "0x15B8E30", Offset = "0x15B7830", VA = "0x1815B8E30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001286")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A63")]
					[Cpp2IlInjected.Address(RVA = "0x15B8F10", Offset = "0x15B7910", VA = "0x1815B8F10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001287")]
				[DebuggerNonUserCode]
				public int CurrencyID
				{
					[Cpp2IlInjected.Token(Token = "0x6006A67")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006A68")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001288")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6006A69")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006A6A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006A64")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public CurrencyInfo()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A65")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public CurrencyInfo(CurrencyInfo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A66")]
				[Cpp2IlInjected.Address(RVA = "0x15B8A20", Offset = "0x15B7420", VA = "0x1815B8A20", Slot = "10")]
				[DebuggerNonUserCode]
				public CurrencyInfo Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A6B")]
				[Cpp2IlInjected.Address(RVA = "0x15B8AB0", Offset = "0x15B74B0", VA = "0x1815B8AB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A6C")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CurrencyInfo other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A6D")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A6E")]
				[Cpp2IlInjected.Address(RVA = "0x15B8CC0", Offset = "0x15B76C0", VA = "0x1815B8CC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A6F")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A70")]
				[Cpp2IlInjected.Address(RVA = "0x15B8950", Offset = "0x15B7350", VA = "0x1815B8950", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A71")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CurrencyInfo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A72")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A73")]
				[Cpp2IlInjected.Address(RVA = "0x15B8B40", Offset = "0x15B7540", VA = "0x1815B8B40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A74")]
				[Cpp2IlInjected.Address(RVA = "0x15B8C00", Offset = "0x15B7600", VA = "0x1815B8C00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A75")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C7B")]
			public sealed class ReturnedData : IMessage<ReturnedData>, IMessage, IEquatable<ReturnedData>, IDeepCloneable<ReturnedData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4003056")]
				private static readonly MessageParser<ReturnedData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003057")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003058")]
				public const int NewAmountsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4003059")]
				private static readonly FieldCodec<CurrencyInfo> _repeated_newAmounts_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400305A")]
				private readonly RepeatedField<CurrencyInfo> newAmounts_;

				[Cpp2IlInjected.Token(Token = "0x17001289")]
				[DebuggerNonUserCode]
				public static MessageParser<ReturnedData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006A7A")]
					[Cpp2IlInjected.Address(RVA = "0x15CA960", Offset = "0x15C9360", VA = "0x1815CA960")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700128A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A7B")]
					[Cpp2IlInjected.Address(RVA = "0x15CA8E0", Offset = "0x15C92E0", VA = "0x1815CA8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700128B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A7C")]
					[Cpp2IlInjected.Address(RVA = "0x15CA9C0", Offset = "0x15C93C0", VA = "0x1815CA9C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700128C")]
				[DebuggerNonUserCode]
				public RepeatedField<CurrencyInfo> NewAmounts
				{
					[Cpp2IlInjected.Token(Token = "0x6006A80")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006A7D")]
				[Cpp2IlInjected.Address(RVA = "0x15CA760", Offset = "0x15C9160", VA = "0x1815CA760")]
				[DebuggerNonUserCode]
				public ReturnedData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A7E")]
				[Cpp2IlInjected.Address(RVA = "0x15CA7E0", Offset = "0x15C91E0", VA = "0x1815CA7E0")]
				[DebuggerNonUserCode]
				public ReturnedData(ReturnedData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A7F")]
				[Cpp2IlInjected.Address(RVA = "0x15C9F80", Offset = "0x15C8980", VA = "0x1815C9F80", Slot = "10")]
				[DebuggerNonUserCode]
				public ReturnedData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A81")]
				[Cpp2IlInjected.Address(RVA = "0x15CA0B0", Offset = "0x15C8AB0", VA = "0x1815CA0B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A82")]
				[Cpp2IlInjected.Address(RVA = "0x15CA190", Offset = "0x15C8B90", VA = "0x1815CA190", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ReturnedData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A83")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A84")]
				[Cpp2IlInjected.Address(RVA = "0x15CA470", Offset = "0x15C8E70", VA = "0x1815CA470", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A85")]
				[Cpp2IlInjected.Address(RVA = "0x15CA4D0", Offset = "0x15C8ED0", VA = "0x1815CA4D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A86")]
				[Cpp2IlInjected.Address(RVA = "0x15C9E70", Offset = "0x15C8870", VA = "0x1815C9E70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A87")]
				[Cpp2IlInjected.Address(RVA = "0x15CA2A0", Offset = "0x15C8CA0", VA = "0x1815CA2A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ReturnedData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A88")]
				[Cpp2IlInjected.Address(RVA = "0x15CA320", Offset = "0x15C8D20", VA = "0x1815CA320", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A89")]
				[Cpp2IlInjected.Address(RVA = "0x15CA220", Offset = "0x15C8C20", VA = "0x1815CA220", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A8A")]
				[Cpp2IlInjected.Address(RVA = "0x15CA410", Offset = "0x15C8E10", VA = "0x1815CA410", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A8B")]
				[Cpp2IlInjected.Address(RVA = "0x15C9F20", Offset = "0x15C8920", VA = "0x1815C9F20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A8C")]
				[Cpp2IlInjected.Address(RVA = "0x15C9CB0", Offset = "0x15C86B0", VA = "0x1815C9CB0")]
				public void ApplyOnlineCurrencies(in Player player, in World world, [Optional] AddDetail detail)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400304D")]
		private static readonly MessageParser<SpendOnlineCurrency> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400304E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001281")]
		[DebuggerNonUserCode]
		public static MessageParser<SpendOnlineCurrency> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006A4F")]
			[Cpp2IlInjected.Address(RVA = "0xC02DB0", Offset = "0xC017B0", VA = "0x180C02DB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001282")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006A50")]
			[Cpp2IlInjected.Address(RVA = "0xC02CE0", Offset = "0xC016E0", VA = "0x180C02CE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001283")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006A51")]
			[Cpp2IlInjected.Address(RVA = "0xC02E10", Offset = "0xC01810", VA = "0x180C02E10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006A52")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SpendOnlineCurrency()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A53")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SpendOnlineCurrency(SpendOnlineCurrency other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006A54")]
		[Cpp2IlInjected.Address(RVA = "0xC02A00", Offset = "0xC01400", VA = "0x180C02A00", Slot = "10")]
		[DebuggerNonUserCode]
		public SpendOnlineCurrency Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SpendOnlineCurrency spendOnlineCurrency = default(SpendOnlineCurrency);
			spendOnlineCurrency.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (spendOnlineCurrency._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return spendOnlineCurrency;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A55")]
		[Cpp2IlInjected.Address(RVA = "0xC02A80", Offset = "0xC01480", VA = "0x180C02A80", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006A56")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpendOnlineCurrency other)
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

		[Cpp2IlInjected.Token(Token = "0x6006A57")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A58")]
		[Cpp2IlInjected.Address(RVA = "0xC02B70", Offset = "0xC01570", VA = "0x180C02B70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A59")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A5A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A5B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpendOnlineCurrency other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006A5C")]
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

		[Cpp2IlInjected.Token(Token = "0x6006A5D")]
		[Cpp2IlInjected.Address(RVA = "0xC02B00", Offset = "0xC01500", VA = "0x180C02B00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A5E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006A5F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006A60")]
		[Cpp2IlInjected.Address(RVA = "0xC02BD0", Offset = "0xC015D0", VA = "0x180C02BD0")]
		static SpendOnlineCurrency()
		{
			Func<SpendOnlineCurrency> func = default(Func<SpendOnlineCurrency>);
			_parser = (MessageParser<SpendOnlineCurrency>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
