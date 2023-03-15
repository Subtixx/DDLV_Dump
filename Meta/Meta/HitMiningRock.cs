using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000394")]
	public sealed class HitMiningRock : IMessage<HitMiningRock>, IMessage, IEquatable<HitMiningRock>, IDeepCloneable<HitMiningRock>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000395")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000396")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000B31")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000B32")]
				[OriginalName("NoMiningTool")]
				NoMiningTool,
				[Cpp2IlInjected.Token(Token = "0x4000B33")]
				[OriginalName("InvalidMiningRock")]
				InvalidMiningRock,
				[Cpp2IlInjected.Token(Token = "0x4000B34")]
				[OriginalName("EmptyRock")]
				EmptyRock,
				[Cpp2IlInjected.Token(Token = "0x4000B35")]
				[OriginalName("NoValidResult")]
				NoValidResult,
				[Cpp2IlInjected.Token(Token = "0x4000B36")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana
			}

			[Cpp2IlInjected.Token(Token = "0x2000397")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000B37")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000B38")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000B39")]
				public const int LocationFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000B3A")]
				private ActivityDataLocationFilter location_;

				[Cpp2IlInjected.Token(Token = "0x4000B3B")]
				public const int IndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000B3C")]
				private int index_;

				[Cpp2IlInjected.Token(Token = "0x17000674")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002388")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE4D0", Offset = "0x1BFCED0", VA = "0x181BFE4D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000675")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002389")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE1D0", Offset = "0x1BFCBD0", VA = "0x181BFE1D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000676")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600238A")]
					[Cpp2IlInjected.Address(RVA = "0x1BFEAD0", Offset = "0x1BFD4D0", VA = "0x181BFEAD0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000677")]
				[DebuggerNonUserCode]
				public ActivityDataLocationFilter Location
				{
					[Cpp2IlInjected.Token(Token = "0x600238E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600238F")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000678")]
				[DebuggerNonUserCode]
				public int Index
				{
					[Cpp2IlInjected.Token(Token = "0x6002390")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002391")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600238B")]
				[Cpp2IlInjected.Address(RVA = "0x1BFE190", Offset = "0x1BFCB90", VA = "0x181BFE190")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600238C")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDD80", Offset = "0x1BFC780", VA = "0x181BFDD80")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600238D")]
				[Cpp2IlInjected.Address(RVA = "0x1BF97E0", Offset = "0x1BF81E0", VA = "0x181BF97E0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002392")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9A80", Offset = "0x1BF8480", VA = "0x181BF9A80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002393")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002394")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002395")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB670", Offset = "0x1BFA070", VA = "0x181BFB670", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002396")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002397")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9120", Offset = "0x1BF7B20", VA = "0x181BF9120", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002398")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA870", Offset = "0x1BF9270", VA = "0x181BFA870", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002399")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA9F0", Offset = "0x1BF93F0", VA = "0x181BFA9F0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600239A")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA330", Offset = "0x1BF8D30", VA = "0x181BFA330", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600239B")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB5A0", Offset = "0x1BF9FA0", VA = "0x181BFB5A0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600239C")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600239D")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB9D0", Offset = "0x1BFA3D0", VA = "0x181BFB9D0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000399")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000B3E")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000B3F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000B40")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000B41")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000B42")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000B43")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000679")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60023A5")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A940", Offset = "0x1C09340", VA = "0x181C0A940")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700067A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60023A6")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A4C0", Offset = "0x1C08EC0", VA = "0x181C0A4C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700067B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60023A7")]
					[Cpp2IlInjected.Address(RVA = "0x1C0ADC0", Offset = "0x1C097C0", VA = "0x181C0ADC0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700067C")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60023AB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60023AC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700067D")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60023AD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60023AE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700067E")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60023BA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60023BB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60023A8")]
				[Cpp2IlInjected.Address(RVA = "0x1C09870", Offset = "0x1C08270", VA = "0x181C09870")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023A9")]
				[Cpp2IlInjected.Address(RVA = "0x1C09BF0", Offset = "0x1C085F0", VA = "0x181C09BF0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023AA")]
				[Cpp2IlInjected.Address(RVA = "0x1C04A80", Offset = "0x1C03480", VA = "0x181C04A80", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60023AF")]
				[Cpp2IlInjected.Address(RVA = "0x1C052F0", Offset = "0x1C03CF0", VA = "0x181C052F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60023B0")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60023B1")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60023B2")]
				[Cpp2IlInjected.Address(RVA = "0x1C07C50", Offset = "0x1C06650", VA = "0x181C07C50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60023B3")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023B4")]
				[Cpp2IlInjected.Address(RVA = "0x1C03BD0", Offset = "0x1C025D0", VA = "0x181C03BD0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60023B5")]
				[Cpp2IlInjected.Address(RVA = "0x1C06720", Offset = "0x1C05120", VA = "0x181C06720", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023B6")]
				[Cpp2IlInjected.Address(RVA = "0x1C06180", Offset = "0x1C04B80", VA = "0x181C06180", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023B7")]
				[Cpp2IlInjected.Address(RVA = "0x1C05A80", Offset = "0x1C04480", VA = "0x181C05A80", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60023B8")]
				[Cpp2IlInjected.Address(RVA = "0x1C07B80", Offset = "0x1C06580", VA = "0x181C07B80", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023B9")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60023BC")]
				[Cpp2IlInjected.Address(RVA = "0x1BFECE0", Offset = "0x1BFD6E0", VA = "0x181BFECE0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60023BD")]
				[Cpp2IlInjected.Address(RVA = "0x1C04240", Offset = "0x1C02C40", VA = "0x181C04240")]
				public static MiningDataItemData ChooseMiningData(MiningDataItemData[] miningDataItemDatas, Random random, ProfilePlayer profilePlayer, MiningData miningData)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000B2E")]
		private static readonly MessageParser<HitMiningRock> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B2F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000671")]
		[DebuggerNonUserCode]
		public static MessageParser<HitMiningRock> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002376")]
			[Cpp2IlInjected.Address(RVA = "0x1704800", Offset = "0x1703200", VA = "0x181704800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000672")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002377")]
			[Cpp2IlInjected.Address(RVA = "0x1704730", Offset = "0x1703130", VA = "0x181704730")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000673")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002378")]
			[Cpp2IlInjected.Address(RVA = "0x1704860", Offset = "0x1703260", VA = "0x181704860", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002379")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public HitMiningRock()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600237A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public HitMiningRock(HitMiningRock other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600237B")]
		[Cpp2IlInjected.Address(RVA = "0x1704450", Offset = "0x1702E50", VA = "0x181704450", Slot = "10")]
		[DebuggerNonUserCode]
		public HitMiningRock Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			HitMiningRock hitMiningRock = default(HitMiningRock);
			hitMiningRock.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (hitMiningRock._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return hitMiningRock;
		}

		[Cpp2IlInjected.Token(Token = "0x600237C")]
		[Cpp2IlInjected.Address(RVA = "0x17044D0", Offset = "0x1702ED0", VA = "0x1817044D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600237D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HitMiningRock other)
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

		[Cpp2IlInjected.Token(Token = "0x600237E")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600237F")]
		[Cpp2IlInjected.Address(RVA = "0x17045C0", Offset = "0x1702FC0", VA = "0x1817045C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002380")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002381")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002382")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HitMiningRock other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002383")]
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

		[Cpp2IlInjected.Token(Token = "0x6002384")]
		[Cpp2IlInjected.Address(RVA = "0x1704550", Offset = "0x1702F50", VA = "0x181704550", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002385")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002386")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002387")]
		[Cpp2IlInjected.Address(RVA = "0x1704620", Offset = "0x1703020", VA = "0x181704620")]
		static HitMiningRock()
		{
			Func<HitMiningRock> func = default(Func<HitMiningRock>);
			_parser = (MessageParser<HitMiningRock>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
