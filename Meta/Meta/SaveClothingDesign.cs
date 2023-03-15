using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	public sealed class SaveClothingDesign : IMessage<SaveClothingDesign>, IMessage, IEquatable<SaveClothingDesign>, IDeepCloneable<SaveClothingDesign>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20001A7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40005B2")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40005B3")]
				[OriginalName("DesignIsEmpty")]
				DesignIsEmpty,
				[Cpp2IlInjected.Token(Token = "0x40005B4")]
				[OriginalName("InvalidDesignId")]
				InvalidDesignId,
				[Cpp2IlInjected.Token(Token = "0x40005B5")]
				[OriginalName("OverLimit")]
				OverLimit,
				[Cpp2IlInjected.Token(Token = "0x40005B6")]
				[OriginalName("NotAllDecalsAreOwned")]
				NotAllDecalsAreOwned
			}

			[Cpp2IlInjected.Token(Token = "0x20001A8")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005B7")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005B8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005B9")]
				public const int ClothingItemFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005BA")]
				private int clothingItem_;

				[Cpp2IlInjected.Token(Token = "0x40005BB")]
				public const int DesignFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005BC")]
				private Design design_;

				[Cpp2IlInjected.Token(Token = "0x40005BD")]
				public const int IsMaleFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005BE")]
				private bool isMale_;

				[Cpp2IlInjected.Token(Token = "0x17000318")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60011A3")]
					[Cpp2IlInjected.Address(RVA = "0x200C2B0", Offset = "0x200ACB0", VA = "0x18200C2B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000319")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60011A4")]
					[Cpp2IlInjected.Address(RVA = "0x200BB30", Offset = "0x200A530", VA = "0x18200BB30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700031A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60011A5")]
					[Cpp2IlInjected.Address(RVA = "0x200CA30", Offset = "0x200B430", VA = "0x18200CA30", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700031B")]
				[DebuggerNonUserCode]
				public int ClothingItem
				{
					[Cpp2IlInjected.Token(Token = "0x60011A9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60011AA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700031C")]
				[DebuggerNonUserCode]
				public Design Design
				{
					[Cpp2IlInjected.Token(Token = "0x60011AB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60011AC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700031D")]
				[DebuggerNonUserCode]
				public bool IsMale
				{
					[Cpp2IlInjected.Token(Token = "0x60011AD")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60011AE")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60011A6")]
				[Cpp2IlInjected.Address(RVA = "0x200B730", Offset = "0x200A130", VA = "0x18200B730")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011A7")]
				[Cpp2IlInjected.Address(RVA = "0x200B5F0", Offset = "0x2009FF0", VA = "0x18200B5F0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011A8")]
				[Cpp2IlInjected.Address(RVA = "0x2005DA0", Offset = "0x20047A0", VA = "0x182005DA0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011AF")]
				[Cpp2IlInjected.Address(RVA = "0x2006300", Offset = "0x2004D00", VA = "0x182006300", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60011B0")]
				[Cpp2IlInjected.Address(RVA = "0x5CA1B0", Offset = "0x5C8BB0", VA = "0x1805CA1B0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60011B1")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3F0", Offset = "0x5C8DF0", VA = "0x1805CA3F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60011B2")]
				[Cpp2IlInjected.Address(RVA = "0x2009630", Offset = "0x2008030", VA = "0x182009630", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011B3")]
				[Cpp2IlInjected.Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011B4")]
				[Cpp2IlInjected.Address(RVA = "0x20053C0", Offset = "0x2003DC0", VA = "0x1820053C0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60011B5")]
				[Cpp2IlInjected.Address(RVA = "0x20080C0", Offset = "0x2006AC0", VA = "0x1820080C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011B6")]
				[Cpp2IlInjected.Address(RVA = "0x2007E10", Offset = "0x2006810", VA = "0x182007E10", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011B7")]
				[Cpp2IlInjected.Address(RVA = "0x2006DE0", Offset = "0x20057E0", VA = "0x182006DE0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011B8")]
				[Cpp2IlInjected.Address(RVA = "0x2008810", Offset = "0x2007210", VA = "0x182008810", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011B9")]
				[Cpp2IlInjected.Address(RVA = "0x5CA0D0", Offset = "0x5C8AD0", VA = "0x1805CA0D0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011BA")]
				[Cpp2IlInjected.Address(RVA = "0x2009930", Offset = "0x2008330", VA = "0x182009930", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20001AA")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005C0")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005C1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005C2")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005C3")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40005C4")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005C5")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40005C6")]
				public const int NewDesignIdFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005C7")]
				private int newDesignId_;

				[Cpp2IlInjected.Token(Token = "0x1700031E")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60011BF")]
					[Cpp2IlInjected.Address(RVA = "0x2019B20", Offset = "0x2018520", VA = "0x182019B20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700031F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60011C0")]
					[Cpp2IlInjected.Address(RVA = "0x2019160", Offset = "0x2017B60", VA = "0x182019160")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000320")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60011C1")]
					[Cpp2IlInjected.Address(RVA = "0x201A1E0", Offset = "0x2018BE0", VA = "0x18201A1E0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000321")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60011C5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60011C6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000322")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60011C7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60011C8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000323")]
				[DebuggerNonUserCode]
				public int NewDesignId
				{
					[Cpp2IlInjected.Token(Token = "0x60011C9")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60011CA")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000324")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60011D6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60011D7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60011C2")]
				[Cpp2IlInjected.Address(RVA = "0x2018770", Offset = "0x2017170", VA = "0x182018770")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011C3")]
				[Cpp2IlInjected.Address(RVA = "0x2018F90", Offset = "0x2017990", VA = "0x182018F90")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011C4")]
				[Cpp2IlInjected.Address(RVA = "0x2010FD0", Offset = "0x200F9D0", VA = "0x182010FD0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011CB")]
				[Cpp2IlInjected.Address(RVA = "0x20124E0", Offset = "0x2010EE0", VA = "0x1820124E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60011CC")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60011CD")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60011CE")]
				[Cpp2IlInjected.Address(RVA = "0x2016570", Offset = "0x2014F70", VA = "0x182016570", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011CF")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011D0")]
				[Cpp2IlInjected.Address(RVA = "0x2010440", Offset = "0x200EE40", VA = "0x182010440", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60011D1")]
				[Cpp2IlInjected.Address(RVA = "0x20149E0", Offset = "0x20133E0", VA = "0x1820149E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011D2")]
				[Cpp2IlInjected.Address(RVA = "0x20146E0", Offset = "0x20130E0", VA = "0x1820146E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011D3")]
				[Cpp2IlInjected.Address(RVA = "0x2013260", Offset = "0x2011C60", VA = "0x182013260", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60011D4")]
				[Cpp2IlInjected.Address(RVA = "0x2015ED0", Offset = "0x20148D0", VA = "0x182015ED0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011D5")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60011D8")]
				[Cpp2IlInjected.Address(RVA = "0x200D910", Offset = "0x200C310", VA = "0x18200D910", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60011D9")]
				[Cpp2IlInjected.Address(RVA = "0x2011A30", Offset = "0x2010430", VA = "0x182011A30")]
				private int DecalModificationCount(Design curDesign, Design newDesign)
				{
					return default(int);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly MessageParser<SaveClothingDesign> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		[DebuggerNonUserCode]
		public static MessageParser<SaveClothingDesign> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001191")]
			[Cpp2IlInjected.Address(RVA = "0x17697E0", Offset = "0x17681E0", VA = "0x1817697E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001192")]
			[Cpp2IlInjected.Address(RVA = "0x1769710", Offset = "0x1768110", VA = "0x181769710")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001193")]
			[Cpp2IlInjected.Address(RVA = "0x1769840", Offset = "0x1768240", VA = "0x181769840", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001194")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SaveClothingDesign()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001195")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SaveClothingDesign(SaveClothingDesign other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001196")]
		[Cpp2IlInjected.Address(RVA = "0x1769430", Offset = "0x1767E30", VA = "0x181769430", Slot = "10")]
		[DebuggerNonUserCode]
		public SaveClothingDesign Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SaveClothingDesign saveClothingDesign = default(SaveClothingDesign);
			saveClothingDesign.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (saveClothingDesign._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return saveClothingDesign;
		}

		[Cpp2IlInjected.Token(Token = "0x6001197")]
		[Cpp2IlInjected.Address(RVA = "0x17694B0", Offset = "0x1767EB0", VA = "0x1817694B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001198")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SaveClothingDesign other)
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

		[Cpp2IlInjected.Token(Token = "0x6001199")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600119A")]
		[Cpp2IlInjected.Address(RVA = "0x17695A0", Offset = "0x1767FA0", VA = "0x1817695A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600119B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600119C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600119D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SaveClothingDesign other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600119E")]
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

		[Cpp2IlInjected.Token(Token = "0x600119F")]
		[Cpp2IlInjected.Address(RVA = "0x1769530", Offset = "0x1767F30", VA = "0x181769530", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011A2")]
		[Cpp2IlInjected.Address(RVA = "0x1769600", Offset = "0x1768000", VA = "0x181769600")]
		static SaveClothingDesign()
		{
			Func<SaveClothingDesign> func = default(Func<SaveClothingDesign>);
			_parser = (MessageParser<SaveClothingDesign>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
