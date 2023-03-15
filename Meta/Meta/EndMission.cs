using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000417")]
	public sealed class EndMission : IMessage<EndMission>, IMessage, IEquatable<EndMission>, IDeepCloneable<EndMission>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000418")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000419")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000CC5")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000CC6")]
				[OriginalName("Error")]
				Error,
				[Cpp2IlInjected.Token(Token = "0x4000CC7")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x200041A")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4000CC8")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CC9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CCA")]
				public const int SlotIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CCB")]
				private int slotId_;

				[Cpp2IlInjected.Token(Token = "0x4000CCC")]
				public const int SlotClassFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000CCD")]
				private MissionSlotClass slotClass_;

				[Cpp2IlInjected.Token(Token = "0x4000CCE")]
				public const int FriendshipChoicesFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4000CCF")]
				private static readonly FieldCodec<FriendshipChoice> _repeated_friendshipChoices_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000CD0")]
				private readonly RepeatedField<FriendshipChoice> friendshipChoices_;

				[Cpp2IlInjected.Token(Token = "0x4000CD1")]
				public const int CheatForcedFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000CD2")]
				private bool cheatForced_;

				[Cpp2IlInjected.Token(Token = "0x4000CD3")]
				public const int InventoryFullResolutionFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000CD4")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.Token(Token = "0x1700074B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600280E")]
					[Cpp2IlInjected.Address(RVA = "0x1E13950", Offset = "0x1E12350", VA = "0x181E13950")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700074C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600280F")]
					[Cpp2IlInjected.Address(RVA = "0x1E13130", Offset = "0x1E11B30", VA = "0x181E13130")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700074D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002810")]
					[Cpp2IlInjected.Address(RVA = "0x1E14250", Offset = "0x1E12C50", VA = "0x181E14250", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700074E")]
				[DebuggerNonUserCode]
				public int SlotId
				{
					[Cpp2IlInjected.Token(Token = "0x6002814")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002815")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700074F")]
				[DebuggerNonUserCode]
				public MissionSlotClass SlotClass
				{
					[Cpp2IlInjected.Token(Token = "0x6002816")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(MissionSlotClass);
					}
					[Cpp2IlInjected.Token(Token = "0x6002817")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000750")]
				[DebuggerNonUserCode]
				public RepeatedField<FriendshipChoice> FriendshipChoices
				{
					[Cpp2IlInjected.Token(Token = "0x6002818")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000751")]
				[DebuggerNonUserCode]
				public bool CheatForced
				{
					[Cpp2IlInjected.Token(Token = "0x6002819")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600281A")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000752")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x600281B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "16")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600281C")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "17")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002811")]
				[Cpp2IlInjected.Address(RVA = "0x1E12DB0", Offset = "0x1E117B0", VA = "0x181E12DB0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002812")]
				[Cpp2IlInjected.Address(RVA = "0x1E12E40", Offset = "0x1E11840", VA = "0x181E12E40")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002813")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CE10", Offset = "0x1E0B810", VA = "0x181E0CE10", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600281D")]
				[Cpp2IlInjected.Address(RVA = "0x1E0DDF0", Offset = "0x1E0C7F0", VA = "0x181E0DDF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600281E")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D9D0", Offset = "0x1E0C3D0", VA = "0x181E0D9D0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600281F")]
				[Cpp2IlInjected.Address(RVA = "0x1E0ED40", Offset = "0x1E0D740", VA = "0x181E0ED40", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002820")]
				[Cpp2IlInjected.Address(RVA = "0x1E105D0", Offset = "0x1E0EFD0", VA = "0x181E105D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002821")]
				[Cpp2IlInjected.Address(RVA = "0x1E11470", Offset = "0x1E0FE70", VA = "0x181E11470", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002822")]
				[Cpp2IlInjected.Address(RVA = "0x1E0C600", Offset = "0x1E0B000", VA = "0x181E0C600", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002823")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F440", Offset = "0x1E0DE40", VA = "0x181E0F440", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002824")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F5E0", Offset = "0x1E0DFE0", VA = "0x181E0F5E0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002825")]
				[Cpp2IlInjected.Address(RVA = "0x1E0EAB0", Offset = "0x1E0D4B0", VA = "0x181E0EAB0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002826")]
				[Cpp2IlInjected.Address(RVA = "0x1E0FED0", Offset = "0x1E0E8D0", VA = "0x181E0FED0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002827")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CCA0", Offset = "0x1E0B6A0", VA = "0x181E0CCA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002828")]
				[Cpp2IlInjected.Address(RVA = "0x1E11100", Offset = "0x1E0FB00", VA = "0x181E11100", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200041C")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4000CD6")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CD7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CD8")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CD9")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000CDA")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000CDB")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000CDC")]
				public const int InventoryFullDetailsFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000CDD")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x17000753")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600282D")]
					[Cpp2IlInjected.Address(RVA = "0x1E20920", Offset = "0x1E1F320", VA = "0x181E20920")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000754")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600282E")]
					[Cpp2IlInjected.Address(RVA = "0x1E1FFA0", Offset = "0x1E1E9A0", VA = "0x181E1FFA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000755")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600282F")]
					[Cpp2IlInjected.Address(RVA = "0x1E20F80", Offset = "0x1E1F980", VA = "0x181E20F80", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000756")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002833")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002834")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000757")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002835")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002836")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000758")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x6002837")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002838")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000759")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002844")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002845")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700075A")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6002846")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002830")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F5B0", Offset = "0x1E1DFB0", VA = "0x181E1F5B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002831")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F7D0", Offset = "0x1E1E1D0", VA = "0x181E1F7D0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002832")]
				[Cpp2IlInjected.Address(RVA = "0x1E19A60", Offset = "0x1E18460", VA = "0x181E19A60", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002839")]
				[Cpp2IlInjected.Address(RVA = "0x1E19DF0", Offset = "0x1E187F0", VA = "0x181E19DF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600283A")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600283B")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600283C")]
				[Cpp2IlInjected.Address(RVA = "0x1E1D8A0", Offset = "0x1E1C2A0", VA = "0x181E1D8A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600283D")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600283E")]
				[Cpp2IlInjected.Address(RVA = "0x1E18CD0", Offset = "0x1E176D0", VA = "0x181E18CD0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600283F")]
				[Cpp2IlInjected.Address(RVA = "0x1E1B930", Offset = "0x1E1A330", VA = "0x181E1B930", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002840")]
				[Cpp2IlInjected.Address(RVA = "0x1E1BE50", Offset = "0x1E1A850", VA = "0x181E1BE50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002841")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A9C0", Offset = "0x1E193C0", VA = "0x181E1A9C0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002842")]
				[Cpp2IlInjected.Address(RVA = "0x1E1D4C0", Offset = "0x1E1BEC0", VA = "0x181E1D4C0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002843")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002847")]
				[Cpp2IlInjected.Address(RVA = "0x1E155D0", Offset = "0x1E13FD0", VA = "0x181E155D0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000CC2")]
		private static readonly MessageParser<EndMission> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CC3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000748")]
		[DebuggerNonUserCode]
		public static MessageParser<EndMission> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60027FC")]
			[Cpp2IlInjected.Address(RVA = "0x174D160", Offset = "0x174BB60", VA = "0x18174D160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000749")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027FD")]
			[Cpp2IlInjected.Address(RVA = "0x174D090", Offset = "0x174BA90", VA = "0x18174D090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027FE")]
			[Cpp2IlInjected.Address(RVA = "0x174D1C0", Offset = "0x174BBC0", VA = "0x18174D1C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027FF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public EndMission()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002800")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public EndMission(EndMission other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002801")]
		[Cpp2IlInjected.Address(RVA = "0x174CDB0", Offset = "0x174B7B0", VA = "0x18174CDB0", Slot = "10")]
		[DebuggerNonUserCode]
		public EndMission Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			EndMission endMission = default(EndMission);
			endMission.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (endMission._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return endMission;
		}

		[Cpp2IlInjected.Token(Token = "0x6002802")]
		[Cpp2IlInjected.Address(RVA = "0x174CE30", Offset = "0x174B830", VA = "0x18174CE30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002803")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EndMission other)
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

		[Cpp2IlInjected.Token(Token = "0x6002804")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002805")]
		[Cpp2IlInjected.Address(RVA = "0x174CF20", Offset = "0x174B920", VA = "0x18174CF20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002806")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002807")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002808")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EndMission other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002809")]
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

		[Cpp2IlInjected.Token(Token = "0x600280A")]
		[Cpp2IlInjected.Address(RVA = "0x174CEB0", Offset = "0x174B8B0", VA = "0x18174CEB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600280B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600280C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600280D")]
		[Cpp2IlInjected.Address(RVA = "0x174CF80", Offset = "0x174B980", VA = "0x18174CF80")]
		static EndMission()
		{
			Func<EndMission> func = default(Func<EndMission>);
			_parser = (MessageParser<EndMission>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
