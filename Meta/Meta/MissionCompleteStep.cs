using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200040E")]
	public sealed class MissionCompleteStep : IMessage<MissionCompleteStep>, IMessage, IEquatable<MissionCompleteStep>, IDeepCloneable<MissionCompleteStep>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200040F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000410")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C9D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C9E")]
				[OriginalName("Expired")]
				Expired,
				[Cpp2IlInjected.Token(Token = "0x4000C9F")]
				[OriginalName("NotUsed")]
				NotUsed,
				[Cpp2IlInjected.Token(Token = "0x4000CA0")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x2000411")]
			public enum Condition
			{
				[Cpp2IlInjected.Token(Token = "0x4000CA2")]
				[OriginalName("DialogueStart")]
				DialogueStart,
				[Cpp2IlInjected.Token(Token = "0x4000CA3")]
				[OriginalName("DialogueEnd")]
				DialogueEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CA4")]
				[OriginalName("FollowEnd")]
				FollowEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CA5")]
				[OriginalName("FollowRestart")]
				FollowRestart,
				[Cpp2IlInjected.Token(Token = "0x4000CA6")]
				[OriginalName("ListenEnd")]
				ListenEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CA7")]
				[OriginalName("VisitEnterLocation")]
				VisitEnterLocation,
				[Cpp2IlInjected.Token(Token = "0x4000CA8")]
				[OriginalName("VisitExitLocation")]
				VisitExitLocation,
				[Cpp2IlInjected.Token(Token = "0x4000CA9")]
				[OriginalName("PartyEnd")]
				PartyEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CAA")]
				[OriginalName("BringItemDialogueEnd")]
				BringItemDialogueEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CAB")]
				[OriginalName("UnlockCharacterEnd")]
				UnlockCharacterEnd,
				[Cpp2IlInjected.Token(Token = "0x4000CAC")]
				[OriginalName("ChaseEnd")]
				ChaseEnd
			}

			[Cpp2IlInjected.Token(Token = "0x2000412")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4000CAD")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CAE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CAF")]
				public const int MissionItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CB0")]
				private int missionItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000CB1")]
				public const int StepNameFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000CB2")]
				private string stepName_;

				[Cpp2IlInjected.Token(Token = "0x4000CB3")]
				public const int ConditionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000CB4")]
				private Condition condition_;

				[Cpp2IlInjected.Token(Token = "0x4000CB5")]
				public const int InventoryFullResolutionFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000CB6")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.Token(Token = "0x1700073A")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60027BE")]
					[Cpp2IlInjected.Address(RVA = "0x25CC5D0", Offset = "0x25CAFD0", VA = "0x1825CC5D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700073B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60027BF")]
					[Cpp2IlInjected.Address(RVA = "0x25CBDD0", Offset = "0x25CA7D0", VA = "0x1825CBDD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700073C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60027C0")]
					[Cpp2IlInjected.Address(RVA = "0x25CCDB0", Offset = "0x25CB7B0", VA = "0x1825CCDB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700073D")]
				[DebuggerNonUserCode]
				public int MissionItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60027C4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60027C5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700073E")]
				[DebuggerNonUserCode]
				public string StepName
				{
					[Cpp2IlInjected.Token(Token = "0x60027C6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027C7")]
					[Cpp2IlInjected.Address(RVA = "0x25CD060", Offset = "0x25CBA60", VA = "0x1825CD060")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700073F")]
				[DebuggerNonUserCode]
				public Condition Condition
				{
					[Cpp2IlInjected.Token(Token = "0x60027C8")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(Condition);
					}
					[Cpp2IlInjected.Token(Token = "0x60027C9")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000740")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x60027CA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "14")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027CB")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "15")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60027C1")]
				[Cpp2IlInjected.Address(RVA = "0x25CB2B0", Offset = "0x25C9CB0", VA = "0x1825CB2B0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027C2")]
				[Cpp2IlInjected.Address(RVA = "0x25CB0F0", Offset = "0x25C9AF0", VA = "0x1825CB0F0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027C3")]
				[Cpp2IlInjected.Address(RVA = "0x25C5340", Offset = "0x25C3D40", VA = "0x1825C5340", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027CC")]
				[Cpp2IlInjected.Address(RVA = "0x25C5BF0", Offset = "0x25C45F0", VA = "0x1825C5BF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027CD")]
				[Cpp2IlInjected.Address(RVA = "0x25C6430", Offset = "0x25C4E30", VA = "0x1825C6430", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027CE")]
				[Cpp2IlInjected.Address(RVA = "0x25C6F70", Offset = "0x25C5970", VA = "0x1825C6F70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027CF")]
				[Cpp2IlInjected.Address(RVA = "0x25C8840", Offset = "0x25C7240", VA = "0x1825C8840", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027D0")]
				[Cpp2IlInjected.Address(RVA = "0x25C9DB0", Offset = "0x25C87B0", VA = "0x1825C9DB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027D1")]
				[Cpp2IlInjected.Address(RVA = "0x25C4C60", Offset = "0x25C3660", VA = "0x1825C4C60", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027D2")]
				[Cpp2IlInjected.Address(RVA = "0x25C7540", Offset = "0x25C5F40", VA = "0x1825C7540", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027D3")]
				[Cpp2IlInjected.Address(RVA = "0x25C7410", Offset = "0x25C5E10", VA = "0x1825C7410", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027D4")]
				[Cpp2IlInjected.Address(RVA = "0x25C6D00", Offset = "0x25C5700", VA = "0x1825C6D00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027D5")]
				[Cpp2IlInjected.Address(RVA = "0x25C8270", Offset = "0x25C6C70", VA = "0x1825C8270", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027D6")]
				[Cpp2IlInjected.Address(RVA = "0x25C4E70", Offset = "0x25C3870", VA = "0x1825C4E70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000414")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4000CB8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CB9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CBA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CBB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000CBC")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000CBD")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000CBE")]
				public const int InventoryFullDetailsFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000CBF")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x17000741")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60027DB")]
					[Cpp2IlInjected.Address(RVA = "0x25D6820", Offset = "0x25D5220", VA = "0x1825D6820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000742")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60027DC")]
					[Cpp2IlInjected.Address(RVA = "0x25D62A0", Offset = "0x25D4CA0", VA = "0x1825D62A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000743")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60027DD")]
					[Cpp2IlInjected.Address(RVA = "0x25D6EE0", Offset = "0x25D58E0", VA = "0x1825D6EE0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000744")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60027E1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60027E2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000745")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60027E3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027E4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000746")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x60027E5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027E6")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000747")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60027F2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60027F3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60027DE")]
				[Cpp2IlInjected.Address(RVA = "0x25D5770", Offset = "0x25D4170", VA = "0x1825D5770")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027DF")]
				[Cpp2IlInjected.Address(RVA = "0x25D5BC0", Offset = "0x25D45C0", VA = "0x1825D5BC0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027E0")]
				[Cpp2IlInjected.Address(RVA = "0x25CF710", Offset = "0x25CE110", VA = "0x1825CF710", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027E7")]
				[Cpp2IlInjected.Address(RVA = "0x25D0990", Offset = "0x25CF390", VA = "0x1825D0990", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027E8")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027E9")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027EA")]
				[Cpp2IlInjected.Address(RVA = "0x25D4170", Offset = "0x25D2B70", VA = "0x1825D4170", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027EB")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027EC")]
				[Cpp2IlInjected.Address(RVA = "0x25CECE0", Offset = "0x25CD6E0", VA = "0x1825CECE0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027ED")]
				[Cpp2IlInjected.Address(RVA = "0x25D2FF0", Offset = "0x25D19F0", VA = "0x1825D2FF0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027EE")]
				[Cpp2IlInjected.Address(RVA = "0x25D2A70", Offset = "0x25D1470", VA = "0x1825D2A70", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027EF")]
				[Cpp2IlInjected.Address(RVA = "0x25D12F0", Offset = "0x25CFCF0", VA = "0x1825D12F0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027F0")]
				[Cpp2IlInjected.Address(RVA = "0x25D3940", Offset = "0x25D2340", VA = "0x1825D3940", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027F1")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027F4")]
				[Cpp2IlInjected.Address(RVA = "0x25CDA20", Offset = "0x25CC420", VA = "0x1825CDA20", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C9A")]
		private static readonly MessageParser<MissionCompleteStep> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C9B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000737")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionCompleteStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60027AC")]
			[Cpp2IlInjected.Address(RVA = "0x7FE550", Offset = "0x7FCF50", VA = "0x1807FE550")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000738")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027AD")]
			[Cpp2IlInjected.Address(RVA = "0x7FE480", Offset = "0x7FCE80", VA = "0x1807FE480")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000739")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027AE")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5B0", Offset = "0x7FCFB0", VA = "0x1807FE5B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027AF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MissionCompleteStep()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60027B0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public MissionCompleteStep(MissionCompleteStep other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1A0", Offset = "0x7FCBA0", VA = "0x1807FE1A0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionCompleteStep Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			MissionCompleteStep missionCompleteStep = default(MissionCompleteStep);
			missionCompleteStep.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (missionCompleteStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionCompleteStep;
		}

		[Cpp2IlInjected.Token(Token = "0x60027B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FE220", Offset = "0x7FCC20", VA = "0x1807FE220", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60027B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionCompleteStep other)
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

		[Cpp2IlInjected.Token(Token = "0x60027B4")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60027B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE310", Offset = "0x7FCD10", VA = "0x1807FE310", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60027B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60027B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60027B8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionCompleteStep other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027B9")]
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

		[Cpp2IlInjected.Token(Token = "0x60027BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2A0", Offset = "0x7FCCA0", VA = "0x1807FE2A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60027BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60027BC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60027BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FE370", Offset = "0x7FCD70", VA = "0x1807FE370")]
		static MissionCompleteStep()
		{
			Func<MissionCompleteStep> func = default(Func<MissionCompleteStep>);
			_parser = (MessageParser<MissionCompleteStep>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
