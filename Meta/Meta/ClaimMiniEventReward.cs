using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003F4")]
	public sealed class ClaimMiniEventReward : IMessage<ClaimMiniEventReward>, IMessage, IEquatable<ClaimMiniEventReward>, IDeepCloneable<ClaimMiniEventReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003F5")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003F6")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C42")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C43")]
				[OriginalName("InvalidEventData")]
				InvalidEventData,
				[Cpp2IlInjected.Token(Token = "0x4000C44")]
				[OriginalName("InvalidName")]
				InvalidName,
				[Cpp2IlInjected.Token(Token = "0x4000C45")]
				[OriginalName("InvalidIndex")]
				InvalidIndex,
				[Cpp2IlInjected.Token(Token = "0x4000C46")]
				[OriginalName("AlreadyClaimed")]
				AlreadyClaimed,
				[Cpp2IlInjected.Token(Token = "0x4000C47")]
				[OriginalName("NotReady")]
				NotReady,
				[Cpp2IlInjected.Token(Token = "0x4000C48")]
				[OriginalName("CannotAddItem")]
				CannotAddItem
			}

			[Cpp2IlInjected.Token(Token = "0x20003F7")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C49")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C4A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C4B")]
				public const int NameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C4C")]
				private string name_;

				[Cpp2IlInjected.Token(Token = "0x4000C4D")]
				public const int IndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C4E")]
				private int index_;

				[Cpp2IlInjected.Token(Token = "0x17000708")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60026CC")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC150", Offset = "0x1DFAB50", VA = "0x181DFC150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000709")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026CD")]
					[Cpp2IlInjected.Address(RVA = "0x1DFBC80", Offset = "0x1DFA680", VA = "0x181DFBC80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700070A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026CE")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC8E0", Offset = "0x1DFB2E0", VA = "0x181DFC8E0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700070B")]
				[DebuggerNonUserCode]
				public string Name
				{
					[Cpp2IlInjected.Token(Token = "0x60026D2")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026D3")]
					[Cpp2IlInjected.Address(RVA = "0x1DFD0F0", Offset = "0x1DFBAF0", VA = "0x181DFD0F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700070C")]
				[DebuggerNonUserCode]
				public int Index
				{
					[Cpp2IlInjected.Token(Token = "0x60026D4")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60026D5")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60026CF")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB350", Offset = "0x1DF9D50", VA = "0x181DFB350")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026D0")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB9D0", Offset = "0x1DFA3D0", VA = "0x181DFB9D0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026D1")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6AC0", Offset = "0x1DF54C0", VA = "0x181DF6AC0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026D6")]
				[Cpp2IlInjected.Address(RVA = "0x1DF70C0", Offset = "0x1DF5AC0", VA = "0x181DF70C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026D7")]
				[Cpp2IlInjected.Address(RVA = "0x1395A20", Offset = "0x1394420", VA = "0x181395A20", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026D8")]
				[Cpp2IlInjected.Address(RVA = "0x1395C10", Offset = "0x1394610", VA = "0x181395C10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026D9")]
				[Cpp2IlInjected.Address(RVA = "0x1DF9620", Offset = "0x1DF8020", VA = "0x181DF9620", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026DA")]
				[Cpp2IlInjected.Address(RVA = "0x1395F20", Offset = "0x1394920", VA = "0x181395F20", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026DB")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6460", Offset = "0x1DF4E60", VA = "0x181DF6460", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026DC")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8A50", Offset = "0x1DF7450", VA = "0x181DF8A50", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026DD")]
				[Cpp2IlInjected.Address(RVA = "0x1DF87C0", Offset = "0x1DF71C0", VA = "0x181DF87C0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026DE")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7E80", Offset = "0x1DF6880", VA = "0x181DF7E80", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026DF")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8BD0", Offset = "0x1DF75D0", VA = "0x181DF8BD0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026E0")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6650", Offset = "0x1DF5050", VA = "0x181DF6650", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026E1")]
				[Cpp2IlInjected.Address(RVA = "0x1DF9E20", Offset = "0x1DF8820", VA = "0x181DF9E20", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003F9")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C50")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C51")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C52")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C53")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000C54")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C55")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000C56")]
				public const int RewardsFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000C57")]
				private MultiReward rewards_;

				[Cpp2IlInjected.Token(Token = "0x1700070D")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60026E6")]
					[Cpp2IlInjected.Address(RVA = "0x1E09F70", Offset = "0x1E08970", VA = "0x181E09F70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700070E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026E7")]
					[Cpp2IlInjected.Address(RVA = "0x1E09DB0", Offset = "0x1E087B0", VA = "0x181E09DB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700070F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026E8")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A690", Offset = "0x1E09090", VA = "0x181E0A690", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000710")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60026EC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60026ED")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000711")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60026EE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026EF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000712")]
				[DebuggerNonUserCode]
				public MultiReward Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x60026F0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026F1")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000713")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60026FD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60026FE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60026E9")]
				[Cpp2IlInjected.Address(RVA = "0x1E08FA0", Offset = "0x1E079A0", VA = "0x181E08FA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026EA")]
				[Cpp2IlInjected.Address(RVA = "0x1E08E10", Offset = "0x1E07810", VA = "0x181E08E10")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026EB")]
				[Cpp2IlInjected.Address(RVA = "0x1E01E60", Offset = "0x1E00860", VA = "0x181E01E60", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026F2")]
				[Cpp2IlInjected.Address(RVA = "0x1E02DE0", Offset = "0x1E017E0", VA = "0x181E02DE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F3")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F4")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F5")]
				[Cpp2IlInjected.Address(RVA = "0x1E06FE0", Offset = "0x1E059E0", VA = "0x181E06FE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026F6")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026F7")]
				[Cpp2IlInjected.Address(RVA = "0x1E00C00", Offset = "0x1DFF600", VA = "0x181E00C00", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F8")]
				[Cpp2IlInjected.Address(RVA = "0x1E04E60", Offset = "0x1E03860", VA = "0x181E04E60", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026F9")]
				[Cpp2IlInjected.Address(RVA = "0x1E05E60", Offset = "0x1E04860", VA = "0x181E05E60", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026FA")]
				[Cpp2IlInjected.Address(RVA = "0x1E04020", Offset = "0x1E02A20", VA = "0x181E04020", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026FB")]
				[Cpp2IlInjected.Address(RVA = "0x1E067D0", Offset = "0x1E051D0", VA = "0x181E067D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026FC")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026FF")]
				[Cpp2IlInjected.Address(RVA = "0x1DFE5D0", Offset = "0x1DFCFD0", VA = "0x181DFE5D0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C3F")]
		private static readonly MessageParser<ClaimMiniEventReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C40")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000705")]
		[DebuggerNonUserCode]
		public static MessageParser<ClaimMiniEventReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60026BA")]
			[Cpp2IlInjected.Address(RVA = "0x727CE0", Offset = "0x7266E0", VA = "0x180727CE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000706")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60026BB")]
			[Cpp2IlInjected.Address(RVA = "0x727C10", Offset = "0x726610", VA = "0x180727C10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000707")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60026BC")]
			[Cpp2IlInjected.Address(RVA = "0x727D40", Offset = "0x726740", VA = "0x180727D40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026BD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ClaimMiniEventReward()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60026BE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ClaimMiniEventReward(ClaimMiniEventReward other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026BF")]
		[Cpp2IlInjected.Address(RVA = "0x727930", Offset = "0x726330", VA = "0x180727930", Slot = "10")]
		[DebuggerNonUserCode]
		public ClaimMiniEventReward Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ClaimMiniEventReward claimMiniEventReward = default(ClaimMiniEventReward);
			claimMiniEventReward.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (claimMiniEventReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return claimMiniEventReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C0")]
		[Cpp2IlInjected.Address(RVA = "0x7279B0", Offset = "0x7263B0", VA = "0x1807279B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60026C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClaimMiniEventReward other)
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

		[Cpp2IlInjected.Token(Token = "0x60026C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C3")]
		[Cpp2IlInjected.Address(RVA = "0x727AA0", Offset = "0x7264A0", VA = "0x180727AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60026C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60026C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClaimMiniEventReward other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026C7")]
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

		[Cpp2IlInjected.Token(Token = "0x60026C8")]
		[Cpp2IlInjected.Address(RVA = "0x727A30", Offset = "0x726430", VA = "0x180727A30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026CB")]
		[Cpp2IlInjected.Address(RVA = "0x727B00", Offset = "0x726500", VA = "0x180727B00")]
		static ClaimMiniEventReward()
		{
			Func<ClaimMiniEventReward> func = default(Func<ClaimMiniEventReward>);
			_parser = (MessageParser<ClaimMiniEventReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
