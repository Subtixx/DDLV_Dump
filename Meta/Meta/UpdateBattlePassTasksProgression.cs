using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20005CA")]
	public sealed class UpdateBattlePassTasksProgression : IMessage<UpdateBattlePassTasksProgression>, IMessage, IEquatable<UpdateBattlePassTasksProgression>, IDeepCloneable<UpdateBattlePassTasksProgression>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005CB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20005CC")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4001181")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4001182")]
				[OriginalName("NoBattlePassFound")]
				NoBattlePassFound
			}

			[Cpp2IlInjected.Token(Token = "0x20005CD")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001183")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001184")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001185")]
				public const int BattlePassesFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001186")]
				private static readonly MapField<string, BattlePassSeasonData>.Codec _map_battlePasses_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001187")]
				private readonly MapField<string, BattlePassSeasonData> battlePasses_;

				[Cpp2IlInjected.Token(Token = "0x4001188")]
				public const int RemoveIsNewFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001189")]
				private bool removeIsNew_;

				[Cpp2IlInjected.Token(Token = "0x17000A42")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60037D2")]
					[Cpp2IlInjected.Address(RVA = "0x1D710C0", Offset = "0x1D6FAC0", VA = "0x181D710C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A43")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037D3")]
					[Cpp2IlInjected.Address(RVA = "0x1D70A60", Offset = "0x1D6F460", VA = "0x181D70A60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A44")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037D4")]
					[Cpp2IlInjected.Address(RVA = "0x1D71120", Offset = "0x1D6FB20", VA = "0x181D71120", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A45")]
				[DebuggerNonUserCode]
				public MapField<string, BattlePassSeasonData> BattlePasses
				{
					[Cpp2IlInjected.Token(Token = "0x60037D8")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A46")]
				[DebuggerNonUserCode]
				public bool RemoveIsNew
				{
					[Cpp2IlInjected.Token(Token = "0x60037D9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60037DA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60037D5")]
				[Cpp2IlInjected.Address(RVA = "0x1D702D0", Offset = "0x1D6ECD0", VA = "0x181D702D0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037D6")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FCE0", Offset = "0x1D6E6E0", VA = "0x181D6FCE0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037D7")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A6B0", Offset = "0x1D690B0", VA = "0x181D6A6B0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037DB")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A850", Offset = "0x1D69250", VA = "0x181D6A850", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037DC")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AE30", Offset = "0x1D69830", VA = "0x181D6AE30", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037DD")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037DE")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D470", Offset = "0x1D6BE70", VA = "0x181D6D470", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037DF")]
				[Cpp2IlInjected.Address(RVA = "0x1D6E810", Offset = "0x1D6D210", VA = "0x181D6E810", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037E0")]
				[Cpp2IlInjected.Address(RVA = "0x1D69900", Offset = "0x1D68300", VA = "0x181D69900", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037E1")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C510", Offset = "0x1D6AF10", VA = "0x181D6C510", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037E2")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C210", Offset = "0x1D6AC10", VA = "0x181D6C210", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037E3")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B600", Offset = "0x1D6A000", VA = "0x181D6B600", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037E4")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D210", Offset = "0x1D6BC10", VA = "0x181D6D210", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037E5")]
				[Cpp2IlInjected.Address(RVA = "0x1D69B90", Offset = "0x1D68590", VA = "0x181D69B90", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20005CF")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400118B")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400118C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400118D")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400118E")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400118F")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001190")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000A47")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60037EA")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F370", Offset = "0x1D7DD70", VA = "0x181D7F370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A48")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037EB")]
					[Cpp2IlInjected.Address(RVA = "0x1D7EDD0", Offset = "0x1D7D7D0", VA = "0x181D7EDD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A49")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60037EC")]
					[Cpp2IlInjected.Address(RVA = "0x1D7FAB0", Offset = "0x1D7E4B0", VA = "0x181D7FAB0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A4A")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60037F0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60037F1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A4B")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60037F2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60037F3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A4C")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60037FF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003800")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60037ED")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E630", Offset = "0x1D7D030", VA = "0x181D7E630")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037EE")]
				[Cpp2IlInjected.Address(RVA = "0x1D7DF80", Offset = "0x1D7C980", VA = "0x181D7DF80")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037EF")]
				[Cpp2IlInjected.Address(RVA = "0x1D77600", Offset = "0x1D76000", VA = "0x181D77600", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037F4")]
				[Cpp2IlInjected.Address(RVA = "0x1D78070", Offset = "0x1D76A70", VA = "0x181D78070", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037F5")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60037F6")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037F7")]
				[Cpp2IlInjected.Address(RVA = "0x1D7C160", Offset = "0x1D7AB60", VA = "0x181D7C160", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037F8")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037F9")]
				[Cpp2IlInjected.Address(RVA = "0x1D76460", Offset = "0x1D74E60", VA = "0x181D76460", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60037FA")]
				[Cpp2IlInjected.Address(RVA = "0x1D79900", Offset = "0x1D78300", VA = "0x181D79900", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037FB")]
				[Cpp2IlInjected.Address(RVA = "0x1D795D0", Offset = "0x1D77FD0", VA = "0x181D795D0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037FC")]
				[Cpp2IlInjected.Address(RVA = "0x1D78B80", Offset = "0x1D77580", VA = "0x181D78B80", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60037FD")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B520", Offset = "0x1D79F20", VA = "0x181D7B520", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60037FE")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003801")]
				[Cpp2IlInjected.Address(RVA = "0x1D71C10", Offset = "0x1D70610", VA = "0x181D71C10", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400117E")]
		private static readonly MessageParser<UpdateBattlePassTasksProgression> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400117F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000A3F")]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateBattlePassTasksProgression> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60037C0")]
			[Cpp2IlInjected.Address(RVA = "0x15D9900", Offset = "0x15D8300", VA = "0x1815D9900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A40")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037C1")]
			[Cpp2IlInjected.Address(RVA = "0x15D9830", Offset = "0x15D8230", VA = "0x1815D9830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A41")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037C2")]
			[Cpp2IlInjected.Address(RVA = "0x15D9960", Offset = "0x15D8360", VA = "0x1815D9960", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037C3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpdateBattlePassTasksProgression()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60037C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpdateBattlePassTasksProgression(UpdateBattlePassTasksProgression other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037C5")]
		[Cpp2IlInjected.Address(RVA = "0x15D9550", Offset = "0x15D7F50", VA = "0x1815D9550", Slot = "10")]
		[DebuggerNonUserCode]
		public UpdateBattlePassTasksProgression Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpdateBattlePassTasksProgression updateBattlePassTasksProgression = default(UpdateBattlePassTasksProgression);
			updateBattlePassTasksProgression.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (updateBattlePassTasksProgression._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return updateBattlePassTasksProgression;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C6")]
		[Cpp2IlInjected.Address(RVA = "0x15D95D0", Offset = "0x15D7FD0", VA = "0x1815D95D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60037C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpdateBattlePassTasksProgression other)
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

		[Cpp2IlInjected.Token(Token = "0x60037C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C9")]
		[Cpp2IlInjected.Address(RVA = "0x15D96C0", Offset = "0x15D80C0", VA = "0x1815D96C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60037CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60037CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60037CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateBattlePassTasksProgression other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037CD")]
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

		[Cpp2IlInjected.Token(Token = "0x60037CE")]
		[Cpp2IlInjected.Address(RVA = "0x15D9650", Offset = "0x15D8050", VA = "0x1815D9650", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037CF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037D0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60037D1")]
		[Cpp2IlInjected.Address(RVA = "0x15D9720", Offset = "0x15D8120", VA = "0x1815D9720")]
		static UpdateBattlePassTasksProgression()
		{
			Func<UpdateBattlePassTasksProgression> func = default(Func<UpdateBattlePassTasksProgression>);
			_parser = (MessageParser<UpdateBattlePassTasksProgression>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
