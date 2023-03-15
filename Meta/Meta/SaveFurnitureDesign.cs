using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	public sealed class SaveFurnitureDesign : IMessage<SaveFurnitureDesign>, IMessage, IEquatable<SaveFurnitureDesign>, IDeepCloneable<SaveFurnitureDesign>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20001BF")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40005F5")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40005F6")]
				[OriginalName("DesignIsEmpty")]
				DesignIsEmpty,
				[Cpp2IlInjected.Token(Token = "0x40005F7")]
				[OriginalName("InvalidDesignId")]
				InvalidDesignId
			}

			[Cpp2IlInjected.Token(Token = "0x20001C0")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005F8")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005F9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005FA")]
				public const int FurnitureItemFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005FB")]
				private int furnitureItem_;

				[Cpp2IlInjected.Token(Token = "0x40005FC")]
				public const int DesignFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005FD")]
				private Design design_;

				[Cpp2IlInjected.Token(Token = "0x17000343")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600128A")]
					[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200ABF0", VA = "0x18200C1F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000344")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600128B")]
					[Cpp2IlInjected.Address(RVA = "0x200BDB0", Offset = "0x200A7B0", VA = "0x18200BDB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000345")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600128C")]
					[Cpp2IlInjected.Address(RVA = "0x200CAF0", Offset = "0x200B4F0", VA = "0x18200CAF0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000346")]
				[DebuggerNonUserCode]
				public int FurnitureItem
				{
					[Cpp2IlInjected.Token(Token = "0x6001290")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001291")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000347")]
				[DebuggerNonUserCode]
				public Design Design
				{
					[Cpp2IlInjected.Token(Token = "0x6001292")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001293")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600128D")]
				[Cpp2IlInjected.Address(RVA = "0x200BA50", Offset = "0x200A450", VA = "0x18200BA50")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600128E")]
				[Cpp2IlInjected.Address(RVA = "0x200B8E0", Offset = "0x200A2E0", VA = "0x18200B8E0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600128F")]
				[Cpp2IlInjected.Address(RVA = "0x2005BA0", Offset = "0x20045A0", VA = "0x182005BA0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001294")]
				[Cpp2IlInjected.Address(RVA = "0x2006450", Offset = "0x2004E50", VA = "0x182006450", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001295")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001296")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001297")]
				[Cpp2IlInjected.Address(RVA = "0x2009810", Offset = "0x2008210", VA = "0x182009810", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001298")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001299")]
				[Cpp2IlInjected.Address(RVA = "0x2004A40", Offset = "0x2003440", VA = "0x182004A40", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600129A")]
				[Cpp2IlInjected.Address(RVA = "0x20086D0", Offset = "0x20070D0", VA = "0x1820086D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600129B")]
				[Cpp2IlInjected.Address(RVA = "0x2008530", Offset = "0x2006F30", VA = "0x182008530", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600129C")]
				[Cpp2IlInjected.Address(RVA = "0x2006EE0", Offset = "0x20058E0", VA = "0x182006EE0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600129D")]
				[Cpp2IlInjected.Address(RVA = "0x2008BB0", Offset = "0x20075B0", VA = "0x182008BB0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600129E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600129F")]
				[Cpp2IlInjected.Address(RVA = "0x2009D50", Offset = "0x2008750", VA = "0x182009D50", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20001C2")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005FF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000600")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000601")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000602")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000603")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000604")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000605")]
				public const int NewDesignIdFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000606")]
				private int newDesignId_;

				[Cpp2IlInjected.Token(Token = "0x17000348")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60012A4")]
					[Cpp2IlInjected.Address(RVA = "0x2019880", Offset = "0x2018280", VA = "0x182019880")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000349")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60012A5")]
					[Cpp2IlInjected.Address(RVA = "0x20192E0", Offset = "0x2017CE0", VA = "0x1820192E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700034A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60012A6")]
					[Cpp2IlInjected.Address(RVA = "0x2019FA0", Offset = "0x20189A0", VA = "0x182019FA0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700034B")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60012AA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60012AB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700034C")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60012AC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60012AD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700034D")]
				[DebuggerNonUserCode]
				public int NewDesignId
				{
					[Cpp2IlInjected.Token(Token = "0x60012AE")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60012AF")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700034E")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60012BB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60012BC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60012A7")]
				[Cpp2IlInjected.Address(RVA = "0x20190E0", Offset = "0x2017AE0", VA = "0x1820190E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012A8")]
				[Cpp2IlInjected.Address(RVA = "0x2018380", Offset = "0x2016D80", VA = "0x182018380")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012A9")]
				[Cpp2IlInjected.Address(RVA = "0x2010E50", Offset = "0x200F850", VA = "0x182010E50", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60012B0")]
				[Cpp2IlInjected.Address(RVA = "0x20125A0", Offset = "0x2010FA0", VA = "0x1820125A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60012B1")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60012B2")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60012B3")]
				[Cpp2IlInjected.Address(RVA = "0x2016810", Offset = "0x2015210", VA = "0x182016810", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60012B4")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012B5")]
				[Cpp2IlInjected.Address(RVA = "0x20101D0", Offset = "0x200EBD0", VA = "0x1820101D0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60012B6")]
				[Cpp2IlInjected.Address(RVA = "0x2015450", Offset = "0x2013E50", VA = "0x182015450", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012B7")]
				[Cpp2IlInjected.Address(RVA = "0x20145D0", Offset = "0x2012FD0", VA = "0x1820145D0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012B8")]
				[Cpp2IlInjected.Address(RVA = "0x2012FA0", Offset = "0x20119A0", VA = "0x182012FA0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60012B9")]
				[Cpp2IlInjected.Address(RVA = "0x20159A0", Offset = "0x20143A0", VA = "0x1820159A0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012BA")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60012BD")]
				[Cpp2IlInjected.Address(RVA = "0x200D4C0", Offset = "0x200BEC0", VA = "0x18200D4C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private static readonly MessageParser<SaveFurnitureDesign> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		[DebuggerNonUserCode]
		public static MessageParser<SaveFurnitureDesign> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001278")]
			[Cpp2IlInjected.Address(RVA = "0x1769D00", Offset = "0x1768700", VA = "0x181769D00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001279")]
			[Cpp2IlInjected.Address(RVA = "0x1769C30", Offset = "0x1768630", VA = "0x181769C30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600127A")]
			[Cpp2IlInjected.Address(RVA = "0x1769D60", Offset = "0x1768760", VA = "0x181769D60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600127B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SaveFurnitureDesign()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600127C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SaveFurnitureDesign(SaveFurnitureDesign other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600127D")]
		[Cpp2IlInjected.Address(RVA = "0x1769950", Offset = "0x1768350", VA = "0x181769950", Slot = "10")]
		[DebuggerNonUserCode]
		public SaveFurnitureDesign Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SaveFurnitureDesign saveFurnitureDesign = default(SaveFurnitureDesign);
			saveFurnitureDesign.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (saveFurnitureDesign._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return saveFurnitureDesign;
		}

		[Cpp2IlInjected.Token(Token = "0x600127E")]
		[Cpp2IlInjected.Address(RVA = "0x17699D0", Offset = "0x17683D0", VA = "0x1817699D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600127F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SaveFurnitureDesign other)
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

		[Cpp2IlInjected.Token(Token = "0x6001280")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001281")]
		[Cpp2IlInjected.Address(RVA = "0x1769AC0", Offset = "0x17684C0", VA = "0x181769AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001282")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001283")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001284")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SaveFurnitureDesign other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001285")]
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

		[Cpp2IlInjected.Token(Token = "0x6001286")]
		[Cpp2IlInjected.Address(RVA = "0x1769A50", Offset = "0x1768450", VA = "0x181769A50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001287")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001288")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001289")]
		[Cpp2IlInjected.Address(RVA = "0x1769B20", Offset = "0x1768520", VA = "0x181769B20")]
		static SaveFurnitureDesign()
		{
			Func<SaveFurnitureDesign> func = default(Func<SaveFurnitureDesign>);
			_parser = (MessageParser<SaveFurnitureDesign>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
