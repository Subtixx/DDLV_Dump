using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004CE")]
	public sealed class EndFtueEvent : IMessage<EndFtueEvent>, IMessage, IEquatable<EndFtueEvent>, IDeepCloneable<EndFtueEvent>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004CF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004D0")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000EFC")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000EFD")]
				[OriginalName("AlreadyDone")]
				AlreadyDone,
				[Cpp2IlInjected.Token(Token = "0x4000EFE")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000EFF")]
				[OriginalName("ProfileIsNull")]
				ProfileIsNull
			}

			[Cpp2IlInjected.Token(Token = "0x20004D1")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F00")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F01")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F02")]
				public const int FtueItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F03")]
				private int ftueItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000F04")]
				public const int CompletedFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000F05")]
				private bool completed_;

				[Cpp2IlInjected.Token(Token = "0x4000F06")]
				public const int HudStateDiffFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F07")]
				private uint hudStateDiff_;

				[Cpp2IlInjected.Token(Token = "0x4000F08")]
				public const int RewardChoicesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4000F09")]
				private static readonly FieldCodec<int> _repeated_rewardChoices_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000F0A")]
				private readonly RepeatedField<int> rewardChoices_;

				[Cpp2IlInjected.Token(Token = "0x1700089B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002ECF")]
					[Cpp2IlInjected.Address(RVA = "0x1E13830", Offset = "0x1E12230", VA = "0x181E13830")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700089C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002ED0")]
					[Cpp2IlInjected.Address(RVA = "0x1E133B0", Offset = "0x1E11DB0", VA = "0x181E133B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700089D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002ED1")]
					[Cpp2IlInjected.Address(RVA = "0x1E13DD0", Offset = "0x1E127D0", VA = "0x181E13DD0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700089E")]
				[DebuggerNonUserCode]
				public int FtueItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002ED5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ED6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700089F")]
				[DebuggerNonUserCode]
				public bool Completed
				{
					[Cpp2IlInjected.Token(Token = "0x6002ED7")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ED8")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A0")]
				[DebuggerNonUserCode]
				public uint HudStateDiff
				{
					[Cpp2IlInjected.Token(Token = "0x6002ED9")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6002EDA")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A1")]
				[DebuggerNonUserCode]
				public RepeatedField<int> RewardChoices
				{
					[Cpp2IlInjected.Token(Token = "0x6002EDB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002ED2")]
				[Cpp2IlInjected.Address(RVA = "0x1E12A20", Offset = "0x1E11420", VA = "0x181E12A20")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ED3")]
				[Cpp2IlInjected.Address(RVA = "0x1E12980", Offset = "0x1E11380", VA = "0x181E12980")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ED4")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D130", Offset = "0x1E0BB30", VA = "0x181E0D130", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EDC")]
				[Cpp2IlInjected.Address(RVA = "0x1E0DD00", Offset = "0x1E0C700", VA = "0x181E0DD00", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EDD")]
				[Cpp2IlInjected.Address(RVA = "0x1E0DB40", Offset = "0x1E0C540", VA = "0x181E0DB40", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EDE")]
				[Cpp2IlInjected.Address(RVA = "0x1E0EE20", Offset = "0x1E0D820", VA = "0x181E0EE20", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EDF")]
				[Cpp2IlInjected.Address(RVA = "0x1E107B0", Offset = "0x1E0F1B0", VA = "0x181E107B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE0")]
				[Cpp2IlInjected.Address(RVA = "0x1E11680", Offset = "0x1E10080", VA = "0x181E11680", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE1")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CA40", Offset = "0x1E0B440", VA = "0x181E0CA40", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE2")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F3A0", Offset = "0x1E0DDA0", VA = "0x181E0F3A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE3")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F1E0", Offset = "0x1E0DBE0", VA = "0x181E0F1E0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE4")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E540", Offset = "0x1E0CF40", VA = "0x181E0E540", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE5")]
				[Cpp2IlInjected.Address(RVA = "0x1E100C0", Offset = "0x1E0EAC0", VA = "0x181E100C0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE6")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CB70", Offset = "0x1E0B570", VA = "0x181E0CB70", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EE7")]
				[Cpp2IlInjected.Address(RVA = "0x1E10D30", Offset = "0x1E0F730", VA = "0x181E10D30", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004D3")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F0C")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F0D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F0E")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F0F")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000F10")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F11")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170008A2")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002EEC")]
					[Cpp2IlInjected.Address(RVA = "0x1E206E0", Offset = "0x1E1F0E0", VA = "0x181E206E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002EED")]
					[Cpp2IlInjected.Address(RVA = "0x1E20320", Offset = "0x1E1ED20", VA = "0x181E20320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002EEE")]
					[Cpp2IlInjected.Address(RVA = "0x1E20B00", Offset = "0x1E1F500", VA = "0x181E20B00", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A5")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002EF2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002EF3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A6")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002EF4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002EF5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008A7")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002F01")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002F02")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002EEF")]
				[Cpp2IlInjected.Address(RVA = "0x1E1ED90", Offset = "0x1E1D790", VA = "0x181E1ED90")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF0")]
				[Cpp2IlInjected.Address(RVA = "0x1E1FAD0", Offset = "0x1E1E4D0", VA = "0x181E1FAD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF1")]
				[Cpp2IlInjected.Address(RVA = "0x1E192A0", Offset = "0x1E17CA0", VA = "0x181E192A0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF6")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A160", Offset = "0x1E18B60", VA = "0x181E1A160", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EF9")]
				[Cpp2IlInjected.Address(RVA = "0x1E1DC00", Offset = "0x1E1C600", VA = "0x181E1DC00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFB")]
				[Cpp2IlInjected.Address(RVA = "0x1E18C00", Offset = "0x1E17600", VA = "0x181E18C00", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFC")]
				[Cpp2IlInjected.Address(RVA = "0x1E1C1A0", Offset = "0x1E1ABA0", VA = "0x181E1C1A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFD")]
				[Cpp2IlInjected.Address(RVA = "0x1E1B620", Offset = "0x1E1A020", VA = "0x181E1B620", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFE")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A750", Offset = "0x1E19150", VA = "0x181E1A750", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EFF")]
				[Cpp2IlInjected.Address(RVA = "0x1E1CF90", Offset = "0x1E1B990", VA = "0x181E1CF90", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002F00")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002F03")]
				[Cpp2IlInjected.Address(RVA = "0x1E17CA0", Offset = "0x1E166A0", VA = "0x181E17CA0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002F04")]
				[Cpp2IlInjected.Address(RVA = "0x1E1B090", Offset = "0x1E19A90", VA = "0x181E1B090")]
				private void GiveRewards(RepeatedField<FtueReward> rewards, in Player player, in World world, ITransactionContext context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000EF9")]
		private static readonly MessageParser<EndFtueEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EFA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000898")]
		[DebuggerNonUserCode]
		public static MessageParser<EndFtueEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBD")]
			[Cpp2IlInjected.Address(RVA = "0x174CC40", Offset = "0x174B640", VA = "0x18174CC40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000899")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBE")]
			[Cpp2IlInjected.Address(RVA = "0x174CB70", Offset = "0x174B570", VA = "0x18174CB70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBF")]
			[Cpp2IlInjected.Address(RVA = "0x174CCA0", Offset = "0x174B6A0", VA = "0x18174CCA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public EndFtueEvent()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public EndFtueEvent(EndFtueEvent other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC2")]
		[Cpp2IlInjected.Address(RVA = "0x174C890", Offset = "0x174B290", VA = "0x18174C890", Slot = "10")]
		[DebuggerNonUserCode]
		public EndFtueEvent Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			EndFtueEvent endFtueEvent = default(EndFtueEvent);
			endFtueEvent.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (endFtueEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return endFtueEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC3")]
		[Cpp2IlInjected.Address(RVA = "0x174C910", Offset = "0x174B310", VA = "0x18174C910", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002EC4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EndFtueEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x6002EC5")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC6")]
		[Cpp2IlInjected.Address(RVA = "0x174CA00", Offset = "0x174B400", VA = "0x18174CA00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EndFtueEvent other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECA")]
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

		[Cpp2IlInjected.Token(Token = "0x6002ECB")]
		[Cpp2IlInjected.Address(RVA = "0x174C990", Offset = "0x174B390", VA = "0x18174C990", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECE")]
		[Cpp2IlInjected.Address(RVA = "0x174CA60", Offset = "0x174B460", VA = "0x18174CA60")]
		static EndFtueEvent()
		{
			Func<EndFtueEvent> func = default(Func<EndFtueEvent>);
			_parser = (MessageParser<EndFtueEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
