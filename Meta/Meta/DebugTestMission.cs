using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003DF")]
	public sealed class DebugTestMission : IMessage<DebugTestMission>, IMessage, IEquatable<DebugTestMission>, IDeepCloneable<DebugTestMission>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003E0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003E1")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C04")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C05")]
				[OriginalName("Error")]
				Error
			}

			[Cpp2IlInjected.Token(Token = "0x20003E2")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C06")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C07")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C08")]
				public const int MissionIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C09")]
				private int missionId_;

				[Cpp2IlInjected.Token(Token = "0x4000C0A")]
				public const int AutoStartFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000C0B")]
				private bool autoStart_;

				[Cpp2IlInjected.Token(Token = "0x4000C0C")]
				public const int StepIndexFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C0D")]
				private int stepIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000C0E")]
				public const int MissionChoiceFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000C0F")]
				private MissionChoice missionChoice_;

				[Cpp2IlInjected.Token(Token = "0x170006E7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002622")]
					[Cpp2IlInjected.Address(RVA = "0x211BC60", Offset = "0x211A660", VA = "0x18211BC60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006E8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002623")]
					[Cpp2IlInjected.Address(RVA = "0x211AF80", Offset = "0x2119980", VA = "0x18211AF80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006E9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002624")]
					[Cpp2IlInjected.Address(RVA = "0x211C080", Offset = "0x211AA80", VA = "0x18211C080", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006EA")]
				[DebuggerNonUserCode]
				public int MissionId
				{
					[Cpp2IlInjected.Token(Token = "0x6002628")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002629")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006EB")]
				[DebuggerNonUserCode]
				public bool AutoStart
				{
					[Cpp2IlInjected.Token(Token = "0x600262A")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600262B")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006EC")]
				[DebuggerNonUserCode]
				public int StepIndex
				{
					[Cpp2IlInjected.Token(Token = "0x600262C")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600262D")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006ED")]
				[DebuggerNonUserCode]
				public MissionChoice MissionChoice
				{
					[Cpp2IlInjected.Token(Token = "0x600262E")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(MissionChoice);
					}
					[Cpp2IlInjected.Token(Token = "0x600262F")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002625")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002626")]
				[Cpp2IlInjected.Address(RVA = "0x211A980", Offset = "0x2119380", VA = "0x18211A980")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002627")]
				[Cpp2IlInjected.Address(RVA = "0x2115D70", Offset = "0x2114770", VA = "0x182115D70", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002630")]
				[Cpp2IlInjected.Address(RVA = "0x2116820", Offset = "0x2115220", VA = "0x182116820", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002631")]
				[Cpp2IlInjected.Address(RVA = "0x2116AF0", Offset = "0x21154F0", VA = "0x182116AF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002632")]
				[Cpp2IlInjected.Address(RVA = "0x2117B60", Offset = "0x2116560", VA = "0x182117B60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002633")]
				[Cpp2IlInjected.Address(RVA = "0x2118D80", Offset = "0x2117780", VA = "0x182118D80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002634")]
				[Cpp2IlInjected.Address(RVA = "0x2119520", Offset = "0x2117F20", VA = "0x182119520", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002635")]
				[Cpp2IlInjected.Address(RVA = "0x21151E0", Offset = "0x2113BE0", VA = "0x1821151E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002636")]
				[Cpp2IlInjected.Address(RVA = "0x2117E70", Offset = "0x2116870", VA = "0x182117E70", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002637")]
				[Cpp2IlInjected.Address(RVA = "0x2117DB0", Offset = "0x21167B0", VA = "0x182117DB0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002638")]
				[Cpp2IlInjected.Address(RVA = "0x2116FD0", Offset = "0x21159D0", VA = "0x182116FD0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002639")]
				[Cpp2IlInjected.Address(RVA = "0x2118430", Offset = "0x2116E30", VA = "0x182118430", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600263A")]
				[Cpp2IlInjected.Address(RVA = "0x2115A00", Offset = "0x2114400", VA = "0x182115A00", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003E4")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C11")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C12")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C13")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C14")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000C15")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C16")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000C17")]
				public const int AnyCharacterChangesFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000C18")]
				private bool anyCharacterChanges_;

				[Cpp2IlInjected.Token(Token = "0x170006EE")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600263F")]
					[Cpp2IlInjected.Address(RVA = "0x2129A60", Offset = "0x2128460", VA = "0x182129A60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006EF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002640")]
					[Cpp2IlInjected.Address(RVA = "0x2128FA0", Offset = "0x21279A0", VA = "0x182128FA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006F0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002641")]
					[Cpp2IlInjected.Address(RVA = "0x2129C40", Offset = "0x2128640", VA = "0x182129C40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006F1")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002645")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002646")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006F2")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002647")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002648")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006F3")]
				[DebuggerNonUserCode]
				public bool AnyCharacterChanges
				{
					[Cpp2IlInjected.Token(Token = "0x6002649")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600264A")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006F4")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002656")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002657")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002642")]
				[Cpp2IlInjected.Address(RVA = "0x21288C0", Offset = "0x21272C0", VA = "0x1821288C0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002643")]
				[Cpp2IlInjected.Address(RVA = "0x2127AD0", Offset = "0x21264D0", VA = "0x182127AD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002644")]
				[Cpp2IlInjected.Address(RVA = "0x21210A0", Offset = "0x211FAA0", VA = "0x1821210A0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600264B")]
				[Cpp2IlInjected.Address(RVA = "0x2122730", Offset = "0x2121130", VA = "0x182122730", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600264C")]
				[Cpp2IlInjected.Address(RVA = "0x5CA1B0", Offset = "0x5C8BB0", VA = "0x1805CA1B0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600264D")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3F0", Offset = "0x5C8DF0", VA = "0x1805CA3F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600264E")]
				[Cpp2IlInjected.Address(RVA = "0x2126820", Offset = "0x2125220", VA = "0x182126820", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600264F")]
				[Cpp2IlInjected.Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002650")]
				[Cpp2IlInjected.Address(RVA = "0x211FF30", Offset = "0x211E930", VA = "0x18211FF30", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002651")]
				[Cpp2IlInjected.Address(RVA = "0x2124A80", Offset = "0x2123480", VA = "0x182124A80", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002652")]
				[Cpp2IlInjected.Address(RVA = "0x2125620", Offset = "0x2124020", VA = "0x182125620", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002653")]
				[Cpp2IlInjected.Address(RVA = "0x2123310", Offset = "0x2121D10", VA = "0x182123310", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002654")]
				[Cpp2IlInjected.Address(RVA = "0x21260C0", Offset = "0x2124AC0", VA = "0x1821260C0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002655")]
				[Cpp2IlInjected.Address(RVA = "0x5CA0D0", Offset = "0x5C8AD0", VA = "0x1805CA0D0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002658")]
				[Cpp2IlInjected.Address(RVA = "0x211D860", Offset = "0x211C260", VA = "0x18211D860", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C01")]
		private static readonly MessageParser<DebugTestMission> _parser = (MessageParser<DebugTestMission>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new DebugTestMission()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C02")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170006E4")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugTestMission> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60025FE")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BDB0", Offset = "0x1A1A7B0", VA = "0x181A1BDB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60025FF")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BCE0", Offset = "0x1A1A6E0", VA = "0x181A1BCE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002600")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BE10", Offset = "0x1A1A810", VA = "0x181A1BE10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002601")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugTestMission()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002602")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugTestMission(DebugTestMission other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002603")]
		[Cpp2IlInjected.Address(RVA = "0x1A17480", Offset = "0x1A15E80", VA = "0x181A17480", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugTestMission Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugTestMission debugTestMission = default(DebugTestMission);
			debugTestMission.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugTestMission._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugTestMission;
		}

		[Cpp2IlInjected.Token(Token = "0x6002604")]
		[Cpp2IlInjected.Address(RVA = "0x1A17500", Offset = "0x1A15F00", VA = "0x181A17500", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002605")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugTestMission other)
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

		[Cpp2IlInjected.Token(Token = "0x6002606")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002607")]
		[Cpp2IlInjected.Address(RVA = "0x1A19570", Offset = "0x1A17F70", VA = "0x181A19570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002608")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002609")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600260A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugTestMission other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600260B")]
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

		[Cpp2IlInjected.Token(Token = "0x600260C")]
		[Cpp2IlInjected.Address(RVA = "0x1A17580", Offset = "0x1A15F80", VA = "0x181A17580", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600260D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600260E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600260F")]
		[Cpp2IlInjected.Address(RVA = "0x1A192E0", Offset = "0x1A17CE0", VA = "0x181A192E0")]
		public static bool StartMission(MissionSlot slot, in Player player, in World world, ITransactionContext context, [Optional] MissionChoice? choice, int stepIndex = 0)
		{
			//Discarded unreachable code: IL_0088
			RepeatedField<MissionStepData> steps_ = slot.Data.steps_;
			Func<MissionStepData, bool> _003C_003E9__24_ = _003C_003Ec._003C_003E9__24_0;
			if (_003C_003E9__24_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			if (Enumerable.FirstOrDefault<MissionStepData>((IEnumerable<>)(object)steps_, (Func<, >)(object)_003C_003E9__24_) != null)
			{
			}
			StartMission.Types.Response response = new StartMission.Types.Response();
			StartMission.Types.Request request = new StartMission.Types.Request();
			MissionChoice missionChoice_ = default(MissionChoice);
			request.missionChoice_ = missionChoice_;
			MissionSlotClass missionSlotClass = (request.slotClass_ = slot.class_);
			int num = (request.slotId_ = slot.slotId_);
			request.stepIndex_ = 0;
			request.CheatForced = true;
			response.request_ = request;
			return ((TransactionAction<TResult>)(object)response).Apply(in player, in world, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6002610")]
		[Cpp2IlInjected.Address(RVA = "0x1A175F0", Offset = "0x1A15FF0", VA = "0x181A175F0")]
		internal static void LockCharacterInVillage(Item characterItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0008
			ProfileWorld section = world.Section;
		}

		[Cpp2IlInjected.Token(Token = "0x6002611")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A8B0", Offset = "0x1A192B0", VA = "0x181A1A8B0")]
		public static void UnlockCharacter(Item characterItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0090
			//IL_0055: Expected O, but got I4
			int itemID = characterItem.ItemID;
			int num = 0;
			ProfileWorld section = world.Section;
			Character character2 = default(Character);
			if (character2 == null || !character2.IsUnlocked)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				int itemID2;
				if (flag)
				{
					Item item = default(Item);
					itemID2 = item.ItemID;
				}
				itemID2 = itemID;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (!flag2 || flag3)
				{
				}
				Item character = (Item)itemID;
				IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<MissionItemData>(ItemType.Mission);
				Func<MissionItemData, bool> func = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
				{
					//Discarded unreachable code: IL_000f
					Item character3 = character;
					return x.IsUnlockingCharacter(character3);
				};
				MissionItemData missionItemData = Enumerable.FirstOrDefault<MissionItemData>(allByType, (Func<, >)(object)func);
				if (missionItemData != null)
				{
					int iD = missionItemData.ID;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002612")]
		[Cpp2IlInjected.Address(RVA = "0x1A17650", Offset = "0x1A16050", VA = "0x181A17650")]
		[IteratorStateMachine(typeof(_003CRequiredVillageArea_003Ed__27))]
		private static IEnumerable<VillageAreaType> RequiredVillageArea(Item characterItem)
		{
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			new _003CRequiredVillageArea_003Ed__27(-2)._003C_003E3__characterItem = (Item)itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002613")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B1F0", Offset = "0x1A19BF0", VA = "0x181A1B1F0")]
		private static void UnlockRequiredVillageArea(Item characterItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_005e
			//IL_002d: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			int itemID = characterItem.ItemID;
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag2 = default(bool);
				if (flag2)
				{
					ProfileWorld section = world.Section;
					int price = ((glPlayFab.Disney.BattlePassReward)num).Price;
					bool flag3 = default(bool);
					bool flag4 = default(bool);
					if (!flag3 && flag4)
					{
						UnlockVillageArea((VillageAreaType)num, in player, in world, context);
					}
				}
			}
			_003CRequiredVillageArea_003Ed__27 _003CRequiredVillageArea_003Ed__ = new _003CRequiredVillageArea_003Ed__27(-2);
			_003CRequiredVillageArea_003Ed__._003C_003E3__characterItem = (Item)itemID;
			if (_003CRequiredVillageArea_003Ed__ != null)
			{
			}
			if (_003CRequiredVillageArea_003Ed__ == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002614")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B8B0", Offset = "0x1A1A2B0", VA = "0x181A1B8B0")]
		internal static void UnlockVillageArea(VillageAreaType area, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0036
			ProfileWorld section = world.Section;
			bool flag = default(bool);
			if (!flag)
			{
				DebugUnlockVillageArea.Types.Response response = new DebugUnlockVillageArea.Types.Response();
				DebugUnlockVillageArea.Types.Request request = new DebugUnlockVillageArea.Types.Request();
				request.area_ = area;
				response.request_ = request;
				bool flag2 = ((TransactionAction<TResult>)(object)response).Apply(in player, in world, context);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002615")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B600", Offset = "0x1A1A000", VA = "0x181A1B600")]
		public static void UnlockTool(Item toolItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_003e, IL_0044
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Tool)
			{
				return;
			}
			ProfilePlayer section = player.Section;
			bool flag = default(bool);
			if (!flag)
			{
				GridCollection gridCollection_ = world.Section.gridCollection_;
				IEnumerable<(IGrid, GridObject)> enumerable = default(IEnumerable<(IGrid, GridObject)>);
				List<(IGrid, GridObject)> list = (List<(IGrid, GridObject)>)(object)Enumerable.ToList<(IGrid, GridObject)>((IEnumerable<>)enumerable);
				bool flag2 = default(bool);
				uint num2 = default(uint);
				if (flag2 && num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002616")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A3D0", Offset = "0x1A18DD0", VA = "0x181A1A3D0")]
		internal static void UnlockBuilding(Item buildingItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_007a
			//IL_005c: Expected I4, but got O
			if ((object)typeof(UnlockBuilding.Types.Response).TypeHandle != null)
			{
				return;
			}
			RepeatedField<int> unlockedBuildings_ = world.Section.unlockedBuildings_;
			bool flag = default(bool);
			if (!flag)
			{
				ProfilePlayer section = player.Section;
				if ((long)section.level_ < (long)(IntPtr)section)
				{
					ProfilePlayer section2 = player.Section;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				UnlockBuilding.Types.Response response = new UnlockBuilding.Types.Response();
				UnlockBuilding.Types.Request request = new UnlockBuilding.Types.Request();
				request.buildingId_ = 0;
				request.unlock_ = true;
				request.isCastle_ = (byte)(int)request != 0;
				request.cheatForced_ = true;
				response.request_ = request;
				bool flag3 = ((TransactionAction<TResult>)(object)response).Apply(in player, in world, context);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002617")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B9C0", Offset = "0x1A1A3C0", VA = "0x181A1B9C0")]
		private static bool UpgradeCastleLevel(int CastleLevel, in Player player, in World world, ITransactionContext context)
		{
			//IL_0040: Expected I4, but got I8
			//IL_0050: Expected I4, but got O
			if (world.Section.castleLevel_ < CastleLevel)
			{
				int itemID = BuildingItem.DreamCastle.ItemID;
				int castleLevel_ = world.Section.castleLevel_;
				if (castleLevel_ < CastleLevel)
				{
					UpgradeBuilding.Types.Response response = new UpgradeBuilding.Types.Response();
					UpgradeBuilding.Types.Request request = new UpgradeBuilding.Types.Request();
					request.buildingType_ = UpgradeBuilding.Types.BuildingType.Castle;
					Item dreamCastle = BuildingItem.DreamCastle;
					request.gridObjectID_ = (uint)(int)dreamCastle;
					response.request_ = request;
					response.DebugSkipValidation = true;
					if (!((TransactionAction<TResult>)(object)response).Apply(in player, in world, context))
					{
						throw new NullReferenceException();
					}
					castleLevel_++;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002618")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A750", Offset = "0x1A19150", VA = "0x181A1A750")]
		private static void UnlockCharacterRealm(Item characterItem, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0013
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				Item item = default(Item);
				int itemID = item.ItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002619")]
		[Cpp2IlInjected.Address(RVA = "0x1A1ADF0", Offset = "0x1A197F0", VA = "0x181A1ADF0")]
		internal static void UnlockRealm(Item universeTag, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_011b
			//IL_0014: Expected O, but got I4
			int itemID = universeTag.ItemID;
			Item universeTag2 = (Item)itemID;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Tag)
			{
				return;
			}
			ProfileWorld section = world.Section;
			Item universeTagItem = universeTag2;
			ulong num = default(ulong);
			if (section.IsRealmUnlocked(universeTagItem) || num == 0)
			{
				return;
			}
			Func<WorldData.Types.World, bool> func = (Func<WorldData.Types.World, bool>)(object)(Func<T, TResult>)delegate(WorldData.Types.World x)
			{
				Item universeTagItem2 = x.UniverseTagItem;
				throw new NullReferenceException();
			};
			WorldData.Types.World world2 = default(WorldData.Types.World);
			if (world2 != null)
			{
				bool flag = UpgradeCastleLevel(4, in player, in world, context);
				ProfilePlayer section2 = player.Section;
				int unlockAtLevel_ = world2.unlockAtLevel_;
				if ((long)(IntPtr)ProfilePlayer._repeated_tools_codec < (long)unlockAtLevel_)
				{
					ProfilePlayer section3 = player.Section;
					IPlayerEventDispatcher dispatcher = player.dispatcher;
					int unlockAtLevel_2 = world2.unlockAtLevel_;
					section3.SetLevel(unlockAtLevel_2, dispatcher);
				}
				UnlockRealm.Types.Response response = new UnlockRealm.Types.Response();
				UnlockRealm.Types.Request request = new UnlockRealm.Types.Request();
				int num2 = (request.realmID_ = world2.sceneId_);
				request.cheatForced_ = true;
				response.request_ = request;
				bool flag2 = ((TransactionAction<TResult>)(object)response).Apply(in player, in world, context);
				EnterRealm.Types.Response response2 = new EnterRealm.Types.Response();
				EnterRealm.Types.Request request2 = new EnterRealm.Types.Request();
				int num3 = (request2.realmID_ = world2.sceneId_);
				response2.request_ = request2;
				bool flag3 = ((TransactionAction<TResult>)(object)response2).Apply(in player, in world, context);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600261A")]
		[Cpp2IlInjected.Address(RVA = "0x1A17300", Offset = "0x1A15D00", VA = "0x181A17300")]
		private static MissionItemData CharacterUnlockedFrom(Item character)
		{
			//Discarded unreachable code: IL_003a
			//IL_0014: Expected O, but got I4
			int itemID = character.ItemID;
			Item character2 = (Item)itemID;
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<MissionItemData>(ItemType.Mission);
			Func<MissionItemData, bool> func = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
			{
				//Discarded unreachable code: IL_000f
				Item character3 = character2;
				return x.IsUnlockingCharacter(character3);
			};
			return Enumerable.FirstOrDefault<MissionItemData>(allByType, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600261B")]
		[Cpp2IlInjected.Address(RVA = "0x1A176C0", Offset = "0x1A160C0", VA = "0x181A176C0")]
		public static void SimulateFTUE(in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0081, IL_008f, IL_0099, IL_00ac, IL_00cf, IL_00d4, IL_00d7, IL_00dc, IL_00e1, IL_00e6, IL_00eb, IL_00f8, IL_0106, IL_0114, IL_0119, IL_0125, IL_012d, IL_016f, IL_01b1, IL_01ee, IL_01f3, IL_01f8, IL_01f9, IL_01ff, IL_0205, IL_020b, IL_0211
			//IL_0011: Expected O, but got I4
			//IL_0018: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_014d: Expected I4, but got O
			//IL_0156: Expected I4, but got O
			//IL_0192: Expected I4, but got O
			//IL_01d4: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			List<(int, int)> list = (List<(int, int)>)(object)new List<T>();
			((List<T>)(object)list).Add((T)num2);
			((List<T>)(object)list).Add((T)num2);
			((List<T>)(object)list).Add((T)num2);
			bool flag = default(bool);
			if (flag)
			{
				ProfileWorld section = world.Section;
				bool flag2 = default(bool);
				if (!flag2)
				{
					ProfileWorld section2 = world.Section;
					bool flag3 = default(bool);
					if (!flag3)
					{
						ProfileWorld section3 = world.Section;
						bool flag4 = default(bool);
						while (!flag4)
						{
						}
					}
				}
				ProfileWorld section4 = world.Section;
			}
			int num3 = 0;
			if (num2 == 0)
			{
				Dictionary<VillageAreaType, VillageAreaType> dictionary = (Dictionary<VillageAreaType, VillageAreaType>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600261C")]
		[Cpp2IlInjected.Address(RVA = "0x1A18930", Offset = "0x1A17330", VA = "0x181A18930")]
		private unsafe static void SimulateQuestProgression(Item mission, bool includeMission, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00ba, IL_00c0, IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6
			//IL_005b: Expected O, but got I4
			//IL_0071: Expected O, but got Ref
			//IL_0086: Expected O, but got I4
			int itemID = mission.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (num2 != 0)
			{
				return;
			}
			ProfileWorld section = world.Section;
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			List<Item> list = (List<Item>)(object)new List<T>();
			QuestInformation questInfo_ = world.Section.questInfo_;
			bool flag2 = default(bool);
			if (!flag2)
			{
				return;
			}
			List<MissionItemData> list2 = (List<MissionItemData>)(object)new List<T>();
			if (num3 != 0)
			{
				int index = 0;
				((List<T>)(object)list2).Insert(index, (T)num3);
				int num5 = 0;
				bool flag3 = default(bool);
				if (flag3)
				{
					ProfileWorld section2 = world.Section;
					int price = ((glPlayFab.Disney.BattlePassReward)System.Runtime.CompilerServices.Unsafe.AsPointer(ref world)).Price;
					bool flag4 = default(bool);
					while (!flag4)
					{
					}
				}
				int num6 = 0;
				if (num5 == 0)
				{
					QuestNode questNode = Enumerable.FirstOrDefault<QuestNode>((IEnumerable<>)num3);
				}
			}
			bool flag5 = default(bool);
			if (flag5)
			{
			}
			int num7 = 0;
			bool flag6 = default(bool);
			if (flag6)
			{
				IEnumerable<ICondition> enumerable = default(IEnumerable<ICondition>);
				if (enumerable != null)
				{
				}
				if (enumerable == null)
				{
				}
			}
			int num8 = 0;
			bool flag7 = default(bool);
			if (flag7)
			{
				IEnumerable<ICondition> enumerable2 = default(IEnumerable<ICondition>);
				if (enumerable2 != null)
				{
				}
				if (enumerable2 == null)
				{
				}
			}
			int num9 = 0;
			bool flag8 = default(bool);
			if (!flag8)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600261D")]
		[Cpp2IlInjected.Address(RVA = "0x1A1BBD0", Offset = "0x1A1A5D0", VA = "0x181A1BBD0")]
		static DebugTestMission()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
